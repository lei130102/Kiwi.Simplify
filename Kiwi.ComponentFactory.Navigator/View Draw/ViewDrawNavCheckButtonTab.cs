using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Navigator view element for drawing a tab check button for a kiwi page.
	/// </summary>
    internal class ViewDrawNavCheckButtonTab : ViewDrawNavCheckButtonBar
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawNavCheckButtonTab class.
        /// </summary>
        /// <param name="navigator">Owning navigator instance.</param>
        /// <param name="page">Page this check button represents.</param>
        /// <param name="orientation">Orientation for the check button.</param>
        public ViewDrawNavCheckButtonTab(KiwiNavigator navigator,
                                         KiwiPage page,
                                         VisualOrientation orientation)
            : base(navigator, page, orientation,
                   page.StateDisabled.Tab,
                   page.StateNormal.Tab,
                   page.StateTracking.Tab,
                   page.StatePressed.Tab,
                   page.StateSelected.Tab,
                   page.OverrideFocus.Tab)
        {
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewDrawNavCheckButtonTab:" + Id;
        }
        #endregion

        #region UpdateButtonSpecMapping
        /// <summary>
        /// Update the button spec manager mapping to reflect current settings.
        /// </summary>
        public override void UpdateButtonSpecMapping()
        {
            // Update the button spec manager for this tab to use a tab style for remapping
            ButtonSpecManager.SetRemapTarget(Navigator.Bar.TabStyle);
            ButtonSpecManager.RecreateButtons();
        }
        #endregion

        #region ButtonClickOnDown
        /// <summary>
        /// Should the item be selected on the mouse down.
        /// </summary>
        protected override bool ButtonClickOnDown
        {
            get { return true; }
        }
        #endregion
    }
}
