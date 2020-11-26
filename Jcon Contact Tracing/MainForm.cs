using Jcon_Contact_Tracing.Validator;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using LTXJconLibrary;
using FluentValidation.Results;
using Jcon_Contact_Tracing.AppData;
using FluentValidation;
using Jcon_Contact_Tracing.UserData;

namespace Jcon_Contact_Tracing
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
            listError.DataSource = DataCollection.Logs;
            lstboxSearchItems.DataSource = DataCollection.SearchItem;
        }

        public void ProcessItem()
        {
            UnknownModel userObject = new UnknownModel();
            userObject.obj = txtboxInput.Text.ToUpper();

            UnknownValidator userValidator = new UnknownValidator();
            ValidationResult result = userValidator.Validate(userObject);

            

            if (result.IsValid == false)
            {
                foreach(ValidationFailure failure in result.Errors)
                {
                    DataCollection.Logs.Add(failure.ErrorMessage);
                }
            }
            else
            {
                if (userObject.obj.Contains("_"))
                {
                    lblResult.Text = JconPath.Search(userObject.obj);
                }
                else if(userObject.obj.Substring(0,1) == "J")
                {
                    JconPathModel jconpath = new JconPathModel();

                    jconpath.TableName = userObject.obj.Substring(0, 4);
                    jconpath.Column = Convert.ToChar(userObject.obj.Substring(5, 1));
                    jconpath.Row = Convert.ToByte(userObject.obj.Substring(7, userObject.obj.Length - 7));


                    JconPathValidator pathValidator = new JconPathValidator();
                    ValidationResult pathresult = pathValidator.Validate(jconpath);

                    if(pathresult.IsValid == false)
                    {
                        foreach(ValidationFailure failure in pathresult.Errors)
                        {
                            DataCollection.Logs.Add(failure.ErrorMessage);
                        }
                    }
                    else
                    {
                        lblResult.Text = SystemBoard.Search(jconpath.TableName, jconpath.Column, jconpath.Row);
                    }

                }
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

        private void txtboxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProcessItem();
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }










    }
}