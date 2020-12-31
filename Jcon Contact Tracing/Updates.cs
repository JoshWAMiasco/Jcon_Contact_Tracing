using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jcon_Contact_Tracing
{
    public partial class Updates : Form
    {
        public Updates()
        {
            InitializeComponent();
            AddVersionNumber();
        }

        private async Task CheckForupdate()
        {
            using (var manager = new UpdateManager(@"\\maxcavte01\TSG\Z_TSG_Joshua_DONOTDELETE\"))
            {
                await manager.UpdateApp();
            }
        }

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            lblVersion.Text = $"v.{versionInfo.FileVersion}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update
            CheckForupdate();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedbackmenu = new Feedback();

            feedbackmenu.Show();
        }
    }
}
