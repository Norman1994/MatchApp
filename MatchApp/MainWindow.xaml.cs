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

namespace MatchApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐱", "🐱",
                "🐓", "🐓",
                "🐖", "🐖",
                "🐙", "🐙",
                "🐍", "🐍",
                "🐬", "🐬",
                "🦀", "🦀",
                "🐀", "🐀"
            };

            Random random = new Random(); //создаю генератор случайных чисел

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count); //выбор случайного числа от 0 до количества элементов в списке
                string nextEmoji = animalEmoji[index]; //присвоение новой переменной элемент из списка, который выбирается рандомной
                textBlock.Text = nextEmoji; //поле в таблице заполняется случайным значением из списка
                animalEmoji.RemoveAt(index);
            };
        }
    }
}
