using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Button specification appropriate for an application menu
    /// </summary>
    public class ButtonSpecAppMenu : ButtonSpecAny
    {
        #region Protected
        /// <summary>
        /// Raises the Click event.
        /// </summary>
        /// <param name="e">An EventArgs containing the event data.</param>
        protected override void OnClick(EventArgs e)
        {
            // Only if associated view is enabled to we perform an action
            if (GetViewEnabled())
            {
                if ((KryptonContextMenu == null) &&
                    (ContextMenuStrip == null))
                {
                    // Remove the popup app menu that is showing
                    VisualPopupManager.Singleton.EndAllTracking();
                }

                // If a checked style button
                if (Checked != ButtonCheckState.NotCheckButton)
                {
                    // Then invert the checked state
                    if (Checked == ButtonCheckState.Unchecked)
                        Checked = ButtonCheckState.Checked;
                    else
                        Checked = ButtonCheckState.Unchecked;
                }

                GenerateClick(e);
            }
        }
        #endregion
    }
}
