using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;
using System;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FrmMediaTek86
    /// </summary>
    public class FrmMediaTek86Controller
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmMediaTek86Controller()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
            motifAccess = new MotifAccess();
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences d'un personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <returns>liste des absences d'un personnel</returns>
        public List<Absences> GetLesAbsences(int idpersonnel)
        {
            return absenceAccess.GetLesAbsences(idpersonnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absences absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="ancienneDateDebut">Permet de retrouver l'absence</param>
        public void UpdateAbsence(Absences absence, DateTime ancienneDateDebut)
        {
            absenceAccess.UpdateAbsence(absence, ancienneDateDebut);
        }

        /// <summary>
        /// Demande de suppression d'une absence d'un personnel
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absences absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Controle si une absence est déjà programmée à cette période
        /// </summary>
        /// <param name="absence">objet absence à controler</param>
        /// <param name="newDateDebut">nouvelle date de début</param>
        /// <param name="newDateFin">nouvelle date de fin</param>
        /// <param name="modifAbsence">statut de la gestion des absences</param>
        /// <returns>true si une absence est déjà programmée</returns>
        /// <returns>false si une absence n'est pas encore programmée</returns>
        public bool ControleAbsence(Absences absence, DateTime newDateDebut, DateTime newDateFin, Boolean modifAbsence)
        {
            return absenceAccess.ControleAbsence(absence, newDateDebut, newDateFin, modifAbsence);
        }
    }
}

