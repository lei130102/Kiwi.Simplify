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
    /// Storage for palette tree view images.
    /// </summary>
    public class KiwiPaletteImagesTreeView : Storage
    {
        #region Instance Fields
        private PaletteRedirect _redirect;
        private Image _plus;
        private Image _minus;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteImagesTreeView class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KiwiPaletteImagesTreeView(PaletteRedirect redirect,
                                            NeedPaintHandler needPaint)
        {
            // Store the redirector
            _redirect = redirect;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the storage
            _plus = null;
            _minus = null;
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
                return (_plus == null) &&
                       (_minus == null);
            }
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            _plus = _redirect.GetTreeViewImage(false);
            _minus = _redirect.GetTreeViewImage(true);
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

        #region Plus
        /// <summary>
        /// Gets and sets the image for use  when a node is collapsed.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use when a node is collapsed.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Plus
        {
            get { return _plus; }

            set
            {
                if (_plus != value)
                {
                    _plus = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Plus property to its default value.
        /// </summary>
        public void ResetPlus()
        {
            Plus = null;
        }
        #endregion

        #region Plus
        /// <summary>
        /// Gets and sets the image for use  when a node is expanded.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use when a node is expanded.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Minus
        {
            get { return _minus; }

            set
            {
                if (_minus != value)
                {
                    _minus = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Minus property to its default value.
        /// </summary>
        public void ResetMinus()
        {
            Minus = null;
        }
        #endregion
    }
}
