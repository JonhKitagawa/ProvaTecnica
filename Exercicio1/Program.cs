using System;

Console.WriteLine("Exercício 1");

/*
 * 1) A partir do código a seguir, esse projeto deve ser capaz de receber uma lista de números via argumentos de linha de comando
 * e passá-lo para o método SomaNumerosPares(). Esse método deve ser alterado para retornar o valor resultante da soma dos números 
 * pares lidos pela entrada.
 *
 */

// via a variável "args", temos acesso aos argumentos da linha de comando enviados
var argumentos = args;

// esse array deve ser preenchido com os valores passados via argumentos de linha de comando
var arrayNumeros = new int[] { };

var soma = SomaNumerosPares(arrayNumeros);

Console.WriteLine($"A soma dos valores é: {soma}");

/// <summary>
/// Método criado para somar todos os números pares encontrados na lista de entrada
/// </summary>
/// <param name="arrayNumeros"></param>
/// <returns></returns>
static long SomaNumerosPares(int[] arrayNumeros)
{
    return 0;
}
