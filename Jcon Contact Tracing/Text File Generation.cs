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
                string username = Environment.UserName;
                string textFilePath = @"C:\Users\Username\Desktop\TextFileName.txt".Replace("Username", username).Replace("TextFileName", txtboxTitle.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}