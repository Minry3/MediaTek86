﻿using System;
using System.Collections.Generic;
using MediaTek86.model;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        ///<summary>
        ///Instance unique de l'accès aux données
        ///</summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// récupère et retourne les absences du personnel
        /// </summary>
        /// <param name="idpersonnel">l'identifiant du personnel</param>
        /// <returns>liste des absences du personnel</returns>
        public List<Absences> GetLesAbsences(int idpersonnel)
        {
            List<Absences> lesAbsences = new List<Absences>();
            if (access.Manager != null)
            {
                string req = "select a.datedebut as 'date début', a.datefin as 'date fin', p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service, m.idmotif as idmotif, m.libelle as motif ";
                req += "from absence a ";
                req += "join motif m on (a.idmotif = m.idmotif) ";
                req += "join personnel p on (a.idpersonnel = p.idpersonnel) ";
                req += "join service s on (p.idservice = s.idservice) ";
                req += "where a.idpersonnel = " + idpersonnel + ";";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if(records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[6], (string)record[7]);
                            Personnel personnel = new Personnel(idpersonnel, (string)record[2], (string)record[3], (string)record[4], (string)record[5], service);
                            Motif motif = new Motif((int)record[8], (string)record[9]);
                            Absences absence = new Absences(personnel, (DateTime)record[0], (DateTime)record[1], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
    }
}
