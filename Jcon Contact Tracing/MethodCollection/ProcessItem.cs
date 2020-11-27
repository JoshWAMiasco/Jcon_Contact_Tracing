using FluentValidation.Results;
using Jcon_Contact_Tracing.AppData;
using Jcon_Contact_Tracing.UserData;
using Jcon_Contact_Tracing.Validator;
using LTXJconLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcon_Contact_Tracing.MethodCollection
{
    public class ProcessItem
    {
        public static void Search(string Item, out string Result)
        {
            GetCathegory(Item.ToUpper(), out string Cathegory, out string ItemForSearch);

         
            if(Cathegory == "System Board")
            {
                Result = JconPath.Search(ItemForSearch);
            }
            else if(Cathegory == "Jcon Path")
            {
                Result = DisplaySystemBoardSearch(ItemForSearch);
            }
            else
            {
                Result = null;
            }




            // Local Methods

             void GetCathegory(string userObject, out string cathegory, out string itemForSearch)
            {

                UnknownModel unknown = new UnknownModel();
                unknown.obj = userObject;
                UnknownValidator userValidator = new UnknownValidator();
                ValidationResult result = userValidator.Validate(unknown);

                if (result.IsValid == false)
                {
                    foreach (ValidationFailure failure in result.Errors)
                    {
                        DataCollection.Logs.Add(failure.ErrorMessage);
                    }
                    cathegory = "Error";
                    itemForSearch = "Error";
                }
                else
                {
                    if (unknown.obj.Contains("_"))
                        cathegory = "System Board";
                    else if (unknown.obj.Substring(0, 1) == "J")
                        cathegory = "Jcon Path";
                    else
                        cathegory = "Unknown";

                    itemForSearch = unknown.obj;
                }

            }




            string DisplaySystemBoardSearch(string item)
            {
                JconPathModel jconpath = new JconPathModel();
                jconpath.TableName = item.Substring(0, 4);
                jconpath.Column = Convert.ToChar(item.Substring(5, 1));
                jconpath.Row = Convert.ToByte(item.Substring(7, item.Length - 7));

                JconPathValidator pathValidator = new JconPathValidator();
                ValidationResult pathresult = pathValidator.Validate(jconpath);

                if (pathresult.IsValid == false)
                {
                    foreach (ValidationFailure failure in pathresult.Errors)
                    {
                        DataCollection.Logs.Add(failure.ErrorMessage);
                    }
                    return "";
                }
                else
                {
                    return SystemBoard.Search(jconpath.TableName, jconpath.Column, jconpath.Row);
                }

            }


        }








    }
}
