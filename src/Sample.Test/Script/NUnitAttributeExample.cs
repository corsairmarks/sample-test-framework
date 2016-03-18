namespace Sample.Test
{
    using NUnit.Framework;
    using Sample.Test.Framework;

    /// <summary>
    /// Sample NUnit test scripts of <see cref="Foo"/> using typical framework elements.
    /// </summary>
    [TestOf(typeof(Foo))]
    public class NUnitAttributeExample : BaseFrameworkTestFixture
    {
        /// <summary>
        /// A sample method that represents a typical test.  This method adds
        /// usage of a <see cref="PropertyAttribute"/>.
        /// </summary>
        [TestCase(TestName = "ReportingName1")]
        [Property("TestId", "WorkItem1")]
        public void TestMethod1()
        {
            this.Prepare();

            // Arrange
            Foo foo = new Foo();

            // Act
            bool result = foo.Bar();

            // Assert
            Assert.That(result, Is.False);

            this.Complete();
        }

        /// <summary>
        /// A sample method that represents a typical test.  This method adds
        /// usage of a constant for the <see cref="PropertyAttribute"/> key.
        /// </summary>
        [TestCase(TestName = "ReportingName2")]
        [Property(FrameworkTestIdAttribute.TestIdPropertyKey, "WorkItem2")]
        public void TestMethod2()
        {
            this.Prepare();

            // Arrange
            Foo foo = new Foo();

            // Act
            bool result = foo.Bar();

            // Assert
            Assert.That(result, Is.False);

            this.Complete();
        }

        /// <summary>
        /// A sample method that represents a typical test.  This method adds usage
        /// of the <see cref="FrameworkTestId"/> attribute, a custom subclass of
        /// <see cref="PropertyAttribute"/>.
        /// </summary>
        [TestCase(TestName = "ReportingName3")]
        [FrameworkTestId("WorkItem3")]
        public void TestMethod3()
        {
            this.Prepare();

            // Arrange
            Foo foo = new Foo();

            // Act
            bool result = foo.Bar();

            // Assert
            Assert.That(result, Is.False);

            this.Complete();
        }
    }
}