using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.ComponentFactory.Toolkit
{
    /// <summary>
    /// Attribute that marks properties for persistence inside the Kiwi palette.
    /// </summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class KiwiPersistAttribute : Attribute
    {
        // Instance fields
        private bool _navigate;
        private bool _populate;

        /// <summary>
        /// Initialize a new instance of the KiwiPersistAttribute class.
        /// </summary>
        public KiwiPersistAttribute()
            : this(true, true)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiPersistAttribute class.
        /// </summary>
        /// <param name="navigate">Should persistence navigate down the property.</param>
        public KiwiPersistAttribute(bool navigate)
            : this(navigate, true)
        {
        }

        /// <summary>
        /// Initialize a new instance of the KiwiPersistAttribute class.
        /// </summary>
        /// <param name="navigate">Should persistence navigate down the property.</param>
        /// <param name="populate">Should property be reset as part of a populate operation.</param>
        public KiwiPersistAttribute(bool navigate, bool populate)
        {
            _navigate = navigate;
            _populate = populate;
        }

        /// <summary>
        /// Gets and sets a value indicating if the persistence should navigate the property.
        /// </summary>
        public bool Navigate
        {
            get { return _navigate; }
            set { _navigate = value; }
        }

        /// <summary>
        /// Gets and sets a value indicating if the property should be reset as part of a populate operation.
        /// </summary>
        public bool Populate
        {
            get { return _populate; }
            set { _populate = value; }
        }
    }
}
