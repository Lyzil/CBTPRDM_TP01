namespace CBTPRDM_TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string senha = txtPass.Text;

            if(id == "admin" && senha == "senha@dmin")
            {
                DisplayAlert("Login", "Login realizado com sucesso!", "OK");
            }
            else
            {
                DisplayAlert("Login", "ID ou senha incorretos!", "OK");
            }
        }
        private void OnLimparClicked(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtPass.Text = string.Empty;

            txtId.Focus();
        }
        private void OnCreditosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Desenvolvido por:\nLuiz Gustavo Verissimo Monteiro - CB3030326\nAuan Julio Galvão dos Santos - CB3030369\nVersão: 1.0.0", "OK");
        }
    }
}
