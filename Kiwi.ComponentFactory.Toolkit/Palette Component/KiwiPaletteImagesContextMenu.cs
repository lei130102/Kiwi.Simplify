﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Storage for palette context menu images.
    /// </summary>
    public class KiwiPaletteImagesContextMenu : Storage
    {
        #region Instance Fields
        private PaletteRedirect _redirect;
        private Image _checked;
        private Image _indeterminate;
        private Image _subMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteImagesContextMenu class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteImagesContextMenu(PaletteRedirect redirect,
                                               NeedPaintHandler needPaint)
        {
            // Store the redirector
            _redirect = redirect;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the storage
            _checked = null;
            _indeterminate = null;
            _subMenu = null;
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
                return (_checked == null) &&
                       (_indeterminate == null) &&
                       (_subMenu == null);
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            _checked = _redirect.GetContextMenuCheckedImage();
            _indeterminate = _redirect.GetContextMenuIndeterminateImage();
            _subMenu = _redirect.GetContextMenuSubMenuImage();
        }
        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public void SetRedirector(PaletteRedirect redirect)
        {
            // Update our cached reference
            _redirect = redirect;
        }
        #endregion

        #region Checked
        /// <summary>
        /// Gets and sets the image for use with a checked menu item.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use with a checked menu item.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Checked
        {
            get { return _checked; }

            set
            {
                if (_checked != value)
                {
                    _checked = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Checked property to its default value.
        /// </summary>
        public void ResetChecked()
        {
            Checked = null;
        }
        #endregion

        #region Indeterminate
        /// <summary>
        /// Gets and sets the image for use with an indeterminate menu item.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use with an indeterminate menu item.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Indeterminate
        {
            get { return _indeterminate; }

            set
            {
                if (_indeterminate != value)
                {
                    _indeterminate = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Indeterminate property to its default value.
        /// </summary>
        public void ResetIndeterminate()
        {
            Indeterminate = null;
        }
        #endregion

        #region SubMenu
        /// <summary>
        /// Gets and sets an image indicating a sub-menu on a context menu item.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image indicating a sub-menu on a context menu item.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image SubMenu
        {
            get { return _subMenu; }

            set
            {
                if (_subMenu != value)
                {
                    _subMenu = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the SubMenu property to its default value.
        /// </summary>
        public void ResetSubMenu()
        {
            SubMenu = null;
        }
        #endregion
    }
}
