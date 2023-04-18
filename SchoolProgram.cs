using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Aggregation_Containment
{
    public class SchoolProgram
    {
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; // Aggregation
        List<Student> _students; // Containment

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;

        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade) // My issue is here due to a null value
        {
            if (_students != null)
            {
                _students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));
            }
            
        }
        public override string ToString()
        {
            return $"{_className} {_classNumber}: {_roomNumber} - {_instructor} - Number of Students {_students}";
        }
    }
}
