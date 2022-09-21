using System;

public class Calculator {

    public static void Main() { 
    Console.Write("[1] O seu calculo é de soma, subtracao, divisao ou multiplicacao?: ");
    string val = Console.ReadLine();

    string a = System.Convert.ToString(val);


    string soma = "soma";
    string subtracao = "subtracao";
    string divisao = "divisao";
    string multi = "multiplicacao";


    if (a == soma)
    {
        Console.Write("[2] Qual o primeiro número? ");
        string primeira = Console.ReadLine();

        Console.Write("[3] Qual o segundo número? ");
        string segundo = Console.ReadLine();

        int numero1 = System.Convert.ToInt32(primeira);
        int numero2 = System.Convert.ToInt32(segundo);


            Console.WriteLine(numero1 + numero2);


      
    }

    if (a == subtracao)
    {
        Console.Write("[2] Qual o primeiro número? ");
        string primeira = Console.ReadLine();

        Console.Write("[3] Qual o segundo número? ");
        string segundo = Console.ReadLine();

        int numero1 = System.Convert.ToInt32(primeira);
        int numero2 = System.Convert.ToInt32(segundo);

        Console.WriteLine(numero1 - numero2);

    }

    if (a == divisao)
    {
        Console.Write("[2] Qual o primeiro número? ");
        string primeira = Console.ReadLine();

        Console.Write("[3] Qual o segundo número? ");
        string segundo = Console.ReadLine();

        int numero1 = System.Convert.ToInt32(primeira);
        int numero2 = System.Convert.ToInt32(segundo);

        Console.WriteLine(numero1 / numero2);

    }

    if (a == multi)
    {
        Console.Write("[2] Qual o primeiro número? ");
        string primeira = Console.ReadLine();

        Console.Write("[3] Qual o segundo número? ");
        string segundo = Console.ReadLine();

        int numero1 = System.Convert.ToInt32(primeira);
        int numero2 = System.Convert.ToInt32(segundo);

        Console.WriteLine(numero1 * numero2);

    }
    }
}
