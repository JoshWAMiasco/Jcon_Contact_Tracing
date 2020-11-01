using Softbox;
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

namespace Jcon_Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<string> JconCommnet = new List<string>();
        private int commentCount = new int();
        private int textlogCount = new int();


        /// <summary>
        /// Convert the number count to Letter of Jcon
        /// </summary>
        /// <param name="_num"></param>
        /// a number that corporate with a Letter of Jcon
        /// <returns></returns>
        private string getLetterValue(string _num)
        {
            if(_num.Equals("0"))
                return "A";
            if(_num.Equals("1"))
                return "B";
            if(_num.Equals("2"))
                return "C";
            if (_num.Equals("3"))
                return "D";
            else
                return "X";
        }

        private bool ValidateJconName(string _jname)
        {
            if (
                _jname == "J100"
                || _jname == "J101"
                || _jname == "J102"
                || _jname == "J103"
                || _jname == "J201"
                || _jname == "J203"
                )
                return true;
            else
                return false;
        }

        /// <summary>
        /// Tells wheter the Jcon Letter is Valid
        /// </summary>
        /// <param name="_alpha"></param>
        /// a char Letter of Jcon
        /// <returns></returns>
        private bool alphaLookUp(char _alpha)
        {
            if (_alpha.Equals('A') || _alpha.Equals('B') || _alpha.Equals('C') || _alpha.Equals('D'))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Convert Letter of Jcon to Specific count to search in JconMap 2D Array
        /// </summary>
        /// <param name="_alpha"></param>
        /// a valid char Letter of Jcon
        /// <returns></returns>
        private int getAlphaValue(char _alpha)
        {
            if (_alpha.Equals('A'))
                return 0;
            else if (_alpha.Equals('B'))
                return 1;
            else if (_alpha.Equals('C'))
                return 2;
            else if (_alpha.Equals('D'))
                return 3;
            else
                return 0;
        }

        /// <summary>
        /// To Combine 2 character which is a 2 numbers to True Tens place number value
        /// </summary>
        /// <param name="_num1"></param>
        /// first number that represent tens place
        /// <param name="_num2"></param>
        /// second number that represent once place
        /// <returns></returns>
        private int ConvertToDigit(int _num1, int _num2)
        {
            return _num1 * 10 + _num2;
        }

        /// <summary>
        /// Process where getting the first 4 character in the input to produce Jcon Name
        /// </summary>
        /// <param name="_rawVariable"></param>
        /// user input that converted to char string
        /// <returns></returns>
        private string GetJname(char[] _rawVariable)
        {
            string newJconFormat = "";
            for(int count = 0; count <= 3; count++)
            {
                newJconFormat = newJconFormat + _rawVariable[count].ToString();
            }
            return newJconFormat;
        }


        private void JconSearch()
        {
            string userInput = txtboxInput.Text.ToUpper();
            char[] userInputArray = userInput.ToCharArray();


            if (!string.IsNullOrWhiteSpace(txtboxInput.Text))
            {
                if (userInput.Contains("_") && userInputArray[0] != 'J')

                    for (byte alpha = 0; alpha < 4; alpha++)
                    {

                        for (byte num = 0; num < 60; num++)
                        {
                            if (userInput.Equals(JconMapClass.j100[alpha, num]))
                                lblResult.Text = $"J100 {getLetterValue(alpha.ToString())} {num.ToString()}";
                            if (userInput.Equals(JconMapClass.j101[alpha, num]))
                                lblResult.Text = $"J101 {getLetterValue(alpha.ToString())} {num.ToString()}";
                            if (userInput.Equals(JconMapClass.j102[alpha, num]))
                                lblResult.Text = $"J102 {getLetterValue(alpha.ToString())} {num.ToString()}";
                            if (userInput.Equals(JconMapClass.j103[alpha, num]))
                                lblResult.Text = $"J103 {getLetterValue(alpha.ToString())} {num.ToString()}";

                        }

                        for (byte num = 0; num < 25; num++)
                        {
                            if (userInput.Equals(JconMapClass.j201[alpha, num]))
                                lblResult.Text = $"J201 {getLetterValue(alpha.ToString())} {num.ToString()}";
                            if (userInput.Equals(JconMapClass.j203[alpha, num]))
                                lblResult.Text = $"J203 {getLetterValue(alpha.ToString())} {num.ToString()}";
                        }


                    }
                else if (userInputArray[0].Equals('J') && (userInputArray.Length.Equals(8) || userInputArray.Length.Equals(9)))
                {
                    if (char.IsWhiteSpace(userInput, 4) && char.IsWhiteSpace(userInput, 6))
                    {

                        if (alphaLookUp(userInputArray[5]))
                        {
                            if (userInputArray.Length.Equals(9) && ConvertToDigit(Int32.Parse(userInputArray[7].ToString()), Int32.Parse(userInputArray[8].ToString())) <= 60)
                            {
                                int firstdigit = Int32.Parse(userInputArray[7].ToString());
                                int secondigit = Int32.Parse(userInputArray[8].ToString());
                                string JconName = GetJname(userInputArray);
                                int alphaValue = getAlphaValue(userInputArray[5]);
                                int numCount = ConvertToDigit(firstdigit, secondigit);

                                if (ValidateJconName(JconName))
                                {
                                    if (JconName.Equals("J201") || JconName.Equals("J203"))
                                    {
                                        if (JconName.Equals("J201") && numCount <= 25)
                                            lblResult.Text = JconMapClass.j103[alphaValue, numCount];
                                        else if (JconName.Equals("J203") && numCount <= 25)
                                            lblResult.Text = JconMapClass.j103[alphaValue, numCount];
                                        else
                                            lblResult.Text = "J count exceed to Limit";

                                    }
                                    else
                                    {

                                        if (JconName.Equals("J100"))
                                            lblResult.Text = JconMapClass.j100[alphaValue, numCount];
                                        else if (JconName.Equals("J101"))
                                            lblResult.Text = JconMapClass.j101[alphaValue, numCount];
                                        else if (JconName.Equals("J102"))
                                            lblResult.Text = JconMapClass.j102[alphaValue, numCount];
                                        else if (JconName.Equals("J103"))
                                            lblResult.Text = JconMapClass.j103[alphaValue, numCount];
                                    }
                                    
                                }
                                else
                                    
                                    lblResult.Text = "Jcon Name Not Exist";


                            }
                            else
                               
                                lblResult.Text = "J count exceed to Limit";
                            if (userInput.Length.Equals(8))
                            {
                                int alphaValue = getAlphaValue(userInputArray[5]);
                                int numCount = Int32.Parse(userInputArray[7].ToString());

                                if (GetJname(userInputArray).Equals("J100"))
                                    lblResult.Text = JconMapClass.j100[alphaValue, numCount];
                                else if (GetJname(userInputArray).Equals("J101"))
                                    lblResult.Text = JconMapClass.j101[alphaValue, numCount];
                                else if (GetJname(userInputArray).Equals("J102"))
                                    lblResult.Text = JconMapClass.j102[alphaValue, numCount];
                                else if (GetJname(userInputArray).Equals("J103"))
                                    lblResult.Text = JconMapClass.j103[alphaValue, numCount];
                                else if (GetJname(userInputArray).Equals("J201"))
                                    lblResult.Text = JconMapClass.j201[alphaValue, numCount];
                                else if (GetJname(userInputArray).Equals("J203"))
                                    lblResult.Text = JconMapClass.j201[alphaValue, numCount];
                                else
                                    lblResult.Text = "Jcon Name Not Match";

                              
                            }

                        }
                        else
                            
                            lblResult.Text = "Letter is not match on Jcon Search";



                    }
                    else
                        
                        lblResult.Text = "Invalid Format";
                }
                else
                   
                    lblResult.Text = "Invalid Input";

            }
            else
            {
                
                lblResult.Text = "Input is required before submit";
            }
        }


        private void AddItems()
        {
            lstboxResults.Items.Add($"{txtboxInput.Text}    ---->   {lblResult.Text}");
            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.FromArgb(132, 129, 122);
            txtboxInput.Clear();
            lblResult.Text = "";
            lblResult.Visible = false;
        }

        private void SaveNote()
        {
            JconCommnet.Add(txtboxResultNote.Text);
            commentCount++;
            
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            JconSearch();
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.FromArgb(255, 218, 121);

        }

        private void txtboxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                JconSearch();
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(255, 218, 121);
                lblResult.Visible = true;
            }
            if(e.Control && e.KeyCode == Keys.A && btnAdd.Enabled)
            {
                AddItems();
            }
           
           
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void lstboxResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int index = this.lstboxResults.IndexFromPoint(e.Location);
            lblCurrentResult.Text = lstboxResults.GetItemText(lstboxResults.SelectedItem);
            btnTakeNote.Enabled = true;
            btnTakeNote.BackColor = Color.FromArgb(255, 218, 121);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                

                if (!JconCommnet.Any())
                {
                    txtboxResultNote.Clear();
                    txtboxResultNote.ForeColor = Color.Red;
                    txtboxResultNote.Enabled = true;
                    
                }
                
                else
                {
                    try
                    {
                        txtboxResultNote.ForeColor = Color.Green;
                        txtboxResultNote.Text = JconCommnet[index];
                    }
                    catch(Exception)
                    {
                        txtboxResultNote.Clear();
                        txtboxResultNote.ForeColor = Color.Red;
                        txtboxResultNote.Enabled = true;
                        
                    }
                }

            }
            else
            {
                MessageBox.Show("please click the item");
            }
        }

      

        private void btnTakeNote_Click(object sender, EventArgs e)
        {

            SaveNote();
            
        }

        private void txtboxResultNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnTakeNote.Enabled = false;
                btnTakeNote.BackColor = Color.FromArgb(132, 129, 122);
                SaveNote();
                txtboxResultNote.ForeColor = Color.Green;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ShortCut Keys:"+
                            "\nAdd Item:    Ctrl + A"+
                            "\nSave Notes:  Ctrl + S"+
                            "\n"+
                            "\n" +
                            "\n" +
                            "\nTitle: Jcon Contact Tracing"+
                            "\nVersion: 1.0"+
                            "\nDeveloper: JM");
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string username = Environment.UserName.ToLower();
            string path = $"C:\\Users\\%username%\\Desktop\\Contact_Log_{textlogCount++.ToString()}.txt".Replace("%username%", username);
            string contactPlusPath = "";
            string comment = "";
            string newline = "";
            System.IO.File.WriteAllText(path, contactPlusPath);
            for (int count = 0; count < JconCommnet.Count; count++)
            {
                contactPlusPath = "Contact Info: " + lstboxResults.Items[count];
                comment = "         Comment:" + "\n" + JconCommnet[count];
                System.IO.File.AppendAllLines(path, new[] { contactPlusPath });
                System.IO.File.AppendAllLines(path, new[] { comment });
                System.IO.File.AppendAllLines(path, new[] { newline });
                System.IO.File.AppendAllLines(path, new[] { newline });

            }
        }

    }
}
