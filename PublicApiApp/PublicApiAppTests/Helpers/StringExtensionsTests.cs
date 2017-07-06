using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Extensions;

namespace PublicApiAppTests.Helpers
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            string nullString = null;

            Assert.IsTrue(nullString.IsNullOrEmpty());
            Assert.IsTrue("".IsNullOrEmpty());
            Assert.IsFalse("lolz".IsNullOrEmpty());
        }

        [TestMethod]
        public void ValidEmail()
        {
            Assert.IsTrue("c@g.com".IsValidEmailAddress());
            Assert.IsFalse("yoyoma.com".IsValidEmailAddress());
        }

        [TestMethod]
        public void ValidPhone()
        {
            Assert.IsTrue("1231231234".IsValidPhoneNumber());
            Assert.IsTrue("(123) 123-1234".IsValidPhoneNumber());
            Assert.IsTrue("(123)123-1234".IsValidPhoneNumber());
            Assert.IsTrue("(123)1231234".IsValidPhoneNumber());
            Assert.IsTrue("1123-123-1234".IsValidPhoneNumber());
            Assert.IsFalse("123123123a".IsValidPhoneNumber());
            Assert.IsFalse("123123".IsValidPhoneNumber());
        }
    }
}
