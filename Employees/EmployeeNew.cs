using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class EmployeeNew : Form
    {
        public EmployeeList parent { get; set; }

        public EmployeeNew()
        {
            InitializeComponent();

            cbFunctions.DataSource = FunctionRepository.GetAll();
            cbFunctions.DisplayMember = "functionname";
        }

        private void buttonAddemployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstname.Text))
            {
                labelRequiredfieldFirstname.Visible = false;
                if (!string.IsNullOrWhiteSpace(textBoxLastname.Text))
                {
                    labelRequiredfieldLastname.Visible = false;
                    if (!string.IsNullOrWhiteSpace(textBoxTelephonenumber.Text))
                    {
                        labelRequiredfieldTelephonenumber.Visible = false;
                        if (labelRequiredfieldDateofbirth.Visible == false)
                        {
                            labelRequiredfieldDateofbirth.Visible = false;
                             string Dateofbirth = dateTimePickerDateofbirth.Value.Date.ToString("dd/MM/yyyy");
                             string Startdate = dateTimePickerStartdate.Value.Date.ToString("dd/MM/yyyy");
                             if (MessageBox.Show("Are you sure you want to add:" + "\n" + "\n" + "Full name:" + "\t" + "\t" + textBoxFirstname.Text + " " + textBoxLastname.Text + "\n" + "Born on:" + "\t" + "\t" + Dateofbirth + "\n" + "Telephonenumber:" + "\t" + textBoxTelephonenumber.Text + "\n" + "Function:" + "\t" + "\t" + (Function)cbFunctions.SelectedItem + "\n" + "Startdate:" + "\t" + "\t" + Startdate + "\n" + "\n" + "To the database?", "Check employee information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                Employee employee = new Employee();

                                employee.firstName = textBoxFirstname.Text;
                                employee.lastName = textBoxLastname.Text;
                                employee.birth = dateTimePickerDateofbirth.Value;
                                employee.telephoneNumber = textBoxTelephonenumber.Text;
                                employee.createdAt = dateTimePickerStartdate.Value;
                                employee.function = (Function)cbFunctions.SelectedItem;

                                EmployeeRepository.AddEmployee(employee);

                                MessageBox.Show(textBoxFirstname.Text + " " + textBoxLastname.Text + " is added to the database.", "Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.parent.refreshListbox();

                                this.Close();
                                }
                                else
                                {
                                MessageBox.Show("The employee is not added.", "Cancelled.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                        }
                        else
                        {
                            MessageBox.Show("Please fill in all required fields.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all required fields.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                labelRequiredfieldFirstname.Visible = true;
                labelRequiredfieldLastname.Visible = true;
                labelRequiredfieldDateofbirth.Visible = true;
                labelRequiredfieldTelephonenumber.Visible = true;
                MessageBox.Show("Please fill in all required fields.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstname.Text))    
            {
                    labelRequiredfieldFirstname.Visible = false;
            }
                else
                {
                    labelRequiredfieldFirstname.Visible = true;
                }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLastname.Text))
            {
                labelRequiredfieldLastname.Visible = false;
            }
            else
            {
                labelRequiredfieldLastname.Visible = true;
            }
        }

        private void dateTimePickerDateofbirth_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dateTimePickerDateofbirth.Text))
            {
                labelRequiredfieldDateofbirth.Visible = false;
            }
            else
            {
                labelRequiredfieldDateofbirth.Visible = true;
            }
        }

        private void textBoxTelephonenumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTelephonenumber.Text))
            {
                labelRequiredfieldTelephonenumber.Visible = false;
            }
            else
            {
                labelRequiredfieldTelephonenumber.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }
