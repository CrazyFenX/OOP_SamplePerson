using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject_Lesson_2_OOP
{
    public class Person
    {
        //fields
        public string lastName;
        public string firstName;
        public string patronymic;

        public DateTime birthDay;
        public decimal salary;
        public bool inStaff;

        //constructors
        public Person() { }

        public Person(string lname, string fname, string patronym, DateTime birthDayTmp, decimal salaryTmp, bool inStaffTmp) {
            this.lastName = lname;
            this.firstName = fname;
            this.patronymic = patronym;
            this.birthDay = birthDayTmp;
            this.salary = salaryTmp;
            this.inStaff = inStaffTmp;
        }

        //methods
        public void indexingSalary(decimal coef){
            this.salary *= coef;
        }
    }
}