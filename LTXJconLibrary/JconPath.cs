/*
 *   Title: Jcon Path
 *   Putpose: to Find Jcon Path by providing system board name information
 *   Version: 1
 *   Author: Joshua
 *   Date Start:
 *   Date End: 11/24/2020
 */

namespace LTXJconLibrary
{
    public class JconPath : JconTable
    {

        public string systemBoard;

        /// <summary>
        /// Search for Jcon path of specific system board.
        /// </summary>
        /// <param name="userObject"></param>
        /// The name of system board.
        /// Must include undersocre
        /// <returns></returns>
        public static string Search(string userObject)
        {
            string Result = null;

            for (byte column = 0; column < (byte)Column.MaxLength; column++)
            {
                for (byte rowJ1 = 0; rowJ1 < (byte)Row.MaxJ1; rowJ1++)
                {
                    if (userObject == j100[column, rowJ1])
                    {
                        Result = $"J100 {(Column)column} {rowJ1}";
                        goto END;
                        
                    }
                    else if (userObject == j101[column, rowJ1])
                    {
                        Result = $"J101 {(Column)column} {rowJ1}";
                        goto END;
                    }
                    else if (userObject == j102[column, rowJ1])
                    {
                        Result = $"J102 {(Column)column} {rowJ1}";
                        goto END;
                    }
                    else if (userObject == j103[column, rowJ1])
                    {
                        Result = $"J103 {(Column)column} {rowJ1}";
                        goto END;
                    }
                    else
                    {
                        Result = "Not Found";
                    }
                    
                }

                for (byte rowJ2 = 0; rowJ2 < (byte)Row.MaxJ2; rowJ2++)
                {
                    if (userObject == j201[column, rowJ2])
                    {
                        Result = $"J201 {(Column)column} {rowJ2}";
                        goto END;
                    }
                    else if (userObject == j203[column, rowJ2])
                    {
                        Result = $"J203 {(Column)column} {rowJ2}";
                        goto END;
                    }
                    else
                    {
                        Result = "Not Found";
                    }
                    
                }

            }
            END:
            return Result;
        }
    }
}   