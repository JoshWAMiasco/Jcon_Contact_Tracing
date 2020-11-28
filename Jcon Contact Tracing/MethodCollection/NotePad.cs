using Jcon_Contact_Tracing.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jcon_Contact_Tracing.MethodCollection
{
    public class NotePad
    {
        private static int CurrentIndex;
        public static void DisplayComment(int index, out string Content)
        {

            try
            {
                Content = DataCollection.Notes[index];
                CurrentIndex = index;
            }
            catch
            {
                Content = null;
            }
             
           
        }

        public static void Save(string Comments)
        {
            try
            {
                DataCollection.Notes[CurrentIndex] = Comments;
            }
            catch
            {
                DataCollection.Notes.Add(Comments);
            }
        }
    }
}
