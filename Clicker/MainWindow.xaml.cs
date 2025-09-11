using System.Collections.ObjectModel;
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
public partial class MainWindow : Window
{
    public CEnemyTemplateList enemyList { get; set; }
    public CEnemyTemplate selectedEnemy { get; set; }


    public MainWindow()
    {
        InitializeComponent();
        enemyList = new CEnemyTemplateList();
        enemyList.addEnemy("spider", "spider.png", 100, 1.0, 10, 1.0, 0.5);
        enemyList.addEnemy("zombie", "zombie.png", 1030, 13.0, 110, 1.4, 0.7);
        selectedEnemy = enemyList.enemies[0];
        DataContext = this;
    }


    
}