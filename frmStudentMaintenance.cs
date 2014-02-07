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
    public partial class frmStudentMaintenance : Form
    {
        public frmStudentMaintenance()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expStudentsAndMajorsDataSet);

        }

        private void frmStudentMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expStudentsAndMajorsDataSet.StudentMajor' table. You can move, or remove it, as needed.
            this.studentMajorTableAdapter.Fill(this.expStudentsAndMajorsDataSet.StudentMajor);
            // TODO: This line of code loads data into the 'expStudentsAndMajorsDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.expStudentsAndMajorsDataSet.Student);

        }

        private void middleInitialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void middleInitialLabel_Click(object sender, EventArgs e)
        {

        }

        private void studentBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void findByIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FindByID(this.expStudentsAndMajorsDataSet.Student, ((int)(System.Convert.ChangeType(studentIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FindByLastNameToolStripButton_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.FindByLastName(this.expStudentsAndMajorsDataSet.Student, ((string)((LastNameToolStripTextBox.Text))));
        }

        private void FindAllToolStripButton_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.expStudentsAndMajorsDataSet.Student);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentAddModify addStudentForm;
            DialogResult result;

            addStudentForm = new frmStudentAddModify();
            addStudentForm.addMode = true;
            result = addStudentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine("Clicked OK on Add Student");
                studentIDToolStripTextBox.Text = addStudentForm.studentID.ToString();
                findByIDToolStripButton.PerformClick();
            }
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("Clicked Cancel on Add Student");
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            frmStudentAddModify addStudentForm;
            DialogResult result;

            addStudentForm = new frmStudentAddModify();
            addStudentForm.addMode = false;
            addStudentForm.studentID = Convert.ToInt32(studentIDTextBox.Text);
            result = addStudentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine("Clicked OK on Modify Student");
                this.studentTableAdapter.FindByID(this.expStudentsAndMajorsDataSet.Student, addStudentForm.studentID);
            }
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("Clicked Cancel on Modify Student");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Student","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.studentBindingSource.RemoveCurrent();
                this.studentTableAdapter.Update(this.expStudentsAndMajorsDataSet.Student);
            }
            else
            {
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
