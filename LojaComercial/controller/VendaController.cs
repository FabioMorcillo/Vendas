using LojaComercial.dao;
using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.controller
{
    static class VendaController
    {
        public static Boolean cadastrar(Venda venda)
        {
            VendaDao vendaDao = null;
            Boolean resultado = false;

            try
            {
                vendaDao = new VendaDao();

                resultado = vendaDao.cadastrar(venda);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (vendaDao != null)
                {
                    vendaDao.close();
                }
            }

            return resultado;
        }
        public static int numeroUltimaNota()
        {
            VendaDao vendaDao = null;
            int resultado = -1;

            try
            {
                vendaDao = new VendaDao();

                resultado = vendaDao.numeroUltimaNota();
            }
            catch
            {
                resultado = -1;
            }
            finally
            {
                if (vendaDao != null)
                {
                    vendaDao.close();
                }
            }

            return resultado;
        }
    }
}
