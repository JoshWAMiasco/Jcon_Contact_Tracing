using Jcon_Contact_Tracing.Validator;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using LTXJconLibrary;
using FluentValidation.Results;
using Jcon_Contact_Tracing.AppData;
using FluentValidation;
using Jcon_Contact_Tracing.MethodCollection;
using System.Drawing;

namespace Jcon_Contact_Tracing
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
        }
        WorkBenchForm benchform = new WorkBenchForm();
        Updates updatesForm = new Updates();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelForm.Controls.Remove(benchform);
            updatesForm.TopLevel = false;
            PanelForm.Controls.Add(updatesForm);
            updatesForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PanelForm.Controls.Remove(updatesForm);
            benchform.TopLevel = false;
            PanelForm.Controls.Add(benchform);
            benchform.Show();
        }
    }
}