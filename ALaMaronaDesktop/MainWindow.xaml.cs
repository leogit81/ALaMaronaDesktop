using NHibernate.Cfg;
using System;
using System.Windows;

namespace ALaMaronaDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            lblTest.Content = "NHibernate configured!";
        }
    }
}
