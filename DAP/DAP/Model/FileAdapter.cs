using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAP.Model
{
    class FileAdapter
    {
        private string path;

        public FileAdapter(string folderName)
        {
            path = @"Files\" + folderName;
        }

        public void createFolderByID()
        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Debug.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Debug.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Debug.WriteLine("The process failed: {0}", e.ToString());
            }

        }

        public void renameFolder(string oldFolderNeme, string newFolderName)
        {

            Directory.Move(@"Files\" + oldFolderNeme, @"Files\" + newFolderName);
        }

        public void copyFiles(string[] fileNames, string[] safeFileName)
        {
            for (int i = 0; i < fileNames.Length; i++)
            {
                File.Copy(fileNames[i], path + @"\" + safeFileName[i], true);
            }

        }

        public DirectoryInfo getAllFiles()
        {

            DirectoryInfo di = new DirectoryInfo(path);

            return di;
        }

        public void deleteFolder(string folder)
        {

            Directory.Delete(folder);
        }

        public void deleteFile(string fileName)
        {

            File.Delete(Path.Combine(path, fileName));
        }

        public void openFile(string fileName)
        {
            System.Diagnostics.Process.Start(Path.Combine(path, fileName));
        }
    }

}
