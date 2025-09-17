using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clicker;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, INotifyPropertyChanged
{
    public CEnemyTemplateList enemyList { get; set; }

    private CEnemyTemplate _selectedEnemy;
    public event PropertyChangedEventHandler PropertyChanged;
    Random rand = new Random();
    public CEnemyTemplate selectedEnemy
    {
        get
        {
            return _selectedEnemy;
        }
        set
        {
            if (_selectedEnemy != value)
            {
                _selectedEnemy = value;
                OnPropertyChanged(nameof(selectedEnemy));
            }
        }
    }


    public MainWindow()
    {
        InitializeComponent();
        enemyList = new CEnemyTemplateList();
        enemyList.addEnemy("spider", "spider.png", 100, 7.0, 177, 7.0, 0.5);
        enemyList.addEnemy("zombie", "zombie.png", 1030, 13.0, 110, 1.4, 0.7);
        selectedEnemy = enemyList.enemies[0];
        DataContext = this;
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        CEnemyTemplate newEnemy = new CEnemyTemplate("New Enemy", "default.png", rand.Next(100), rand.NextDouble(), rand.Next(10), rand.NextDouble(), rand.NextDouble()*100);
        enemyList.enemies.Add(newEnemy);
        selectedEnemy = newEnemy;
    }

    private void RemoveButton_Click(object sender, RoutedEventArgs e)
    {
        int index = enemyList.enemies.IndexOf(selectedEnemy);
        enemyList.enemies.Remove(selectedEnemy);
        if (enemyList.enemies.Count > 0)
        {
            if (index>= enemyList.enemies.Count)
            {
                selectedEnemy = enemyList.enemies[index - 1];
            }
            else
            {
                selectedEnemy = enemyList.enemies[index - 1];
            }
        }
        else
        {
            selectedEnemy = null;
        }
        

    }
    
     public void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        string filePath = enemyList.ShowSaveDialog();
        if (!string.IsNullOrEmpty(filePath))
        {
            enemyList.saveToJson(filePath);
        }
    }

    private void LoadButton_Click(object sender, RoutedEventArgs e)
    {
        string filePath = enemyList.ShowOpenDialog();
        if (!string.IsNullOrEmpty(filePath))
        {
            enemyList.loadFromJson(filePath);
            selectedEnemy = enemyList.enemies[0];
        }

    }
    
    
}