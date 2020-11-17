
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LTXJconLibrary;

namespace Jcon_Contact_Tracing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public void JconSearch()
        {
            if (txtboxInput.Text.Contains("_"))
            {
                lblResult.Text = JconPath.Search(txtboxInput.Text.ToUpper());
            }
            else if (txtboxInput.Text.Contains("J"))
            {
                lblResult.Text = SystemBoard.Search(txtboxInput.Text.ToUpper());
            }
            else
            {
                lblResult.Text = "Invalid Format";
            }
        }
        
        private void txtboxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                JconSearch();
            }
        }
    }
}
