using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExamenIIIParcialYadia.Models;
using SQLite;

namespace ExamenIIIParcialYadia.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<CPagos>().Wait();
        }

        public Task<int> SavePersona(CPagos person)
        {
            if (person.Idpago != 0)
            {
                return db.UpdateAsync(person);
                ;
            }
            else
            {
                return db.InsertAsync(person);
            }
        }
       
        public Task<List<CPagos>> GetPersonasAync()
        {
            return db.Table<CPagos>().ToListAsync();
        }
       
        public Task<CPagos> GetPersonaByIdAsync(int person)
        {
            return db.Table<CPagos>().Where(a => a.Idpago == person).FirstOrDefaultAsync();
        }

        public Task<int> Grabarpersona(CPagos person)
        {
            if (person.Idpago !=0)
            {
                return db.UpdateAsync(person);
            }
            else
            {
                return db.InsertAsync(person);
            }    
        }

        public Task<int> DropPersonaAsync(CPagos person)
        {
            return db.DeleteAsync(person);
        }


    }
}
