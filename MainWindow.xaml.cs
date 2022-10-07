using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace wpfMultiSolar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer t1, t2, t3, t4, t5, t6, t7, t8;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DispatcherMethod();
            TimerMethod();
        }

        private void DispatcherMethod()
        {
            DispatcherTimer dt = new DispatcherTimer();
            Planet p1 = new Planet(mercury, 90, 0.07);
            Planet p2 = new Planet(venus, 124, 0.04);
            Planet p3 = new Planet(earth, 148, 0.032);
            Planet p4 = new Planet(mars, 176, 0.022);
            Planet p5 = new Planet(jupiter, 267, 0.0065);
            Planet p6 = new Planet(saturn, 316, 0.0059);
            Planet p7 = new Planet(uranus, 367, 0.0038);
            Planet p8 = new Planet(neptune, 402, 0.0013);
            dt.Tick += new EventHandler(p1.MovePlanet1);
            dt.Tick += new EventHandler(p2.MovePlanet1);
            dt.Tick += new EventHandler(p3.MovePlanet1);
            dt.Tick += new EventHandler(p4.MovePlanet1);
            dt.Tick += new EventHandler(p5.MovePlanet1);
            dt.Tick += new EventHandler(p6.MovePlanet1);
            dt.Tick += new EventHandler(p7.MovePlanet1);
            dt.Tick += new EventHandler(p8.MovePlanet1);
            dt.Interval = TimeSpan.FromMilliseconds(1);
            dt.Start();
        }

        private void TimerMethod()
        {
            TimeSpan dueTime = TimeSpan.Zero;
            TimeSpan interval = TimeSpan.FromMilliseconds(1);
            Planet p1 = new Planet(mercury, 90, 0.07);
            Planet p2 = new Planet(venus, 124, 0.04);
            Planet p3 = new Planet(earth, 148, 0.032);
            Planet p4 = new Planet(mars, 176, 0.022);
            Planet p5 = new Planet(jupiter, 267, 0.0065);
            Planet p6 = new Planet(saturn, 316, 0.0059);
            Planet p7 = new Planet(uranus, 367, 0.0038);
            Planet p8 = new Planet(neptune, 402, 0.0013);
            t1 = new Timer(p1.MovePlanet2, null, dueTime, interval);
            t2 = new Timer(p2.MovePlanet2, null, dueTime, interval);
            t3 = new Timer(p3.MovePlanet2, null, dueTime, interval);
            t4 = new Timer(p4.MovePlanet2, null, dueTime, interval);
            t5 = new Timer(p5.MovePlanet2, null, dueTime, interval);
            t6 = new Timer(p6.MovePlanet2, null, dueTime, interval);
            t7 = new Timer(p7.MovePlanet2, null, dueTime, interval);
            t8 = new Timer(p8.MovePlanet2, null, dueTime, interval);

        }
    }
}
