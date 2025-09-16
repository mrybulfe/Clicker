using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    class CIconList
    {


        public void Load(string path)
        {
            //путь до папки содержащей изображения
            string folder = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + path;

            //фильтр расширения изображения
            string filter = "*.png";
            //получение массива строк содержащих пути до изображений
            string[] files = Directory.GetFiles(folder, filter);
            foreach (string file in files)
            {
                //в file содержится путь до изображения с расширением .png
            }
        }
    }
}
