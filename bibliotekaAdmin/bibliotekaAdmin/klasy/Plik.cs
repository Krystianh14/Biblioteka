using System;
using System.IO;
using System.Windows.Forms;

namespace bibliotekaAdmin.klasy 
{
    public static class Plik
    {
        
        public static string SciezkaPlikuDanych
        {
            get
            {
                string folder = @"C:\Users\kryst\source\repos\bibliotekaAdmin\biblioteka";

                
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                return Path.Combine(folder, "dane.json");
            }
        }
    }
}
