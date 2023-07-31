using AP_Inheritance;

namespace AP_Inheritance
{
    public class ClassTeacher : Teacher
    {
        private CClass whichClass;

        public CClass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}
