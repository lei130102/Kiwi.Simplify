using Kiwi.ComponentFactory.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kiwi.ComponentFactory.Docking
{
    /// <summary>
    /// Acts as a placeholder for a KiwiPage so that it can be restored to this location at a later time.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KiwiStorePage : KiwiPage
    {
        #region Instance Fields
        private string _storeName;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KiwiStorePage class.
        /// </summary>
        /// <param name="uniqueName">UniqueName of the page this is placeholding.</param>
        /// <param name="storeName">Storage name associated with this page location.</param>
        public KiwiStorePage(string uniqueName, string storeName)
        {
            Visible = false;
            UniqueName = uniqueName;
            _storeName = storeName;
        }
        #endregion

        #region Public
        /// <summary>
        /// As a placeholder this page is never visible.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public override bool LastVisibleSet
        {
            get { return false; }
            set { }
        }

        /// <summary>
        /// Gets the storgate name associated with this page.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public string StoreName
        {
            get { return _storeName; }
        }
        #endregion
    }
}
