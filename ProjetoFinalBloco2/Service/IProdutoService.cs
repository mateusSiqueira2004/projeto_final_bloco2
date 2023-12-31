﻿using ProjetoFinalBloco2.Model;

namespace ProjetoFinalBloco2.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAll();

        Task<Produto?> GetById(long id);

        Task<IEnumerable<Produto>> GetByNome(string nome);
      
        Task<IEnumerable<Produto>> GetByPreco(decimal preco);

        Task<Produto?> Create(Produto produto);

        Task<Produto?> Update(Produto produto);

        Task Delete(Produto produto);

    }
}
