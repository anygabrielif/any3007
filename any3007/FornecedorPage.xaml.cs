using Microsoft.Maui.Controls;

namespace any3007
{
    public partial class FornecedorPage: Microsoft.Maui.Controls.ContentPage
    {
        public FornecedorPage()
        {
            InitializeComponent();
        }
    
        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Cadastrado", "Fornecedor cadastrado com sucesso!", "OK");
        }
    }

}