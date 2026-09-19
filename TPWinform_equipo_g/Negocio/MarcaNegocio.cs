using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class MarcaNegocio
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

        public void modificarMarca(Marca marca)
        {
            try
            {
                datos.setearConsulta("Update MARCAS set Descripcion=@desc where Id=@id");
                datos.setearParametro("@desc", marca.Descripcion);
                datos.setearParametro("@id", marca.Id);
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

        public List<Marca> filtrarMarcas(string campo,string criterio, string filtro)
        {
            List<Marca> listaFiltrada = new List<Marca>();
            try
            {
                string consulta = "Select Id, Descripcion from MARCAS where ";
                if (campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Descripcion like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "Descripcion like '%" + filtro + "%'";
                            break;
                    }
                } else if (campo == "Id")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Id > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Id < " + filtro;
                            break;
                        case "Igual a":
                            consulta += "Id = " + filtro;
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    listaFiltrada.Add(aux);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return listaFiltrada;
        }
    }
}
