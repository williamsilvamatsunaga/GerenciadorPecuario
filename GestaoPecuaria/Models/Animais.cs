using System;
using System.Globalization;
using System.Windows.Forms;

public class Animais
{
    private int idAnimal;
    private string nomeNumeracao;
    private string raca;
    private string sexo;
    private string dataNascimento;
    private decimal peso;
    private string ultimaVacinacao;
    private string observacao;

    public void SetNomeNumeracao(string nomeNumeracao)
    {
        if (nomeNumeracao.Length <= 50)
        {
            this.nomeNumeracao = nomeNumeracao;
        }
        else
        {
            throw new Exception("O nome ou numeração do animal não pode ter mais de 50 caracteres.");
        }
    }

    public void SetRaca(string raca)
    {
        if (raca.Length <= 50)
        {
            this.raca = raca;
        }
        else
        {
            throw new Exception("O raça do animal não pode ter mais de 50 caracteres.");
        }
    }

    public void SetSexo(string sexo)
    {
        if(sexo.Equals("M") || sexo.Equals("F"))
        {
            this.sexo = sexo;
        }
        else
        {
            throw new Exception("O sexo do animal deve ser 'M' ou 'F'.");
        }
    }

    public void SetDataNascimento(string dataNascimento)
    {
        DateTime data;

        if (DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
        {
            this.dataNascimento = data.ToString("dd/MM/yyyy");
        }
        else
        {
            throw new Exception("Data de nascimento inválida! Use o formato dd/MM/yyyy.");
        }
    }

    public void SetPeso(decimal peso)
    {
        if (peso <= 0)
        {
            throw new Exception("O peso do animal deve ser maior que zero.");
        }
        else if (peso > 1000)
        {
            throw new Exception("O peso informado é muito alto. Verifique novamente.");
        }
        this.peso = peso;
    }

    public void SetUltimaVacinacao(string ultimaVacinacao)
    {
        DateTime data;

        if (DateTime.TryParseExact(ultimaVacinacao, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
        {
            this.ultimaVacinacao = data.ToString("dd/MM/yyyy");
        }
        else
        {
            throw new Exception("Data de última vacinação inválida! Use o formato dd/MM/yyyy.");
        }
    }

    public void SetObservacao(string observacao)
    {
        if (observacao.Length > 1000)
        {
            throw new Exception("A observação do animal não pode ter mais de 1000 caracteres.");
        }

        this.observacao = observacao;
    }

    public bool GetReturn()
    {
        string mensagem = "Nome: " + this.nomeNumeracao + "\n" +
                          "Raça: " + this.raca + "\n" +
                          "Sexo: " + this.sexo + "\n" +
                          "Data de Nascimento: " + this.dataNascimento + "\n" +
                          "Peso KG: " + this.peso + "\n" +
                          "Data da última vacinação: " + this.ultimaVacinacao + "\n" +
                          "Observação: " + this.observacao;

        DialogResult no = MessageBox.Show(mensagem, "Confirme os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        return no == DialogResult.Yes;
    }
}
