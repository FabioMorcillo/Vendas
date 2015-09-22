using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaComercial
{
    static class Global
    {
        private static Form mainForm;
        private static Operador operador;

        private static Produto produto;
              
        
        public static Form MainForm
        {
            get { return mainForm; }
            set { mainForm = value; }
        }

        public static Operador Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public static Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }
    }
}
