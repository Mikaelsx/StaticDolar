// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using DolarEstatico;

Console.Clear();

Converse v3 = new Converse();

Console.WriteLine(@$"
Olá, bem vindo ao convertor de moeda selecione a opção desejada:
1 - Converter real pra dolar
2 - Converter dolar pra real
3 - Sair");
Console.WriteLine($"");
v3.selection = Console.ReadLine()!;
Console.WriteLine($"");

        

    switch (v3.selection)
    {
        case "1":
        Console.WriteLine($"Qual o valor que vai ser convertido ?");
        Console.WriteLine($"");
        v3.varum = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"");
        
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine($"O valor do dolar é {Converse.RealPraDolar(v3.varum)}");
        Console.ResetColor();
        break;

        case "2":
        Console.WriteLine($"Qual o valor que vai ser convertido ?");
        Console.WriteLine($"");
        v3.vardois = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"");
        
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine($"O valor convertido para real é {Converse.DolarPraReal(v3.vardois)}");
        Console.ResetColor();
        break;

        case "3":
        Console.ForegroundColor=ConsoleColor.Yellow;
        Console.WriteLine($"Aplicação encerrada");
        Console.ResetColor();
        break;

        default:
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine($"Inválido");
        Console.ResetColor();
        break;
    }
        

