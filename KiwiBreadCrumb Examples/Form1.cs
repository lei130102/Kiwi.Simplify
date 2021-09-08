using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiwiBreadCrumb_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kiwiBreadCrumb1.SelectedItem = kiwiBreadCrumb1.RootItem.Items[0].Items[0].Items[1].Items[1];
            kiwiBreadCrumb2.SelectedItem = kiwiBreadCrumb2.RootItem.Items[0].Items[1].Items[1];
            kiwiBreadCrumb3.SelectedItem = kiwiBreadCrumb3.RootItem.Items[1].Items[0];
            kiwiBreadCrumb4.SelectedItem = kiwiBreadCrumb4.RootItem;

            // Setup the property grid to edit this bread crumb
            propertyGrid.SelectedObject = new KiwiBreadCrumbProxy(kiwiBreadCrumb1);
        }

        private void breadCrumb_MouseDown(object sender, MouseEventArgs e)
        {
            // Setup the property grid to edit this bread crumb
            propertyGrid.SelectedObject = new KiwiBreadCrumbProxy(sender as KiwiBreadCrumb);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            kiwiBreadCrumb2.SelectedItem = kiwiBreadCrumb2.RootItem;
        }

        private void menuSpider_Click(object sender, EventArgs e)
        {
            kiwiBreadCrumb3.SelectedItem = kiwiBreadCrumb3.RootItem.Items[0].Items[1].Items[2].Items[1];
        }

        private void menuKangeroo_Click(object sender, EventArgs e)
        {
            kiwiBreadCrumb3.SelectedItem = kiwiBreadCrumb3.RootItem.Items[0].Items[0].Items[2].Items[2];
        }

        private void menuFern_Click(object sender, EventArgs e)
        {
            kiwiBreadCrumb3.SelectedItem = kiwiBreadCrumb3.RootItem.Items[1].Items[0].Items[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Stack<int> indexes = new Stack<int>();

            // Walk up the tree and stack the node indexes as we go
            TreeNode node = e.Node;
            while (node.Parent != null)
            {
                indexes.Push(node.Index);
                node = node.Parent;
            }

            // Start with the root crumb
            KiwiBreadCrumbItem crumb = kiwiBreadCrumb4.RootItem;

            // Walk down the matching path of the bread crumb trail
            while (indexes.Count > 0)
                crumb = crumb.Items[indexes.Pop()];

            kiwiBreadCrumb4.SelectedItem = crumb;
        }

        private void kiwiBreadCrumb4_SelectedItemChanged(object sender, EventArgs e)
        {
            Stack<int> indexes = new Stack<int>();

            // Walk up the tree and stack the crumb indexes as we go
            KiwiBreadCrumbItem crumb = kiwiBreadCrumb4.SelectedItem;
            while (crumb.Parent != null)
            {
                indexes.Push(crumb.Parent.Items.IndexOf(crumb));
                crumb = crumb.Parent;
            }

            // Start with the rot node
            TreeNode node = treeView1.Nodes[0];

            // Walk down the matching path of the node
            while (indexes.Count > 0)
                node = node.Nodes[indexes.Pop()];

            treeView1.SelectedNode = node;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class KiwiBreadCrumbProxy
    {
        private KiwiBreadCrumb _breadCrumb;

        public KiwiBreadCrumbProxy(KiwiBreadCrumb breadCrumb)
        {
            _breadCrumb = breadCrumb;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get { return _breadCrumb.PaletteMode; }
            set { _breadCrumb.PaletteMode = value; }
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        public bool AutoSize
        {
            get { return _breadCrumb.AutoSize; }
            set { _breadCrumb.AutoSize = value; }
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        public AutoSizeMode AutoSizeMode
        {
            get { return _breadCrumb.AutoSizeMode; }
            set { _breadCrumb.AutoSizeMode = value; }
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get { return _breadCrumb.Size; }
            set { _breadCrumb.Size = value; }
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get { return _breadCrumb.Location; }
            set { _breadCrumb.Location = value; }
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get { return _breadCrumb.Enabled; }
            set { _breadCrumb.Enabled = value; }
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KiwiBreadCrumb.BreadCrumbButtonSpecCollection ButtonSpecs
        {
            get { return _breadCrumb.ButtonSpecs; }
        }

        [Category("Visuals")]
        [Description("Should drop down buttons allow navigation to children.")]
        public bool DropDownNavigation
        {
            get { return _breadCrumb.DropDownNavigation; }
            set { _breadCrumb.DropDownNavigation = value; }
        }

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        public bool AllowButtonSpecToolTips
        {
            get { return _breadCrumb.AllowButtonSpecToolTips; }
            set { _breadCrumb.AllowButtonSpecToolTips = value; }
        }

        [Category("Visuals")]
        [Description("Background style for the control.")]
        public PaletteBackStyle ControlBackStyle
        {
            get { return _breadCrumb.ControlBackStyle; }
            set { _breadCrumb.ControlBackStyle = value; }
        }

        [Category("Visuals")]
        [Description("Button style used for drawing each bread crumb.")]
        public ButtonStyle CrumbButtonStyle
        {
            get { return _breadCrumb.CrumbButtonStyle; }
            set { _breadCrumb.CrumbButtonStyle = value; }
        }

        [Category("Visuals")]
        [Description("Border style for the control.")]
        public PaletteBorderStyle ControlBorderStyle
        {
            get { return _breadCrumb.ControlBorderStyle; }
            set { _breadCrumb.ControlBorderStyle = value; }
        }

        [Category("Data")]
        [Description("Root bread crumb item.")]
        public KiwiBreadCrumbItem RootItem
        {
            get { return _breadCrumb.RootItem; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common bread crumb appearance that other states can override.")]
        public PaletteDoubleMetricRedirect StateCommon
        {
            get { return _breadCrumb.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining disabled appearance.")]
        public PaletteBreadCrumbDoubleState StateDisabled
        {
            get { return _breadCrumb.StateDisabled; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining normal appearance.")]
        public PaletteBreadCrumbDoubleState StateNormal
        {
            get { return _breadCrumb.StateNormal; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining tracking bread crumb appearance.")]
        public PaletteBreadCrumbState StateTracking
        {
            get { return _breadCrumb.StateTracking; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining pressed bread crumb appearance.")]
        public PaletteBreadCrumbState StatePressed
        {
            get { return _breadCrumb.StatePressed; }
        }
    }
}
