﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// KiwiHeaderGroup specific implementation of a button specification.
    /// </summary>
    public class ButtonSpecHeaderGroup : ButtonSpecAny
    {
        #region Instance Fields
        private HeaderLocation _location;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the HeaderGroupButtonSpec class.
		/// </summary>
        public ButtonSpecHeaderGroup()
        {
            _location = HeaderLocation.PrimaryHeader;
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
                return (base.IsDefault &&
                        HeaderLocation == HeaderLocation.PrimaryHeader);
            }
        }
        #endregion

        #region HeaderLocation
        /// <summary>
        /// Gets and sets if the button header location.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Defines header location for the button.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(typeof(HeaderLocation), "PrimaryHeader")]
        public HeaderLocation HeaderLocation
        {
            get { return _location; }

            set
            {
                if (_location != value)
                {
                    _location = value;
                    OnButtonSpecPropertyChanged("Location");
                }
            }
        }

        /// <summary>
        /// Resets the HeaderLocation property to its default value.
        /// </summary>
        public void ResetHeaderLocation()
        {
            HeaderLocation = HeaderLocation.PrimaryHeader;
        }
        #endregion

        #region CopyFrom
        /// <summary>
        /// Value copy form the provided source to ourself.
        /// </summary>
        /// <param name="source">Source instance.</param>
        public void CopyFrom(ButtonSpecHeaderGroup source)
        {
            // Copy class specific values
            HeaderLocation = source.HeaderLocation;

            // Let base class copy the base values
            base.CopyFrom(source);
        }
        #endregion

        #region IButtonSpecValues
        /// <summary>
        /// Gets the button location value.
        /// </summary>
        /// <param name="palette">Palette to use for inheriting values.</param>
        /// <returns>Button location.</returns>
        public override HeaderLocation GetLocation(IPalette palette)
        {
            return HeaderLocation;
        }
        #endregion
    }
}
