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
        DispatcherTimer horse0ForwardTimer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer horse0BackwardTimer = new DispatcherTimer(DispatcherPriority.Render);

        DispatcherTimer horse1ForwardTimer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer horse1BackwardTimer = new DispatcherTimer(DispatcherPriority.Render);

        private int _timer0 = 0;
        public int Timer0
        {
            get
            { return _timer0; }
            set
            { _timer0 = value; }
        }

        private int _timer1 = 0;
        public int Timer1
        {
            get
            { return _timer1; }
            set
            { _timer1 = value; }
        }

        public Random rnd = new Random();

        public double RectangleLeft0
        {
            get { return (double)pokerectange0.GetValue(Canvas.LeftProperty); }
        }

        public double RectangleLeft1
        {
            get { return (double)pokerectange1.GetValue(Canvas.LeftProperty); }
        }

        private int _limit0 = 0;
        public int Limit0
        {
            get
            { 
                    _limit0 = rnd.Next(300, 400);
                return _limit0;
            }
            set { _limit0 = value; }
          
        }

        private int _limit1 = 0;
        public int Limit1
        {
            get
            {
                _limit1 = rnd.Next(500, 600);
                return _limit1;
            }
            set { _limit1 = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            horse0ForwardTimer.Tick += new EventHandler(horse0ForwardTimer_Tick);
            horse0ForwardTimer.Interval = TimeSpan.FromMilliseconds(10);
            horse0BackwardTimer.Tick += new EventHandler(horse0BackwardTimer_Tick);
            horse0BackwardTimer.Interval = TimeSpan.FromMilliseconds(10);

            horse1ForwardTimer.Tick += new EventHandler(horse1ForwardTimer_Tick);
            horse1ForwardTimer.Interval = TimeSpan.FromMilliseconds(10);
            horse1BackwardTimer.Tick += new EventHandler(horse1BackwardTimer_Tick);
            horse1BackwardTimer.Interval = TimeSpan.FromMilliseconds(10);
        }

        private void raceButton_Click(object sender, RoutedEventArgs e)
        {
            Timer0 = 0;
            Timer1 = 0;
            horse0ForwardTimer.Start();
            horse1ForwardTimer.Start();

        }

        private void horse0ForwardTimer_Tick(object sender, EventArgs e)
        {
            if (Timer0 < Limit0)
            {
                horse0BackwardTimer.Stop();
                Timer0++;
                this.pokerectange0.SetValue(Canvas.LeftProperty, RectangleLeft0 + 1);
            }
            else
            {
                horse0ForwardTimer.Stop();
                Timer0 = 0;
                horse0BackwardTimer.Start();
            }
        }

        private void horse0BackwardTimer_Tick(object sender, EventArgs e)
        {
            if (Timer0 < Limit0)
            {
                horse0ForwardTimer.Stop();
                Timer0++;
                this.pokerectange0.SetValue(Canvas.LeftProperty, RectangleLeft0 - 1);
            }
            else
            {
                horse0BackwardTimer.Stop();
                Timer0 = 0;
                horse0ForwardTimer.Start();
            }
        }

        private void horse1ForwardTimer_Tick(object sender, EventArgs e)
        {
            int j = rnd.Next(200, 400);
            if (Timer1 < Limit1)
            {
                horse1BackwardTimer.Stop();
                Timer1++;
                this.pokerectange1.SetValue(Canvas.LeftProperty, RectangleLeft1 + 1);
            }
            else
            {
                horse1ForwardTimer.Stop();
                Timer1 = 0;
                horse1BackwardTimer.Start();
            }
        }

        private void horse1BackwardTimer_Tick(object sender, EventArgs e)
        {

            if (Timer1 < Limit1)
            {
                horse1ForwardTimer.Stop();
                Timer1++;
                this.pokerectange1.SetValue(Canvas.LeftProperty, RectangleLeft1 - 1);
            }
            else
            {
                horse1BackwardTimer.Stop();
                Timer1 = 0;
                horse1ForwardTimer.Start();
            }
        }
    }
}
