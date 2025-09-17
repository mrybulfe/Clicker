using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Clicker
{
    public class CIconList : INotifyPropertyChanged

    {
        private ObservableCollection<CIcon> _icons;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<CIcon> Icons
        {
            get { return _icons; }
            set
            {
                _icons = value;
                OnPropertyChanged(nameof(Icons));
            }
        }
        
     public CIconList()
        {
            Icons = new ObservableCollection<CIcon>();
        } 
    public void LoadIconsFromFolder(string folderPath)
        {
            Icons.Clear();
            
            string filter = "*.png";
            string[] imageFiles = Directory.GetFiles(folderPath, filter);
            foreach (string filePath in imageFiles)
            {
                CIcon icon = new CIcon(filePath);
                Icons.Add(icon);
            }
        }
        //исправить генераторы
        public CIcon FindIconByName(string name)
        {
            return Icons.FirstOrDefault(icon => icon.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<string> GetAllIconNames()
        {
            return Icons.Select(icon => icon.Name).ToList();
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
