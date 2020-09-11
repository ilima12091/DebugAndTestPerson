using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class PersonTest
    {
        private Person person;
        [SetUp]
        public void Setup()
        {
            this.person = new Person("test", "testid");
        }

        [Test]
        public void Nombre_no_vacio()
        {
            person.Name = "";
            Assert.AreEqual("test", person.Name);
        }

        [Test]
        public void Nombre_no_nulo()
        {
            person.Name = null;
            Assert.AreEqual("test", person.Name);
        }
    }
}