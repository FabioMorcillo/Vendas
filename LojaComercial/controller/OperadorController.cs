using LojaComercial.dao;
using LojaComercial.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComercial.controller
{
    static class OperadorController
    {
        public static Boolean cadastrar(Operador operador)
        {
            OperadorDao operadorDao = null;
            Boolean resultado = false;

            try
            {
                operadorDao = new OperadorDao();

                resultado = operadorDao.cadastrar(operador);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (operadorDao != null)
                {
                    operadorDao.close();
                }
            }

            return resultado;
        }

        public static Boolean editar(Operador operador)
        {
            OperadorDao operadorDao = null;
            Boolean resultado = false;

            try
            {
                operadorDao = new OperadorDao();

                resultado = operadorDao.editar(operador);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (operadorDao != null)
                {
                    operadorDao.close();
                }
            }

            return resultado;
        }

        public static Boolean deletar(Operador operador)
        {
            OperadorDao operadorDao = null;
            Boolean resultado = false;

            try
            {
                operadorDao = new OperadorDao();

                resultado = operadorDao.deletar(operador);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (operadorDao != null)
                {
                    operadorDao.close();
                }
            }

            return resultado;
        }

        public static Boolean credencialValida(Operador operador)
        {
            OperadorDao operadorDao = null;
            Boolean resultado = false;

            try
            {
                operadorDao = new OperadorDao();

                resultado = operadorDao.credencialValida(operador);

                System.Diagnostics.Debug.WriteLine("Operador -> Tipo -> "+operador.Tipo);
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (operadorDao != null)
                {
                    operadorDao.close();
                }
            }

            return resultado;
        }

        public static List<Operador> lista()
        {
            OperadorDao operadorDao = null;
            List<Operador> resultado = null;

            try
            {
                operadorDao = new OperadorDao();

                resultado = operadorDao.lista();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (operadorDao != null)
                {
                    operadorDao.close();
                }
            }

            return resultado;
        }

        public static Operador busca(int id)
        {
            OperadorDao operadorDao = null;
            Operador operador = null;

            try
            {
                operadorDao = new OperadorDao();

                operador = operadorDao.busca(id);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (operadorDao != null)
                {
                    operadorDao.close();
                }
            }

            return operador;
        }
    }
}
