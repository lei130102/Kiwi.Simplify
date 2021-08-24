using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implementation for the fixed minimize button for kiwi form.
    /// </summary>
    public class ButtonSpecFormWindowMin : ButtonSpecFormFixed
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonSpecFormWindowMin class.
        /// </summary>
        /// <param name="form">Reference to owning kiwi form instance.</param>
        public ButtonSpecFormWindowMin(KiwiForm form)
            : base(form, PaletteButtonSpecStyle.FormMin)
        {
        }
        #endregion

        #region IButtonSpecValues
        /// <summary>
        /// Gets the button visible value.
        /// </summary>
        /// <param name="palette">Palette to use for inheriting values.</param>
        /// <returns>Button visibiliy.</returns>
        public override bool GetVisible(IPalette palette)
        {
            // We do not show if the custom chrome is combined with composition,
            // in which case the form buttons are handled by the composition
            if (KiwiForm.ApplyComposition && KiwiForm.ApplyCustomChrome)
                return false;

            // The minimize button is never present on tool windows
            switch (KiwiForm.FormBorderStyle)
            {
                case FormBorderStyle.FixedToolWindow:
                case FormBorderStyle.SizableToolWindow:
                    return false;
            }

            // Have all buttons been turned off?
            if (!KiwiForm.ControlBox)
                return false;

            // Has the minimize/maximize buttons been turned off?
            if (!KiwiForm.MinimizeBox && !KiwiForm.MaximizeBox)
                return false;

            return true;
        }

        /// <summary>
        /// Gets the button enabled state.
        /// </summary>
        /// <param name="palette">Palette to use for inheriting values.</param>
        /// <returns>Button enabled state.</returns>
        public override ButtonEnabled GetEnabled(IPalette palette)
        {
            // Has the minimize buttons been turned off?
            if (!KiwiForm.MinimizeBox)
                return ButtonEnabled.False;

            return ButtonEnabled.True;
        }

        /// <summary>
        /// Gets the button checked state.
        /// </summary>
        /// <param name="palette">Palette to use for inheriting values.</param>
        /// <returns>Button checked state.</returns>
        public override ButtonCheckState GetChecked(IPalette palette)
        {
            // Close button is never shown as checked
            return ButtonCheckState.NotCheckButton;
        }
        #endregion    

        #region Protected Overrides
        /// <summary>
        /// Raises the Click event.
        /// </summary>
        /// <param name="e">An EventArgs that contains the event data.</param>
        protected override void OnClick(EventArgs e)
        {
            // Only if associated view is enabled to we perform an action
            if (GetViewEnabled())
            {
                // If we do not provide an inert form
                if (!KiwiForm.InertForm)
                {
                    // Only if the mouse is still within the button bounds do we perform action
                    MouseEventArgs mea = (MouseEventArgs)e;
                    if (GetView().ClientRectangle.Contains(mea.Location))
                    {
                        // Toggle between minimized and restored
                        if (KiwiForm.WindowState == FormWindowState.Minimized)
                            KiwiForm.SendSysCommand(PI.SC_RESTORE);
                        else
                            KiwiForm.SendSysCommand(PI.SC_MINIMIZE);

                        // Let base class fire any other attached events
                        base.OnClick(e);
                    }
                }
            }
        }
        #endregion
    }
}
