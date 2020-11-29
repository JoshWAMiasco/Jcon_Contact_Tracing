using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcon_Contact_Tracing.AppData
{
    public class DataCollection
    {
        public static BindingList<string> Logs = new BindingList<string>();
        public static List<string> SearchItem = new List<string>();
        public static List<string> Notes = new List<string>();
        public static string ErrorMessage = null;
    }
}
