using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Tests
{
    [TestClass]
    public class Tests
    {
        

        [TestMethod]
        public void StateAbbr()
        {
            Assert.IsTrue(Address.StateAbbreviations().Length == 2);
        }

        [TestMethod]
        public void State()
        {
            Assert.IsNotNull(Address.State());

        }

        [TestMethod]
        public void StreetName()
        {
            Assert.IsNotNull(Address.StreetName());
        }

        [TestMethod]
        public void MaleFirst()
        {
            Assert.IsNotNull(Name.MaleFirstName());
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.IsNotNull(Name.FirstName());
        }

        [TestMethod]
        public void FullName()
        {
            Assert.IsNotNull(Name.FullName());
        }
    }
}
