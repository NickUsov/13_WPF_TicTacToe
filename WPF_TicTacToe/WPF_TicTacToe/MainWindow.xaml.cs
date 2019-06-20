using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace WPF_TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool step;
        char[,] field = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        DateTime start;
        ObservableCollection<Player> list = new ObservableCollection<Player>();

        public MainWindow()
        {
            InitializeComponent();
            step = true;
            start = DateTime.Now;
            listBox.ItemsSource = list;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content == null)
            {
                if (step)
                {
                    bt1.Content = "X";
                    field[0, 0] = 'X';
                    step = false;
                }
                else
                {
                    bt1.Content = "0";
                    step = true;
                    field[0, 0] = '0';
                }
                CheckField();
            }
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (bt2.Content == null)
            {
                if (step)
                {
                    bt2.Content = "X";
                    field[1, 0] = 'X';
                    step = false;
                }
                else
                {
                    bt2.Content = "0";
                    field[1, 0] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        private void bt3_click(object sender, RoutedEventArgs e)
        {
            if (bt3.Content == null)
            {
                if (step)
                {
                    bt3.Content = "X";
                    field[2, 0] = 'X';
                    step = false;
                }
                else
                {
                    bt3.Content = "0";
                    field[2, 0] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (bt4.Content == null)
            {
                if (step)
                {
                    bt4.Content = "X";
                    field[0, 1] = 'X';
                    step = false;
                }
                else
                {
                    bt4.Content = "0";
                    field[0, 1] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (bt5.Content == null)
            {
                if (step)
                {
                    bt5.Content = "X";
                    field[1, 1] = 'X';
                    step = false;
                }
                else
                {
                    bt5.Content = "0";
                    field[1, 1] = '0';
                    step = true;
                }
            }
            CheckField();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (bt6.Content == null)
            {
                if (step)
                {
                    bt6.Content = "X";
                    field[2, 1] = 'X';
                    step = false;
                }
                else
                {
                    bt6.Content = "0";
                    field[2, 1] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (bt7.Content == null)
            {
                if (step)
                {
                    bt7.Content = "X";
                    field[0, 2] = 'X';
                    step = false;
                }
                else
                {
                    bt7.Content = "0";
                    field[0, 2] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (bt8.Content == null)
            {
                if (step)
                {
                    bt8.Content = "X";
                    field[1, 2] = 'X';
                    step = false;
                }
                else
                {
                    bt8.Content = "0";
                    field[1, 2] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (bt9.Content == null)
            {
                if (step)
                {
                    bt9.Content = "X";
                    field[2, 2] = 'X';
                    step = false;
                }
                else
                {
                    bt9.Content = "0";
                    field[2, 2] = '0';
                    step = true;
                }
                CheckField();
            }
        }

        public void CheckField()
        {

            if (field[0, 0] == 'X' && field[1, 0] == 'X' && field[2, 0] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                //Close();
            }
            if (field[0, 1] == 'X' && field[1, 1] == 'X' && field[2, 1] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[0, 2] == 'X' && field[1, 2] == 'X' && field[2, 2] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[0, 0] == 'X' && field[0, 1] == 'X' && field[0, 2] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[1, 0] == 'X' && field[1, 1] == 'X' && field[1, 2] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[2, 0] == 'X' && field[2, 1] == 'X' && field[2, 2] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[0, 0] == 'X' && field[1, 1] == 'X' && field[2, 2] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[2, 0] == 'X' && field[1, 1] == 'X' && field[0, 2] == 'X')
            {
                AddToText(textBox.Text);
                MessageBox.Show("Player win!");
                Close();
            }
            if (field[0, 0] == '0' && field[1, 0] == '0' && field[2, 0] == '0')
            {
                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[0, 1] == '0' && field[1, 1] == '0' && field[2, 1] == '0')
            {

                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[0, 2] == '0' && field[1, 2] == '0' && field[2, 2] == '0')
            {

                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[0, 0] == '0' && field[0, 1] == '0' && field[0, 2] == '0')
            {
                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[1, 0] == '0' && field[1, 1] == '0' && field[1, 2] == '0')
            {
                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[2, 0] == '0' && field[2, 1] == '0' && field[2, 2] == '0')
            {
                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[0, 0] == '0' && field[1, 1] == '0' && field[2, 2] == '0')
            {
                MessageBox.Show("Computer win!");
                Close();
            }
            if (field[0, 2] == '0' && field[1, 1] == '0' && field[2, 0] == '0')
            {
                MessageBox.Show("Computer win!");
                Close();
            }
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
                step = true;
            else
                step = false;
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            if (rb2.IsChecked == true)
                step = false;
            else
                step = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("test.txt"))
            {
                using (StreamReader sr = new StreamReader("test.txt", Encoding.Default))
                {
                    string msg;
                    string[] arr;
                    while (!sr.EndOfStream)
                    {
                        Player p = new Player();
                        msg = sr.ReadLine();
                        arr = msg.Split(' ');
                        p.name = arr[0];
                        p.time = double.Parse(arr[1]);
                        list.Add(p);
                    }
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Create), Encoding.Default))
            {
                foreach (Player p in list)
                {
                    sw.WriteLine(p.name + " " + p.time.ToString());
                }
            }
        }

        private void AddToText(string str)
        {
            TimeSpan ts = DateTime.Now - start;
            if (str == "")
                str = "Player";
            list.Add(new Player { name = str, time = ts.TotalSeconds });
            List<Player> ls = list.ToList<Player>();
            ls.Sort();
            list.Clear();
            foreach (Player item in ls)
                list.Add(item);
        }
    }
    public class Player : IComparable
    {
        public string name { get; set; }
        public double time { get; set; }
        public int CompareTo(object obj)
        {
            Player p = obj as Player;
            if (p != null)
                return this.time.CompareTo(p.time);
            else
                throw new NotImplementedException();
        }
    }
}
