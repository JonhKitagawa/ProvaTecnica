using System;

Console.WriteLine("Exercício 2");

/**
 * 2) Com base no código abaixo, realize a validação dos dados que estão sendo recebidos.
 * 
 * As regras a serem utilizadas:
 * * Nome não pode ser vazio e deve ter até 100 caracteres
 * * Idade deve ser um dígito numérico inteiro e positivo
 * * Data de nascimento deve ser uma data válida no formato dia/mês/ano e deve ser uma data no passado
 * 
 * As validações devem ser seguras em relação a não permitir o encerramento do programa de maneira abrupta por Exceptions, de forma
 * que qualquer dado inválido deve resultar numa mensagem via Console.WriteLine() para o usuário.
 * 
 * As validações devem ser feitas apenas após o recebimento de todos os dados e deve ser exibido, linha a linha, o resultado da 
 * validação, seja informando um erro de validação ou um sucesso de que o dado é válido.
 * 
 * Exemplo de saída esperada:
 * 
 * Preencha o nome:
 * Preencha a idade:
 * Preencha a data de nascimento:
 * 
 * Resultados da validação
 * 
 * Nome válido!
 * Idade não é um número positivo (-5)
 * Data de nascimento não pode ser uma data no futuro (01/04/2202)
*/

Console.WriteLine("Preencha o nome:");
string entradaNome = Console.ReadLine();

Console.WriteLine("Preencha a idade:");
string entradaIdade = Console.ReadLine();

Console.WriteLine("Preencha a data de nascimento:");
string entradaDataNascimento = Console.ReadLine();

Console.WriteLine($"{Environment.NewLine}Resultados da validação {Environment.NewLine}");


