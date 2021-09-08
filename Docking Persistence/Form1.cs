using Kiwi.ComponentFactory.Docking;
using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Docking_Persistence
{
    public partial class Form1 : KiwiForm
    {
        private int _count = 1;
        private byte[] _array1;
        private byte[] _array2;
        private byte[] _array3;

        public Form1()
        {
            InitializeComponent();
        }

        private KiwiPage NewDocument()
        {
            KiwiPage page = NewPage("Document ", 0, new ContentDocument());

            // Document pages cannot be docked or auto hidden
            page.ClearFlags(KiwiPageFlags.DockingAllowAutoHidden | KiwiPageFlags.DockingAllowDocked);

            return page;
        }

        private KiwiPage NewInput()
        {
            return NewPage("Input ", 1, new ContentInput());
        }

        private KiwiPage NewPropertyGrid()
        {
            return NewPage("Properties ", 2, new ContentPropertyGrid());
        }

        private KiwiPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KiwiPage p = new KiwiPage();
            p.Text = name + _count.ToString();
            p.TextTitle = name + _count.ToString();
            p.TextDescription = name + _count.ToString();
            p.UniqueName = p.Text;
            p.ImageSmall = imageListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KiwiDockingWorkspace w = kiwiDockingManager.ManageWorkspace(kiwiDockableWorkspace);
            kiwiDockingManager.ManageControl(kiwiPanel, w);
            kiwiDockingManager.ManageFloating(this);

            // Add docking pages
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Left, new KiwiPage[] { NewPropertyGrid() });
            kiwiDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KiwiPage[] { NewInput(), NewInput() });
            kiwiDockingManager.AddAutoHiddenGroup("Control", DockingEdge.Right, new KiwiPage[] { NewPropertyGrid() });
            kiwiDockingManager.AddToWorkspace("Workspace", new KiwiPage[] { NewDocument(), NewDocument(), NewDocument() });
        }

        private void buttonSaveArray1_Click(object sender, EventArgs e)
        {
            _array1 = kiwiDockingManager.SaveConfigToArray();
            buttonLoadArray1.Enabled = true;
        }

        private void buttonSaveArray2_Click(object sender, EventArgs e)
        {
            _array2 = kiwiDockingManager.SaveConfigToArray();
            buttonLoadArray2.Enabled = true;
        }

        private void buttonSaveArray3_Click(object sender, EventArgs e)
        {
            _array3 = kiwiDockingManager.SaveConfigToArray();
            buttonLoadArray3.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                kiwiDockingManager.SaveConfigToFile(saveFileDialog.FileName);
        }

        private void buttonLoadArray1_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.LoadConfigFromArray(_array1);
        }

        private void buttonLoadArray2_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.LoadConfigFromArray(_array2);
        }

        private void buttonLoadArray3_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.LoadConfigFromArray(_array3);
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                kiwiDockingManager.LoadConfigFromFile(openFileDialog.FileName);
        }


        private void buttonHideAll_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.HideAllPages();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            kiwiDockingManager.ShowAllPages();
        }

        private void kiwiDockingManager_GlobalSaving(object sender, DockGlobalSavingEventArgs e)
        {
            // Example code showing how to save extra data into the global config
            e.XmlWriter.WriteStartElement("CustomGlobalData");
            e.XmlWriter.WriteAttributeString("SavedTime", DateTime.Now.ToString());
            e.XmlWriter.WriteEndElement();
        }

        private void kiwiDockingManager_GlobalLoading(object sender, DockGlobalLoadingEventArgs e)
        {
            // Example code showing how to reload the extra data that was saved into the global config
            e.XmlReader.Read();
            Console.WriteLine("GlobalConfig was saved at {0}", e.XmlReader.GetAttribute("SavedTime"));
            e.XmlReader.Read();
        }

        private void kiwiDockingManager_PageSaving(object sender, DockPageSavingEventArgs e)
        {
            // Example code showing how to save extra data into the page config
            e.XmlWriter.WriteStartElement("CustomPageData");
            e.XmlWriter.WriteAttributeString("SavedMilliseconds", DateTime.Now.Millisecond.ToString());
            e.XmlWriter.WriteEndElement();
        }

        private void kiwiDockingManager_PageLoading(object sender, DockPageLoadingEventArgs e)
        {
            // Example code showing how to reload the extra data that was saved into the page config
            e.XmlReader.Read();
            Console.WriteLine("PageConfig was saved at {0}", e.XmlReader.GetAttribute("SavedMilliseconds"));
            e.XmlReader.Read();
        }

        private void kiwiContextMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
