string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
    CalcularSoma();

        break;
    case "-":
        Console.WriteLine("Você selecionou subtração");
        break;
    case "*":
        double a, b, resultadomulti;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultadomulti = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultadomulti}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
    case "/":
        Console.WriteLine("Você selecionou divisão");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");

void CalcularSoma()
{

    int n1, n2, resultado; 

    Console.WriteLine("--- Soma A+B ---\n"); 
    Console.WriteLine("Digiteos valores. ");

    Console.Write("A= ");
    n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
    n2 = Convert.ToInt32(Console.ReadLine()); 

      resultado = n1 + n2;
      Console.WriteLine($"{n1} somado por {n2} é {resultado}");
      return;
}