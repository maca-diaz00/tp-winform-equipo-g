using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinform_equipo_g
{
    internal class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List <Marca> listaMarcas= new List<Marca>();
            AccesoDatos datos = new AccesoDatos();//se instancia datos para poder configurar luego

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
    }
}
