using Jcon_Contact_Tracing.AppData;
using Jcon_Contact_Tracing.MethodCollection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jcon_Contact_Tracing
{
    public partial class WorkBenchForm : Form
    {
        public WorkBenchForm()
        {
            InitializeComponent();
            listError.DataSource = DataCollection.Logs;
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

            if (e.Control && e.KeyCode == Keys.A)
            {
                ProcessItem.AddToDataCollection(inputCaptured.ToUpper(), lblResult.Text);
                lstboxSearchItems.Items.Add(DataCollection.SearchItem[DataCollection.SearchItem.Count - 1]);
            }
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

        private void picboxDownload_Click(object sender, EventArgs e)
        {
            Text_File_Generation txtfilegen = new Text_File_Generation();
            txtfilegen.Show();
            picboxDownload.Enabled = false;
        }

        private void txtboxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                NotePad.Save(txtboxNotes.Text);
                txtboxNotes.ForeColor = Color.Green;
                picboxDownload.Enabled = true;
            }
        }
    }
}
