using System;
using System.Collections.Generic;
using System.Text;


/*
 *   Title: System Board
 *   Putpose: to Find SystemBoard name by providing jcon path information
 *   Version: 1
 *   Author: Joshua Miasco
 *   Date Start: 
 *   Date End: 11/24/2020
 */
namespace LTXJconLibrary
{
    public class SystemBoard : JconTable
    {
        /// <summary>
        /// Search for System Board with specific Jcon path
        /// </summary>
        /// <param name="JconTableName"></param>
        /// Jcon Table Name
        /// <param name="column"></param>
        /// Column
        /// <param name="Row"></param>
        /// Row
        /// <returns></returns>
        public static string Search(string JconTableName, char column, byte Row)
        {
            byte ColumnInDigit = (byte) (Enum.Parse(typeof(Column), column.ToString()));

            switch (JconTableName)
            {
                case "J100":
                    return j100[ColumnInDigit, Row];
                case "J101":
                    return j101[ColumnInDigit, Row];
                case "J102":
                    return j102[ColumnInDigit, Row];
                case "J103":
                    return j103[ColumnInDigit, Row];
                case "J201":
                    return j201[ColumnInDigit, Row];
                case "J203":
                    return j203[ColumnInDigit, Row];
                default:
                    return "Not Found";
            }
        }


    }
}