using Jcon_Contact_Tracing.AppData;
using Jcon_Contact_Tracing.UserData;
using Jcon_Contact_Tracing.Validator;
using System;
using System.IO;
using FluentValidation;
using FluentValidation.Results;

namespace Jcon_Contact_Tracing.MethodCollection
{
    public class Datalogs
    {
        /// <summary>
        /// Create a Text File of all save Data Notes.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="title"></param>
        /// <param name="dietype"></param>
        /// <param name="devicename"></param>
        /// <param name="author"></param>
        public static void GenerateTextFile(string location, string title, string dietype, string devicename, string author)
        {
            using (StreamWriter sw = File.CreateText(location))
            {
                sw.WriteLine("Title: {0}", title);
                sw.WriteLine("Die Type: {0}", dietype);
                sw.WriteLine("Device Name: {0}", devicename);
                sw.WriteLine("Author: {0}", author);
                sw.WriteLine("Date Creation: {0}", DateTime.Now);
                for (int count = 0; count <= DataCollection.Notes.Count - 1; count++)
                {
                    sw.WriteLine($"\nItem:  {DataCollection.SearchItem[count]}   \nComment:  {DataCollection.Notes[count]}\n\n");
                }
            }
        }

        public static void ValidateInfo(string title, string dietype, string devicename, string author, out bool Status)
        {
            TextFileInfoModel TextFile = new TextFileInfoModel();

            TextFile.title = title;
            TextFile.dietype = dietype;
            TextFile.devicename = devicename;
            TextFile.author = author;

            TextFileInfoValidator validator = new TextFileInfoValidator();
            ValidationResult result = validator.Validate(TextFile);

            if (result.IsValid == false)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    DataCollection.ErrorMessage = DataCollection.ErrorMessage + $"{failure.PropertyName} : {failure.ErrorMessage}\n";
                }
                Status = false;
            }
            else
            {
                Status = true;
            }
        }
    }
}