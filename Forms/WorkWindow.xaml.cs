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
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
            List<Model.Work> works = new List<Model.Work>
            {
                 new Model.Work{ Name = "Взаимная реклама"  , Minqualifications = 0 , Wages = 0 , UpExperience = 1} ,
                 new Model.Work{ Name = "Реклама мини-каналов"  , Minqualifications = 10 , Wages = 20 , UpExperience = 2} ,
                 new Model.Work{ Name = "Реклама онлайн магазинов"  , Minqualifications = 50 , Wages = 50 , UpExperience = 5} ,
                 new Model.Work{ Name = "Реклама 1X BET"  , Minqualifications = 100 , Wages = 100  , UpExperience = 10} ,
                 new Model.Work{ Name = "Бартер"  , Minqualifications = 250 , Wages = 250 , UpExperience = 25} ,
                 new Model.Work{ Name = "Реклама Авиасейлс"  , Minqualifications = 500 , Wages = 500 , UpExperience = 50} ,
                 new Model.Work{ Name = "Международная реклама"  , Minqualifications = 1000 , Wages = 1000 , UpExperience = 100} ,
                 new Model.Work{ Name = "Свой мерч"  , Minqualifications = 2500 , Wages = 2500 , UpExperience = 250} ,
                 new Model.Work{ Name = "Реклама Тинькофф"  , Minqualifications = 5000 , Wages = 5000 , UpExperience = 500} ,
                 new Model.Work{ Name = "Реклама Кремля"  , Minqualifications = 10000 , Wages = 10000 , UpExperience = 1000} ,
            };

            listWork.ItemsSource = works;
        }

        private void btWorking_Click(object sender, RoutedEventArgs e)
        {
            Model.Work work = listWork.SelectedItem as Model.Work;

            if (work.Minqualifications <= App.myWork.Experience)
            {
                App.myWork.Name = work.Name;
                App.myWork.Wages = work.Wages;
                App.myWork.UpExperience = work.UpExperience;
                GameWindow gameWingdow = new GameWindow();
                gameWingdow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Вы ещё не можете это рекламировать");
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
