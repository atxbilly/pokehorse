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
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace pokehorse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer(DispatcherPriority.Render);
        int timer = 0;
        double switchinterval = 1;
        public Random rnd = new Random();
        List<double> directions = new List<double>() { -.1, 2 };

        public double RectangleLeft
        {
            get { return (double)pokerectange0.GetValue(Canvas.LeftProperty); }
        }


        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1);

        }

        private void raceButton_Click(object sender, RoutedEventArgs e)
        {
            
            timer = 0;
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (timer != 600)
            {
                this.pokerectange0.SetValue(Canvas.LeftProperty, RectangleLeft+ switchinterval);
                // Forcing the CommandManager to raise the RequerySuggested event
                CommandManager.InvalidateRequerySuggested();
                if (timer % 1 == 0)
                {
                    switchinterval = directions[rnd.Next(0, 1)];
                }
                timer++;

            }


            else { dispatcherTimer.Stop(); }
        }
    }
}
