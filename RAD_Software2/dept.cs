using System;
using System.Collections.Generic;
using System.Text;

namespace RAD_Software2
{
    public class dept
    {
        private int id;
        private string name;
        private int personel;
        private string major;
        private string address;
        private string tell;

        public int ID
        {
            get{return id;}
            set { id = value; }
            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public int Personel
        {
            get { return personel; }
            set { personel = value; }
        }

        public string Tell
        {
            get { return tell; }
            set { tell = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        ////constructor
        public dept(int id, string name, int personel, string major, string address, string tell)
        {
            ID = id;
            Name = name;
            Personel = personel;
            Major = major;
            Address = address;
            Tell = tell;
        }
        /////methods

        public int SearchIDDept(string name)
        {
            int i = 0;
            foreach (dept d in myData.depts)
            {
                if (d.Name == name)
                {
                    i = d.ID;
                }
            }
            return i;

        }
        public int SearchPersonelSum(int Deid)
        {
            int i = 0;
            foreach (dept d1 in myData.depts)
            {
                if (d1.id == Deid)
                {
                    i = d1.personel;
                }
                
            }
            return i;
        }
    }
}
