using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Windows.Forms;
using BusinessLayer;
using Microsoft.Win32;

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
                // Define the path to the file where you want save the data on registry
                string KeyPath = @"HKEY_CURRENT_USER\Software\DVLD\Permissions\Login";
                string UsernameKey = "Username";
                string PasswordKey = "Password";
                try
                {

                    if (Username == "")
                    {
                        KeyPath = @"Software\DVLD\Permissions\Login";
                        // Open the registry key in read/write mode with explicit registry view
                        using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        {
                            using (RegistryKey key = baseKey.OpenSubKey(KeyPath, true))
                            {
                                if (key != null)
                                {
                                    // Delete the saved username and password

                                    key.DeleteValue(UsernameKey);
                                    key.DeleteValue(PasswordKey);
                                    return true;
                                }
                                else
                                {
                                    Console.WriteLine($"Registry key '{KeyPath}' not found");
                                }
                            }
                        }
                    }
                    else
                    {

                        Registry.SetValue(KeyPath, UsernameKey, Username, RegistryValueKind.String);
                        Registry.SetValue(KeyPath, PasswordKey, Password, RegistryValueKind.String);
                        return true;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }


            }
            catch (Exception )
            {
                return false;
            }


            return false;


        }

        static public bool GetStoredCredintial(ref string Username,ref string Password) {

            // This will get the stored username and password from registry and will return true if found and false if not found

            string KeyPath = @"HKEY_CURRENT_USER\Software\DVLD\Permissions\Login";
            string UsernameKey = "Username";
            string PasswordKey = "Password";

            try
            {
                 Username = Registry.GetValue(KeyPath, UsernameKey, null) as string;
                 Password = Registry.GetValue(KeyPath, PasswordKey, null) as string;

                if (Username != null && Password != null)
                {

                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred {");
            }


            return false ;
        }
    }
}
