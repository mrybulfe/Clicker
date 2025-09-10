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
    CEnemyTemplateList enemyList = new CEnemyTemplateList();
    CEnemyTemplate selectedEnemy;
    
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        enemyList.addEnemy("edd", "ff", 3, 33, 2, 4, 5);


    }

    
}