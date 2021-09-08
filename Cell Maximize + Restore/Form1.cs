using Kiwi.ComponentFactory.Navigator;
using Kiwi.ComponentFactory.Toolkit;
using Kiwi.ComponentFactory.Workspace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Maximize___Restore
{
    public partial class Form1 : Form
    {
        private string _pageText = @"{\rtf1\ansi\ansicpg1252\deff0\deflang3081{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}{\f1\fswiss\fcharset0 Arial;}}
{\colortbl ;\red0\green128\blue128;}\viewkind4\uc1\pard\cf1\f0\fs24\b\fs22 Double Click\cf0\b0\fs18\par
Use the mouse to double click the tab headers and toggle between the maximized and restored mode for the cell that contains that clicked page.\par\par
\cf1\b\fs22 Context Menu\cf0\b0\fs18\par
Right-click the tab header and use the context menu option to toggle between maximized modes.\par\par
\cf1\b\fs22 Keyboard Shortcut\cf0\b0\fs18\par
Use the keyboard shortcut \i Ctrl + Shift + M\i0  to toggle maximized mode.\par\par
\cf1\b\fs22 Maximize/Restore Buttons\cf0\b0\fs18\par
A custom \i ButtonSpec \i0 has been added to the tabs area that can be clicked to toggle maximized modes.\f1\fs20\par}";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define help text within each page
            richTextBox1.Rtf = _pageText;
            richTextBox2.Rtf = _pageText;
            richTextBox3.Rtf = _pageText;
            richTextBox4.Rtf = _pageText;
            richTextBox5.Rtf = _pageText;
            richTextBox6.Rtf = _pageText;
        }

        private void kiwiWorkspace_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // When adding a new cell we need to default the tabs style
            e.Cell.Bar.TabStyle = TabStyle.OneNote;

            // Remove the standard buttons bar buttons
            e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.ButtonDisplayLogic = ButtonDisplayLogic.None;

            // Generate event whenever a tab is double clicked
            e.Cell.TabDoubleClicked += new EventHandler<KiwiPageEventArgs>(OnTabDoubleClicked);
        }

        private void kiwiWorkspace_ActiveCellChanged(object sender, ActiveCellChangedEventArgs e)
        {
            if (e.OldCell != null)
                e.OldCell.Bar.TabStyle = TabStyle.OneNote;

            if (e.NewCell != null)
                e.NewCell.Bar.TabStyle = TabStyle.HighProfile;
        }

        private void OnTabDoubleClicked(object sender, KiwiPageEventArgs e)
        {
            // Find the cell that has this page
            KiwiWorkspaceCell cell = kiwiWorkspace.CellForPage(e.Item);

            // Toggle maximized state
            if (kiwiWorkspace.MaximizedCell == null)
                kiwiWorkspace.MaximizedCell = cell;
            else
                kiwiWorkspace.MaximizedCell = null;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
