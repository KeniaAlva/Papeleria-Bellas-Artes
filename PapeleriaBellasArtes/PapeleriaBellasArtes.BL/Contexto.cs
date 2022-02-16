using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapeleriaBellasArtes.BL
{
    public class Contexto: DbContext
    {
        //Conexion stream para la creacion de la BD//
        public Contexto(): base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PapeleriaBellasArtesDB.mdf")
        {
            

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)    //Evita que se pluralicen los nombres de las tablas//
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
