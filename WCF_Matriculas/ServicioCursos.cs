using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCursos" en el código y en el archivo de configuración a la vez.
    public class ServicioCursos : IServicioCursos
    {
        public Boolean ActualizarCurso()
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
        public Boolean EliminarCurso()
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
        public Boolean InsertarCurso()
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
        public CursoDC ConsultarCurso()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                CursoDC objCursoDC = new CursoDC();
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return objCursoDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<CursoDC> ListarCurso()
        {
            try
            {
                //creamos una instancia del model
                DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();
                //creamos la cosa a retornar
                List<CursoDC> objListaCurso = new List<CursoDC>();
                //***********************************************************//





                //***********************************************************//
                //retornamos la coleccion
                return objListaCurso;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
