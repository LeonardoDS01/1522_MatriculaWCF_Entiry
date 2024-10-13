using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProfesores" en el código y en el archivo de configuración a la vez.
    public class ServicioProfesores : IServicioProfesores
    {
        public Boolean ActualizarProfesor()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                Boolean boolActualizar = false;
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return boolActualizar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarProfesor()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                Boolean boolEliminar = false;
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return boolEliminar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InsertarProfesor()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                Boolean boolInsertar = false;
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return boolInsertar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ProfesorDC ConsultarProfesor()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                ProfesorDC objProfesorDC = new ProfesorDC();
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return objProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<ProfesorDC> ListarProfesor()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<ProfesorDC> objListaProfesorDC = new List<ProfesorDC>();
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return objListaProfesorDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
