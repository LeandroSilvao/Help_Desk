using System.Windows;
using System.Windows.Controls;
using Uniinfo_Desk.ServiceReference;

namespace Uniinfo_Desk.Apresentação
{
    /// <summary>
    /// Lógica interna para frmInicio.xaml
    /// </summary>
    public partial class frmInicio : Window
    {
        WebServiceSoapClient obj = new WebServiceSoapClient();
        Inicio Inicio = new Inicio();

        public frmInicio()
        {
            InitializeComponent();
            gridFuncionarios.ItemsSource = obj.ConsultarFuncionario();
        }
        

        private void DtgtvInicio_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "ExtensionData")
            {
                e.Column = null;
            }
            if (e.PropertyName == "idFuncionario")
            {
                e.Column = null;
            }
            if (e.PropertyName.StartsWith("ramal"))
            {
                e.Column.Header = "Ramal";
            }
            if (e.PropertyName.StartsWith("email"))
            {
                e.Column.Header = "E-mail";
            }
            if (e.PropertyName.StartsWith("nComputador"))
            {
                e.Column.Header = "Nº Computador";
            }
            if (e.PropertyName.StartsWith("nome"))
            {
                e.Column.Header = "Nome";
            }
            if (e.PropertyName.StartsWith("setor"))
            {
                e.Column.Header = "Setor";
            }
        }


        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            mnaFuncionarios1.Close();
            Inicio.mnConsulta.Show();
        }

        private void BtnExibirFunc_Click(object sender, RoutedEventArgs e)
        {
            gridFuncionarios.ItemsSource = obj.ConsultarFuncionario();
        }

        private void GridFuncionarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
