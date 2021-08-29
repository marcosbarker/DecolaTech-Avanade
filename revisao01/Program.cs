using System;

namespace revisao01
{
    class Program
    {
        static void Main(string[] args)
    {
    
      Aluno[] alunos = new Aluno[5];
      var indiceAluno = 0;

      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      { //ToUpper compara caixa baixa e alta
        switch (opcaoUsuario)
        {

          case "1": //adicionar aluno
            Console.Write("Informe o nome do Aluno: ");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.Write("Informe a nota do aluno: ");
        
            if (decimal.TryParse(Console.ReadLine(), out decimal nota)) {
                aluno.Nota = nota;
            
            } else {
                throw new ArgumentOutOfRangeException("Valor da nota deve ser decimal");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;
            break;

          case "2": //listar alunos   
            foreach (var a in alunos) {
                if (!string.IsNullOrEmpty(a.Nome)) {
                Console.Write($"Aluno: {a.Nome} - Nota: {a.Nota}\n");
                
                }
            }
           break;

          case "3": //calcular media
            decimal notaTotal = 0;
            var numAlunos = 0;

            for (int i = 0; i < alunos.Length; i++) {
                if (!string.IsNullOrEmpty(alunos[i].Nome)) {
                    notaTotal = notaTotal + alunos[i].Nota;
                    numAlunos++;
                }
            }

            var mediaGeral = notaTotal / numAlunos;
            ConceitoEnum conceitoGeral;

            if (mediaGeral < 2) {
                conceitoGeral = ConceitoEnum.E;

            } else if (mediaGeral < 4) {
                conceitoGeral = ConceitoEnum.D;

            } else if (mediaGeral < 6) {
                conceitoGeral = ConceitoEnum.C;

            } else if (mediaGeral < 8) {
                conceitoGeral = ConceitoEnum.B;
            
            } else {
                conceitoGeral = ConceitoEnum.A;
            }

            Console.Write($"Média Geral: {mediaGeral} e Conceito: {conceitoGeral}");
            Console.WriteLine();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
        
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("Informe a opção desejada:");
      Console.WriteLine("1-Inserir novo aluno");
      Console.WriteLine("2-Listar alunos");
      Console.WriteLine("3-Calcular média geral");
      Console.WriteLine("X-Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}