using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class StudentCatalog
    {
        private List<Student> _students; 

        public StudentCatalog()
        {
            _students = new List<Student>();

        }

        public int Count
        {
            get
            {
                return _students.Count;

            }
        }


        public void AddStudent(Student aStudent)
        {
            _students.Add(aStudent);
        }

        public Student FindAStudent(string name)
        {
            return null;
        }

        public void RemoveStudent(string name)
        {
            
            
        }


    }
}
