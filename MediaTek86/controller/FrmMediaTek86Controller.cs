using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;


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

        public List<Absences> GetlesAbsences(int idpersonnel)
        {
            return absenceAccess.GetLesAbsences(idpersonnel);
        }



    }
}
