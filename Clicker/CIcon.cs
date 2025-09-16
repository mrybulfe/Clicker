using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows; 
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes; 
using System.IO;
namespace Clicker
{
    class CIcon
    {
        public string name;
        int iconWidth;
        int iconHeight;
        Point position;
        Rectangle icon;
        public CIcon(int icoiconWidth, int inticonHeight, string imagePath)
        {
            this.iconWidth = iconWidth;
            this.iconHeight = iconHeight;
            position = new Point(0, 0);
            name = System.IO.Path.GetFileNameWithoutExtension(imagePath);
            icon = new Rectangle();

            icon.Stroke = Brushes.Black;
            ImageBrush ib = new ImageBrush();
            ib.AlignmentX = AlignmentX.Left;
            ib.AlignmentY = AlignmentY.Top;
            ib.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
            icon.RenderTransform = new TranslateTransform(position.X, position.Y);
            icon.Fill = ib;
            icon.HorizontalAlignment = HorizontalAlignment.Left;
            icon.VerticalAlignment = VerticalAlignment.Center;
            icon.Height = iconHeight;
            icon.Width = iconWidth;


        }
        public string Name()
        {
            return name;
        }
        public double X()
        {
            return position.X;
        }
        public double Y()
        {
            return position.Y;
        }
        public int IconWidth()
        {
            return iconWidth;
        }
        public int IconHeight()
        {
            return iconHeight;
        }
        public Rectangle getIcon()
        {
            return icon;
        }
        public void setPosition(Point newPosition)
        {
            position = newPosition;
            icon.RenderTransform =  new TranslateTransform(position.X, position.Y);
        }
        public bool isMouseOver(Point mousePosition)
        {
            return mousePosition.X >= position.X && mousePosition.X <= position.X + iconWidth && mousePosition.Y >= position.Y && mousePosition.Y <= position.Y + iconHeight;
        }
        public Rectangle CloneIcon()
        {
            Rectangle clonedIcon = new Rectangle();
            clonedIcon.Stroke = icon.Stroke;
            clonedIcon.StrokeThickness = icon.StrokeThickness;
            clonedIcon.Fill = icon.Fill;
            clonedIcon.RenderTransform = new TranslateTransform(position.X, position.Y);
            clonedIcon.HorizontalAlignment = icon.HorizontalAlignment;
            clonedIcon.VerticalAlignment = icon.VerticalAlignment;
            clonedIcon.Height = icon.Height;
            clonedIcon.Width = icon.Width;
            return clonedIcon;
        }

    }
}
