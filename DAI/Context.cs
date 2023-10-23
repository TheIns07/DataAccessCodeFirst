using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAI
{
    public class Context : DbContext
    {
        public Context() : base("exampleDB") {
            //Crear base de datos si esta no existe
            //Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());

            //Crear si el modelo de la base de datos cambia
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());

            //Borra y crea una nueva base de datos (preferente en la creación de las clases modelos)
            //Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
        }
    }
}
