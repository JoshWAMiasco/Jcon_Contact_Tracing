using System;
using System.Collections.Generic;
using System.Text;

/*
 *   Title: Jcon Path Model
 *   Putpose: to produce valid jcon path data 
 *   Version: 1.0
 *   Author: Joshua
 *   Date Start: 
 *   Date End: 11/24/2020
 */
namespace LTXJconLibrary
{
    public class JconPathModel : JconTable
    {

        private string jcontablename;
        private char jconcolumn;
        private byte jconrow;

        public string TableName
        {
            get { return jcontablename; }
            set
            {
                foreach (string content in Enum.GetNames(typeof(JconTableNames)))
                {
                    if(content == value)
                    {
                        jcontablename = value;
                        break;
                    }
                    else
                    {
                        jcontablename = "Not Found";
                    }
                }
            }
        }
        public char JconColumn
        {
            get { return jconcolumn; }
            set
            {
                foreach(string content in Enum.GetNames(typeof(Column)))
                {
                    if(content == value.ToString())
                    {
                        jconcolumn = value;
                        break;
                    }
                    else
                    {
                        jconcolumn = 'I';
                    }
                }
            }
        }
        public byte JconRow
        {
            get { return jconrow; }
            set
            {
                List<string> J1 = new List<string> { "J100", "J101", "J102", "J103" };
                List<string> J2 = new List<string> { "J201", "J203" };

                if (J1.Contains(jcontablename) && value <= (byte)Row.MaxJ1)
                {
                    jconrow = value;
                }
                else if(J2.Contains(jcontablename) && value <= (byte)Row.MaxJ2)
                {
                    jconrow = value;
                }
                else
                {
                    jconrow = 255;
                }
            }
        }


        /// <summary>
        /// Populate unknown user input to Valid Jcon Path
        /// </summary>
        /// <param name="unknownObject"></param>
        /// user input
        /// <param name="JconTableName"></param>
        /// JconTable Name
        /// <param name="JconColumn"></param>
        /// Column
        /// <param name="JconRow"></param>
        /// Row
        /// <returns></returns>
        public static bool Make(string unknownObject, out string JconTableName, out char JconColumn, out byte JconRow)
        {
            JconPathModel unknown = new JconPathModel();

            unknown.TableName = unknownObject.Substring(0, 4);
            try
            {
                unknown.JconColumn = Convert.ToChar(unknownObject.Substring(5, 1));
            }
            catch
            {
                unknown.JconColumn = 'I';
            }

            try
            {
                unknown.JconRow = Convert.ToByte(unknownObject.Substring(7, unknownObject.Length - 7));
            }
            catch
            {
                unknown.JconRow = 200;
            }
            

            if(unknown.jcontablename != "Not Found" && unknown.jconcolumn != 'I' && unknown.jconrow != 255)
            {
                JconTableName = unknown.jcontablename;
                JconColumn = unknown.JconColumn;
                JconRow = unknown.JconRow;
                return true;
            }
            else
            {

                JconTableName = unknown.jcontablename == "Not Found"? "Not Found" : unknown.jcontablename;
                JconColumn = unknown.jconcolumn == 'I' ? 'I' : unknown.jconcolumn;
                JconRow = unknown.jconrow == 255 ? (byte)255 : unknown.jconrow;
                JconRow = unknown.jconrow == 200 ? (byte)200 : unknown.jconrow;
                return false;
            }
            
        }


    }
}
