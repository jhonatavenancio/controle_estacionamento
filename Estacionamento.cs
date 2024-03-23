using System;

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      // Solicite ao usuário que digite o nome do teste:
      string nomeDoTeste = Console.ReadLine();

      // Solicite ao usuário que digite a descrição do erro:
      string descricaoDoErro = Console.ReadLine();

      // Se o teste falhar, exibe a descrição do erro:
      Console.WriteLine($"O teste falhou. Descrição: {descricaoDoErro}");
    }
  }
}
