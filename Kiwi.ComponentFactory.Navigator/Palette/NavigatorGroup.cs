using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Storage for group related properties.
	/// </summary>
    public class NavigatorGroup : Storage
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private PaletteBackStyle _groupBackStyle;
        private PaletteBorderStyle _groupBorderStyle;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorGroup class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorGroup(KiwiNavigator navigator,
                              NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _groupBackStyle = PaletteBackStyle.ControlClient;
            _groupBorderStyle = PaletteBorderStyle.ControlClient;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return ((GroupBackStyle == PaletteBackStyle.ControlClient) &&
                        (GroupBorderStyle == PaletteBorderStyle.ControlClient));
            }
        }
        #endregion

        #region GroupBackStyle
        /// <summary>
        /// Gets and sets the group back style.
        /// </summary>
        [Category("Visuals")]
        [Description("Group back style.")]
        [DefaultValue(typeof(PaletteBackStyle), "ControlClient")]
        public PaletteBackStyle GroupBackStyle
        {
            get { return _groupBackStyle; }

            set
            {
                if (_groupBackStyle != value)
                {
                    _groupBackStyle = value;
                    _navigator.OnViewBuilderPropertyChanged("GroupBackStyle");
                }
            }
        }
        #endregion

        #region GroupBorderStyle
        /// <summary>
        /// Gets and sets the group border style.
        /// </summary>
        [Category("Visuals")]
        [Description("Group border style.")]
        [DefaultValue(typeof(PaletteBorderStyle), "ControlClient")]
        public PaletteBorderStyle GroupBorderStyle
        {
            get { return _groupBorderStyle; }

            set
            {
                if (_groupBorderStyle != value)
                {
                    _groupBorderStyle = value;
                    _navigator.OnViewBuilderPropertyChanged("GroupBorderStyle");
                }
            }
        }
        #endregion
    }
}
