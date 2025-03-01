using System;
using System.Globalization;
using System.Windows.Forms;

public class Animais
{
    public int idAnimal;
    public string nomeNumeracao;
    public string raca;
    public string sexo;
    public DateTime dataNascimento;
    public decimal peso;
    public DateTime ultimaVacinacao;
    public string observacao;

    public void NomeNumeracao(string nomeNumeracao)
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

    public void Raca(string raca)
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

    public void Sexo(string sexo)
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

    public void DataNascimento(DateTime dataNascimento)
    {
        if (dataNascimento > DateTime.Now)
        {
            throw new Exception("A data de nascimento não pode ser no futuro.");
        }
        this.dataNascimento = dataNascimento;
    }

    public void Peso(decimal peso)
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

    public void UltimaVacinacao(DateTime ultimaVacinacao)
    {
        if (ultimaVacinacao > DateTime.Now)
        {
            throw new Exception("A data da última vacinação não pode ser no futuro.");
        }
        if (ultimaVacinacao < dataNascimento)
        {
            throw new Exception("A última vacinação não pode ser antes da data de nascimento.");
        }
        this.ultimaVacinacao = ultimaVacinacao;
    }

    public void Observacao(string observacao)
    {
        if (observacao.Length > 1000)
        {
            throw new Exception("A observação do animal não pode ter mais de 1000 caracteres.");
        }

        this.observacao = observacao;
    }

    public bool Return()
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


