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
    /// Lógica interna para CadastrarCompra.xaml
    /// </summary>
    public partial class CadastrarCompra : Window
    {
        public CadastrarCompra()
        {
            InitializeComponent();
        }

        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            ListarEstoque listarEstoque = new ListarEstoque();
            listarEstoque.ShowDialog();
        }

        private void Compras_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCompra cadastrarCompra = new CadastrarCompra();
            cadastrarCompra.ShowDialog();   
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFuncionario funcionario = new CadastrarFuncionario();
            funcionario.ShowDialog();   
        }
    }
}
