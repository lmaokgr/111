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
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Model.Gamer Gamer;
        Model.Computer Computer;
        Model.Work Work;
        public GameWindow()
        {
            InitializeComponent();
            Gamer = App.myGamer;
            gridInfoGamer.DataContext = Gamer;

            Computer = App.myComputer;
            gridComputerInfo.DataContext = Computer;

            Work = App.myWork;
            gridInfoWork.DataContext = Work;
        }

        private void btNextDay_Click(object sender, RoutedEventArgs e)
        {
            if (Gamer.GamerSatiety <= 0)
            {
                MainWindow mainWindow = new MainWindow();
                MessageBox.Show("Вы умерли голодной смертью. Дней прожито: " + App.myGamer.EveryDay);
                mainWindow.Show();
                Close();
            }
            if (Work.Name == "Практика дома")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Оператор ЭВМ")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Фриланс")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Разработчик мобильных приложений")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Разработчик компьютерных игр")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Web-разработчик")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Программист Яндекса")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Программист Microsoft")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Программист Google")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Своя IT-компания")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            if (Gamer.Fatigue >= 100)
            {
                MessageBox.Show("Вы умерли от усталости. Дней прожито: " + Gamer.EveryDay);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            if (Work.Experience >= 15000 && Work.Name == "Своя IT-компания" && Computer.Canal == 5 && Computer.Quality == 5 &&
                Computer.SoundQuality == 5 && Computer.Edit == 5 && Computer.Light == 5 && Computer.Fon == 5 && Computer.Memory == 5 && Computer.MyComputer == 5)
            {
                MessageBox.Show("Поздравляем, вы прошли игру! Вам понадобилось на это " + Gamer.EveryDay + " дней");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }

            Gamer.Fatigue = 0;
            Gamer.EveryDay += 1;
            Gamer.GamerSatiety -= 10;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btWork_Click(object sender, RoutedEventArgs e)
        {
            WorkWindow workWindow = new WorkWindow();
            workWindow.ShowDialog();
            Close();
        }

        private void btFood_Click(object sender, RoutedEventArgs e)
        {
            FoodWindow foodWindow = new FoodWindow();
            foodWindow.ShowDialog();
            Close();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btSaveGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.Gamer newGamer = new Model.Gamer();
                Model.Computer newComputer = new Model.Computer();
                Model.Work newWork = new Model.Work();

                newGamer.GamerName = App.myGamer.GamerName;
                newGamer.GamerAge = App.myGamer.GamerAge;
                newGamer.GamerGender = App.myGamer.GamerGender;
                newGamer.GamerSatiety = App.myGamer.GamerSatiety;
                newGamer.Fatigue = App.myGamer.Fatigue;
                newGamer.Money = App.myGamer.Money;
                newGamer.EveryDay = App.myGamer.EveryDay;

                newComputer.Canal = App.myComputer.Canal;
                newComputer.Quality = App.myComputer.Quality;
                newComputer.SoundQuality = App.myComputer.SoundQuality;
                newComputer.Edit = App.myComputer.Edit;
                newComputer.Light = App.myComputer.Light;
                newComputer.Fon = App.myComputer.Fon;
                newComputer.Memory = App.myComputer.Memory;
                newComputer.MyComputer = App.myComputer.MyComputer;

                newWork.Name = App.myWork.Name;
                newWork.Wages = App.myWork.Wages;
                newWork.Minqualifications = App.myWork.Minqualifications;
                newWork.Experience = App.myWork.Experience;
                newWork.UpExperience = App.myWork.UpExperience;

                using DB.MySqlLiteContext mySqlLiteContext = new DB.MySqlLiteContext();
                mySqlLiteContext.Gamers.Add(newGamer);
                mySqlLiteContext.SaveChanges();
                mySqlLiteContext.Computers.Add(newComputer);
                mySqlLiteContext.SaveChanges();
                mySqlLiteContext.Works.Add(newWork);
                mySqlLiteContext.SaveChanges();

                MessageBox.Show("Вы сохранили игру");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btComputer_Click(object sender, RoutedEventArgs e)
        {
            ComputerWindow computerWindow = new ComputerWindow();
            computerWindow.ShowDialog();
            Close();
            gridComputerInfo.DataContext = null;
            gridComputerInfo.DataContext = Computer;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
            gridInfoWork.DataContext = null;
            gridInfoWork.DataContext = Work;
        }

        private void btLearning_Click(object sender, RoutedEventArgs e)
        {
            ToLearn toLearn = new ToLearn();
            toLearn.ShowDialog();
            Close();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btexit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}