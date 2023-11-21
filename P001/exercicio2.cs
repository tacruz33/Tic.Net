
// Resolução da Atividade P001 - Tales de Araujo CRuz 


//Questão 1 - 

/*Para verificar se eles estar corretamente instalado, use o comando  : */  dotnet --version

/*Para verificar as versões .NET SDK instaladas no seu ambiente, use o comando : */ dotnet --list-sdks 





// Questão 2 - Tipo de Dados

//  Inteiro - Exemplo :
int numeroInteiro = 42;

// Long.Exemplo :
long numeroLongo = 123456789012345;

// Short - Exemplo :
short numero = 1000;


/*Questão 3 - Abaixo um codigo que mostra a a variável numeroDouble é do tipo double com o valor 7.8. 
Ao converter para int usando (int)numeroDouble, a parte fracionária 0.8 é truncada, resultando em 7.
*/
class Program
{
    static void Main()
    {
        // Definindo uma variável double
        double numeroDouble = 7.8;

        // Convertendo double para int
        int numeroInteiro = (int)numeroDouble;

        // Exibindo os resultados
        Console.WriteLine("Número Double: " + numeroDouble);
        Console.WriteLine("Número Inteiro após conversão: " + numeroInteiro);

        Console.ReadLine();
    }
}
/*Ao final ela mostrará :
Número Double: 7.8
Número Inteiro após conversão: 7 */

// Questão 4 -  Abaixo um exemplo onde é feito as quatro operações básicas da matemática.

using System;

class Operações 
{
    static void Main()
    {
        // Definindo as variáveis
        int x = 10;
        int y = 3;

        // Adição
        int soma = x + y;
        Console.WriteLine("Adição: " + soma);

        // Subtração
        int subtracao = x - y;
        Console.WriteLine("Subtração: " + subtracao);

        // Multiplicação
        int multiplicacao = x * y;
        Console.WriteLine("Multiplicação: " + multiplicacao);

        // Divisão
        // Nota: Divisão de inteiros resulta em um quociente inteiro
        int divisao = x / y;
        Console.WriteLine("Divisão: " + divisao);

        Console.ReadLine();
    }
}

// Questão 5 -  No exemplo abaixa a condição e avaliada  diretamente na linha Console.WriteLine e ao final exibir :


using System;

class Program
{
    static void Main()
    {
        
        int a = 5;
        int b = 8; 
        Console.WriteLine("a é maior que b? " + (a > b));

        Console.ReadLine();
    }
}
/* NO final exibido : */  a é maior que b? False

/* Questão 6-  Neste exemplo, a expressão (str1 == str2) é diretamente usada dentro do método Console.WriteLine, 
eliminando a necessidade de uma variável intermediária. O programa mostrará:*/

using System;

class Iguais
{
    static void Main()
    {
       
        string str1 = "Hello";
        string str2 = "World";

        // Verificando se as strings são iguais e exibindo o resultado
        bool saoIguais = str1 == str2;
        Console.WriteLine("As strings são iguais? " + saoIguais);

        Console.ReadLine();
    }
}

// Questão 7 - 

using System;

class Condicoes
{
    static void Main()
    {
        // Definindo as variáveis booleanas
        bool condicao1 = true;
        bool condicao2 = false;

        // Verificando se ambas as condições são verdadeiras e exibindo o resultado
        bool ambasVerdadeiras = condicao1 && condicao2;
        Console.WriteLine("Ambas as condições são verdadeiras? " + ambasVerdadeiras);

        Console.ReadLine();
    }
}

/*Questão 8 - Neste exemplo, as expressões num1 > num2 e num3 == num1 + num2 são avaliadas, 
e os resultados são armazenados nas variáveis condicao1 e condicao2, respectivamente*/

using System;

class Condicoes
{
    static void Main()
    {
        // Definindo as variáveis
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        // Verificando as condições
        bool condicao1 = num1 > num2;
        bool condicao2 = num3 == num1 + num2;

        // Exibindo os resultados
        Console.WriteLine("num1 é maior do que num2? " + condicao1);
        Console.WriteLine("num3 é igual a num1 + num2? " + condicao2);

        Console.ReadLine();
    }
}
// Ao final mostrará :
num1 é maior do que num2? True
num3 é igual a num1 + num2? True














