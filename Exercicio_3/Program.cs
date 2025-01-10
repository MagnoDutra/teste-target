using System.Text.Json;
using System.Text.Json.Serialization;
using Exercicio_3.Data;

string filePath = "Data/dados.json";

string json = File.ReadAllText(filePath);
var faturamentoList = JsonSerializer.Deserialize<List<Faturamento>>(json);

if (faturamentoList == null || faturamentoList.Count == 0)
{
  System.Console.WriteLine("Não há dados disponíveis");
}