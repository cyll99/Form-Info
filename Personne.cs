﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Nom: Larose
/// Prenom : Christ-Yan Love
/// </summary>
namespace Etudiants
{
   
    class Personne
    {
        DateTime now = DateTime.Now;

        String _nom, _prenom1, _prenom2, _nationalite, _adresseRue, _ville, _pays, _telephone, _dateCree;
        int _age;

        // Constructeur avec toutes les proprietes
        public Personne(string nom, string prenom1, string prenom2, int age, string nationalite, string adresseRue, string ville, string pays, string telephone, string dateCree)
        {
            this.Nom = nom;         
            this.Prenom1 = prenom1;
            this.Prenom2 = prenom2;  
            this.Age = age;
            this.Nationalite = nationalite;
            this.AdresseRue = adresseRue;
            this.Ville = ville;
            this.Pays = pays;
            this.Telephone = telephone;
            this.DateCree = dateCree;
        }

        // Deuxieme constructeur
        public Personne(string nom, string prenom1, string prenom2, int age)
        {
            this.Nom = nom;
            this.Prenom1 = prenom1;
            this.Prenom2 = prenom2;
            this.Age = age;
        }

        /// <summary>
        /// Methode to capitalize a string
        /// </summary>
        /// <param name="word"></param>
        /// <returns>A string capitalized </returns>
        private string capitalize(string word) => (char.ToUpper(word[0]) + word.Substring(1));

        public String Nom
        {
            get => _nom;
            set => _nom = capitalize(value);

        }

        public String Prenom1
        {
            get => _prenom1;
            set
            {   if (value.Length != 0)
                    _prenom1 = capitalize(value);
                else
                    _prenom1 = "";
            }

        }

        public String Prenom2
        {
            get => _prenom2;
            set
            {
                if (value.Length != 0)
                    _prenom2 = capitalize(value);
                else
                    _prenom2 = "";
            }

        }

        public int Age
        {
            get => _age;
            set
            {
                if (0 < value && value < 150)
                    _age = value;
                else
                    _age = -1;

            }
        }

        public String Nationalite
        {
            get => _nationalite;
            set => _nationalite = capitalize(value);

        }

        public String AdresseRue
        {
            get => _adresseRue;
            set => _adresseRue = capitalize(value);

        }

        public String Ville
        {
            get => _ville;
            set => _ville = capitalize(value);

        }

        public String Pays
        {
            get => _pays;
            set => _pays = capitalize(value);

        }


        public String Telephone
        {
            get => _telephone;
            set => _telephone = capitalize(value);

        }

        public String DateCree
        {


            get => _dateCree;
            set => _dateCree = ($"{now.Day} / {now.Month} / {now.Year}");

        }

        // Methode to display full name
        public String ToString() => ($"{_prenom1} {_prenom2} {_nom}");






    }
}

