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
    /// Логика взаимодействия для ComputerWindow.xaml
    /// </summary>
    public partial class ComputerWindow : Window
    {
        Model.Computer Computer;
        Model.Gamer Gamer;
        Model.Work Work;
        public ComputerWindow()
        {
            InitializeComponent();

            Computer = App.myComputer;
            gridComputerInfo.DataContext = Computer;

            Gamer = App.myGamer;
            tbInfoFat.DataContext = Gamer;

            Work = App.myWork;
            tbInfoExp.DataContext = Work;
        }

        private void btUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Canal == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень оформления канала!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Canal += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btUpgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Quality == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень качества видео!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Quality += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btUpgrade3_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.SoundQuality == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень качества звука!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.SoundQuality += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btUpgrade4_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Edit == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень видеомонтажа!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Edit += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btUpgrade5_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Light == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень освещения!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Light += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }

        }

        private void btUpgrade6_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Fon == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень фонового изображения!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Fon += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btUpgrade7_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Memory == 5)
            {
                MessageBox.Show("Достигнут максимальный объем памяти!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Memory += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btUpgrade8_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.MyComputer == 5)
            {
                MessageBox.Show("Достигнут максимальный уровень компьютера!");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.MyComputer += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("У вас недостаточно денег");
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btCreateVideo1_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 30;
            App.myWork.Experience += 15;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы выположили видео");
            if (App.myComputer.Canal == 2 && App.myComputer.Quality == 2 && App.myComputer.SoundQuality == 2 && App.myComputer.Edit == 2 &&
                App.myComputer.Light == 2 && App.myComputer.Fon == 2 && App.myComputer.Memory == 2 && App.myComputer.MyComputer == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 3 && App.myComputer.Quality == 3 && App.myComputer.SoundQuality == 3 && App.myComputer.Edit == 3 &&
                App.myComputer.Light == 3 && App.myComputer.Fon == 3 && App.myComputer.Memory == 3 && App.myComputer.MyComputer == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 4 && App.myComputer.Quality == 4 && App.myComputer.SoundQuality == 4 && App.myComputer.Edit == 4 &&
                App.myComputer.Light == 4 && App.myComputer.Fon == 4 && App.myComputer.Memory == 4 && App.myComputer.MyComputer == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 5 && App.myComputer.Quality == 5 && App.myComputer.SoundQuality == 5 && App.myComputer.Edit == 5 &&
                App.myComputer.Light == 5 && App.myComputer.Fon == 5 && App.myComputer.Memory == 5 && App.myComputer.MyComputer == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }

        private void btCreateVideo2_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 40;
            App.myWork.Experience += 25;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы выположили видео");
            if (App.myComputer.Canal == 2 && App.myComputer.Quality == 2 && App.myComputer.SoundQuality == 2 && App.myComputer.Edit == 2 &&
                App.myComputer.Light == 2 && App.myComputer.Fon == 2 && App.myComputer.Memory == 2 && App.myComputer.MyComputer == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 3 && App.myComputer.Quality == 3 && App.myComputer.SoundQuality == 3 && App.myComputer.Edit == 3 &&
                App.myComputer.Light == 3 && App.myComputer.Fon == 3 && App.myComputer.Memory == 3 && App.myComputer.MyComputer == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 4 && App.myComputer.Quality == 4 && App.myComputer.SoundQuality == 4 && App.myComputer.Edit == 4 &&
                App.myComputer.Light == 4 && App.myComputer.Fon == 4 && App.myComputer.Memory == 4 && App.myComputer.MyComputer == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 5 && App.myComputer.Quality == 5 && App.myComputer.SoundQuality == 5 && App.myComputer.Edit == 5 &&
                App.myComputer.Light == 5 && App.myComputer.Fon == 5 && App.myComputer.Memory == 5 && App.myComputer.MyComputer == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }

        private void btCreateVideo3_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 60;
            App.myWork.Experience += 45;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы выположили видео");
            if (App.myComputer.Canal == 2 && App.myComputer.Quality == 2 && App.myComputer.SoundQuality == 2 && App.myComputer.Edit == 2 &&
                App.myComputer.Light == 2 && App.myComputer.Fon == 2 && App.myComputer.Memory == 2 && App.myComputer.MyComputer == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 3 && App.myComputer.Quality == 3 && App.myComputer.SoundQuality == 3 && App.myComputer.Edit == 3 &&
                App.myComputer.Light == 3 && App.myComputer.Fon == 3 && App.myComputer.Memory == 3 && App.myComputer.MyComputer == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 4 && App.myComputer.Quality == 4 && App.myComputer.SoundQuality == 4 && App.myComputer.Edit == 4 &&
                App.myComputer.Light == 4 && App.myComputer.Fon == 4 && App.myComputer.Memory == 4 && App.myComputer.MyComputer == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myComputer.Canal == 5 && App.myComputer.Quality == 5 && App.myComputer.SoundQuality == 5 && App.myComputer.Edit == 5 &&
                App.myComputer.Light == 5 && App.myComputer.Fon == 5 && App.myComputer.Memory == 5 && App.myComputer.MyComputer == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }
    }
}