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
	/// Storage for panel related properties.
	/// </summary>
    public class NavigatorPanel : Storage
    {
        #region Instance Fields
        private KiwiNavigator _navigator;
        private PaletteBackStyle _panelBackStyle;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the NavigatorPanel class.
		/// </summary>
        /// <param name="navigator">Reference to owning navigator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public NavigatorPanel(KiwiNavigator navigator,
                              NeedPaintHandler needPaint)
        {
            Debug.Assert(navigator != null);

            // Remember back reference
            _navigator = navigator;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Default values
            _panelBackStyle = PaletteBackStyle.PanelClient;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get { return (PanelBackStyle == PaletteBackStyle.PanelClient); }
        }
        #endregion

        #region PanelBackStyle
        /// <summary>
        /// Gets and sets the panel back style.
        /// </summary>
        [Category("Visuals")]
        [Description("Panel back style.")]
        [DefaultValue(typeof(PaletteBackStyle), "PanelClient")]
        public PaletteBackStyle PanelBackStyle
        {
            get { return _panelBackStyle; }

            set
            {
                if (_panelBackStyle != value)
                {
                    _panelBackStyle = value;
                    _navigator.OnViewBuilderPropertyChanged("PanelBackStyle");
                }
            }
        }
        #endregion
    }
}
