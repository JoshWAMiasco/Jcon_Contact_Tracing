using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcon_Contact_Tracing.Validator
{
    public class userValidator
    {
        public static bool Inspect(string userInput, out string MessageLog)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                MessageLog = "Please Input details before submit";
                return false;
            }
            else if (userInput.Length <= 2)
            {
                MessageLog = "Please provide valid Length";
                return false;
            }
            else if (userInput.Length > 20)
            {
                MessageLog = "Input Exceed the Limit";
                return false;
            }
            else
            {
                if (userInput.Contains("_"))
                {
                    //systemboard
                    MessageLog = "SystemBoard";
                    return true;
                }
                
                else if (userInput.Substring(0, 1) == "J")
                {
                    //jcon path j100 a 23
                    if((userInput.Length == 9 || userInput.Length == 8) && (userInput.Substring(4,1) == " " && userInput.Substring(6,1) == " "))
                    {
                        MessageLog = "JconPath";
                        return true;
                    }
                    else
                    {
                        MessageLog = "Invalid Jcon Path Format";
                        return false;
                    }
                    
                }
                else
                {
                    MessageLog = "Please include identification";
                    return false;
                }
            }

        }
            
        







    }
}
