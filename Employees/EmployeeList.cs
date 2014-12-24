using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Employees
{
    public partial class EmployeeList : Form
    {
        private Employee selectedEmployee;

        public EmployeeList()
        {
            InitializeComponent();

            refreshListbox();
        }

        public void refreshListbox()
        {
            listBoxEmployees.DataSource = EmployeeRepository.GetAll();
            listBoxEmployees.DisplayMember = "fullName";
            listBoxEmployees.ValueMember = "employeeid";
        }

        private void buttonNewemployee_Click(object sender, EventArgs e)
        {
            EmployeeNew employeeNew = new EmployeeNew();
            employeeNew.MdiParent = this.ParentForm;
            employeeNew.parent = this;
            employeeNew.Show();
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBoxEmployees.SelectedValue);
            //selectedEmployee = EmployeeRepository.GetEmployeebyID(id);

            if (MessageBox.Show("Are you sure you want to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                EmployeeRepository.RemoveEmployee(id);
                refreshListbox();
                MessageBox.Show("The employee is deleted.");
            }
            else
            {           
            }
        }

        private void buttonEmployeeDetails_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBoxEmployees.SelectedValue);

            selectedEmployee = EmployeeRepository.GetEmployeebyid(id);

            textBoxFirstname.Text = selectedEmployee.firstName;
            textBoxLastname.Text = selectedEmployee.lastName;
            textBoxDateofbirth.Text = Convert.ToString(selectedEmployee.birth);
            textBoxTelephonenumber.Text = Convert.ToString(selectedEmployee.telephoneNumber);
            textBoxCreatedat.Text = Convert.ToString(selectedEmployee.createdAt);
            textBoxFunction.Text = Convert.ToString(selectedEmployee.function);

            //listBoxVakken.DataSource = selectedEmployee.UitslagenLijst;
            //listBoxVakken.DisplayMember = "UitslagVolledig";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
                listBoxEmployees.SelectedItems.Clear();

                string searched = textBoxSearch.Text;

                int index = listBoxEmployees.FindString(searched, -1);
                if (index != -1)
                {
                    listBoxEmployees.SetSelected(index, true);
                    
                    MessageBox.Show("Found employee: " + searched);
                }
                else
                    MessageBox.Show("The employee was not found." + "\n" + "\n" + "Note: if there are more then two '" + searched + "' in the database the employee will not be found. Specify your search.");

        }

        private void buttonSavechanges_Click(object sender, EventArgs e)
        {
            selectedEmployee.firstName = textBoxFirstname.Text;
            selectedEmployee.lastName = textBoxLastname.Text;
            selectedEmployee.birth = Convert.ToDateTime(selectedEmployee.birth);
            selectedEmployee.telephoneNumber = textBoxTelephonenumber.Text;
            selectedEmployee.createdAt = Convert.ToDateTime(selectedEmployee.createdAt);
            //selectedEmployee.function = textBoxFunction.Text;

            EmployeeRepository.UpdateEmployee(selectedEmployee);
            MessageBox.Show("Employee updated");

        }
    }
}
