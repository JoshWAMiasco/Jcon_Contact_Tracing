using Jcon_Contact_Tracing.Validator;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using LTXJconLibrary;
using FluentValidation.Results;
using Jcon_Contact_Tracing.AppData;
using FluentValidation;
using Jcon_Contact_Tracing.MethodCollection;

namespace Jcon_Contact_Tracing
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
            listError.DataSource = DataCollection.Logs;
            listError.SelectedIndex = listError.Items.Count - 1;
            listError.SelectedIndex = -1;

            lstboxSearchItems.DataSource = DataCollection.SearchItem;
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
                ProcessItem.Search(txtboxInput.Text.ToUpper(), out string Result);
                if (Result != null)
                    lblResult.Text = Result;
            }
            
            if(e.Control && e.KeyCode == Keys.A)
            {
                
                ProcessItem.AddToDataCollection(txtboxInput.Text.ToUpper(), lblResult.Text);

                
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void lstboxSearchItems_DoubleClick(object sender, EventArgs e)
        {
           
            if (lstboxSearchItems.SelectedItem == null)
            {
                MessageBox.Show("Please Select Item");
            }
            else
            {
                txtboxNotes.Enabled = true;
                int Index = lstboxSearchItems.SelectedIndex;
                NotePad.DisplayComment(Index, out string Content);
                if (Content != null)
                {
                    txtboxNotes.Text = Content;

                }
                else
                {
                    txtboxNotes.Text = "";
                }
                
            }
        }

        private void txtboxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                NotePad.Save(txtboxNotes.Text);
            }
        }
    }
}