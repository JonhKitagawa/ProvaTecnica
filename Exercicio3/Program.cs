using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Exercício 3");

/**
 * 3) Considere a classe Solicitacao definida ao final do arquivo e complete os métodos do código abaixo para retornarem 
 * dados específicos da lista de solicitação, conforme os filtros especificados.
 * 
 * O método RetornarTotalSolicitacoesCriadasEntre() deve retornar o total de solicitações com a data de criação entre 
 * duas datas que podem ou não serem passadas (null)
 * 
 * O método RetornarSolicitacoesCriadasEntre() deve retornar uma lista de objetos de solicitação com a data de criação entre 
 * duas datas que podem ou não serem passadas (null)
 * 
 * O método RetornarSolicitacoesAbertas() deve retornar uma lista de objetos de solicitação que não possuam data de encerramento (null)
*/

var solicitacoes = new List<Solicitacao>
{
    new Solicitacao(1, new DateTime(2022, 02, 10, 13, 30, 22), new DateTime(2022, 02, 11, 10, 26, 57)),
    new Solicitacao(2, new DateTime(2022, 02, 11, 09, 37, 31), null),
    new Solicitacao(3, new DateTime(2022, 02, 11, 09, 38, 19), new DateTime(2022, 03, 25, 17, 42, 03)),
    new Solicitacao(4, new DateTime(2022, 02, 11, 09, 38, 20), new DateTime(2022, 03, 03, 15, 49, 29)),
    new Solicitacao(5, new DateTime(2022, 02, 11, 09, 38, 21), null),
};

DateTime? dataInicial = new DateTime(2022, 02, 11);
DateTime? dataFinal = null;

var totalSolicitacoesFiltradas = RetornarTotalSolicitacoesCriadasEntre(solicitacoes, dataInicial, dataFinal);
Console.WriteLine($"Total de Solicitações Filtradas: {totalSolicitacoesFiltradas}");

var listaSolicitacoesFiltradas = RetornarSolicitacoesCriadasEntre(solicitacoes, DateTime.Now.AddMonths(-1), DateTime.Now);
Console.WriteLine($"Solicitações entre {dataInicial?.ToString("dd/MM/yyyy HH:mm:ss") ?? "NULO"} e {dataFinal?.ToString("dd/MM/yyyy HH:mm:ss") ?? "NULO"}: {string.Join(", ", listaSolicitacoesFiltradas.Select(x => x.NumeroProtocolo).ToArray())}");

var listaSolicitacoesAbertas = RetornarSolicitacoesAbertas(solicitacoes);
Console.WriteLine($"Solicitações abertas: {string.Join(", ", listaSolicitacoesFiltradas.Select(x => x.NumeroProtocolo).ToArray())}");

/// <summary>
/// Método deve retornar o total de solicitações encontradas com Data de Criação entre as datas passadas
/// </summary>
/// <param name="solicitacoes"></param>
/// <param name="dataInicial"></param>
/// <param name="dataFinal"></param>
/// <returns></returns>
int RetornarTotalSolicitacoesCriadasEntre(List<Solicitacao> solicitacoes, DateTime? dataInicial, DateTime? dataFinal)
{
    return 0;
}

/// <summary>
/// Método deve retornar apenas solicitações com Data de Criação entre as datas passadas
/// </summary>
/// <param name="solicitacoes"></param>
/// <param name="dataInicial"></param>
/// <param name="dataFinal"></param>
/// <returns></returns>
List<Solicitacao> RetornarSolicitacoesCriadasEntre(List<Solicitacao> solicitacoes, DateTime? dataInicial, DateTime? dataFinal)
{
    return new List<Solicitacao>();
}

/// <summary>
/// Método deve retornar apenas solicitações que não possuam Data de Encerramento
/// </summary>
/// <param name="solicitacoes"></param>
/// <returns></returns>
List<Solicitacao> RetornarSolicitacoesAbertas(List<Solicitacao> solicitacoes)
{
    return new List<Solicitacao>();
}

public record Solicitacao(int NumeroProtocolo, DateTime DataCriacao, DateTime? DataEncerramento);
