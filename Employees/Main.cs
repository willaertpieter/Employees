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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            //Clock bottom right screen
            Timer clock = new Timer();
            clock.Interval = 1000;
            clock.Tick += new EventHandler(clock_Tick);
            clock.Start();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.MdiParent = this;
            employeeList.Show();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            //Clock bottom right screen
            labelCurrenthour.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
