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
        public static BindingList<string> SearchItem = new BindingList<string>();
        public static List<string> Notes = new List<string>();
    }
}
