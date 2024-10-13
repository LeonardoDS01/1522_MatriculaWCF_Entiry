using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumnos" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumnos : IServicioAlumnos
    {
        public Boolean ActualizarEstudiante()
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
        public Boolean EliminarEstudiante()
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
        public Boolean InsertarEstudiante()
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
        public AlumnoDC ConsultarEstudiante()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                AlumnoDC objAlumnoDC = new AlumnoDC();
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return objAlumnoDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<AlumnoDC> ListarEstudiante()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<AlumnoDC> objListaAlumnos = new List<AlumnoDC>();
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return objListaAlumnos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
