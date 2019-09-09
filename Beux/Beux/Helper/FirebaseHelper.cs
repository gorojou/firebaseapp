using Beux.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beux.Helper
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://upick-app-c921d.firebaseio.com/");

        

        public async Task<List<Person>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OrderByKey()
              .OnceAsync<Person>()).Select(item => new Person
              {
                  Uid = item.Object.Uid,
                  Nickname = item.Object.Nickname,
                  Email = item.Object.Email,
                  Celular = item.Object.Celular,
                  CodPromocional = item.Object.CodPromocional,
                  Genero = item.Object.Genero,
                  Password = item.Object.Password,
                  MayorEdad = item.Object.MayorEdad,
                  TermConds = item.Object.TermConds,
                  TipoPersona = item.Object.TipoPersona,
                  StatusPersona =item.Object.StatusPersona,
                  CitaSolicitud = item.Object.CitaSolicitud
              }).ToList();
        }

        public async Task AddPerson(string uid, string nickname, string email,  string celular, string codPromocional, string genero, string password, string mayorEdad, string termConds, string tipopersona, string statuspersona, string citasolicitud)
        {

            await firebase
              .Child("Persons")
              .PostAsync(new Person() {Uid = uid, Nickname = nickname, Email=email, Celular=celular, CodPromocional= codPromocional, Genero=genero, Password=password, MayorEdad="true", TermConds="true", TipoPersona = tipopersona, StatusPersona = statuspersona, CitaSolicitud = citasolicitud });
        }
        public async Task<List<Person>> GetPersonListClientes()
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<Person>();
            return allPersons.Where(a => a.TipoPersona == "C" && a.CitaSolicitud=="S").ToList();


        }
        public async Task<Person> GetPersonCliente()
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<Person>();
            return allPersons.Where(a => a.TipoPersona == "C" && a.CitaSolicitud == "S").FirstOrDefault();


        }
        public async Task FacturaPersonTotal(string uid)
        {
            Person person = await GetPerson(uid);

            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Uid == uid).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Person()
              {
                  Uid = person.Uid,
                  Nickname = person.Nickname,
                  Email = person.Email,
                  Celular = person.Celular,
                  CodPromocional = person.CodPromocional,
                  Genero = person.Genero,
                  Password = person.Password,
                  MayorEdad = person.MayorEdad,
                  TermConds = person.TermConds,
                  TipoPersona = person.TipoPersona,
                  StatusPersona = person.StatusPersona,
                  CitaSolicitud = person.CitaSolicitud,
                  ValorHora = person.TipoCita,
                  TipoCita = person.TipoCita
              });
        }
        public async Task ActivacionPerson(string uid, string vhora, string tcita)
        {
            Person person = await GetPerson(uid);

            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Uid == uid).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Person() {Uid= person.Uid, Nickname = person.Nickname,
                  Email = person.Email, Celular = person.Celular,
                  CodPromocional = person.CodPromocional, Genero = person.Genero,
                  Password = person.Password, MayorEdad = person.MayorEdad,
                  TermConds = person.TermConds, TipoPersona = person.TipoPersona,
                  StatusPersona = "A" ,
                  CitaSolicitud = person.CitaSolicitud,
                  ValorHora = vhora,
                  TipoCita = tcita
              });
        }
        public async Task DesactivacionPerson(string uid, string vhora, string tcita)
        {
            Person person = await GetPerson(uid);

            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Uid == uid).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Person()
              {
                  Uid = person.Uid,
                  Nickname = person.Nickname,
                  Email = person.Email,
                  Celular = person.Celular,
                  CodPromocional = person.CodPromocional,
                  Genero = person.Genero,
                  Password = person.Password,
                  MayorEdad = person.MayorEdad,
                  TermConds = person.TermConds,
                  TipoPersona = person.TipoPersona,
                  StatusPersona = "I",
                  CitaSolicitud = person.CitaSolicitud,
                  ValorHora = vhora,
                  TipoCita = tcita
              });
        }

        public async Task<Person> GetPerson(string uid)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<Person>();
            return allPersons.Where(a => a.Uid == uid ).FirstOrDefault();
             
            
        }

        public async Task UpdatePerson( string uid)
        {
            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Uid == uid).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Person() {  Uid = uid });
        }

        public async Task DeletePerson(string uid)
        {
            var toDeletePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Uid == uid).FirstOrDefault();
            await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

        }
    }
}

