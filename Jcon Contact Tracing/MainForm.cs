using Jcon_Contact_Tracing.Validator;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using LTXJconLibrary;

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
            string userObject = txtboxInput.Text.ToUpper();

            if (userValidator.Inspect(userObject, out string MessageLog))
            {
                if(MessageLog == "SystemBoard")
                {
                    lblResult.Text = JconPath.Search(userObject);
                }
                else if(MessageLog == "JconPath")
                {
                    if(JconPathModel.Make(userObject, out string JconTableName, out char JconColumn, out byte JconRow))
                    {
                        lblResult.Text = SystemBoard.Search(JconTableName, JconColumn, JconRow);
                    }
                    else
                    {
                        if (JconTableName == "Not Found")
                        {
                            ErrorCollection.Add("Invalid Jcon Table Name");
                        }
                        else if(JconColumn == 'I')
                        {
                            ErrorCollection.Add("Invalid Column Name");
                        }
                        else if(JconRow == 255)
                        {
                            ErrorCollection.Add("Row Exceed the Limit");
                        }
                        else if (JconRow == 200)
                        {
                            ErrorCollection.Add("please enter number only on Row");
                        }
                    }
                }
               
            }
            else
            {
                ErrorCollection.Add(MessageLog);
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