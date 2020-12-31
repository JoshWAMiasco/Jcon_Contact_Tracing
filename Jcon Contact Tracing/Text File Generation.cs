using Jcon_Contact_Tracing.AppData;
using Jcon_Contact_Tracing.MethodCollection;
using System;
using System.IO;
using System.Windows.Forms;

namespace Jcon_Contact_Tracing
{
    public partial class Text_File_Generation : Form
    {
        public Text_File_Generation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datalogs.ValidateInfo(txtboxTitle.Text, txtboxDieType.Text, txtboxDeviceName.Text, txtboxAuthor.Text, out bool Staus);

            if (Staus == false)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(DataCollection.ErrorMessage, "Warning Message", buttons);
                if (result == DialogResult.OK) DataCollection.ErrorMessage = null;
            }
            else
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Title = "Save This Documention";
                savefile.InitialDirectory = @"C:\Users\username\Desktop".Replace("username", Environment.UserName);
                savefile.DefaultExt = "txt";
                savefile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    string username = Environment.UserName;
                    string textFilePath = savefile.FileName;
                    Datalogs.GenerateTextFile(
                                                location: textFilePath,
                                                title: txtboxTitle.Text,
                                                dietype: txtboxDieType.Text,
                                                devicename: txtboxDeviceName.Text,
                                                author: txtboxAuthor.Text
                                              );
                    File.SetAttributes(textFilePath, FileAttributes.ReadOnly);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}