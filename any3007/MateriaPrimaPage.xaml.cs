using Microsoft.Maui.Controls;

namespace any3007
{
    public partial class MateriaPrimaPage: Microsoft.Maui.Controls.ContentPage
    {
        public MateriaPrimaPage()
        {
            InitializeComponent();
        }
         private void OnEnviarClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Enviado", "Dados enviados com sucesso!", "OK");
        }
    }
}