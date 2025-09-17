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
using System.ComponentModel;
namespace Clicker
{
    public class CIcon
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name;
        ImageSource iconImage;
        public CIcon(string imagePath)
        {
            name = System.IO.Path.GetFileNameWithoutExtension(imagePath);
            iconImage = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
        }
        public ImageSource IconImage
        {
            get { return iconImage; }
            set
            {
                iconImage = value;
                OnPropertyChanged(nameof(IconImage));
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
