using System;
using System.Collections.Generic;

namespace AP_Inheritance
{
    public class CClass
    {
        private string name;
        private Teacher whichTeacher;
        private List<SubjectTeacher> subjectTeachers;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teacher WhichTeacher
        {
            get { return whichTeacher; }
            set { whichTeacher = value; }
        }

        public List<SubjectTeacher> SubjectTeachers
        {
            get { return subjectTeachers; }
            set { subjectTeachers = value; }
        }
    }
}
