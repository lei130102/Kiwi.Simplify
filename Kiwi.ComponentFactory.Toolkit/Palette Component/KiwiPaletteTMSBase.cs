using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Base class for the palette TMS storage classes to derive from.
    /// </summary>
    public abstract class KiwiPaletteTMSBase : Storage
    {
        #region Instance Fields
        private KiwiInternalKCT _internalKCT;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiPaletteTMSBase class.
        /// </summary>
        /// <param name="internalKCT">Reference to inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KiwiPaletteTMSBase(KiwiInternalKCT internalKCT,
                                       NeedPaintHandler needPaint)
        {
            Debug.Assert(internalKCT != null);

            _internalKCT = internalKCT;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets access to the internal class used to inherit values.
        /// </summary>
        internal KiwiInternalKCT InternalKCT
        {
            get { return _internalKCT; }
        }
        #endregion
    }
}
