using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace App
{
    public partial class NouvelleCourse : Form
    {
        private CourseRepository courseRep = new CourseRepository();
        DataGridView dataG = new DataGridView();

        public NouvelleCourse(ref DataGridView d)
        {            
            dataG = d;        
            InitializeComponent();
        }

        public void AfficherContenu()
        {
            dataG.Rows.Clear();
            dataG.Refresh();

            foreach (Course course in this.courseRep.GetAll())
            {
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(), "10" };
                dataG.Rows.Add(resultat);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Course course = new Course(this.textBoxLieu.Text, Convert.ToDouble(this.textBoxDist.Text), this.richTextBoxDesc.Text, this.dateTimePicker.Value);
            courseRep.Save(course);
            AfficherContenu();
        }
    }
}
