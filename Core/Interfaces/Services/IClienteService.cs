﻿using Core.Dtos;
using Core.Entities;

namespace Core.Interfaces.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAll(DateTime? fecha);
        Task<List<Motivo>> GetAllMotivo();
        Task<Cliente> AddCliente(Cliente cliente);
    }
}
