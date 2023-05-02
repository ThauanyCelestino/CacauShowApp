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

namespace CacauShowApp
{
    /// <summary>
    /// Lógica interna para RealizarLogin.xaml
    /// </summary>
    public partial class RealizarLogin : Window
    {
        public RealizarLogin()
        {
            InitializeComponent();
        }

        private void Produto_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProduto produto = new CadastrarProduto();
            produto.ShowDialog();
        }
    }
}
