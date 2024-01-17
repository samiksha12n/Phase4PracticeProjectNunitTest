using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProjectTesting
{
    [TestFixture]
    public class StudentManagementTest
    {
        StudentManagement management;
        List<Student> list;
        [SetUp]
        public void SetUp()
        {
            management = new StudentManagement();
            list = new List<Student>();
        }
        [Test]
        public void NotNullTest()
        {
            list = management.AllStudents();
            foreach (Student emp in list)
            {
                Assert.IsNotNull(emp.Id);
                Assert.IsNotNull(emp.Name);
                Assert.IsNotNull(emp.Subject);
                Assert.IsNotNull(emp.Class);
            }
        }
        [Test]
        public void GetStudentTest()
        {
            list = management.GetStudentById(1);
            foreach (Student student in list)
            {
                Assert.AreEqual(1, student.Id);
                Assert.AreEqual("Sam", student.Name);
                Assert.AreEqual("Data Engineering", student.Subject);
            }
        }
    }
}
