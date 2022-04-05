using LeezaalLib;
using NUnit.Framework;
using System;


namespace UnitTestLezaalLib
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void HatTestGoedNaamIs()
        {
            var list = Hat.Hats();
            var actual = list[2];
            var expexted = "Pet";
            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void MagazineClorsTestReturns()
        {
            var list = MagazineColors.Colors();
            var actual = list[2];
            var expexted = "Groen";
            Assert.AreEqual(expexted, actual);
        }
        [Test]
        public void MagazineTestRandom()
        {
            Random rand = new Random();
            var Colorlist = new Magazine();
            var actual = Colorlist.Kleur;
            var expexted = rand.Next(Colorlist.Kleur);
            Assert.AreEqual(expexted, actual);
        }

        [Test]
        public void HatTestRandom()
        {
            Random rand = new Random();
            var Hatlist = new Reader();
            var actual = Hatlist.HatIndex;
            var expexted = rand.Next(Hatlist.HatIndex);
            Assert.AreEqual(expexted, actual);
        }


    }
}
