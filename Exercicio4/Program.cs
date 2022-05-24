using System;

Console.WriteLine("Exercício 4");

/**
 * 4) Com base no código abaixo, crie a classe Cep de forma que ela possa completar o programa.
 * 
 * A regra de validação do CEP deve consistir em:
 * * a string deve ter apenas 8 caracteres numéricos
 * * não pode ter letras e outros tipos de caracteres, como espaço ou traço
 * 
 * A regra de formação do CEP deve ser de exibir o CEP no formato NNNNN-NNN (5 números + traço + 3 números)
 * 
 * Exemplo de entrada correta: 71060240
 * Exemplo de saída: O CEP 71060-240 é válido!
 * 
 * Exemplo de entrada incorreta: 38402-046
 * Exemplo de saída: CEP inválido!
*/

string entradaCep = Console.ReadLine();

if (!Cep.Validar(entradaCep, out Cep numeroCep))
{
    Console.WriteLine("CEP inválido!");
    return;
}

Console.WriteLine($"O CEP {numeroCep.Formatar()} é válido!");

public class Cep
{
    // Complete essa classe para que o código acima atenda ao exercício!
}