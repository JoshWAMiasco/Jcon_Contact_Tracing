using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jcon_Contact_Tracing
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string tag = "From : name    | Date: date".Replace("name", Environment.UserName).Replace("date", DateTime.Now.ToString("MM - dd - yyyy"));
            int counter = 0;
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            string filename = $"Feed_{counter}_{date}.txt";
            string path = @"\\maxcavte01\TSG\Z_TSG_Joshua_DoNotDelete\User Feedback\Jcon Contact Tracing\file".Replace("file", filename);
            bool NotDone = true;

            while (NotDone)
            {
                if (File.Exists(path))
                {
                    counter += 1;
                    filename = $"Feed_{counter}_{date}.txt";
                    path = @"\\maxcavte01\TSG\Z_TSG_Joshua_DoNotDelete\User Feedback\Jcon Contact Tracing\file".Replace("file", filename);
                }
                else
                {
                    using (StreamWriter textfile = File.CreateText(path))
                    {
                        textfile.WriteLine(tag);
                        textfile.WriteLine(txtFeedback.Text);
                        NotDone = false;
                    }
                }
            }
            MessageBox.Show("Thank you!");
            this.Hide();
            
        }
    }
}
