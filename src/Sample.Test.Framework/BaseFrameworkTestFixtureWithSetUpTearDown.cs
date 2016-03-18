namespace Sample.Test.Framework
{
    using NUnit.Framework;

    /// <summary>
    /// A sample framework base test class that extends <see cref="BaseFrameworkTestFixture"/> by leveraging NUnit to automatically call pre- and post-test operations.
    /// </summary>
    public abstract class BaseFrameworkTestFixtureWithSetUpTearDown : BaseFrameworkTestFixture
    {
        /// <summary>
        /// Called once before each test in any descendant classes.  As noted in the
        /// NUnit documentation, methods marked with marked with <see cref="SetUpAttribute"/>
        /// will always be called from least-derived to most-derived in that order.
        /// </summary>
        [SetUp]
        protected void SetUp()
        {
            this.Prepare();
        }

        /// <summary>
        /// Called once before each test in any descendant classes.  As noted in the
        /// NUnit documentation, methods marked with marked with <see cref="TearDownAttribute"/>
        /// will always be called from most-derived to least-derived in that order.
        /// </summary>
        [TearDown]
        protected void TearDown()
        {
            this.Complete();
        }
    }
}