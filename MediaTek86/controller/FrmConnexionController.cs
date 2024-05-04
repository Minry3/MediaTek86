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
        private readonly ResponsableAccess responsableAccess;

        public FrmConnexionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        public Boolean ControleConnexion(Responsable responsable)
        {
            return responsableAccess.ControleConnexion(responsable);
        }
    }
}
