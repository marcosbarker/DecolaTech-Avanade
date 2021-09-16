using apiCatalogoJogosDio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiCatalogoJogosDio.Repositories
{
    public interface IJogoRepository : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<Jogo> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Remover(Guid id);
        Task Atualizar(Jogo entidadeJogo);
    }
}
