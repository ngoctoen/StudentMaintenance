using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentMaintenance
{
    public partial class frmStudentAddModify : Form
    {

        public bool addMode;
        public int studentID;

        public frmStudentAddModify()
        {
            InitializeComponent();
        }



        private void frmStudentAddModify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expStudentsAndMajorsDataSet.Student' table. You can move, or remove it, as needed.
            if (addMode)
            {
                this.Text = "Add a Student";
                this.btnOK.Text = "Add Student";
                this.studentBindingSource.AddNew();
            }
            else
            {
                this.Text = "Modify a Student";
                this.btnOK.Text = "Save Changes";
                this.studentTableAdapter.FindByID(this.expStudentsAndMajorsDataSet.Student, studentID);


            }

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.expStudentsAndMajorsDataSet.Student);
            if (addMode)
            {
                studentID = Convert.ToInt32(studentIDTextBox.Text);
            }
        }
    }
}
