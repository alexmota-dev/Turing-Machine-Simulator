using System;
using System.Text;

public class Transicao
{
    private String Estado;
    private String Palavra;
    private String Acao;

    public Transicao(String Estado, String Palavra, String Acao)
    {
        this.Estado = Estado;
        this.Palavra = Palavra;
        this.Acao = Acao;
    }

    public override string ToString()
    {
        return $"Transicao[Estado={Estado}, Palavra={Palavra}, Acao={Acao}]";
    }
}