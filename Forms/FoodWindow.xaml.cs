
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
using System.Windows.Shapes;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для FoodWindow.xaml
    /// </summary>
    public partial class FoodWindow : Window
    {
        public FoodWindow()
        {
            InitializeComponent();
        }

        private void btEat1_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.GamerSatiety == 100)
            {
                MessageBox.Show("Вы максимально сыты");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
            else if (App.myGamer.Money >= 20)
            {
                App.myGamer.Money -= 20;
                if (App.myGamer.GamerSatiety > 90)
                {
                    App.myGamer.GamerSatiety = 100;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы успешно перекусили");
                    App.myGamer.GamerSatiety += 10;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не хватает денег");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
        }

        private void btEat2_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.GamerSatiety == 100)
            {
                MessageBox.Show("Вы максимально сыты");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
            else if (App.myGamer.Money >= 50)
            {
                App.myGamer.Money -= 50;
                if (App.myGamer.GamerSatiety > 75)
                {
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы успешно перекусили");
                    App.myGamer.GamerSatiety += 25;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не хватает денег");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
        }

        private void btEat3_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.GamerSatiety == 100)
            {
                MessageBox.Show("Вы максимально сыты");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
            else if (App.myGamer.Money >= 100)
            {
                App.myGamer.Money -= 100;
                if (App.myGamer.GamerSatiety > 50)
                {
                    App.myGamer.GamerSatiety = 100;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Вы успешно перекусили");
                    App.myGamer.GamerSatiety += 50;
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("У вас не хватает денег");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                Close();
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }
    }
}