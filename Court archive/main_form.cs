using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Court_archive
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            string accesslevel = Connect.user_id.GetValue(3).ToString();
            if (accesslevel != "3")
            {
                доступ3ToolStripMenuItem.Enabled = false;
            }
        }
        
        private void архивToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новоеДелоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void доступ3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
