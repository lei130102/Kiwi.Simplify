using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Ribbon;
using Kiwi.ComponentFactory.Toolkit;
using Kiwi.ComponentFactory.Workspace;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Memo_Editor
{
    public partial class MemoEditorForm : KiwiForm
    {
        #region Static Fields
        private static readonly int _maxRecentDocs = 9;
        private static readonly string _memoEditorPath = @"Software\Component Factory\Kiwi\MemoEditor";
        #endregion

        #region Instance Fields
        private int _count = 1;
        private NavigatorMode _cellMode;
        private KiwiRibbonGroupButton[] _paletteButtons;
        private KiwiRibbonGroupButton[] _groupingButtons;
        #endregion

        #region Identity
        public MemoEditorForm()
        {
            InitializeComponent();

            _paletteButtons = new KiwiRibbonGroupButton[]{button2010Blue, button2010Silver, button2010Black,
                                                             button2007Blue, button2007Silver, button2007Black,
                                                             buttonSparkleBlue, buttonSparkleOrange, buttonSparklePurple,
                                                             buttonSystem, button2003};

            _groupingButtons = new KiwiRibbonGroupButton[]{buttonTabs, buttonRibbonTabs, buttonButtons,
                                                              buttonHeader, buttonHeaderButtons, buttonStack};

            _cellMode = NavigatorMode.BarTabGroup;
        }
        #endregion

        #region Form Event Handlers
        private void MemoEditorForm1_Load(object sender, EventArgs e)
        {
            // Try and open the saved settings for memo editor
            RegistryKey memoEditorSettings = Registry.CurrentUser.OpenSubKey(_memoEditorPath);
            if (memoEditorSettings != null)
            {
                try
                {
                    // Look for each of the maximum number of entries
                    for (int i = 1; i <= _maxRecentDocs; i++)
                    {
                        // If we managed to get an entry
                        string filename = memoEditorSettings.GetValue(i.ToString()) as string;
                        if (!string.IsNullOrEmpty(filename))
                        {
                            KiwiRibbonRecentDoc recentDoc = new KiwiRibbonRecentDoc();
                            recentDoc.Click += new EventHandler(buttonRecentFile_Clicked);
                            recentDoc.Text = filename;

                            // Add to end of the recent docs collection
                            kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Add(recentDoc);
                        }
                    }
                }
                catch { };

                try
                {
                    // Restore the global palette selected previously
                    string globalPalette = memoEditorSettings.GetValue("GlobalPalette") as string;
                    if (!string.IsNullOrEmpty(globalPalette))
                        kiwiManager.GlobalPaletteMode = (PaletteModeManager)Enum.Parse(typeof(PaletteModeManager), globalPalette);

                    // Restore the cell mode selected previously
                    string cellMode = memoEditorSettings.GetValue("CellMode") as string;
                    if (!string.IsNullOrEmpty(cellMode))
                        _cellMode = (NavigatorMode)Enum.Parse(typeof(NavigatorMode), cellMode);
                }
                catch { };

                memoEditorSettings.Close();
            }

            // Add the three predefined memos as content
            buttonReadMe_Click(null, EventArgs.Empty);
            buttonShortcuts_Click(null, EventArgs.Empty);
            buttonPersistence_Click(null, EventArgs.Empty);

            // Organize them
            buttonGridArrange_Click(null, EventArgs.Empty);

            // Make the first cell the selected one
            kiwiWorkspace.ActiveCell = kiwiWorkspace.FirstCell();

            UpdateCellsFromGrouping();
            UpdateButtonsFromGrouping();
            UpdateButtonsFromPalette();
            UpdateApplicationTitle();
            UpdateOptions();
        }

        private void MemoEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            kiwiWorkspace.SuspendLayout();

            // Search each cell in turn
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                // Close each page within the cell (unless it returns the operation has been cancelled)
                for (int i = cell.Pages.Count - 1; i >= 0; i--)
                    if (CloseMemoPage(cell.Pages[i]))
                    {
                        kiwiWorkspace.ResumeLayout();
                        e.Cancel = true;
                        return;
                    }

                cell = kiwiWorkspace.NextCell(cell);
            }

            kiwiWorkspace.ResumeLayout();
        }

        private void MemoEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Try and open the saved settings for memo editor
            RegistryKey memoEditorSettings = Registry.CurrentUser.OpenSubKey(_memoEditorPath, true);

            // If it does not already exist then create it now
            if (memoEditorSettings == null)
                memoEditorSettings = Registry.CurrentUser.CreateSubKey(_memoEditorPath);

            // If we managed to get hold of a valid registry key...
            if (memoEditorSettings != null)
            {
                // Clear out the existing recent docs contents
                for (int i = 1; i <= _maxRecentDocs; i++)
                    memoEditorSettings.SetValue(i.ToString(), string.Empty, RegistryValueKind.String);

                // Set the value for each existing entry
                for (int i = 0; i < kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Count; i++)
                    memoEditorSettings.SetValue((i + 1).ToString(), kiwiRibbon.RibbonAppButton.AppButtonRecentDocs[i].Text, RegistryValueKind.String);

                // Save the global palette setting and cell mode
                memoEditorSettings.SetValue("GlobalPalette", kiwiManager.GlobalPaletteMode.ToString(), RegistryValueKind.String);
                memoEditorSettings.SetValue("CellMode", _cellMode.ToString(), RegistryValueKind.String);
                memoEditorSettings.Close();
            }
        }
        #endregion

        #region Ribbon Event Handlers
        private void buttonNewMemo_Click(object sender, EventArgs e)
        {
            AddNewMemo();
        }

        private void buttonOpenMemo_Click(object sender, EventArgs e)
        {
            // Did the user select at least one file?
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Get the list of open filenames
                List<String> filenames = GetOpenFilenames();

                // Try and open each file selected in the open dialog box
                foreach (string file in openFileDialog.FileNames)
                {
                    // Only interested in files that are not already loaded
                    if (filenames.BinarySearch(file) < 0)
                    {
                        // Load the file contents and add as a new tab
                        FileInfo fileInfo = new FileInfo(file);
                        if (fileInfo.Exists)
                            using (StreamReader reader = new StreamReader(file))
                                AddNewMemo(fileInfo.Name, fileInfo.FullName, reader.ReadToEnd());
                    }
                }
            }
        }

        private void buttonSaveMemo_Click(object sender, EventArgs e)
        {
            // Save memo at the current page
            if (kiwiWorkspace.ActivePage != null)
                SaveMemoPage(kiwiWorkspace.ActivePage);
        }

        private void buttonSaveAsMemo_Click(object sender, EventArgs e)
        {
            // 'Save As' memo at the current page
            if (kiwiWorkspace.ActivePage != null)
                SaveAsMemoPage(kiwiWorkspace.ActivePage);
        }

        private void buttonSaveAllMemo_Click(object sender, EventArgs e)
        {
            // Search each cell in turn
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                // Save each page within the cell
                foreach (KiwiPage page in cell.Pages)
                {
                    // Save the memo in the page
                    SaveMemoPage(page);
                }

                cell = kiwiWorkspace.NextCell(cell);
            }
        }

        private void buttonCloseMemo_Click(object sender, EventArgs e)
        {
            // Close memo at the current page
            if (kiwiWorkspace.ActivePage != null)
                CloseMemoPage(kiwiWorkspace.ActivePage);
        }

        private void buttonCloseAllMemo_Click(object sender, EventArgs e)
        {
            kiwiWorkspace.SuspendLayout();

            // Search each cell in turn
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                // Close each page within the cell (unless it returns the operation has been cancelled)
                for (int i = cell.Pages.Count - 1; i >= 0; i--)
                    if (CloseMemoPage(cell.Pages[i]))
                    {
                        kiwiWorkspace.ResumeLayout();
                        return;
                    }

                cell = kiwiWorkspace.NextCell(cell);
            }

            kiwiWorkspace.ResumeLayout();
        }

        private void buttonSingleGroupArrange_Click(object sender, EventArgs e)
        {
            // Move all the pages into a single cell
            kiwiWorkspace.ApplySingleCell();
        }

        private void buttonGridArrange_Click(object sender, EventArgs e)
        {
            // Arrange pages into a grid with one page per cell
            kiwiWorkspace.ApplyGridPages(false);
        }

        private void buttonVerticalArrange_Click(object sender, EventArgs e)
        {
            // Vertical list is the same as arranging in a vertical grid of 1 element per row
            kiwiWorkspace.ApplyGridPages(false, Orientation.Vertical, 1);
        }

        private void buttonHorizontalArrange_Click(object sender, EventArgs e)
        {
            // Horizontal list is the same as arranging in a horizontal grid of 1 element per column
            kiwiWorkspace.ApplyGridPages(false, Orientation.Horizontal, 1);
        }

        private void buttonReadMe_Click(object sender, EventArgs e)
        {
            if (!SelectExistingPage("ReadMe"))
            {
                // Add a predefined memo with some read me instructions
                AddNewMemo("ReadMe",
                           "Memo Editor uses the Kiwi Workspace to organize the document area of the application.\n\n" +
                           "Drag the document headers around the workspace to rearrange the layout.\n\n" +
                           "Right-click the document headers to access extra workspace options.");
            }
        }

        private void buttonShortcuts_Click(object sender, EventArgs e)
        {
            if (!SelectExistingPage("Shortcuts"))
            {
                // Add a predefined memo with a list of the shortcuts
                AddNewMemo("Shortcuts",
                           "Ctrl + Tab\tFocus Next Tab\n" +
                           "Ctrl + Shift + Tab\tFocus Previous Tab\n\n" +
                           "Ctrl + N\t\tNew\n" +
                           "Ctrl + O\t\tOpen\n" +
                           "Ctrl + S\t\tSave\n" +
                           "Ctrl + Shift + S\tSave All\n" +
                           "Ctrl + Shift + C\tClose\n\n" +
                           "Ctrl + Shift + T\tSingle Group Arrange\n" +
                           "Ctrl + Shift + G\tGrid Arrange\n\n" +
                           "Ctrl + Shift + N\tMove Tab to Next Group\n" +
                           "Ctrl + Shift + P\tMove Tab to Previous Group\n" +
                           "Ctrl + Shift + V\tSplit Vertical\n" +
                           "Ctrl + Shift + H\tSplit Horizontal\n" +
                           "Ctrl + Shift + R\tRebalance\n");
            }
        }

        private void buttonPersistence_Click(object sender, EventArgs e)
        {
            if (!SelectExistingPage("Persistence"))
            {
                // Add a predefined memo with some read me instructions
                AddNewMemo("Persistence",
                           "On exit the list of recent documents is saved into the registry along with the selected palette and selected grouping mode." +
                           "This makes it easy to carry on from where you left off.");
            }
        }

        private bool SelectExistingPage(string filename)
        {
            // Get the list of open filenames
            KiwiPage page = GetPageForFilename(filename);
            if (page != null)
            {
                // Select the page and we are done
                KiwiWorkspaceCell cell = kiwiWorkspace.CellForPage(page);
                cell.SelectedPage = page;
                kiwiWorkspace.ActiveCell = cell;
                return true;
            }

            return false;
        }

        private void buttonPalette_Clicked(object sender, EventArgs e)
        {
            // The tag property of the button is the enum string value of the palette we want
            KiwiRibbonGroupButton button = (KiwiRibbonGroupButton)sender;
            kiwiManager.GlobalPaletteMode = (PaletteModeManager)Enum.Parse(typeof(PaletteModeManager), (string)button.Tag);
            UpdateButtonsFromPalette();
        }

        private void buttonGrouping_Click(object sender, EventArgs e)
        {
            // Cache the new mode setting
            KiwiRibbonGroupButton button = (KiwiRibbonGroupButton)sender;
            _cellMode = (NavigatorMode)Enum.Parse(typeof(NavigatorMode), (string)button.Tag);
            UpdateCellsFromGrouping();
            UpdateButtonsFromGrouping();
        }

        private void buttonRecentFile_Clicked(object sender, EventArgs e)
        {
            // Always remove the selected entry, we only put it back if we find it is valid
            KiwiRibbonRecentDoc recentDoc = (KiwiRibbonRecentDoc)sender;
            kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Remove(recentDoc);

            // Get the existing page that contains the selected filename
            KiwiPage page = GetPageForFilename(recentDoc.Text);
            if (page != null)
            {
                // Make this the top most 'recent doc' entry
                kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Insert(0, recentDoc);

                // Select the page and we are done
                KiwiWorkspaceCell cell = kiwiWorkspace.CellForPage(page);
                cell.SelectedPage = page;
                kiwiWorkspace.ActiveCell = cell;
                return;
            }

            // If we get here then we need to try and load the document
            FileInfo fileInfo = new FileInfo(recentDoc.Text);
            if (fileInfo.Exists)
            {
                using (StreamReader reader = new StreamReader(fileInfo.FullName))
                {
                    // Make this the top most 'recent doc' entry
                    kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Insert(0, recentDoc);

                    // Add contents of the file as a new page associated with the file
                    AddNewMemo(fileInfo.Name, fileInfo.FullName, reader.ReadToEnd());
                }
            }
        }

        private void buttonSpecExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Workspace Event Handlers
        private void kiwiWorkspace_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Do not show any navigator level buttons
            e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.ButtonDisplayLogic = ButtonDisplayLogic.None;

            // Do not need the secondary header for header modes
            e.Cell.Header.HeaderVisibleSecondary = false;
        }

        private void kiwiWorkspace_ActivePageChanged(object sender, ActivePageChangedEventArgs e)
        {
            // Change in active page requires we update button/form state
            UpdateApplicationTitle();
            UpdateOptions();
        }

        private void kiwiWorkspace_ActiveCellChanged(object sender, ActiveCellChangedEventArgs e)
        {
            // Ensure all but the newly selected cell have a lower profile appearance
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                if (e.NewCell != cell)
                    cell.Bar.TabStyle = TabStyle.StandardProfile;
                cell = kiwiWorkspace.NextCell(cell);
            }

            // Ensure the newly selected cell has a higher profile appearance
            if (e.NewCell != null)
                e.NewCell.Bar.TabStyle = TabStyle.HighProfile;
        }

        private void kiwiCell_PageCloseAction(object sender, CloseActionEventArgs e)
        {
            // Tell the cell instance to not perform any actions with the page, we will remove it if we need to
            e.Action = CloseButtonAction.None;

            // Use our own routine to close the page, so user is asked to save changes if required
            CloseMemoPage(e.Item);
        }
        #endregion

        #region RichTextBox Event Handlers
        private void kiwiRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Find the page from the sender reference
            KiwiRichTextBox rtb = (KiwiRichTextBox)sender;
            KiwiPage page = (KiwiPage)rtb.Tag;

            // If the page is not already marked as modified
            if (!page.Text.EndsWith("*"))
            {
                // Mark as modified by adding a star to end of text name
                page.Text = page.Text + "*";
                page.TextTitle = page.TextTitle + "*";
                page.TextDescription = page.TextDescription + "*";

                // Change in page requires we update button/form state
                UpdateApplicationTitle();
                UpdateOptions();
            }
        }
        #endregion

        #region Implementation
        private KiwiPage CreateNewMemo()
        {
            // Create what we hope is a unique name for the new memo
            string name = "Untitled" + (_count++).ToString();
            return CreateNewMemo(name, name, string.Empty, false);
        }

        private KiwiPage CreateNewMemo(string text,
                                          string description,
                                          string memo,
                                          bool loaded)
        {
            // Define page name and images
            KiwiPage page = new KiwiPage();
            page.Text = text;
            page.TextTitle = description;
            page.TextDescription = description;
            page.ImageSmall = Memo_Editor.Properties.Resources.note16;
            page.ImageMedium = Memo_Editor.Properties.Resources.note24;
            page.ImageLarge = Memo_Editor.Properties.Resources.note24;

            // Place border between page and internal controls
            page.Padding = new Padding(5);

            // Use the tag to remember if the page was loaded or is new
            page.Tag = loaded;

            // Create a close button for the page
            ButtonSpecAny bsa = new ButtonSpecAny();
            bsa.Tag = page;
            bsa.Type = PaletteButtonSpecStyle.Close;
            bsa.Click += new EventHandler(OnClosePage);
            page.ButtonSpecs.Add(bsa);

            // We use the rich text box as the memo editor
            KiwiRichTextBox rtb = new KiwiRichTextBox();
            rtb.StateCommon.Border.Draw = InheritBool.False;
            rtb.Dock = DockStyle.Fill;
            rtb.Text = memo;
            rtb.Tag = page;

            // Need to know when the user makes a change to the memo text
            rtb.TextChanged += new EventHandler(kiwiRichTextBox_TextChanged);

            // Add rich text box as content
            page.Controls.Add(rtb);

            return page;
        }

        private void OnClosePage(object sender, EventArgs e)
        {
            // Find the page this button is contained within
            ButtonSpecAny bsa = (ButtonSpecAny)sender;

            // Close the page
            CloseMemoPage((KiwiPage)bsa.Tag);
        }

        private void AddNewMemo()
        {
            // Create a new blank memo page
            KiwiPage newPage = CreateNewMemo();

            // Add page into the currently active workspace cell
            kiwiWorkspace.ActiveCell.Pages.Add(newPage);
            kiwiWorkspace.ActiveCell.SelectedPage = newPage;
        }

        private void AddNewMemo(string name, string memo)
        {
            AddNewMemo(name, name, memo, false);
        }

        private void AddNewMemo(string name, string path, string memo)
        {
            AddNewMemo(name, path, memo, true);
        }

        private void AddNewMemo(string name, string path, string memo, bool loaded)
        {
            // Create a new blank memo page
            KiwiPage newPage = CreateNewMemo(name, path, memo, loaded);

            // Add page into the currently active workspace cell
            kiwiWorkspace.ActiveCell.Pages.Add(newPage);
            kiwiWorkspace.ActiveCell.SelectedPage = newPage;

            // Is the new memo loaded from a file?
            if (loaded)
                AddRecentFile(path);
        }

        private void SaveMemoPage(KiwiPage page)
        {
            // We must have a page to actually save
            if (page != null)
            {
                // If the page is not associated with a file then 'Save As'
                if (!(bool)page.Tag)
                    SaveAsMemoPage(page);
                else
                {
                    // The page must be dirty and so in need of saving
                    if (page.Text.EndsWith("*"))
                    {
                        // Get access to the contained rich text box
                        KiwiRichTextBox rtb = (KiwiRichTextBox)page.Controls[0];

                        // Write out the contents to the file
                        FileInfo fileInfo = new FileInfo(page.TextDescription.TrimEnd('*'));
                        using (FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Create, FileAccess.Write))
                        using (StreamWriter streamWriter = new StreamWriter(fileStream))
                            streamWriter.Write(rtb.Text);

                        // Remove the dirty flag on the file
                        page.Text = page.Text.TrimEnd('*');
                        page.TextTitle = page.TextTitle.TrimEnd('*');
                        page.TextDescription = page.TextDescription.TrimEnd('*');

                        UpdateApplicationTitle();
                        UpdateOptions();
                    }
                }
            }
        }

        private void SaveAsMemoPage(KiwiPage page)
        {
            // We must have a page to actually save
            if (page != null)
            {
                // Set the directory/filename into the dialog box
                FileInfo extractInfo = new FileInfo(page.TextDescription.TrimEnd('*'));
                saveFileDialog.FileName = extractInfo.Name;
                if (string.IsNullOrEmpty(extractInfo.DirectoryName))
                    saveFileDialog.InitialDirectory = extractInfo.DirectoryName;

                // If the user entered a valid filename for saving
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Get access to the contained rich text box
                    KiwiRichTextBox rtb = (KiwiRichTextBox)page.Controls[0];

                    // Write out the contents to the file
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    using (FileStream fileStream = fileInfo.OpenWrite())
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                        streamWriter.Write(rtb.Text);

                    // Remove the dirty flag on the file
                    page.Text = fileInfo.Name;
                    page.TextTitle = fileInfo.Name;
                    page.TextDescription = fileInfo.FullName;

                    // Mark the page as associated with a file
                    page.Tag = true;

                    // Add the new filename to the recent docs list
                    AddRecentFile(fileInfo.FullName);

                    UpdateApplicationTitle();
                    UpdateOptions();
                }
            }
        }

        private bool CloseMemoPage(KiwiPage page)
        {
            // We must have a page to actually close
            if (page != null)
            {
                // If the page is dirty then we need to ask if it should be saved
                if (page.Text.EndsWith("*"))
                {
                    switch (MessageBox.Show("Do you want to save changes to '" + page.Text.TrimEnd('*') + "' ?",
                                           "Memo Editor", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:
                            // Returning true indicates the operation was cancelled
                            return true;
                        case DialogResult.Yes:
                            SaveMemoPage(page);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }

                // Remove the page from the containing cell
                KiwiWorkspaceCell cell = kiwiWorkspace.CellForPage(page);
                cell.Pages.Remove(page);
                page.Dispose();

                UpdateApplicationTitle();
                UpdateOptions();
            }

            // Returning false indicates the operation was not cancelled
            return false;
        }

        private List<string> GetOpenFilenames()
        {
            List<String> filenames = new List<string>();

            // Scan all cells
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                // Scan all pages in the cell
                foreach (KiwiPage page in cell.Pages)
                {
                    // If the contents come from a file
                    if ((bool)page.Tag)
                        filenames.Add(page.TextDescription.TrimEnd('*'));
                }

                cell = kiwiWorkspace.NextCell(cell);
            }

            return filenames;
        }

        private KiwiPage GetPageForFilename(string filename)
        {
            // Scan all cells
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                // Scan all pages in the cell
                foreach (KiwiPage page in cell.Pages)
                {
                    // Look for the matching filename
                    if (page.TextDescription.TrimEnd('*').Equals(filename))
                        return page;
                }

                cell = kiwiWorkspace.NextCell(cell);
            }

            return null;
        }

        private void AddRecentFile(string filename)
        {
            // Search for an existing entry for that filename
            KiwiRibbonRecentDoc recentDoc = null;
            foreach (KiwiRibbonRecentDoc entry in kiwiRibbon.RibbonAppButton.AppButtonRecentDocs)
                if (entry.Text.Equals(filename))
                {
                    recentDoc = entry;
                    break;
                }

            // If no existing entry then create a new one
            if (recentDoc == null)
            {
                recentDoc = new KiwiRibbonRecentDoc();
                recentDoc.Click += new EventHandler(buttonRecentFile_Clicked);
                recentDoc.Text = filename;
            }

            // Remove entry from current list and insert at the top
            kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Remove(recentDoc);
            kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Insert(0, recentDoc);

            // Restrict list to just 9 entries
            if (kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Count > _maxRecentDocs)
                for (int i = kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Count; i > _maxRecentDocs; i--)
                    kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.RemoveAt(kiwiRibbon.RibbonAppButton.AppButtonRecentDocs.Count - 1);
        }

        private void UpdateCellsFromGrouping()
        {
            KiwiWorkspaceCell cell = kiwiWorkspace.FirstCell();
            while (cell != null)
            {
                cell.NavigatorMode = _cellMode;
                cell = kiwiWorkspace.NextCell(cell);
            }
        }

        private void UpdateButtonsFromGrouping()
        {
            // Get the string representation of the cell mode
            string cellMode = _cellMode.ToString();

            // Check the palette button that matches the cell mode
            foreach (KiwiRibbonGroupButton button in _groupingButtons)
                button.Checked = (button.Tag.ToString().Equals(cellMode));
        }

        private void UpdateButtonsFromPalette()
        {
            // Get the string representation of the global palette
            string mode = kiwiManager.GlobalPaletteMode.ToString();

            // Check the palette button that matches the global palette
            foreach (KiwiRibbonGroupButton button in _paletteButtons)
                button.Checked = (button.Tag.ToString().Equals(mode));
        }

        private void UpdateApplicationTitle()
        {
            // Always prefix with application name
            string title = "Memo Editor";

            // If we have an active page then append that memo name
            if (kiwiWorkspace.ActivePage != null)
                title += " - " + kiwiWorkspace.ActivePage.TextDescription;

            Text = title;
        }

        private void UpdateOptions()
        {
            bool activePage = (kiwiWorkspace.ActivePage != null);
            appButtonSaveMemo.Enabled = buttonSaveMemo.Enabled = activePage;
            appButtonSaveAsMemo.Enabled = buttonSaveAsMemo.Enabled = activePage;
            appButtonSaveAllMemo.Enabled = buttonSaveAllMemo.Enabled = activePage;
            appButtonCloseMemo.Enabled = buttonCloseMemo.Enabled = activePage;
            appButtonCloseAllMemo.Enabled = buttonCloseAllMemo.Enabled = activePage;
        }
        #endregion
    }
}
