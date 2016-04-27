using System;
using System.Collections.Generic;
using System.Text;

namespace RAD_Software2
{
    public class project
    {
        private int code;
        private string name;
        private string subject;
        private string tarikh;
        private int hourse;
        private int personel;
        private string major;
        private int deptid;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Tarikh
        {
            get { return tarikh; }
            set { tarikh = value; }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int Personel
        {
            get { return personel; }
            set { personel = value; }

        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }

        }

        public int Hourse
        {
            get { return hourse; }
            set { hourse=value;}

        }
        public string Major
        {
            get { return major; }
            set { major = value; }

        }
        public int Deptid
        {
            get { return deptid; }
            set { deptid = value; }

        }
        ////constructor
        public project(int code, string name, string subject, string tarikh, int hourse, int personel, string major, int deptid)
        {
            Code = code;
            Name = name;
            Subject = subject;
            Tarikh = tarikh;
            Hourse = hourse;
            Personel = personel;
            Major = major;
            Deptid = deptid;
        }
        //////methods

        public int SearchProjectPersonel(int ProjectCode)
        {
            int Sum = 0;
            foreach (project project1 in myData.projects)
            {
                if (project1.Code == ProjectCode)
                {
                    Sum = project1.personel;
                }
            }
            return Sum;
        }
        //for calc
        public int SearchHoure(int ProjectCode)
        {
            int houre = 0;
            foreach (project project1 in myData.projects)
            {
                if (project1.code == ProjectCode)
                {
                    houre = project1.hourse;
                }
            }
            return houre;
        }
    }
}
