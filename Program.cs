namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();

    }

    static void Menu()
    {

        Console.Clear();

        Console.WriteLine("Olá, tudo bem? O que deseja calcular?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------");
        Console.WriteLine("Selecione uma opção");

        short res;
        bool isValidinput = short.TryParse(Console.ReadLine(), out res);


        if (isValidinput)
        {

            switch (res)
            {
                case 1: PerformingOperations(Operations.Soma); break;
                case 2: PerformingOperations(Operations.Subtracao); break;
                case 3: PerformingOperations(Operations.Divisao); break;
                case 4: PerformingOperations(Operations.Multiplicacao); break;
                case 5: System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("Opção inválida, Por Favor, Selecione uma opção válida.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Menu(); break;
            }

        }
        else
        {
            Console.WriteLine("Opção inválida, Por Favor, Selecione uma opção válida.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu();
        }


    }

    static void PerformingOperations(Func<float, float, float> operation)
    {

        Console.Clear();
        Console.WriteLine("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        float res = operation(v1, v2);
        if (!float.IsNaN(res))
        {
            Console.WriteLine($"O Resultado da Operação é: {res}");
        }

        Console.WriteLine("Pressione Qualquer Tecla Para Continuar...");
        Console.ReadKey();
        Menu();


    }

    public class Operations()
    {

        public static float Soma(float v1, float v2)
        {
            return v1 + v2;
        }

        public static float Subtracao(float v1, float v2)
        {
            return v1 - v2;
        }

        public static float Divisao(float v1, float v2)
        {

            if (v2 == 0)
            {
                Console.WriteLine("Erro: Divisão por ZERO não é permitida!");
                return float.NaN;
            }
            else
            {
                return v1 / v2;
            }

        }

        public static float Multiplicacao(float v1, float v2)
        {
            return v1 * v2;
        }

    }

}

