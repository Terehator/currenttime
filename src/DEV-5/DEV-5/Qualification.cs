using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class Qualification: IComparable<Qualification>
    {
        QualificationChecker QualificationChecker;
        private string name;
        private int salary;
        private int productivity;
        public Qualification(QualificationChecker qc, string name, int sallary, int productivity)
        {
                this.QualificationChecker = qc;
                this.Name = name;
                this.Sallary = sallary;
                this.Productivity = productivity;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (QualificationChecker.CheckName(value))
                    this.name = value;
            }
        }
        public int Sallary
        { 
            get { return this.salary; }
            set
            {
                if (QualificationChecker.CheckSallary(value))
                    this.salary = value;
            }
        }
        public int Productivity
        {
            get { return this.productivity; }
            set
            {
                if (QualificationChecker.CheckProductivity(value))
                    this.productivity = value;
            }
        }
        public int CompareTo(Qualification q)
        {
            return this.productivity.CompareTo(q.productivity);
        }
    }
}
