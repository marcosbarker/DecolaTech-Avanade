using System;

namespace revisao01
{
    class Program
    {
        static void Main(string[] args)
    {
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X") ;
      { //ToUpper compara caixa baixa e alta
        switch (opcaoUsuario)
        {

          case "1": //adicionar aluno
            break;

          case "2": //listar alunos   
            break;

          case "3": //calcular media
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
        
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine("Informe a opção desejada:");
      Console.WriteLine("1-Inserir novo aluno");
      Console.WriteLine("2-Listar alunos");
      Console.WriteLine("3-Calcular média geral");
      Console.WriteLine("X-Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();
      return opcaoUsuario;
    }
  }
}