using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
	/// Storage for gallery button images.
	/// </summary>
    public class GalleryImages : Storage
    {
        #region Instance Fields
        private GalleryButtonImages _up;
        private GalleryButtonImages _down;
        private GalleryButtonImages _dropDown;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the GalleryImages class.
		/// </summary>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public GalleryImages(NeedPaintHandler needPaint)
        {
            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the storage
            _up = new GalleryButtonImages(needPaint);
            _down = new GalleryButtonImages(needPaint);
            _dropDown = new GalleryButtonImages(needPaint);
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
                return _up.IsDefault &&
                       _down.IsDefault &&
                       _dropDown.IsDefault;
            }
        }
        #endregion

        #region Up
        /// <summary>
        /// Gallery up button images.
        /// </summary>
        [KiwiPersist(true)]
        [Category("Visuals")]
        [Description("Gallery up button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public GalleryButtonImages Up
        {
            get { return _up; }
        }
        #endregion

        #region Down
        /// <summary>
        /// Gallery down button images.
        /// </summary>
        [KiwiPersist(true)]
        [Category("Visuals")]
        [Description("Gallery down button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public GalleryButtonImages Down
        {
            get { return _down; }
        }
        #endregion

        #region DropDown
        /// <summary>
        /// Gallery drop down button images.
        /// </summary>
        [KiwiPersist(true)]
        [Category("Visuals")]
        [Description("Gallery drop down button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public GalleryButtonImages DropDown
        {
            get { return _dropDown; }
        }
        #endregion
    }
}
