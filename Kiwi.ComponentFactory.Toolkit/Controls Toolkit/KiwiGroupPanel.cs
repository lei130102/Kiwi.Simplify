using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Special panel used in the KiwiGroup and KiwiHeaderGroup controls.
	/// </summary>
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[ToolboxItem(false)]
	[Designer("Kiwi.ComponentFactory.Toolkit.KiwiGroupPanelDesigner, Kiwi.ComponentFactory.Toolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=360f304a9e10e704")]
	//
	[ToolboxBitmap(typeof(KiwiGroupPanel), "ToolboxBitmaps.KiwiGroupPanel.bmp")]
	[DesignerCategory("code")]
	[Description("Enables you to group collections of controls.")]
	[Docking(DockingBehavior.Never)]
	public sealed class KiwiGroupPanel : KiwiPanel
	{
		#region Instance Fields
		private PaletteBackInheritForced _forcedDisabled;
		private PaletteBackInheritForced _forcedNormal;
		private NeedPaintHandler _layoutHandler;
		#endregion

		#region Events
		/// <summary>
		/// Occurs when the value of the AutoSize property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new event EventHandler AutoSizeChanged;

		/// <summary>
		/// Occurs when the value of the Dock property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new event EventHandler DockChanged;

		/// <summary>
		/// Occurs when the value of the Location property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new event EventHandler LocationChanged;

		/// <summary>
		/// Occurs when the value of the TabIndex property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new event EventHandler TabIndexChanged;

		/// <summary>
		/// Occurs when the value of the TabStop property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new event EventHandler TabStopChanged;

		/// <summary>
		/// Occurs when the value of the Visible property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new event EventHandler VisibleChanged;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the KiwiGroupPanel class.
		/// </summary>
		/// <param name="alignControl">Container control for alignment.</param>
		/// <param name="stateCommon">Common appearance state to inherit from.</param>
		/// <param name="stateDisabled">Disabled appearance state.</param>
		/// <param name="stateNormal">Normal appearance state.</param>
		/// <param name="layoutHandler">Callback delegate for layout processing.</param>
		public KiwiGroupPanel(Control alignControl,
								 PaletteDoubleRedirect stateCommon,
								 PaletteDouble stateDisabled,
								 PaletteDouble stateNormal,
								 NeedPaintHandler layoutHandler)
			: base(stateCommon, stateDisabled, stateNormal)
		{
			// Remember the delegate used to notify layouts
			_layoutHandler = layoutHandler;

			// Create the forced overrides to enforce the graphics option we want
			_forcedDisabled = new PaletteBackInheritForced(stateDisabled.Back);
			_forcedNormal = new PaletteBackInheritForced(stateNormal.Back);

			// We never allow the anti alias option as it prevent transparent background working
			_forcedDisabled.ForceGraphicsHint = PaletteGraphicsHint.None;
			_forcedNormal.ForceGraphicsHint = PaletteGraphicsHint.None;

			// Set the correct initial palettes
			ViewDrawPanel.SetPalettes(Enabled ? _forcedNormal : _forcedDisabled);

			// Make sure the alignment of the group panel is as that of the parent
			ViewManager.AlignControl = alignControl;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets or sets how a KiwiSplitterPanel attaches to the edges of the KiwiSplitContainer.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override AnchorStyles Anchor
		{
			get { return base.Anchor; }
			set { /* Ignore request */ }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the KiwiSplitterPanel is automatically resized to display its entire contents.
		/// </summary>
		[Browsable(false)]
		[Bindable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override bool AutoSize
		{
			get { return base.AutoSize; }
			set { /* Ignore request */ }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the control is automatically resized to display its entire contents.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override AutoSizeMode AutoSizeMode
		{
			get { return base.AutoSizeMode; }
			set { /* Ignore request */ }
		}

		/// <summary>
		/// Gets or sets the border style for the KiwiSplitterPanel. 
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new BorderStyle BorderStyle
		{
			get { return base.BorderStyle; }
			set { /* Ignore request */ }
		}

		/// <summary>
		/// Gets or sets which edge of the KiwiSplitContainer that the KiwiSplitterPanel is docked to. 
		/// </summary>
		[Browsable(false)]
		[Bindable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override DockStyle Dock
		{
			get { return base.Dock; }
			set { /* Ignore request */ }
		}

		/// <summary>
		/// Gets the internal spacing between the KiwiSplitterPanel and its edges.
		/// </summary>
		[Browsable(false)]
		[Bindable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DockPaddingEdges DockPadding
		{
			get { return base.DockPadding; }
		}

		/// <summary>
		/// Gets or sets the height of the KiwiGroupPanel. 
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new int Height
		{
			get { return base.Height; }
			set { base.Height = value; }
		}

		/// <summary>
		/// Gets or sets the coordinates of the upper-left corner of the KiwiSplitterPanel relative to the upper-left corner of its KiwiSplitContainer. 
		/// </summary>
		[Browsable(false)]
		[Bindable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Point Location
		{
			get { return base.Location; }
			set { base.Location = value; }
		}

		/// <summary>
		/// The name of this KiwiSplitterPanel.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new string Name
		{
			get { return base.Name; }
			set { base.Name = value; }
		}

		/// <summary>
		/// The name of this KiwiSplitterPanel.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Control Parent
		{
			get { return base.Parent; }
			set { base.Parent = value; }
		}

		/// <summary>
		/// Gets or sets the height and width of the KiwiSplitterPanel.
		/// </summary>
		[Browsable(false)]
		[Bindable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Size Size
		{
			get { return base.Size; }
			set { base.Size = value; }
		}

		/// <summary>
		/// Gets or sets the tab order of the KiwiSplitterPanel within its KiwiSplitContainer.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new int TabIndex
		{
			get { return base.TabIndex; }
			set { base.TabIndex = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the user can give the focus to this KiwiSplitterPanel using the TAB key.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new bool TabStop
		{
			get { return base.TabStop; }
			set { base.TabStop = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the KiwiSplitterPanel is displayed.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new bool Visible
		{
			get { return base.Visible; }
			set { base.Visible = value; }
		}

		/// <summary>
		/// Gets or sets the width of the KiwiSplitterPanel. 
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new int Width
		{
			get { return base.Width; }
			set { base.Width = value; }
		}

		/// <summary>
		/// Gets or sets the palette to be applied.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new PaletteMode PaletteMode
		{
			get { return base.PaletteMode; }
			set { base.PaletteMode = value; }
		}

		/// <summary>
		/// Gets and sets the custom palette implementation.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new IPalette Palette
		{
			get { return base.Palette; }
			set { base.Palette = value; }
		}

		/// <summary>
		/// Gets and sets the panel style.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new PaletteBackStyle PanelBackStyle
		{
			get { return base.PanelBackStyle; }
			set { base.PanelBackStyle = value; }
		}

		/// <summary>
		/// Gets access to the common panel appearance that other states can override.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new PaletteBack StateCommon
		{
			get { return base.StateCommon; }
		}

		/// <summary>
		/// Gets access to the disabled panel appearance.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new PaletteBack StateDisabled
		{
			get { return base.StateDisabled; }
		}

		/// <summary>
		/// Gets access to the normal panel appearance.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new PaletteBack StateNormal
		{
			get { return base.StateNormal; }
		}
		#endregion

		#region Protected Overrides
		/// <summary>
		/// Gets the space, in pixels, that is specified by default between controls.
		/// </summary>
		protected override Padding DefaultMargin
		{
			get { return new Padding(0, 0, 0, 0); }
		}

		/// <summary>
		/// Raises the Layout event.
		/// </summary>
		/// <param name="levent">A LayoutEventArgs that contains the event data.</param>
		protected override void OnLayout(LayoutEventArgs levent)
		{
			// Inform anyone interested that we are performing a layout call
			if (_layoutHandler != null)
				_layoutHandler(this, new NeedLayoutEventArgs(true));

			base.OnLayout(levent);
		}

		/// <summary>
		/// Raises the EnabledChanged event.
		/// </summary>
		/// <param name="e">An EventArgs that contains the event data.</param>
		protected override void OnEnabledChanged(EventArgs e)
		{
			// Let base class fire standard event
			base.OnEnabledChanged(e);

			// Update with the correct forced palette entry
			ViewDrawPanel.SetPalettes(Enabled ? _forcedNormal : _forcedDisabled);
		}

		/// <summary>
		/// Gets the control reference that is the parent for transparent drawing.
		/// </summary>
		protected override Control TransparentParent
		{
			get
			{
				// Just in case there is not a parent yet
				if (Parent == null)
					return null;

				// Just in case the parent does not have a parent
				if (Parent.Parent == null)
					return Parent;

				// The KiwiGroupPanel is always a child within another 
				// Kiwi control that should be considered the actual 
				// parent for transparent drawing purposes.
				return Parent.Parent;
			}
		}

		/// <summary>
		/// Raises the AutoSizeChanged event.
		/// </summary>
		/// <param name="e">An EventArgs containing the event data.</param>
		protected override void OnAutoSizeChanged(EventArgs e)
		{
			if (AutoSizeChanged != null)
				AutoSizeChanged(this, e);

			base.OnAutoSizeChanged(e);
		}

		/// <summary>
		/// Raises the DockChanged event.
		/// </summary>
		/// <param name="e">An EventArgs containing the event data.</param>
		protected override void OnDockChanged(EventArgs e)
		{
			if (DockChanged != null)
				DockChanged(this, e);

			base.OnDockChanged(e);
		}

		/// <summary>
		/// Raises the LocationChanged event.
		/// </summary>
		/// <param name="e">An EventArgs containing the event data.</param>
		protected override void OnLocationChanged(EventArgs e)
		{
			if (LocationChanged != null)
				LocationChanged(this, e);

			base.OnLocationChanged(e);
		}

		/// <summary>
		/// Raises the TabIndexChanged event.
		/// </summary>
		/// <param name="e">An EventArgs containing the event data.</param>
		protected override void OnTabIndexChanged(EventArgs e)
		{
			if (TabIndexChanged != null)
				TabIndexChanged(this, e);

			base.OnTabIndexChanged(e);
		}

		/// <summary>
		/// Raises the TabStopChanged event.
		/// </summary>
		/// <param name="e">An EventArgs containing the event data.</param>
		protected override void OnTabStopChanged(EventArgs e)
		{
			if (TabStopChanged != null)
				TabStopChanged(this, e);

			base.OnTabStopChanged(e);
		}

		/// <summary>
		/// Raises the VisibleChanged event.
		/// </summary>
		/// <param name="e">An EventArgs containing the event data.</param>
		protected override void OnVisibleChanged(EventArgs e)
		{
			if (VisibleChanged != null)
				VisibleChanged(this, e);

			base.OnVisibleChanged(e);
		}
		#endregion
	}
}
