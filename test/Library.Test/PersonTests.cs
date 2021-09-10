using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestIdValid() // Cambiá el nombre para indicar qué estás probando
        {
            Person persona = new Person("Person", "5.267.022-1");
            const string expectedId = "5.267.022-1";
            persona.ID = "5.267.022-3";
            Assert.AreEqual(expectedId,persona.ID);
        }

        [Test]
        public void TestIdNotValid()
        {
            Person persona = new Person("Person1","5.267.022-9");
            const string expectedId = null;
            Assert.AreEqual(expectedId, persona.ID);
        }

        [Test]
        public void TestNameNotValid()
        {
            Person persona = new Person("","5.267.022-1");
            const string expectedName = null;
            Assert.AreEqual(expectedName,persona.Name);
        }
    }

}