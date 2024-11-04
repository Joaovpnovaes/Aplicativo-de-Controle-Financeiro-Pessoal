namespace GerenciamentoFinanceiroPessoal;

public partial class UserRegistrationPage : ContentPage
{
    public UserRegistrationPage()
    {
        InitializeComponent();
    }

    private void OnCadastrarClicked(object sender, EventArgs e)
    {
        string nome = NomeEntry.Text;
        string email = EmailEntry.Text;
        string senha = SenhaEntry.Text;
        string confirmarSenha = ConfirmarSenhaEntry.Text;

        // Verifica se a senha e a confirmação coincidem
        if (senha == confirmarSenha)
        {
            // Aqui você poderia salvar o cadastro ou realizar outra ação
            ResultadoLabel.Text = "Cadastro realizado com sucesso!";
            ResultadoLabel.TextColor = Colors.Green;
        }
        else
        {
            ResultadoLabel.Text = "As senhas não coincidem. Tente novamente.";
            ResultadoLabel.TextColor = Colors.Red;
        }
    }
}
