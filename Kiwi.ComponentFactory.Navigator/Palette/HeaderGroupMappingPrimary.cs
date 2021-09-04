using Kiwi.ComponentFactory.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Navigator
{
    /// <summary>
	/// Storage and mapping for primary header.
	/// </summary>
	public class HeaderGroupMappingPrimary : HeaderGroupMappingBase
    {
        #region Static Fields
        private const string _defaultHeading = "(Empty)";
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the HeaderGroupMappingPrimary class.
        /// </summary>
        /// <param name="navigator">Reference to owning navogator instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public HeaderGroupMappingPrimary(KiwiNavigator navigator,
                                         NeedPaintHandler needPaint)
            : base(navigator, needPaint)
        {
        }
        #endregion

        #region Default Values
        /// <summary>
        /// Gets the default heading value.
        /// </summary>
        /// <returns>String reference.</returns>
        protected override string GetHeadingDefault()
        {
            return _defaultHeading;
        }

        /// <summary>
        /// Gets the default description value.
        /// </summary>
        /// <returns>String reference.</returns>
        protected override string GetDescriptionDefault()
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets the default image mapping value.
        /// </summary>
        /// <returns>Image mapping enumeration.</returns>
        protected override MapKiwiPageImage GetMapImageDefault()
        {
            return MapKiwiPageImage.SmallMedium;
        }

        /// <summary>
        /// Gets the default heading mapping value.
        /// </summary>
        /// <returns>Text mapping enumeration.</returns>
        protected override MapKiwiPageText GetMapHeadingDefault()
        {
            return MapKiwiPageText.TitleText;
        }

        /// <summary>
        /// Gets the default description mapping value.
        /// </summary>
        /// <returns>Text mapping enumeration.</returns>
        protected override MapKiwiPageText GetMapDescriptionDefault()
        {
            return MapKiwiPageText.None;
        }
        #endregion

        #region MapImage
        /// <summary>
        /// Gets and sets the mapping used for the Image property.
        /// </summary>
        [DefaultValue(typeof(MapKiwiPageImage), "Small - Medium")]
        public override MapKiwiPageImage MapImage
        {
            get { return base.MapImage; }
            set { base.MapImage = value; }
        }
        #endregion

        #region MapHeading
        /// <summary>
        /// Gets and sets the mapping used for the Heading property.
        /// </summary>
        [DefaultValue(typeof(MapKiwiPageText), "Title - Text")]
        public override MapKiwiPageText MapHeading
        {
            get { return base.MapHeading; }
            set { base.MapHeading = value; }
        }
        #endregion

        #region MapDescription
        /// <summary>
        /// Gets and sets the mapping used for the Description property.
        /// </summary>
        [DefaultValue(typeof(MapKiwiPageText), "None (Empty string)")]
        public override MapKiwiPageText MapDescription
        {
            get { return base.MapDescription; }
            set { base.MapDescription = value; }
        }
        #endregion
    }
}
