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

namespace Navigator_Playground
{
    public partial class Form1 : Form
    {
        private int _count = 3;

        public Form1()
        {
            InitializeComponent();

            // Monitor changes in the pages collection
            kiwiNavigator1.Pages.Inserted += new TypedHandler<KiwiPage>(OnPageInsertRemove);
            kiwiNavigator1.Pages.Removed += new TypedHandler<KiwiPage>(OnPageInsertRemove);
            kiwiNavigator1.Pages.Cleared += new EventHandler(OnPagesCleared);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Use the proxy to expose just the interesting properties of the navigator
            propertyGrid1.SelectedObject = new KiwiNavigatorProxy(kiwiNavigator1);

            // Set initial state of the buttons
            UpdateButtonState();
        }

        private void kiwiButtonAdd_Click(object sender, EventArgs e)
        {
            // Create a new kiwi page
            KiwiPage newPage = new KiwiPage();

            // Populate with text and image
            newPage.Text = "Page " + _count.ToString();
            newPage.TextTitle = "Page " + _count.ToString() + " Title";
            newPage.TextDescription = "Page " + _count.ToString() + " Description";
            newPage.ImageSmall = imageList1.Images[_count % imageList1.Images.Count];
            _count++;

            // Append to end of the pages collection
            kiwiNavigator1.Pages.Add(newPage);

            // Select the new page
            kiwiNavigator1.SelectedPage = newPage;
        }

        private void kiwiButtonRemove_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.Pages.Remove(kiwiNavigator1.SelectedPage);
        }

        private void kiwiButtonClear_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.Pages.Clear();
        }

        private void kiwiButtonEnable_Click(object sender, EventArgs e)
        {
            kiwiNavigator1.SelectedPage.Enabled = !kiwiNavigator1.SelectedPage.Enabled;
            UpdateButtonState();
        }

        private void kiwiNavigator1_SelectedPageChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        void OnPagesCleared(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        void OnPageInsertRemove(object sender, TypedCollectionEventArgs<KiwiPage> e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Can only remove if a page is selected
            kiwiButtonRemove.Enabled = (kiwiNavigator1.SelectedPage != null);

            // Can only clear if there is at least one page in collection
            kiwiButtonClear.Enabled = (kiwiNavigator1.Pages.Count > 0);

            // Can only change enabled state if a button is selected
            kiwiButtonEnable.Enabled = (kiwiNavigator1.SelectedPage != null);

            // Only update the enabled button text if the button is itself enabled
            if (kiwiButtonEnable.Enabled)
            {
                // Give text to indicate the enabled state will be toggled
                if (kiwiNavigator1.SelectedPage.Enabled)
                    kiwiButtonEnable.Text = "Disable";
                else
                    kiwiButtonEnable.Text = "Enable";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class KiwiNavigatorProxy
    {
        private KiwiNavigator _navigator;

        public KiwiNavigatorProxy(KiwiNavigator navigator)
        {
            _navigator = navigator;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get { return _navigator.PaletteMode; }
            set { _navigator.PaletteMode = value; }
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get { return _navigator.AutoSize; }
            set { _navigator.AutoSize = value; }
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(typeof(AutoSizeMode), "GrowOnly")]
        public AutoSizeMode AutoSizeMode
        {
            get { return _navigator.AutoSizeMode; }
            set { _navigator.AutoSizeMode = value; }
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        [DefaultValue(true)]
        public bool Enabled
        {
            get { return _navigator.Enabled; }
            set { _navigator.Enabled = value; }
        }

        [Category("Visuals")]
        [Description("Collection of pages in the navigator control.")]
        public KiwiPageCollection Pages
        {
            get { return _navigator.Pages; }
        }

        [Category("Visuals (Modes)")]
        [Description("Overrides for defining bar settings.")]
        public NavigatorBar Bar
        {
            get { return _navigator.Bar; }
        }
        [Category("Visuals (Modes)")]
        [Description("Button specifications and fixed button logic.")]
        public NavigatorButton Button
        {
            get { return _navigator.Button; }
        }

        [Category("Visuals (Modes)")]
        [Description("Overrides for defining group settings.")]
        public NavigatorGroup Group
        {
            get { return _navigator.Group; }
        }

        [Category("Visuals (Modes)")]
        [Description("Overrides for defining header settings.")]
        public NavigatorHeader Header
        {
            get { return _navigator.Header; }
        }

        [Category("Visuals (Modes)")]
        [Description("Overrides for defining panel settings.")]
        public NavigatorPanel Panel
        {
            get { return _navigator.Panel; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common navigator appearance.")]
        public PaletteNavigatorRedirect StateCommon
        {
            get { return _navigator.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining disabled navigator appearance.")]
        public PaletteNavigator StateDisabled
        {
            get { return _navigator.StateDisabled; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining normal navigator appearance.")]
        public PaletteNavigator StateNormal
        {
            get { return _navigator.StateNormal; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining tracking navigator appearance.")]
        public PaletteNavigatorOther StateTracking
        {
            get { return _navigator.StateTracking; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining pressed navigator appearance.")]
        public PaletteNavigatorOther StatePressed
        {
            get { return _navigator.StatePressed; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining selected navigator appearance.")]
        public PaletteNavigatorOther StateSelected
        {
            get { return _navigator.StateSelected; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining focus navigator appearance.")]
        public PaletteNavigatorOtherRedirect OverrideFocus
        {
            get { return _navigator.OverrideFocus; }
        }

        [Category("Visuals")]
        [Description("Display mode of the control instance.")]
        [DefaultValue(typeof(NavigatorMode), "Bar - CheckButton - Group - Outside")]
        public NavigatorMode NavigatorMode
        {
            get { return _navigator.NavigatorMode; }
            set { _navigator.NavigatorMode = value; }
        }

        [Category("Visuals")]
        [Description("Page back style.")]
        [DefaultValue(typeof(PaletteBackStyle), "ControlClient")]
        public PaletteBackStyle PageBackStyle
        {
            get { return _navigator.PageBackStyle; }
            set { _navigator.PageBackStyle = value; }
        }
    }
}
