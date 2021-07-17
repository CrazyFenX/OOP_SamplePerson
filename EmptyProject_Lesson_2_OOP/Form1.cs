using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyProject_Lesson_2_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person genDirector = new Person();
            genDirector.lastName = "Ponasenkov";
            genDirector.firstName = "Evgeniy";
            genDirector.patronymic = "Nicolaevich";

            genDirector.birthDay = DateTime.Today;
            genDirector.salary = 100000;
            genDirector.inStaff = true;

            Person officeWorker = new Person("Ponasenkov", "Evgeniy", "Nicolaevich",DateTime.Today , 100000, true);
            decimal k = 1.2m;
            string output = $"Зарплата officeWorker до индексации:{officeWorker.salary}\n";
            officeWorker.indexingSalary(k);
            output += $"Зарплата officeWorker после индексации:{officeWorker.salary}";
            MessageBox.Show(output);
        }
    }
}