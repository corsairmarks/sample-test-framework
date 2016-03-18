namespace Sample.Test.Framework
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// A custom subclass of <see cref="PropertyAttribute"/> that adds semantic meaning for holding a test identifier.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class FrameworkTestIdAttribute : PropertyAttribute
    {
        /// <summary>
        /// The key used in the <see cref="base.Properties"/> collection.
        /// </summary>
        public const string TestIdPropertyKey = "TestIdPropertyKey";

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameworkTestIdAttribute"/> class.
        /// </summary>
        /// <param name="testId">The identifier of the test case for this test method.</param>
        public FrameworkTestIdAttribute(string testId)
            : base(TestIdPropertyKey, testId)
        {
        }
    }
}