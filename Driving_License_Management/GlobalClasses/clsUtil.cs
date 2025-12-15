using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Driving_License_Management.GlobalClasses
{
    public class clsUtil
    {

        static public void FoucsOnPreviousRow(ref DataGridView dgv, int CurrentIndex)
        {
            //Put focus on the pervious row if the current row is not the first

            if (CurrentIndex > 0)
            {
                dgv.CurrentCell = dgv.Rows[CurrentIndex - 1].Cells[0];

            }
        }
        static public string GenerateGUID()
        {
            Guid NewGiud =  Guid.NewGuid();
            
            return NewGiud.ToString();
        }

        public static string ReplaceFileNameWithGuid(string sourceFile) { 
        
            string FileName = sourceFile;

            FileInfo fi = new FileInfo(FileName);
            string extn = fi.Extension;

            return GenerateGUID() + extn;
        
        }

        static public bool CreateFoldeIfNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Creating Folder:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

            }
            return true;        }

        static public bool CopeyFileToProjectFolder(ref string sourceFile) {

            string FolderPath = @"C:\DVLD_People_Image\";
            if (CreateFoldeIfNotExist(FolderPath))
            {
                string destinationFile = FolderPath + ReplaceFileNameWithGuid(sourceFile);
                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                    sourceFile = destinationFile;
                    return true;
                }
                catch (IOException iox)
                {
                    MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;


        }
    }
}
