﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Ribbon
{
    /// <summary>
    /// Represents a single gallery range.
    /// </summary>
    [ToolboxItem(false)]
    [DefaultProperty("Heading")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    //
    [ToolboxBitmap(typeof(KiwiGalleryRange), "ToolboxBitmaps.KiwiGalleryRange.bmp")]
    public class KiwiGalleryRange : Component
    {
        #region Instance Fields
        private string _heading;
        private int _imageIndexStart;
        private int _imageIndexEnd;
        #endregion

        #region Events
        /// <summary>
        /// Occurs after the value of a property has changed.
        /// </summary>
        [Category("Gallery")]
        [Description("Occurs after the value of a property has changed.")]
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KiwiGalleryRange class.
        /// </summary>
        public KiwiGalleryRange()
        {
            // Default fields
            _heading = "Heading";
            _imageIndexStart = -1;
            _imageIndexEnd = -1;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets and sets the gallery range heading text.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Gallery range heading text.")]
        [DefaultValue("Heading")]
        public string Heading
        {
            get { return _heading; }

            set
            {
                if (value != _heading)
                {
                    _heading = value;
                    OnPropertyChanged("Heading");
                }
            }
        }

        /// <summary>
        /// Gets and sets the index of first image in the gallery ImageList for display.
        /// </summary>
        [Category("Behavior")]
        [Description("Index of first image in the gallery ImageList for display.")]
        [DefaultValue(-1)]
        public int ImageIndexStart
        {
            get { return _imageIndexStart; }

            set
            {
                if (_imageIndexStart != value)
                {
                    _imageIndexStart = value;
                    OnPropertyChanged("ImageIndexStart");
                }
            }
        }

        /// <summary>
        /// Gets and sets the index of last image in the gallery ImageList for display.
        /// </summary>
        [Category("Behavior")]
        [Description("Index of last image in the gallery ImageList for display.")]
        [DefaultValue(-1)]
        public int ImageIndexEnd
        {
            get { return _imageIndexEnd; }

            set
            {
                if (_imageIndexEnd != value)
                {
                    _imageIndexEnd = value;
                    OnPropertyChanged("ImageIndexEnd");
                }
            }
        }
        #endregion

        #region Protected
        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">Name of property that has changed.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
