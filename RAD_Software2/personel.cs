using System;
using System.Collections.Generic;
using System.Text;

namespace RAD_Software2
{
    public class personel
    {
        private int id;
        private string name;
        private int deptid;
        private int projectid;
        private int karkard;
        private int salary;
        private int bsalary;
        private int article;
        private int workcount;
        private int teachcount;
        private string type;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

      
        public int Karkard
        {
            get { return karkard; }
            set { karkard = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Deptid
        {
            get { return deptid; }
            set { deptid = value; }
        }
        public int Projectid
        {
            get { return projectid; }
            set { projectid = value; }
        }
        public int Bsalary
        {
            get { return bsalary; }
            set { bsalary = value; }
        }
        public int Article
        {
            get { return article; }
            set { article = value; }
        }
        public int Workcount
        {
            get { return workcount; }
            set { workcount = value; }
        }
        public int TeachCount
        {
            get { return teachcount; }
            set { teachcount = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        ////constructor
        public personel(int id, string name, int deptid, int projectid, int karkard, int salary, int bsalary, int article, int workcount, int teachcount, string type)
        {
            ID = id;
            Name = name;
            Deptid = deptid;
            Projectid = projectid;
            Karkard = karkard;
            Salary = salary;
            Bsalary = bsalary;
            Article = article;
            Workcount = workcount;
            TeachCount = teachcount;
            Type = type;
        }
        



        ////methods
        public int PersonelDeptSum(int deptID)
        {
            int sum = 0;
            foreach (personel p1 in myData.personels)
            {
                if (p1.deptid == deptID)
                    sum++;
            }
            return sum;
        }

        public int SearchSumPersonelProject(int ProjectCode)
        {
            int PerSonelSum = 0;
            foreach (personel p1 in myData.personels)
            {
                if (p1.projectid == ProjectCode)
                    PerSonelSum++;
            }
            return PerSonelSum;
        }
        ///for calc
        public int SumofKarkard(int ProjectCode)
        {
            int sum = 0;
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.projectid == ProjectCode)
                {
                    sum = sum + personel1.karkard;
                }
            }
            return sum;
        }
        ////rotbe
        public int RotbeCalculation(int PersonelID, string Ptype)
        {
            int rotbe = 0;
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.id == PersonelID)
                {
                    if (Ptype == "Researcher")
                    {
                        rotbe = (personel1.teachcount) + (2 * personel1.workcount) + personel1.article;
                    }
                    else
                    {
                        rotbe = personel1.article;
                    }
                }
            }
            return rotbe; 
        }
        ///salary
        ///

        public int SalaryCalculation(int PersonelID, string Ptype)
        {
            int salary1 = 0;
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.id == PersonelID)
                {
                    if (Ptype == "Researcher")
                    {
                        salary1 = (personel1.bsalary) + (personel1.salary * personel1.karkard); 
                    }
                    else
                    {
                        salary1 = (personel1.salary * personel1.karkard); 
                    }
                }
            }
            return salary1; 

        }
    }
}
