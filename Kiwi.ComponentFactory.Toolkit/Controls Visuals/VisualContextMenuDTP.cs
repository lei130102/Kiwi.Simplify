using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Specialized version of the visual context menu that knows about the KiwiDateTimePicker drop down button.
    /// </summary>
    public class VisualContextMenuDTP : VisualContextMenu
    {
        #region Instance Fields
        private Rectangle _dropScreenRect;
        #endregion

        #region Identity
        /// <summary>
        ///  Initialize a new instance of the VisualContextMenuDTP class.
        /// </summary>
        /// <param name="contextMenu">Originating context menu instance.</param>
        /// <param name="palette">Local palette setting to use initially.</param>
        /// <param name="paletteMode">Palette mode setting to use initially.</param>
        /// <param name="redirector">Redirector used for obtaining palette values.</param>
        /// <param name="redirectorImages">Redirector used for obtaining images.</param>
        /// <param name="items">Collection of context menu items to be displayed.</param>
        /// <param name="enabled">Enabled state of the context menu.</param>
        /// <param name="keyboardActivated">Was the context menu activate by a keyboard action.</param>
        /// <param name="dropScreenRect">Screen rectangle of the drop down button.</param>
        public VisualContextMenuDTP(KiwiContextMenu contextMenu,
                                    IPalette palette,
                                    PaletteMode paletteMode,
                                    PaletteRedirect redirector,
                                    PaletteRedirectContextMenu redirectorImages,
                                    KiwiContextMenuCollection items,
                                    bool enabled,
                                    bool keyboardActivated,
                                    Rectangle dropScreenRect)
            : base(contextMenu, palette, paletteMode, redirector, redirectorImages,
                   items, enabled, keyboardActivated)
        {
            _dropScreenRect = dropScreenRect;
        }
        #endregion

        #region Public
        /// <summary>
        /// Should the mouse down be eaten when the tracking has been ended.
        /// </summary>
        /// <param name="m">Original message.</param>
        /// <param name="pt">Screen coordinates point.</param>
        /// <returns>True to eat message; otherwise false.</returns>
        public override bool DoesMouseDownGetEaten(Message m, Point pt)
        {
            // If the user dismissed the context menu by clicking down on the drop down button of
            // the KiwiDateTimePicker then eat the down message to prevent the down press from
            // opening the menu again.
            return _dropScreenRect.Contains(new Point(pt.X, pt.Y));
        }
        #endregion
    }
}
