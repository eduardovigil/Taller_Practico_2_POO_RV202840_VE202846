using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    public class Usuario
    {

        private String user;
        private String contra;

        private static List<Usuario> listaUsuarios = new List<Usuario>();

        public Usuario()
        {
        }

        public Usuario(string usuario, string contra)
        {
            this.User = usuario;
            this.Contra = contra;
        }

        public string User { get => user; set => user = value; }
        public string Contra { get => contra; set => contra = value; }
        public List<Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
    }
}
