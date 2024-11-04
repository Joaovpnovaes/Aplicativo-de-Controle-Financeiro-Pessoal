using Models;

namespace GerenciamentoFinanceiroPessoal;

public partial class UserRegistrationPage : ContentPage
{
    public UserRegistrationPage()
    {
        InitializeComponent();
    }

    private void OnCadastrarClicked(object sender, EventArgs e)
    {
        // Cria um novo objeto Usuario com os dados preenchidos
        Usuario usuario = new Usuario
        {
            Nome = NomeEntry.Text,
            Email = EmailEntry.Text,
            Cpf = CpfEntry.Text,
            Senha = SenhaEntry.Text
        };

        // Captura as senhas para verificação
        string senha = SenhaEntry.Text;
        string confirmarSenha = ConfirmarSenhaEntry.Text;

        // Verifica se a senha e a confirmação coincidem
        if (senha == confirmarSenha)
        {
            // Aqui você poderia salvar o cadastro ou realizar outra ação
            ResultadoLabel.Text = "Cadastro realizado com sucesso!";
            ResultadoLabel.TextColor = Colors.Green;

            // Limpa os campos de entrada após o cadastro
            NomeEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            CpfEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;
            ConfirmarSenhaEntry.Text = string.Empty;
        }
        else
        {
            ResultadoLabel.Text = "As senhas não coincidem. Tente novamente.";
            ResultadoLabel.TextColor = Colors.Red;
        }
    }
}
