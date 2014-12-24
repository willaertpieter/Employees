namespace Employees
{
    partial class EmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.labelListofemployees = new System.Windows.Forms.Label();
            this.groupBoxDetailsEmployee = new System.Windows.Forms.GroupBox();
            this.buttonSavechanges = new System.Windows.Forms.Button();
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCreatedat = new System.Windows.Forms.TextBox();
            this.textBoxTelephonenumber = new System.Windows.Forms.TextBox();
            this.textBoxDateofbirth = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEmployeeDetails = new System.Windows.Forms.Button();
            this.buttonNewemployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxDetailsEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(12, 63);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(204, 173);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // labelListofemployees
            // 
            this.labelListofemployees.AutoSize = true;
            this.labelListofemployees.Location = new System.Drawing.Point(12, 47);
            this.labelListofemployees.Name = "labelListofemployees";
            this.labelListofemployees.Size = new System.Drawing.Size(88, 13);
            this.labelListofemployees.TabIndex = 1;
            this.labelListofemployees.Text = "List of employees";
            // 
            // groupBoxDetailsEmployee
            // 
            this.groupBoxDetailsEmployee.Controls.Add(this.buttonSavechanges);
            this.groupBoxDetailsEmployee.Controls.Add(this.textBoxFunction);
            this.groupBoxDetailsEmployee.Controls.Add(this.label6);
            this.groupBoxDetailsEmployee.Controls.Add(this.label5);
            this.groupBoxDetailsEmployee.Controls.Add(this.label4);
            this.groupBoxDetailsEmployee.Controls.Add(this.textBoxCreatedat);
            this.groupBoxDetailsEmployee.Controls.Add(this.textBoxTelephonenumber);
            this.groupBoxDetailsEmployee.Controls.Add(this.textBoxDateofbirth);
            this.groupBoxDetailsEmployee.Controls.Add(this.textBoxLastname);
            this.groupBoxDetailsEmployee.Controls.Add(this.textBoxFirstname);
            this.groupBoxDetailsEmployee.Controls.Add(this.label3);
            this.groupBoxDetailsEmployee.Controls.Add(this.label2);
            this.groupBoxDetailsEmployee.Controls.Add(this.label1);
            this.groupBoxDetailsEmployee.Location = new System.Drawing.Point(250, 47);
            this.groupBoxDetailsEmployee.Name = "groupBoxDetailsEmployee";
            this.groupBoxDetailsEmployee.Size = new System.Drawing.Size(281, 232);
            this.groupBoxDetailsEmployee.TabIndex = 3;
            this.groupBoxDetailsEmployee.TabStop = false;
            this.groupBoxDetailsEmployee.Text = "Employee Details";
            // 
            // buttonSavechanges
            // 
            this.buttonSavechanges.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSavechanges.Location = new System.Drawing.Point(192, 202);
            this.buttonSavechanges.Name = "buttonSavechanges";
            this.buttonSavechanges.Size = new System.Drawing.Size(89, 23);
            this.buttonSavechanges.TabIndex = 13;
            this.buttonSavechanges.Text = "Save changes";
            this.buttonSavechanges.UseVisualStyleBackColor = false;
            this.buttonSavechanges.Click += new System.EventHandler(this.buttonSavechanges_Click);
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Location = new System.Drawing.Point(104, 147);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(171, 20);
            this.textBoxFunction.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Function";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Joined company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telephonenumber";
            // 
            // textBoxCreatedat
            // 
            this.textBoxCreatedat.Location = new System.Drawing.Point(104, 120);
            this.textBoxCreatedat.Name = "textBoxCreatedat";
            this.textBoxCreatedat.ReadOnly = true;
            this.textBoxCreatedat.Size = new System.Drawing.Size(171, 20);
            this.textBoxCreatedat.TabIndex = 8;
            // 
            // textBoxTelephonenumber
            // 
            this.textBoxTelephonenumber.Location = new System.Drawing.Point(104, 93);
            this.textBoxTelephonenumber.Name = "textBoxTelephonenumber";
            this.textBoxTelephonenumber.Size = new System.Drawing.Size(171, 20);
            this.textBoxTelephonenumber.TabIndex = 6;
            // 
            // textBoxDateofbirth
            // 
            this.textBoxDateofbirth.Location = new System.Drawing.Point(104, 66);
            this.textBoxDateofbirth.Name = "textBoxDateofbirth";
            this.textBoxDateofbirth.Size = new System.Drawing.Size(171, 20);
            this.textBoxDateofbirth.TabIndex = 5;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(104, 43);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(171, 20);
            this.textBoxLastname.TabIndex = 4;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(104, 17);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(171, 20);
            this.textBoxFirstname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // buttonEmployeeDetails
            // 
            this.buttonEmployeeDetails.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEmployeeDetails.Location = new System.Drawing.Point(13, 249);
            this.buttonEmployeeDetails.Name = "buttonEmployeeDetails";
            this.buttonEmployeeDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployeeDetails.TabIndex = 4;
            this.buttonEmployeeDetails.Text = "Show details";
            this.buttonEmployeeDetails.UseVisualStyleBackColor = false;
            this.buttonEmployeeDetails.Click += new System.EventHandler(this.buttonEmployeeDetails_Click);
            // 
            // buttonNewemployee
            // 
            this.buttonNewemployee.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNewemployee.Location = new System.Drawing.Point(426, 10);
            this.buttonNewemployee.Name = "buttonNewemployee";
            this.buttonNewemployee.Size = new System.Drawing.Size(91, 23);
            this.buttonNewemployee.TabIndex = 5;
            this.buttonNewemployee.Text = "New employee";
            this.buttonNewemployee.UseVisualStyleBackColor = false;
            this.buttonNewemployee.Click += new System.EventHandler(this.buttonNewemployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(112, 250);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(104, 23);
            this.buttonRemoveEmployee.TabIndex = 6;
            this.buttonRemoveEmployee.Text = "Remove employee";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = false;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(138, 20);
            this.textBoxSearch.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(156, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(60, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(543, 291);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonNewemployee);
            this.Controls.Add(this.buttonEmployeeDetails);
            this.Controls.Add(this.groupBoxDetailsEmployee);
            this.Controls.Add(this.labelListofemployees);
            this.Controls.Add(this.listBoxEmployees);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeList";
            this.ShowIcon = false;
            this.Text = "Employees";
            this.TopMost = true;
            this.groupBoxDetailsEmployee.ResumeLayout(false);
            this.groupBoxDetailsEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label labelListofemployees;
        private System.Windows.Forms.GroupBox groupBoxDetailsEmployee;
        private System.Windows.Forms.Button buttonEmployeeDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCreatedat;
        private System.Windows.Forms.TextBox textBoxTelephonenumber;
        private System.Windows.Forms.TextBox textBoxDateofbirth;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSavechanges;
        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNewemployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}