using System.Windows.Forms;

public class Animal
{
    private int idAnimal;
    private string nome;
    private string raca;
    private string sexo;
    private string dataNascimento;
    private decimal peso;
    private string ultimaVacinacao;
    private string observacao;

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetRaca(string raca)
    {
        this.raca = raca;
    }

    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }

    public void SetDataNascimento(string dataNascimento)
    {
        this.dataNascimento = dataNascimento;
    }

    public void SetPeso(decimal peso)
    {
        this.peso = peso;
    }

    public void SetUltimaVacinacao(string ultimaVacinacao)
    {
        this.ultimaVacinacao = ultimaVacinacao;
    }

    public void SetObservacao(string observacao)
    {
        this.observacao = observacao;
    }

    public string GetReturn()
    {
        string mensagem = "Nome: " + this.nome + "\n" +
                          "Raça: " + this.raca + "\n" +
                          "Sexo: " + this.sexo + "\n" +
                          "Data de Nascimento: " + this.dataNascimento + "\n" +
                          "Peso: " + this.peso + "\n" +
                          "Data da última vacinação: " + this.ultimaVacinacao + "\n" +
                          "Observação: " + this.observacao;

        MessageBox.Show(mensagem, "Confirme os dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return mensagem;
    }
}
