﻿using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Provides the set of drag targets relevent to the set of pages being moved.
    /// </summary>
    public class DockingDragTargetProvider : IDragTargetProvider
    {
        #region Instance Fields
        private KiwiDockingManager _manager;
        private KiwiPageCollection _pages;
        private KiwiFloatingWindow _floatingWindow;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DragTargetNull class.
        /// </summary>
        /// <param name="manager">Reference to docking manager.</param>
        /// <param name="floatingWindow">Reference to window being dragged.</param>
        /// <param name="pages">Reference to collection of pages to drag.</param>
        public DockingDragTargetProvider(KiwiDockingManager manager,
                                         KiwiFloatingWindow floatingWindow,
                                         KiwiPageCollection pages)
        {
            _manager = manager;
            _floatingWindow = floatingWindow;
            _pages = pages;
        }
        #endregion

        #region Public
        /// <summary>
        /// Generate a list of drag targets that are relevant to the provided end data.
        /// </summary>
        /// <param name="dragEndData">Pages data being dragged.</param>
        /// <returns>List of drag targets.</returns>
        public DragTargetList GenerateDragTargets(PageDragEndData dragEndData)
        {
            DragTargetList targets = new DragTargetList();

            // Generate the set of targets from the element hierarchy
            _manager.PropogateDragTargets(_floatingWindow, dragEndData, targets);

            // Must have at least one target
            if (targets.Count == 0)
                targets.Add(new DragTargetNull());

            return targets;
        }
        #endregion
    }
}
