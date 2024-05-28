using System;
using System.Collections.Generic;
using MediaTek86.model;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant le responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Contrôle si l'utilisateur a le droit de se connecter (login et pwd)
        /// </summary>
        /// <param name="responsable">objet responsable a contrôler</param>
        /// <returns>true si l'utilisateur peut se connecter</returns>
        /// <returns>false si l'utilisateur ne peut pas se connecter</returns>
        public Boolean ControleConnexion(Responsable responsable)
        {
            if(access.Manager != null)
            {
                string req = "select * from responsable r ";
                req += "where r.login=@login and r.pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.Login);
                parameters.Add("@pwd", responsable.Pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}
