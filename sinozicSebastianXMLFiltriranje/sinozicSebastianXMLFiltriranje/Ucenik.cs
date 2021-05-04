using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianXMLFiltriranje
{
    class Ucenik
    {
        string Ime, Prezime, Email, Razred;
        public Ucenik(string ime,string prezime,string email,string razred)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Razred = razred;
        
        }

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Razred1 { get => Razred; set => Razred = value; }
    }
}
