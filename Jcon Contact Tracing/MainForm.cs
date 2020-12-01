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
            listError.DataSource = DataCollection.Logs;
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



        // inputCaptured prevent to Add different or change user input on the real search data.
        string inputCaptured = null;
        private void txtboxInput_KeyDown(object sender, KeyEventArgs e)
       {
            

            if(e.KeyCode == Keys.Enter)
            {
                ProcessItem.Search(txtboxInput.Text.ToUpper(), out string Result);
                if (Result != null)
                    lblResult.Text = Result;
                    inputCaptured = txtboxInput.Text;
            }
            
            if(e.Control && e.KeyCode == Keys.A)
            {
                ProcessItem.AddToDataCollection(inputCaptured.ToUpper(), lblResult.Text);
                lstboxSearchItems.Items.Add(DataCollection.SearchItem[DataCollection.SearchItem.Count -1]);
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
                lblCurrentResult.Text = DataCollection.SearchItem[Index];
                MessageBox.Show(Index.ToString() + " Double click");
                NotePad.DisplayComment(Index, out string Content);
                if (Content != null)
                {
                    txtboxNotes.ForeColor = Color.Green;
                    txtboxNotes.Text = Content;
                }
                else
                {
                    txtboxNotes.ForeColor = Color.Red;
                    txtboxNotes.Text = "";
                }
            }
        }

        private void txtboxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                NotePad.Save(txtboxNotes.Text);
                txtboxNotes.ForeColor = Color.Green;
                picboxDownload.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NotePad.Save(txtboxNotes.Text);
        }

        private void picboxDownload_Click(object sender, EventArgs e)
        {
            Text_File_Generation txtfilegen = new Text_File_Generation();
            txtfilegen.Show();
            picboxDownload.Enabled = false;
        }
    }
}