using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Crud_operation.Contexts.Crud
{
    public partial class CrudContext : DbContext
    {
        internal object simpleCruds;

        public CrudContext()
            : base("name=CrudContext")
        {
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
