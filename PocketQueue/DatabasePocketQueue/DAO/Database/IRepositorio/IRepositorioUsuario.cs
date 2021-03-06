﻿using DatabasePocketQueue.DAO.Entidades;
using System.Collections.Generic;

namespace DatabasePocketQueue.DAO.Database.IRepositorio
{
    public interface IRepositorioUsuario
    {
        bool RemoverUsuario(Usuario usuario);
        bool InserirUsuario(Usuario usuario);
        List<Usuario> ListarUsuarios();
        List<Usuario> ListarUsuariosPorTipo(TipoUsuario tipoUsuario);
        bool AlterarUsuario(Usuario usuario);
        List<Usuario> ListarUsuariosCompleto();
    }
}
