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
        private void btnWorkbench_Click(object sender, EventArgs e)
        {
            PanelForms.Controls.Remove(updatesForm);
            benchform.TopLevel = false;
            PanelForms.Controls.Add(benchform);
            
            benchform.Show();
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            PanelForms.Controls.Remove(benchform);
            updatesForm.TopLevel = false;
            PanelForms.Controls.Add(updatesForm);
            
            updatesForm.Show();
        }
    }
}