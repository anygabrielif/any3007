using Microsoft.Maui.Controls;

namespace any3007
{
    public partial class VendasPage: Microsoft.Maui.Controls.ContentPage
    {
        public VendasPage()
        {
            InitializeComponent();
        }
    
        private async void OnVendasClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmação", "Tem certeza que deseja vender?", "Sim", "Não");
            if (answer)
            {
                
                await DisplayAlert("Vendido", "Produto vendido com sucesso!", "OK");
            }
        }
    }
}