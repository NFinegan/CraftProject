using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CraftProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player = new Player();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Inventory.Text = player.GetInventoryInformation();
            Introduction.Text = "Welcome to [STORENAME HERE]. \nEnter your name below to get started.";
        }

        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (PlayerInput.Text != "")
            {
                PlayerInput.Name = PlayerInput.Text;
                Introduction.Text = $"Nice to meet you, {PlayerInput.Name}";
            }
            else
            {
                Introduction.Text = "Please enter a name!";
            }
        }
    }
}
