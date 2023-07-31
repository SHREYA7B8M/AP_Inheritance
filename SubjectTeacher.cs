using AP_Inheritance;
using System;

namespace AP_Inheritance
{
    public class SubjectTeacher : Teacher
    {
        private Subject whichSubject;

        public Subject WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }
}
