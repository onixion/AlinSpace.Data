using System;

namespace AlinSpace.Data
{
    /// <summary>
    /// Represents the property.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        public object Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the modification timestamp.
        /// </summary>
        public DateTime ModificationTimestamp { get; set; }

        /// <summary>
        /// Clone property.
        /// </summary>
        /// <returns></returns>
        public virtual Property Clone()
        {
            return new Property
            {
                Key = Key,
                Value = Value,
            };
        }
    }

    ///// <summary>
    ///// Represents the property.
    ///// </summary>
    ///// <typeparam name="TKey">Type of the key.</typeparam>
    //public class Property<TKey> where TKey : struct
    //{
    //    public TKey Key { get; set; }

    //    /// <summary>
    //    /// Gets or sets the value.
    //    /// </summary>
    //    public object? Value { get; set; }

    //    /// <summary>
    //    /// Gets or sets the modification timestamp.
    //    /// </summary>
    //    public DateTime ModificationTimestamp { get; set; }
    //}

    ///// <summary>
    ///// Represents the property.
    ///// </summary>
    ///// <typeparam name="TKey">Type of the key.</typeparam>
    ///// <typeparam name="TValue">Type of the value.</typeparam>
    //public class Property<TKey, TValue> : Property<TKey> where TKey : struct
    //{
    //    /// <summary>
    //    /// Gets or sets the value.
    //    /// </summary>
    //    public new TValue? Value { get; set; }
    //}
}