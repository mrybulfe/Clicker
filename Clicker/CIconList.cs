using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows;

namespace Clicker
{
    public class CIconList
    {
        List<CIcon> icons;
        int border;
        int x;
        int y;
        int x_sh;
        int y_sh;
        int imageWidth;
        int imageHeight;
        int canvasW;
        int canvasH;

        //public CIconList(int icon_width,int icon_height,int canvas_width,int canvas_height)
        //{
        //    icons = new List<CIcon>();
        //    border = 10;
        //    x = border;
        //    y = border;
        //    x_sh = 0;
        //    y_sh = 0;
        //    imageHeight = icon_height;
        //    imageWidth = icon_width;
        //    canvasH = canvas_height;
        //    canvasW = canvas_width;
        //}


        //public void Load(string path)
        //{
        //    //путь до папки содержащей изображения
        //    string folder = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + path;

        //    //фильтр расширения изображения
        //    string filter = "*.png";
        //    //получение массива строк содержащих пути до изображений
        //    string[] files = Directory.GetFiles(folder, filter);
        //    foreach (string file in files)
        //    {
        //        CIcon icon = new CIcon(imageWidth, imageHeight, file);
        //        //icon.setPosition(new Point(x, y));
        //        //icons.Add(icon);

        //        //x += imageWidth + border;
                //if (x + imageWidth > canvasW - border)
                //{
                //    x = border;
                //    y += imageHeight + border;
                //}

        //    }
        //}

        //public int getDeltaY()
        //{
        //    return y_sh;
        //}
        //public void scroll(double delta)
        //{
        //    y_sh += (int)delta;
        //    foreach(var icon in icons)
        //    {
        //        Point currentPosition = new Point(icon.X(), icon.Y());
        //        icon.setPosition(new Point(currentPosition.X, currentPosition.Y + (int)delta));
        //    }
        //}
        //public List<CIcon> getIcons()
        //{
        //    return icons;
        //}
        //public CIcon findByName(string name)
        //{
        //    foreach(CIcon icon in icons)
        //    {
        //        if (icon.Name == name)
        //        {
        //            return icon;
        //        }
        //    }
        //    return null;
        //}

        //public CIcon isMouseOver(Point mousePosition)
        //{
        //    foreach (CIcon icon in icons)
        //    {
        //        if (icon.isMouseOver(mousePosition))
        //        {
        //            return icon;
        //        }
        //    }
        //    return null;
        //}

    }
}
