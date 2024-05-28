using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// getter sur Login
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// getter sur Pwd
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Valorise les priopriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
