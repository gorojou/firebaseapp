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
              .OnceAsync<Person>()).Select(item => new Person
              {
                  Nickname = item.Object.Nickname,
                  Email = item.Object.Email,
                  Celular = item.Object.Celular,
                  CodPromocional = item.Object.CodPromocional,
                  Genero = item.Object.Genero,
                  Password = item.Object.Password,
                  MayorEdad = item.Object.MayorEdad,
                  TermConds = item.Object.TermConds
              }).ToList();
        }

        public async Task AddPerson(string nickname, string email,  string celular, string codPromocional, string genero, string password, bool mayorEdad, bool termConds)
        {

            await firebase
              .Child("Persons")
              .PostAsync(new Person() { Nickname = nickname, Email=email, Celular=celular, CodPromocional= codPromocional, Genero=genero, Password=password, MayorEdad=true, TermConds=true });
        }

        public async Task<Person> GetPerson(string nickname)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<Person>();
            return allPersons.Where(a => a.Nickname == nickname).FirstOrDefault();
        }

        public async Task UpdatePerson( string nickname)
        {
            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Nickname == nickname).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Person() {  Nickname = nickname });
        }

        public async Task DeletePerson(string nickname)
        {
            var toDeletePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Nickname == nickname).FirstOrDefault();
            await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

        }
    }
}

