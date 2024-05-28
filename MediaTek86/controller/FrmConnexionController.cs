using System;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FrmConnexion
    /// </summary>
    class FrmConnexionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmConnexionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Contrôle si l'utilisateur a le droit de se connecter (login et pwd)
        /// </summary>
        /// <param name="responsable">objet responsable a contrôler</param>
        /// <returns>true si l'utilisateur peut se connecter</returns>
        /// <returns>false si l'utilisateur ne peut pas se connecter</returns>
        public Boolean ControleConnexion(Responsable responsable)
        {
            return responsableAccess.ControleConnexion(responsable);
        }
    }
}
