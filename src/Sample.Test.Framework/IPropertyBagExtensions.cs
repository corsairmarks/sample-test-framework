namespace Sample.Test.Framework
{
    using System;
    using NUnit.Framework.Interfaces;

    /// <summary>
    /// Extensions for the <see cref="IPropertyBag"/> interface.
    /// </summary>
    public static class IPropertyBagExtensions
    {
        /// <summary>
        /// Retrieve the test identifier from this <see cref="IPropertyBag"/>.
        /// </summary>
        /// <param name="properties">THe <see cref="IPropertyBag"/> from which to retrieve the test identifier.</param>
        /// <returns>The test identifier if present in the <paramref name="properties"/>; otherwise, <c>null</c>.</returns>
        /// <remarks>Uses the <see cref="FrameworkTestIdAttribute.TestIdPropertyKey"/> constant as a key to retrieve the first value.</remarks>
        /// <exception cref="System.ArgumentNullException"><paramref name="properties"/> is <c>null</c>.</exception>
        public static string GetTestId(this IPropertyBag properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }

            object value = properties.Get(FrameworkTestIdAttribute.TestIdPropertyKey);
            if (value != null && value.GetType() == typeof(string))
            {
                return (string)value;
            }

            return null;
        }
    }
}