using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class ViewDrawMenuHeading : ViewComposite
    {
        #region Instance Fields
        private FixedContentValue _contentValues;
        private ViewDrawDocker _drawDocker;
        private ViewDrawContent _drawContent;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawMenuHeading class.
		/// </summary>
        /// <param name="heading">Reference to owning heading entry.</param>
        /// <param name="palette">Reference to palette source.</param>
        public ViewDrawMenuHeading(KiwiContextMenuHeading heading,
                                   PaletteTripleRedirect palette)
        {
            // Create fixed storage of the content values
            _contentValues = new FixedContentValue(heading.Text,
                                                   heading.ExtraText,
                                                   heading.Image,
                                                   heading.ImageTransparentColor);

            // Give the heading object the redirector to use when inheriting values
            heading.SetPaletteRedirect(palette);

            // Create the content for the actual heading text/image
            _drawContent = new ViewDrawContent(heading.StateNormal.Content, _contentValues, VisualOrientation.Top);

            // Use the docker to provide the background and border
            _drawDocker = new ViewDrawDocker(heading.StateNormal.Back, heading.StateNormal.Border);
            _drawDocker.Add(_drawContent, ViewDockStyle.Fill);

            // Add docker as the composite content
            Add(_drawDocker);
        }

        /// <summary>
        /// Obtains the String representation of this instance.
        /// </summary>
        /// <returns>User readable name of the instance.</returns>
        public override string ToString()
        {
            // Return the class name and instance identifier
            return "ViewDrawMenuHeading:" + Id;
        }
        #endregion

        #region Layout
        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null) throw new ArgumentNullException("context");

            // We take on all the available display area
            ClientRectangle = context.DisplayRectangle;

            // Let base class perform usual processing
            base.Layout(context);
        }
        #endregion
    }
}
