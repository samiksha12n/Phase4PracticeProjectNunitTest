using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProjectTesting
{
    public class StudentManagement
    {
        static List<Student> students = new List<Student>()
        { new Student() {Id=1,Name="sam",Subject="Data Engineering" ,Class="7"},
            new Student() {Id=2,Name="Arsh",Subject="Data Analyst" ,Class="8"},
            new Student() {Id=3,Name="Rajiv",Subject="Java" ,Class="9"},
            new Student() {Id=4,Name="Deepesh",Subject="Web Developement" ,Class="6"},
            new Student() {Id=5,Name="Avi",Subject="Testing" ,Class="5"},
        };
        public List<Student> AllStudents()
        {
            return students;
        }
        public List<Student> GetStudentById(int id)
        {
            List<Student> searchList = new List<Student>();
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    searchList.Add(student);
                }

            }
            return searchList;
        }
    }
}
