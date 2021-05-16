using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FirstConsoleApplitation
{
    public class TestClass
    {
        [Test]

        public void СheckExperienceLessThan0()
        {
            Employee empl = new Employee(0, "Ira", "Gulevich", 0);
            Assert.IsTrue(empl.getBonusPercent() == 0);
        }
        [Test]

        public void СheckExperienceLessThan5()
        {
            Employee empl1 = new Employee(4, "Ira", "Gulevich", 0);
            Assert.IsTrue(empl1.getBonusPercent() == 5);
        }


        [Test]

        public void СheckExperienceLessThan10()
        {
            Employee empl2 = new Employee(5, "Ira", "Gulevich", 2);
            Assert.IsTrue(empl2.getBonusPercent() == 10);
        }

        [Test]

        public void СheckExperienceLessThan15()
        {
            Employee empl3 = new Employee(6, "Ira", "Gulevich", 4);
            Assert.IsTrue(empl3.getBonusPercent() == 15);
        }
        [Test]

        public void СheckExperienceLessThan20()
        {
            Employee empl4 = new Employee(6, "Ira", "Gulevich", 5);
            Assert.IsTrue(empl4.getBonusPercent() == 20);


        }
        [Test]

        public void СheckExperienceLessThan11()
        {
            Employee empl4 = new Employee(6, "Ira", "Gulevich", 5);
            Assert.IsTrue(empl4.getBonusPercent() == 11);


        }
    }


}