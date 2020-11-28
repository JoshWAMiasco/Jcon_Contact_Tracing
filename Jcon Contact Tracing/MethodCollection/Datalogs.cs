using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Jcon_Contact_Tracing.AppData;
using System.Windows.Forms;

namespace Jcon_Contact_Tracing.MethodCollection
{
    public class Datalogs
    {

        public static void GenerateTextFile(string location)
        {

            using (StreamWriter sw = File.CreateText(location))
            {
                for (int count = 0; count <= DataCollection.Notes.Count - 1; count++)
                {
                    sw.WriteLine( $"\n Item:  {DataCollection.SearchItem[count]}   Comment:  {DataCollection.Notes[count]}");
                }
            }



            
        }
    }
}
