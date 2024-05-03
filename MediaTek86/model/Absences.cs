using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Absences
    /// </summary>
    public class Absences
    {
        public Personnel Personnel { get; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Motif Motif { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absences(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Personnel = personnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
        }
    }
}
