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
            tab.SelectedIndex = 0;
        }

        private void miColores_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = tiColores.TabIndex;
        }

        private void miStock_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = tiStock.TabIndex;
        }

        private void miProductos_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = tiProductos.TabIndex;
        }

        private void btnNuevoProducto_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarProducto.IsEnabled = true;
            txtCodigo.Clear();
            txtDescripcion.Clear();
        }

        private void btnBuscarProducto_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnGuardarProducto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
