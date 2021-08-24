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
    /// Storage for check button content value information.
    /// </summary>
    public class CheckButtonImageStates : ButtonImageStates
    {
        #region Instance Fields
        private Image _imageCheckedNormal;
        private Image _imageCheckedPressed;
        private Image _imageCheckedTracking;
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
                return (base.IsDefault &&
                        (ImageCheckedNormal == null) &&
                        (ImageCheckedPressed == null) &&
                        (ImageCheckedTracking == null));
            }
        }
        #endregion

        #region ImageCheckedNormal
        /// <summary>
        /// Gets and sets the button image for checked normal state.
        /// </summary>
        [KiwiPersist(false)]
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Button image for checked normal state.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DefaultValue(null)]
        public override Image ImageCheckedNormal
        {
            get { return _imageCheckedNormal; }

            set
            {
                if (_imageCheckedNormal != value)
                {
                    _imageCheckedNormal = value;
                    PerformNeedPaint(true);
                }
            }
        }

        private bool ShouldSerializeImageCheckedNormal()
        {
            return ImageCheckedNormal != null;
        }

        /// <summary>
        /// Resets the ImageCheckedNormal property to its default value.
        /// </summary>
        public void ResetImageCheckedNormal()
        {
            ImageCheckedNormal = null;
        }
        #endregion

        #region ImageCheckedPressed
        /// <summary>
        /// Gets and sets the button image for checked pressed state.
        /// </summary>
        [KiwiPersist(false)]
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Button image for checked pressed state.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DefaultValue(null)]
        public override Image ImageCheckedPressed
        {
            get { return _imageCheckedPressed; }

            set
            {
                if (_imageCheckedPressed != value)
                {
                    _imageCheckedPressed = value;
                    PerformNeedPaint(true);
                }
            }
        }

        private bool ShouldSerializeImageCheckedPressed()
        {
            return ImageCheckedPressed != null;
        }

        /// <summary>
        /// Resets the ImageCheckedPressed property to its default value.
        /// </summary>
        public void ResetImageCheckedPressed()
        {
            ImageCheckedPressed = null;
        }
        #endregion

        #region ImageCheckedTracking
        /// <summary>
        /// Gets and sets the button image for checked tracking state.
        /// </summary>
        [KiwiPersist(false)]
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Button image for checked tracking state.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DefaultValue(null)]
        public override Image ImageCheckedTracking
        {
            get { return _imageCheckedTracking; }

            set
            {
                if (_imageCheckedTracking != value)
                {
                    _imageCheckedTracking = value;
                    PerformNeedPaint(true);
                }
            }
        }

        private bool ShouldSerializeImageCheckedTracking()
        {
            return ImageCheckedTracking != null;
        }

        /// <summary>
        /// Resets the ImageCheckedTracking property to its default value.
        /// </summary>
        public void ResetImageCheckedTracking()
        {
            ImageCheckedTracking = null;
        }
        #endregion

        #region CopyFrom
        /// <summary>
        /// Value copy form the provided source to ourself.
        /// </summary>
        /// <param name="source">Source instance.</param>
        public void CopyFrom(CheckButtonImageStates source)
        {
            base.CopyFrom(source);
            ImageCheckedNormal = source.ImageCheckedNormal;
            ImageCheckedPressed = source.ImageCheckedPressed;
            ImageCheckedTracking = source.ImageCheckedTracking;
        }
        #endregion
    }
}
