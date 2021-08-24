﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Implement storage for a track bar position only states.
    /// </summary>
    public class PaletteTrackBarPositionStates : Storage
    {
        #region Instance Fields
        private PaletteElementColor _positionState;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteTrackBarPositionStates class.
        /// </summary>
        /// <param name="redirect">Source for inheriting values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteTrackBarPositionStates(PaletteTrackBarRedirect redirect,
                                             NeedPaintHandler needPaint)
            : this(redirect.Position, needPaint)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteTrackBarPositionStates class.
        /// </summary>
        /// <param name="inheritPosition">Source for inheriting position values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteTrackBarPositionStates(IPaletteElementColor inheritPosition,
                                             NeedPaintHandler needPaint)
        {
            Debug.Assert(inheritPosition != null);

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create storage that maps onto the inherit instances
            _positionState = new PaletteElementColor(inheritPosition, needPaint);
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
                return Position.IsDefault;
            }
        }
        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        /// <param name="inheritPosition">Source for inheriting position values.</param>
        public void SetInherit(IPaletteElementColor inheritPosition)
        {
            _positionState.SetInherit(inheritPosition);
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Palette state to use when populating.</param>
        public void PopulateFromBase(PaletteState state)
        {
            _positionState.PopulateFromBase(state);
        }
        #endregion

        #region Position
        /// <summary>
        /// Gets access to the position appearance.
        /// </summary>
        [KiwiPersist]
        [Category("Visuals")]
        [Description("Overrides for defining position appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteElementColor Position
        {
            get { return _positionState; }
        }

        private bool ShouldSerializePosition()
        {
            return !_positionState.IsDefault;
        }
        #endregion
    }
}
