using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// getter sur Idpersonnel
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// getter et setter sur Nom
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// getter et setter sur Prenom
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// getter et setter sur Tel
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// getter et setter sur Mail
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// getter et setter sur Service
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }
    }
}

