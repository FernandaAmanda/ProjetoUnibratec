using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class EstadoSenhaMap : EntityTypeConfiguration<EstadoSenha>
    {
        public EstadoSenhaMap()
        {
            //Chave Primária
            HasKey(es => es.IDEstado);
        }
    }
}
