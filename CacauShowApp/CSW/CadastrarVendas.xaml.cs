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
    /// Lógica interna para CadastrarVendas.xaml
    /// </summary>
    public partial class CadastrarVendas : Window
    {
        public CadastrarVendas()
        {
            InitializeComponent();
        }

        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            ListarEstoque estoque = new ListarEstoque();    
            estoque.ShowDialog();
        }

        private void Vendas_Click(object sender, RoutedEventArgs e)
        {
            CadastrarVendas vendas = new CadastrarVendas();
            vendas.ShowDialog();
        }

        private void Compras_Click(object sender, RoutedEventArgs e)
        {
            ListarCompras compras = new ListarCompras();
            compras.ShowDialog();
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionarios fun = new ListarFuncionarios();
            fun.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RealizarLogin login = new RealizarLogin();
            login.ShowDialog();
        }
    }
}
