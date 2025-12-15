using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Windows.Forms;
using BusinessLayer;

namespace Driving_License_Management.GlobalClasses
{
    internal static class clsGlobal
    {

        static public string IconsDirectoryPath = @"..\..\..\Storge\Icons\Icons\";

        static public clsUser CurrentUser;

        static public bool RememberMeUsernameAndPassword(string Username, string Password)
        {
            try
            {

                // get the current project's path
                string thisFolderPath = System.IO.Directory.GetCurrentDirectory();

                // Define the path to the text file where you want save the data
                string FilePath = thisFolderPath + "\\data";

                if (Username == "" && File.Exists(FilePath))
                {
                    // if you dont want save data
                    File.Delete(FilePath);
                    return true;
                }


                // Concatonate username and password with seperator
                string DataToSave = Username + "//##//" + Password;

                // Write the data in the file for future retrieval
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine(DataToSave);
                    return true;
                }


            }
            catch (Exception ex)
            {
              MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
             


        }

        static public bool GetStoredCredintial(ref string Username,ref string Password) {

            // This will get the stored username and password and will return true if found and false if not found


            try
            {
                // Get the current project's directory path
                string thisFolderPath = System.IO.Directory.GetCurrentDirectory();

                // Path for the file contains the credential
                string FilePath = thisFolderPath + "\\data";

                // Check if the file exist before attempting to read it
                if (File.Exists(FilePath))
                {
                    // Create a StreamReader for reading from the file
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        // Read data line by line until end of the file
                        string Line;
                        while ((Line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(Line);

                            string[] result = Line.Split(new string[] { "//##//" }, StringSplitOptions.None);
                            
                                Username = result[0];
                                Password = result[1];
                            
                        }
                        return true;
                    }

                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        
        }
    }
}
