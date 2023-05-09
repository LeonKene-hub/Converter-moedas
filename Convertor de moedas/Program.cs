using Convertor_de_moedas;
using System.Globalization;

var regiaoUS = new RegionInfo("us");
var regiaoBR = new RegionInfo("pt-BR");

bool concluido = false;
string opcao;
double valor;
do
{

Console.WriteLine(@$"
===========================
|  Bem vindo ao convertor |
|        de moedas        |
|                         |
| Deseja converter:       |
|                         |
| (1) Dolar para Reais    |
| (2) Reais para Dolar    |
| (0) Sair                |
===========================
");
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Digite o valor em dolar:");
            valor = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{regiaoBR.CurrencySymbol} {Convertor.ConverterDolar(valor)}");
            break;

        case "2":
            Console.WriteLine($"Digite o valor em real:");
            valor = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{regiaoUS.CurrencySymbol} {Convertor.ConverterReal(valor)}");
            break;

        case "0":
            Console.WriteLine($"Até mais!");
            concluido = true;
            break;
        default:
            concluido = true;
            break;
    }
    Console.ReadLine();
    Console.Clear();

} while (concluido == false);