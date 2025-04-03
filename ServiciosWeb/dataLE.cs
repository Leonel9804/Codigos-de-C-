using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace WebServiceL
{
    public class dataLE
    {
        private string connectionString = @"Data Source=LEO\IPNLEONEL;Initial Catalog=WSL;User ID=sa;Password=Leoprogramando";

        // CREATE
        public Informe AddInforme(string usuario, string evento, string lugar)
        {
            Informe nuevoInforme = new Informe
            {
                Usuario = usuario,
                evento = evento,
                fecha = DateTime.Now,
                lugar = lugar
            };

            using (DataContext db = new DataContext(connectionString))
            {
                db.GetTable<Informe>().InsertOnSubmit(nuevoInforme);
                db.SubmitChanges();
            }

            return nuevoInforme;
        }

        // READ ALL
        public List<Informe> GetAllInformes()
        {
            using (DataContext db = new DataContext(connectionString))
            {
                return db.GetTable<Informe>().ToList();
            }
        }

        // UPDATE
        public bool UpdateInforme(int id, string usuario, string evento, string lugar)
        {
            using (DataContext db = new DataContext(connectionString))
            {
                var informe = db.GetTable<Informe>().FirstOrDefault(i => i.id == id);
                if (informe == null)
                {
                    return false;
                }

                informe.Usuario = usuario;
                informe.evento = evento;
                informe.lugar = lugar;

                db.SubmitChanges();
                return true;
            }
        }

        // DELETE
        public bool DeleteInforme(int id)
        {
            using (DataContext db = new DataContext(connectionString))
            {
                var informe = db.GetTable<Informe>().FirstOrDefault(i => i.id == id);
                if (informe == null)
                {
                    return false;
                }

                db.GetTable<Informe>().DeleteOnSubmit(informe);
                db.SubmitChanges();
                return true;
            }
        }

    }
}