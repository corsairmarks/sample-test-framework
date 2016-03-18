namespace Sample.Test.Framework
{
    using NUnit.Framework;

    /// <summary>
    /// A sample framework base test class, containing shared functionality.
    /// </summary>
    [TestFixture]
    public abstract class BaseFrameworkTestFixture
    {
        /// <summary>
        /// This method prepares running a single test execution.  This would be used to initialize custom reporting and other per-test concerns.
        /// </summary>
        /// <remarks>
        /// The sample body of this method shows how NUnit properties might be leveraged as metadata instead of custom code, and how it might be output from a test.
        /// </remarks>
        protected void Prepare()
        {
            // do setup here with some NUnit properties
            TestContext.TestAdapter currentTest = TestContext.CurrentContext.Test;
            string methodName = currentTest.MethodName;
            string testName = currentTest.Name;
            string testId = currentTest.Properties.GetTestId();

            // to generate sample output
            TestContext.Out.WriteLine("Prepare() {1} ({0}): {2}", methodName, testName, testId);
        }

        /// <summary>
        /// This method cleans up after a single test execution.  This would be used to write final reporting or clean up resources used per-test.
        /// </summary>
        protected void Complete()
        {
            // sample method body
            TestContext.Out.WriteLine("Complete()");
        }
    }
}