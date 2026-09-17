using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinform_equipo_g
{
    internal class MarcaNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Marca> listar()
        {
            List <Marca> listaMarcas= new List<Marca>();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarConsulta();



                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];


                    listaMarcas.Add(aux);
                }



                return listaMarcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }




        }
        public void nuevaMarca(Marca nuevaMarca)
        {
            try
            {
                datos.setearConsulta("Insert into MARCAS(Descripcion)values (@desc)");
                datos.setearParametro("@desc", nuevaMarca.Descripcion);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
