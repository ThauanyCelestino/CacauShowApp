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
    /// Lógica interna para ListarFuncionarios.xaml
    /// </summary>
    public partial class ListarFuncionarios : Window
    {
        public ListarFuncionarios()
        {
            InitializeComponent();
        }

     

        private void Funcionario1_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFuncionario funcionario   = new CadastrarFuncionario();
            funcionario.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RealizarLogin login = new RealizarLogin();
            login.ShowDialog();
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionarios funcionarios = new ListarFuncionarios();
            funcionarios.ShowDialog();
        }

        private void Compras_Click(object sender, RoutedEventArgs e)
        {
            ListarCompras funcionarios = new ListarCompras();
            funcionarios.ShowDialog();
        }

        private void Vendas_Click(object sender, RoutedEventArgs e)
        {
            CadastrarVendas ven = new CadastrarVendas();
                ven.ShowDialog();
        }

        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            ListarEstoque est = new ListarEstoque();
            est.ShowDialog();
        }
    }
}
