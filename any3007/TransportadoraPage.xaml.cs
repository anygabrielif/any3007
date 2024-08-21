using Microsoft.Maui.Controls;

namespace any3007
{
    public partial class TransportadoraPage : Microsoft.Maui.Controls.ContentPage
    {
        public TransportadoraPage()
        {
            InitializeComponent();
        }
        

        private void SubmitClicked(object sender, EventArgs e)
        {
            ConfirmationDialog.IsVisible = true;
        }

        private void YesClicked(object sender, EventArgs e)
        {
           
            ConfirmationDialog.IsVisible = false;
            DisplayAlert("Success", "Form submitted successfully!", "OK");
        }

        private void NoClicked(object sender, EventArgs e)
        {
            ConfirmationDialog.IsVisible = false;
        }
    }
}