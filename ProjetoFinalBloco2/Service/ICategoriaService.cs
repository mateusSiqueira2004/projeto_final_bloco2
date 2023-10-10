﻿using ProjetoFinalBloco2.Model;

namespace ProjetoFinalBloco2.Service
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAll();

        Task<Categoria?> GetById(long id);

        Task<IEnumerable<Categoria>> GetByTipo(string tipo);

        Task<Categoria?> Create(Categoria categoria);

        Task<Categoria?> Update(Categoria categoria);

        Task Delete(Categoria categoria);
    }
}
