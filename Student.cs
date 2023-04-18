﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Aggregation_Containment
{
    public class Student
    {
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade;}
        public int GenEdGrade { get => _genEdGrade;}
        public override string ToString()
        {
            return $"{_firstName} - {_lastName} - CSI Grade:{_csiGrade} - GenEd Grade:{_genEdGrade}";
        }
    }
}
