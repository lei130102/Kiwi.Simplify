using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Toolkit
{
	/// <summary>
	/// Storage for the secondary header of the header group control.
	/// </summary>
	public class HeaderGroupValuesSecondary : HeaderValuesBase
	{
		#region Static Fields
		private const string _defaultDescription = "Description";
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the HeaderGroupValuesSecondary class.
		/// </summary>
		/// <param name="needPaint">Delegate for notifying paint requests.</param>
		public HeaderGroupValuesSecondary(NeedPaintHandler needPaint)
			: base(needPaint)
		{
		}
		#endregion

		#region Default Values
		/// <summary>
		/// Gets the default image value.
		/// </summary>
		/// <returns>Image reference.</returns>
		protected override Image GetImageDefault()
		{
			return null;
		}

		/// <summary>
		/// Gets the default heading value.
		/// </summary>
		/// <returns>String reference.</returns>
		protected override string GetHeadingDefault()
		{
			return _defaultDescription;
		}

		/// <summary>
		/// Gets the default description value.
		/// </summary>
		/// <returns>String reference.</returns>
		protected override string GetDescriptionDefault()
		{
			return string.Empty;
		}
		#endregion

		#region Heading
		/// <summary>
		/// Gets and sets the heading text.
		/// </summary>
		[DefaultValue("Description")]
		public override string Heading
		{
			get { return base.Heading; }
			set { base.Heading = value; }
		}
		#endregion
	}
}
