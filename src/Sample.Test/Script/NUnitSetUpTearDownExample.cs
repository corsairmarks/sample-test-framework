﻿namespace Sample.Test
{
    using NUnit.Framework;
    using Sample.Test.Framework;

    /// <summary>
    /// Sample NUnit test scripts of <see cref="Foo"/> using proposed framework elements.
    /// </summary>
    [TestOf(typeof(Foo))]
    public class NUnitSetUpTearDownExample : BaseFrameworkTestFixtureWithSetUpTearDown
    {
        /// <summary>
        /// A sample method that represents a proposed test.  Because the base class
        /// <see cref="BaseFrameworkTestFixtureWithSetUpTearDown"/> leverages NUnit to ensure
        /// that <see cref="BaseFrameworkTestFixture.Prepare()"/> is called before every test and
        /// that <see cref="BaseFrameworkTestFixture.Complete()"/> is called after every test, the
        /// boilerplate code is no longer necessary.
        /// </summary>
        [Test]
        [FrameworkTestId("WorkItem4")]
        public void TestMethod4_TestAttribute()
        {
            // Arrange
            Foo foo = new Foo();

            // Act
            bool result = foo.Bar();

            // Assert
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// A sample method that represents a proposed test.  Because the base class
        /// <see cref="BaseFrameworkTestFixtureWithSetUpTearDown"/> leverages NUnit to ensure
        /// that <see cref="BaseFrameworkTestFixture.Prepare()"/> is called before every test and
        /// that <see cref="BaseFrameworkTestFixture.Complete()"/> is called after every test, the
        /// boilerplate code is no longer necessary.
        /// </summary>
        [TestCase]
        [FrameworkTestId("WorkItem4")]
        public void TestMethod4_TestCaseAttribute()
        {
            // Arrange
            Foo foo = new Foo();

            // Act
            bool result = foo.Bar();

            // Assert
            Assert.That(result, Is.False);
        }
    }
}