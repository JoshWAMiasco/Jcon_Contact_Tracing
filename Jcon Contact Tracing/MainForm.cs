
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
using Jcon_Contact_Tracing.Validator;
using FluentValidation.Results;

namespace Jcon_Contact_Tracing
{
    public partial class MainForm : Form
    {

        public BindingList<string> ErrorCollection = new BindingList<string>();


        public MainForm()
        {
            InitializeComponent();
            listError.DataSource = ErrorCollection;
        }

       
        
        
        public void Search()
        {
            userObject userObj = new userObject();
            userObj.Input = txtboxInput.Text;

            

            userObjectValidator validator = new userObjectValidator();

            ValidationResult inputResult = validator.Validate(userObj);

            if(inputResult.IsValid == false)
            {
                foreach(ValidationFailure failure in inputResult.Errors)
                {
                    ErrorCollection.Add(failure.ErrorMessage);
                }
            }
            else
            {
                ErrorCollection.Add("Success");
                
            }



            

        }






        /*
         * 
         *                   ALL EVENTS HANDLER
         * 
         */
        private void picboxDownload_MouseHover(object sender, EventArgs e)
        {
            picboxDownload.Image = imageList1.Images[0];
        }

        private void picboxDownload_MouseLeave(object sender, EventArgs e)
        {
            picboxDownload.Image = imageList1.Images[1];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
