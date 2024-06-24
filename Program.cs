using System;

class Program
{
    static void Main()
    {
        Menu();
        
    }

    static void Menu(){
        int escolha;

        while (true)
        {
            Console.WriteLine("\nMenu da Maquina de Turing:");
            Console.WriteLine("[1] - Começar uma nova maquina.");
            Console.WriteLine("[2] - Rodar a maquina de Turing.");
            Console.WriteLine("[3] - Modificar a maquina.");
            //Posso adicionar os nomes da maquinas aqui de forma iterativa, dependendo
            //de como fizer posso armazer k maquinas de turing in memory e usar essa
            //maquina depois, listando elas aqui o user escolhe qual maquina usar.
            Console.WriteLine("[4] - Sair");
            Console.Write("Escolha uma opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ComecarCriarNovaMquina();
                    break;
                case 2:
                    Opcao2();
                    break;
                case 3:
                    Opcao3();
                    break;
                case 4:
                    Sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }

    static void ComecarCriarNovaMquina()
    {
        Console.WriteLine("Vamos começar a configurar a sua nova maquina de turing.");
        int numeroDeEstados = EscolherNumeroDeEstados();
        Console.WriteLine($"Você escolheu {numeroDeEstados} estados.");

        Console.WriteLine($"Maquina de teste:");

        MaquinaTuring maquina = CriarMaquinaGenerica();

        Console.WriteLine($"Propriedades da minha maquina criada:");
        Console.WriteLine(maquina.ToString());
    }

    static MaquinaTuring CriarMaquinaGenerica()
    {
        String[] Estados = new String[] { "Q1", "Q2"};
        String[] Alfabeto = new String[] { "a", "b"};
        Transicao Transicao1 = new Transicao(Estados[0], Alfabeto[0], "Mover pra direita.");
        Transicao Transicao2 = new Transicao(Estados[0], Alfabeto[1], "Mover pra direita.");
        Transicao Transicao3 = new Transicao(Estados[1], Alfabeto[0], "Mover pra direita.");
        Transicao Transicao4 = new Transicao(Estados[1], Alfabeto[1], "Mover pra direita.");
        Transicao[] Transicoes = new Transicao[]{ Transicao1, Transicao2, Transicao3, Transicao4 };
        String[] Entrada = new String[] { "a", "b", "a"};

        return new MaquinaTuring("Primeira Maquina", Estados, Alfabeto, Transicoes, Entrada);
    }

    static int EscolherNumeroDeEstados()
    { 
        int numeroDeEstados = 0;
        Console.WriteLine("Insira o número de estados na maquina:");
        numeroDeEstados = Convert.ToInt32(Console.ReadLine());

        while(numeroDeEstados <= 0){
            Console.WriteLine("Por favor insira um valor válido:");
            numeroDeEstados = Convert.ToInt32(Console.ReadLine());
        }

        return numeroDeEstados;
    }

    static void Opcao1()
    {
        Console.WriteLine("Você escolheu a Opção 2.");
        // Adicione o código específico para a Opção 2 aqui
    }

    static void Opcao2()
    {
        Console.WriteLine("Você escolheu a Opção 2.");
        // Adicione o código específico para a Opção 2 aqui
    }

    static void Opcao3()
    {
        Console.WriteLine("Você escolheu a Opção 3.");
        // Adicione o código específico para a Opção 3 aqui
    }

    static void Sair()
    {
        Console.WriteLine("Saindo do programa...");
        Environment.Exit(0);
    }
}
