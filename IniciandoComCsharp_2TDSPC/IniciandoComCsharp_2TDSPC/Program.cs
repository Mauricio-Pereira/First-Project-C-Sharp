// See https://aka.ms/new-console-template for more information

using IniciandoComCsharp_2TDSPC;

Console.WriteLine("Hello, World!"); // isso no java é System.out.println("Hello, World!");
//var textoDigitado = Console.ReadLine();
//Console.WriteLine(textoDigitado);

// tipos primittivos
var idade = 30;
var altura = 1.80;
var maiorDeIdade = true;
var nome = "Lucas";
var sexo = 'M';
var peso = 80.5f;
var salario = 1000.50m;
long populacao = 1000000000;
short quantidade = 10;
byte idadeEmMeses = 30;

/* tipos primitivos com null validation
 o ? no c# é para aceitar valores nulos, isso é uma novidade do c# 8,
 no java tem que usar o wrapper */

int? idadeNula = null;
bool? maiorDeIdadeNulo = null;

// tipos de string
var nome2 = "Leonardo";

var textoMutipliasLinhas = """
                            oi
                            meu nome é leonardo
                            esta aula é de c#
                           """;

var stringInterpolada = $"meu nome é {nome2}";


// operadores
var soma = 10 + 5;
var subtracao = 10 - 5;
var multiplicacao = 10 * 5;
var divisao = 10 / 5;
var resto = 10 % 5;
var incremento = soma++;
var decremento = soma--;

// operadores de comparação
var igual = 10 == 5;
var diferente = 10 != 5;
var maior = 10 > 5;
var menor = 10 < 5;
var maiorOuIgual = 10 >= 5;
var menorOuIgual = 10 <= 5;

// operadores lógicos
var e = true && false;
var ou = true || false;
var negacao = !true;

// estruturas condicionais
if(idade >=18)
    Console.WriteLine("é maior de idade");
else
    Console.WriteLine("é menor de idade");

// operador ternário
var verifcacaoMaioridade = idade >= 18 ? "é maior de idade" : "é menor de idade";
    
//switch case
switch (idade)
{
    case > 18:
        Console.WriteLine("é maior de idade");
        break;
    default:
        Console.WriteLine("não é maior de idade");
        break;
}

// estruturas de repetição
for(var i =0; i < 10; i++)
    Console.WriteLine($"iteração {i}");

// foreach range
foreach(var i in Enumerable.Range(0,10))
    Console.WriteLine($"iteração {i}");

var novoProduto = new Produto(1, "Iphone");
Console.WriteLine(novoProduto.ToString());
