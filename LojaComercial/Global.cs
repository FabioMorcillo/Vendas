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

        public static Form MainForm
        {
            get { return mainForm; }
            set { mainForm = value; }
        }

    }
}
