namespace TheCalculator;
class Program
{
    static void Main(string[] args)
    {
            Menu();
    }
    static void Menu()
    { 
        

        Console.Clear();
        Console.WriteLine("Olá, bem vindo a melhor calculadora do c#");
        Console.WriteLine("por favor, escolha uma operação: ");
        Console.WriteLine("1 - soma");
        Console.WriteLine("2 - subtração");
        Console.WriteLine("3 - multiplicação");
        Console.WriteLine("4 - divisão");
        Console.WriteLine("5 - para porcentagem");
        Console.WriteLine("6 - para saber quantos % um numero é de outro");
        Console.WriteLine("7 - para sair da aplicação");
        Console.WriteLine("------------------------");
        

        var res  = Console.ReadLine();
        short resN = short.Parse(res);
        switch(resN) 
            {
            case 1: Soma();break;
            case 2: Subtracao();break;
            case 3: Multiplica();break;
            case 4: Divisao();break;
            case 5: Porcentagemde();break;
            case 6: DescobrePorcen();break;
            case 7: System.Environment.Exit(0);break;
             default: Menu();break;
             }


    }
    static void Soma()
        { 
        Console.WriteLine("SOMANDO DOIS NUMEROS");
        Console.WriteLine("digite o primeiro valor: ");
        var v1 = Console.ReadLine();
        float n1 = float.Parse(v1);
        Console.WriteLine("Digite o segundo valor: ");
        var v2 = Console.ReadLine();
        float n2 = float.Parse(v2);
        float somaN = (n1 + n2);
        Console.WriteLine ("o resultado é: "+somaN);
        Console.WriteLine("------------------------");

        Console.ReadKey();

        Menu();
        


        }
    static void Subtracao()

         { 
        Console.WriteLine("SUBTRAINDO DOIS NÚMEROS");
        Console.WriteLine("digite o primeiro valor: ");
        var v1 = Console.ReadLine();
        float n1 = float.Parse(v1);
        Console.WriteLine("Digite o segundo valor: ");
        var v2 = Console.ReadLine();
        float n2 = float.Parse(v2);
        float menosN = (n1 - n2);
        Console.WriteLine ("o resultado é: "+menosN);
        Console.WriteLine("------------------------");
        Console.ReadKey();

        Menu();


        }
    static void Multiplica()
        { 
        Console.WriteLine("MULTIPLICANDO DOIS NÚMEROS");
        Console.WriteLine("digite o primeiro valor: ");
        var v1 = Console.ReadLine();
        float n1 = float.Parse(v1);
        Console.WriteLine("Digite o segundo valor: ");
        var v2 = Console.ReadLine();
        float n2 = float.Parse(v2);
        float multiN = (n1*n2);
        Console.WriteLine ("o resultado é: "+ multiN);
        Console.WriteLine("------------------------");

        Console.ReadKey();
        Menu();


        }
    static void Divisao()
         { 
        Console.WriteLine("DIVIDINDO DOIS NÚMEROS");
        Console.WriteLine("digite o primeiro valor: ");
        var v1 = Console.ReadLine();
        float n1 = float.Parse(v1);
        Console.WriteLine("Digite o segundo valor: ");
        var v2 = Console.ReadLine();
        float n2 = float.Parse(v2);
        float diviN = (n1/n2);
        Console.WriteLine ("o resultado é: "+diviN);
        Console.WriteLine("------------------------");

        Console.ReadKey();
        Menu();
        }
    static void Porcentagemde()
        {
        Console.WriteLine("PORCENTAGEM DE UM NUMERO");
        Console.WriteLine("digite a %");
        var v1 = Console.ReadLine();
        float p1 = float.Parse(v1);
        Console.WriteLine("digite o numero o qual você quer extrair a porcentagem");
        var v2 = Console.ReadLine();
        float p2 = float.Parse(v2);
        float porcenP = ((p1/100)*p2);
        Console.WriteLine(p1+"% de " + p2 +" é " + porcenP);
        Console.ReadKey();
        Menu();

        }
    static void DescobrePorcen()
        {
        Console.WriteLine("calcula quantos % um numero é de outro");
        Console.WriteLine("digite um numero");
        var v1 = Console.ReadLine();
        float p1 = float.Parse(v1);
        Console.WriteLine("Digite outro numero o qual será usado para referência");
        var v2 = Console.ReadLine();
        float p2 = float.Parse(v2);
        float PorcenD = ((p1/p2)*100);
        Console.WriteLine(p1 + " é "+ PorcenD +" % de "+p2);
        Console.ReadKey();
        Menu();
        }
}





