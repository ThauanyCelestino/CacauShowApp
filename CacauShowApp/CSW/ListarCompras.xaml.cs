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

namespace CacauShowApp.CSW
{
    /// <summary>
    /// Lógica interna para ListarCompras.xaml
    /// </summary>
    public partial class ListarCompras : Window
    {
        public ListarCompras()
        {
            InitializeComponent();
        }

        private void Produto_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Compra_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCompra compra = new CadastrarCompra();
            compra.ShowDialog();
        }

        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            ListarEstoque listarEstoque = new ListarEstoque();
                listarEstoque.ShowDialog();
        }

        private void Compras_Click(object sender, RoutedEventArgs e)
        {
            ListarCompras compras = new ListarCompras();
            compras.ShowDialog();
        }

        private void Vendas_Click(object sender, RoutedEventArgs e)
        {
            CadastrarVendas vendas = new CadastrarVendas();
            vendas.ShowDialog();
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionarios funcionarios = new ListarFuncionarios();
            funcionarios.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RealizarLogin login = new RealizarLogin();  
            login.ShowDialog();
        }
    }
}
