using Jcon_Contact_Tracing.AppData;
using System.Windows.Forms;

namespace Jcon_Contact_Tracing.MethodCollection
{
    public class NotePad
    {
        private static int CurrentIndex;

        /// <summary>
        /// Show Content of a Note by current Index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="Content"></param>
        public static void DisplayComment(int index, out string Content)
        {
            CurrentIndex = index;

            try
            {
                Content = DataCollection.Notes[index];
            }
            catch
            {
                Content = null;
            }
        }

        /// <summary>
        /// Save comment on Notepad and save in DataCollection.Notes
        /// </summary>
        /// <param name="Comments"></param>
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