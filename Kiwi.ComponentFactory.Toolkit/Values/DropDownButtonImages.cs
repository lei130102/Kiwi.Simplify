using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Storage for drop down button images.
	/// </summary>
    public class DropDownButtonImages : Storage
    {
        #region Instance Fields
        private Image _common;
        private Image _disabled;
        private Image _normal;
        private Image _tracking;
        private Image _pressed;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DropDownButtonImages class.
		/// </summary>
        public DropDownButtonImages()
            : this(null)
        {
        }

        /// <summary>
        /// Initialize a new instance of the DropDownButtonImages class.
		/// </summary>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public DropDownButtonImages(NeedPaintHandler needPaint)
        {
            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the storage
            _common = null;
            _normal = null;
            _disabled = null;
            _tracking = null;
            _pressed = null;
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
                return (_common == null) &&
                       (_disabled == null) &&
                       (_normal == null) &&
                       (_tracking == null) &&
                       (_pressed == null);
            }
        }
        #endregion

        #region Common
        /// <summary>
        /// Gets and sets the common image that other drop down button images inherit from.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Common image that other drop down button images inherit from.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Common
        {
            get { return _common; }

            set
            {
                if (_common != value)
                {
                    _common = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Common property to its default value.
        /// </summary>
        public void ResetCommon()
        {
            Common = null;
        }
        #endregion

        #region Disabled
        /// <summary>
        /// Gets and sets the image for use when the drop down button is disabled.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use when the drop down button is disabled.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Disabled
        {
            get { return _disabled; }

            set
            {
                if (_disabled != value)
                {
                    _disabled = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Disabled property to its default value.
        /// </summary>
        public void ResetDisabled()
        {
            Disabled = null;
        }
        #endregion

        #region Normal
        /// <summary>
        /// Gets and sets the image for use when the drop down button is normal.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use when the drop down button is normal.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Normal
        {
            get { return _normal; }

            set
            {
                if (_normal != value)
                {
                    _normal = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Normal property to its default value.
        /// </summary>
        public void ResetNormal()
        {
            Normal = null;
        }
        #endregion

        #region Tracking
        /// <summary>
        /// Gets and sets the image for use when the drop down button is tracking.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use when the drop down button is tracking.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Tracking
        {
            get { return _tracking; }

            set
            {
                if (_tracking != value)
                {
                    _tracking = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Tracking property to its default value.
        /// </summary>
        public void ResetTracking()
        {
            Tracking = null;
        }
        #endregion

        #region Pressed
        /// <summary>
        /// Gets and sets the image for use when the drop down button is pressed.
        /// </summary>
        [KiwiPersist(false)]
        [Category("Visuals")]
        [Description("Image for use when the drop down button is pressed.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Pressed
        {
            get { return _pressed; }

            set
            {
                if (_pressed != value)
                {
                    _pressed = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Resets the Pressed property to its default value.
        /// </summary>
        public void ResetPressed()
        {
            Pressed = null;
        }
        #endregion
    }
}
