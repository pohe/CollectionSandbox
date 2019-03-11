using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests
{
    [TestClass()]
    public class StudentCatalogTests
    {

        private StudentCatalog _catalog;

        public void setUp()
        {
            Student s1 = new Student("Mohammed");
            Student s2 = new Student("Poul");
            Student s3 = new Student("Vibeke");
            _catalog = new StudentCatalog();
            _catalog.AddStudent(s1);
            _catalog.AddStudent(s2);
            _catalog.AddStudent(s3);
        }


        [TestMethod()]
        public void AddStudentTest()
        {
            //Arrange
            setUp();

            ////Act
            Student s4 = new Student("Jamshid");
            int beforeAdd = _catalog.Count;
            _catalog.AddStudent(s4);
            int afterAdd = _catalog.Count;
            ////Assert
            Assert.AreEqual(afterAdd-1, beforeAdd);
        }

        [TestMethod()]
        public void FindAStudentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveStudentTest()
        {
            Assert.Fail();
        }
    }
}