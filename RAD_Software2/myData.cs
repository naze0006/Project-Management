using System;
using System.Collections.Generic;
using System.Text;

namespace RAD_Software2
{
    static class myData
    {
        public static List<personel> personels;
        public static List<project> projects;
        public static List<dept> depts;

        public static void BuildmyData()
        {
            personels = new List<personel>();
            projects = new List<project>();
            depts = new List<dept>();

            //Data of myData
            personel p1 = new personel(123, "Ava Moradi", 1, -1, 20, 30000,20000,3,1,3,"Researcher");
            personel p2 = new personel(234, "Shirin Nazemoroaya", 1, 111, 30, 50000,-1,2,-1,-1,"Apprentice");
            personel p3 = new personel(123, "Nazanin Manafi", 1, -1, 20, 30000, 20000, 3, 1, 3, "Researcher");
            personel p4 = new personel(123, "Meysam Karimi", 1, -1, 20, 30000, 20000, 3, 1, 3, "Researcher");
            personels.Add(p1);
            personels.Add(p2);
            personels.Add(p3);
            personels.Add(p4);

            dept d1 = new dept(1, "soft",2, "study", "shiraz-eram", "2345678");
            dept d2 = new dept(1, "IT", 2, "Implementation", "Seri Kembangan", "892675678");
            depts.Add(d1);
            depts.Add(d2);

            project pr1 = new project(111, "Rad", "soft2", "2012/3/10", 20, 2, "study", 1);
            projects.Add(pr1);
        }
    }
}
