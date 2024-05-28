using System;
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
                    if (records != null)
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

        /// <summary>
        /// Demande de suppression d'une absence d'un personnel
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absences absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.DateDebut);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absences absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.DateDebut);
                parameters.Add("@datefin", absence.DateFin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absences absence, DateTime ancienneDateDebut)
        {
            if (access.Manager != null)
            {
                string req = "update absence set idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @anciennedatedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.DateDebut);
                parameters.Add("@datefin", absence.DateFin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                parameters.Add("@anciennedatedebut", ancienneDateDebut);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Controle si une absence est déjà programmée à cette période
        /// </summary>
        /// <param name="absence">objet absence à controler</param>
        /// <param name="newDateDebut">nouvelle date de début</param>
        /// <param name="newDateFin">nouvelle date de fin</param>
        /// <param name="modifAbsence">statut de la gestion des absences</param>
        /// <returns></returns>
        public bool ControleAbsence(Absences absence, DateTime newDateDebut, DateTime newDateFin, Boolean modifAbsence)
        {
            List<Absences> lesAbsences = GetLesAbsences(absence.Personnel.Idpersonnel);

            foreach (Absences uneAbsence in lesAbsences)
            {
                if (uneAbsence != absence && (
                    (newDateDebut >= uneAbsence.DateDebut && newDateDebut <= uneAbsence.DateFin) ||
                    (newDateFin >= uneAbsence.DateDebut && newDateFin <= uneAbsence.DateFin) ||
                    (newDateDebut <= uneAbsence.DateDebut && newDateFin >= uneAbsence.DateFin)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}