using ALaMarona.Service;
using NHibernate;
using NHibernate.Cfg;
using System.Windows;

namespace ALaMaronaDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductoService productoService { get; set; }
        public ISessionFactory SessionFactory { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            var nhConfig = new Configuration().Configure();
            SessionFactory = nhConfig.BuildSessionFactory();
            lblTest.Content = "NHibernate configured!";
            tab.SelectedIndex = 0;

            //TODO: esto habría que cambiarlo utilizando inyección de dependencias
            productoService = new ProductoService(SessionFactory);
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

        void habilitarEdicionProducto(bool habilitar)
        {
            txtCodigo.IsReadOnly = !habilitar;
            txtDescripcion.IsReadOnly = !habilitar;
        }

        private void btnNuevoProducto_Click(object sender, RoutedEventArgs e)
        {
            habilitarEdicionProducto(true);
            btnGuardarProducto.IsEnabled = true;
            txtCodigo.Clear();
            txtDescripcion.Clear();
        }

        private void btnBuscarProducto_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnGuardarProducto_Click(object sender, RoutedEventArgs e)
        {
            var producto = new ALaMarona.Domain.Entities.Producto();
            producto.Codigo = txtCodigo.Text;
            producto.Descripcion = txtDescripcion.Text;
            productoService.Save(producto);
            habilitarEdicionProducto(false);
        }
    }
}
