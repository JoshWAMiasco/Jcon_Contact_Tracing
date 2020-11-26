using FluentValidation;
using Jcon_Contact_Tracing.UserData;
using LTXJconLibrary;
using System;
using System.Collections.Generic;

namespace Jcon_Contact_Tracing.Validator
{
    public class JconPathValidator : AbstractValidator<JconPathModel>
    {
        bool Result;
        string Cathegory;
        List<string> J1 = new List<string> { "J100", "J101", "J102", "J103"};
        
        
        public JconPathValidator()
        {
            RuleFor(item => item.TableName)
            
                .Must(ValidJconName).WithMessage("Invalid Jcon Name");

            RuleFor(item => item.Column)
                .Must(ValidJconColumn).WithMessage("Invalid Jcon Column name");

            RuleFor(item => item.Row)
                 
                .Must(ValidJconRow).WithMessage("Jcon Row Exceed Limit");

        }


        protected bool ValidJconName(string Jname)
        {
            foreach(string content in Enum.GetNames(typeof(JconTable.JconTableNames)))
            {
                if (content == Jname)
                {
                    Result = true;
                    Cathegory = J1.Contains(Jname) ? "J1" : "J2";
                    break;
                }
                else Result = false;
                
            }
            return Result ? Result : Result;
        }

        protected bool ValidJconColumn(char jcolumn)
        {
            foreach(string content in Enum.GetNames(typeof(JconTable.Column)))
            {
                if (content == jcolumn.ToString())
                {
                    Result = true;
                    break;
                }
                else Result = false;
            }
            return Result ? Result : Result;
        }

        protected bool ValidJconRow(byte jrow)
        {
            if (Cathegory == "J1")
            {
                return jrow <= (byte)JconTable.Row.MaxJ1;
            }
            else if (Cathegory == "J2")
            {
                return jrow <= (byte)JconTable.Row.MaxJ2;
            }
            else return false;
        }



    }
}

    
