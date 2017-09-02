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

        DispatcherTimer horse2ForwardTimer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer horse2BackwardTimer = new DispatcherTimer(DispatcherPriority.Render);

        DispatcherTimer horse3ForwardTimer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer horse3BackwardTimer = new DispatcherTimer(DispatcherPriority.Render);

        DispatcherTimer horse4ForwardTimer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer horse4BackwardTimer = new DispatcherTimer(DispatcherPriority.Render);

        DispatcherTimer horse5ForwardTimer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer horse5BackwardTimer = new DispatcherTimer(DispatcherPriority.Render);

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

        private int _timer2 = 0;
        public int Timer2
        {
            get
            { return _timer2; }
            set
            { _timer2 = value; }
        }

        private int _timer3 = 0;
        public int Timer3
        {
            get
            { return _timer3; }
            set
            { _timer3 = value; }
        }

        private int _timer4 = 0;
        public int Timer4
        {
            get
            { return _timer4; }
            set
            { _timer4 = value; }
        }

        private int _timer5 = 0;
        public int Timer5
        {
            get
            { return _timer5; }
            set
            { _timer5 = value; }
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

        public double RectangleLeft2
        {
            get { return (double)pokerectange2.GetValue(Canvas.LeftProperty); }
        }

        public double RectangleLeft3
        {
            get { return (double)pokerectange3.GetValue(Canvas.LeftProperty); }
        }

        public double RectangleLeft4
        {
            get { return (double)pokerectange4.GetValue(Canvas.LeftProperty); }
        }

        public double RectangleLeft5
        {
            get { return (double)pokerectange5.GetValue(Canvas.LeftProperty); }
        }
        private int _limit0 = 0;
        public int Limit0
        {
            get
            { 
                    _limit0 = rnd.Next(400, 500);
                return _limit0;
            }
            set { _limit0 = value; }
          
        }

        private int _limit1 = 0;
        public int Limit1
        {
            get
            {
                _limit1 = rnd.Next(400, 500);
                return _limit1;
            }
            set { _limit1 = value; }
        }

        private int _limit2 = 0;
        public int Limit2
        {
            get
            {
                _limit2 = rnd.Next(400, 500);
                return _limit2;
            }
            set { _limit2 = value; }
        }

        private int _limit3 = 0;
        public int Limit3
        {
            get
            {
                _limit3 = rnd.Next(400, 500);
                return _limit3;
            }
            set { _limit3 = value; }
        }

        private int _limit4 = 0;
        public int Limit4
        {
            get
            {
                _limit4 = rnd.Next(400, 500);
                return _limit4;
            }
            set { _limit4 = value; }
        }

        private int _limit5 = 0;
        public int Limit5
        {
            get
            {
                _limit5 = rnd.Next(400, 500);
                return _limit5;
            }
            set { _limit5 = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            horse0ForwardTimer.Tick += new EventHandler(horse0ForwardTimer_Tick);
            horse0ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
            horse0BackwardTimer.Tick += new EventHandler(horse0BackwardTimer_Tick);
            horse0BackwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));

            horse1ForwardTimer.Tick += new EventHandler(horse1ForwardTimer_Tick);
            horse1ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
            horse1BackwardTimer.Tick += new EventHandler(horse1BackwardTimer_Tick);
            horse1BackwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));

            horse2ForwardTimer.Tick += new EventHandler(horse2ForwardTimer_Tick);
            horse2ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
            horse2BackwardTimer.Tick += new EventHandler(horse2BackwardTimer_Tick);
            horse2BackwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));

            horse3ForwardTimer.Tick += new EventHandler(horse3ForwardTimer_Tick);
            horse3ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
            horse3BackwardTimer.Tick += new EventHandler(horse3BackwardTimer_Tick);
            horse3BackwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));

            horse4ForwardTimer.Tick += new EventHandler(horse4ForwardTimer_Tick);
            horse4ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
            horse4BackwardTimer.Tick += new EventHandler(horse4BackwardTimer_Tick);
            horse4BackwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));

            horse5ForwardTimer.Tick += new EventHandler(horse5ForwardTimer_Tick);
            horse5ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
            horse5BackwardTimer.Tick += new EventHandler(horse5BackwardTimer_Tick);
            horse5BackwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 50));
        }

        private void raceButton_Click(object sender, RoutedEventArgs e)
        {
            Timer0 = 0;
            Timer1 = 0;
            Timer2 = 0;
            Timer3 = 0;
            Timer4 = 0;
            Timer5 = 0;

            horse1ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 100));

            horse0ForwardTimer.Start();
            horse1ForwardTimer.Start();
            horse2ForwardTimer.Start();
            horse3ForwardTimer.Start();
            horse4ForwardTimer.Start();
            horse5ForwardTimer.Start();
            

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
                horse1ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10,100));

                horse1ForwardTimer.Start();
            }
        }

        private void horse2ForwardTimer_Tick(object sender, EventArgs e)
        {
            if (Timer2 < Limit2)
            {
                horse2BackwardTimer.Stop();
                Timer2++;
                this.pokerectange2.SetValue(Canvas.LeftProperty, RectangleLeft2 + 1);
            }
            else
            {
                horse2ForwardTimer.Stop();
                Timer1 = 0;

                horse2BackwardTimer.Start();
            }
        }

        private void horse2BackwardTimer_Tick(object sender, EventArgs e)
        {

            if (Timer2 < Limit2)
            {
                horse2ForwardTimer.Stop();
                Timer1++;
                this.pokerectange2.SetValue(Canvas.LeftProperty, RectangleLeft2 - 1);
            }
            else
            {
                horse2BackwardTimer.Stop();
                Timer2 = 0;
                horse2ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 100));

                horse2ForwardTimer.Start();
            }
        }

        private void horse3ForwardTimer_Tick(object sender, EventArgs e)
        {
            if (Timer3 < Limit3)
            {
                horse3BackwardTimer.Stop();
                Timer3++;
                this.pokerectange3.SetValue(Canvas.LeftProperty, RectangleLeft3 + 1);
            }
            else
            {
                horse3ForwardTimer.Stop();
                Timer1 = 0;

                horse3BackwardTimer.Start();
            }
        }

        private void horse3BackwardTimer_Tick(object sender, EventArgs e)
        {

            if (Timer3 < Limit3)
            {
                horse3ForwardTimer.Stop();
                Timer3++;
                this.pokerectange3.SetValue(Canvas.LeftProperty, RectangleLeft3 - 1);
            }
            else
            {
                horse3BackwardTimer.Stop();
                Timer3 = 0;
                horse3ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 100));

                horse3ForwardTimer.Start();
            }
        }

        private void horse4ForwardTimer_Tick(object sender, EventArgs e)
        {
            if (Timer4 < Limit4)
            {
                horse4BackwardTimer.Stop();
                Timer4++;
                this.pokerectange4.SetValue(Canvas.LeftProperty, RectangleLeft4 + 1);
            }
            else
            {
                horse4ForwardTimer.Stop();
                Timer4 = 0;

                horse4BackwardTimer.Start();
            }
        }

        private void horse4BackwardTimer_Tick(object sender, EventArgs e)
        {

            if (Timer4 < Limit4)
            {
                horse3ForwardTimer.Stop();
                Timer4++;
                this.pokerectange4.SetValue(Canvas.LeftProperty, RectangleLeft4 - 1);
            }
            else
            {
                horse4BackwardTimer.Stop();
                Timer4 = 0;
                horse4ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 100));

                horse4ForwardTimer.Start();
            }
        }

        private void horse5ForwardTimer_Tick(object sender, EventArgs e)
        {
            if (Timer5 < Limit5)
            {
                horse5BackwardTimer.Stop();
                Timer5++;
                this.pokerectange5.SetValue(Canvas.LeftProperty, RectangleLeft5 + 1);
            }
            else
            {
                horse5ForwardTimer.Stop();
                Timer1 = 0;

                horse5BackwardTimer.Start();
            }
        }

        private void horse5BackwardTimer_Tick(object sender, EventArgs e)
        {

            if (Timer5 < Limit5)
            {
                horse5ForwardTimer.Stop();
                Timer5++;
                this.pokerectange5.SetValue(Canvas.LeftProperty, RectangleLeft5 - 1);
            }
            else
            {
                horse5BackwardTimer.Stop();
                Timer5 = 0;
                horse5ForwardTimer.Interval = TimeSpan.FromMilliseconds(rnd.Next(10, 100));

                horse5ForwardTimer.Start();
            }
        }
    }
}
