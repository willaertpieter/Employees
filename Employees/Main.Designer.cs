namespace Employees
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateWagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelCurrenthour = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeListToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.employeeListToolStripMenuItem.Text = "Manage Employees";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.employeeListToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsListToolStripMenuItem,
            this.newFunctionToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.functionsToolStripMenuItem.Text = "Manage Functions";
            // 
            // functionsListToolStripMenuItem
            // 
            this.functionsListToolStripMenuItem.Name = "functionsListToolStripMenuItem";
            this.functionsListToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.functionsListToolStripMenuItem.Text = "Functions list";
            // 
            // newFunctionToolStripMenuItem
            // 
            this.newFunctionToolStripMenuItem.Name = "newFunctionToolStripMenuItem";
            this.newFunctionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newFunctionToolStripMenuItem.Text = "New function";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateWagesToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // calculateWagesToolStripMenuItem
            // 
            this.calculateWagesToolStripMenuItem.Name = "calculateWagesToolStripMenuItem";
            this.calculateWagesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.calculateWagesToolStripMenuItem.Text = "Calculate wages";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelCurrenthour
            // 
            this.labelCurrenthour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrenthour.AutoSize = true;
            this.labelCurrenthour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrenthour.Location = new System.Drawing.Point(495, 411);
            this.labelCurrenthour.Name = "labelCurrenthour";
            this.labelCurrenthour.Size = new System.Drawing.Size(57, 15);
            this.labelCurrenthour.TabIndex = 3;
            this.labelCurrenthour.Text = "HH:mm:ss";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 426);
            this.Controls.Add(this.labelCurrenthour);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "NV Programmeren";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateWagesToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labelCurrenthour;
        private System.Windows.Forms.Timer timerMain;
    }
}

