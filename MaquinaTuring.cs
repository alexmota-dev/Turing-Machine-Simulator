using System;
using System.Text;

public class MaquinaTuring
{
    private String Nome;
    private String[] Estados;
    private String[] Alfabeto;
    private Transicao[] Transicoes;
    private String[] Entrada;

    public MaquinaTuring(String Nome, String[] Estados, String[] Alfabeto, Transicao[] Transicoes, String[] Entrada = null)
    {
        this.Nome = Nome;
        this.Estados = Estados;
        this.Alfabeto = Alfabeto;
        this.Transicoes = Transicoes;
        this.Entrada = Entrada ?? Array.Empty<string>(); 
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("MaquinaTuring:\n");
        sb.Append("Estados: ");
        sb.Append(string.Join(", ", Estados));
        sb.Append("\nAlfabeto: ");
        sb.Append(string.Join(", ", Alfabeto));
        sb.Append("\nTransicoes:\n");
        foreach (var transicao in Transicoes)
        {
            sb.Append(transicao.ToString());
            sb.Append("\n");
        }
        sb.Append("Entrada: ");
        sb.Append(string.Join(", ", Entrada));
        return sb.ToString();
    }

}