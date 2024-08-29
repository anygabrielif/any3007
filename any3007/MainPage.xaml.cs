namespace any3007;

public partial class MainPage : Microsoft.Maui.Controls.ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    async void OnFornecedorClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage=new FornecedorPage();
    }

    async void OnCadastrarMateriaPrimaClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage=new MateriaPrimaPage();
    }

    async void OnVendasClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage=new VendasPage();
    }
    async void ClientesClicked(object sender, EventArgs e)
    {
         Application.Current.MainPage=new ListaClientePage();
    }

    async void OnCostureiraClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage=new CostureiraPage();
    }

}

