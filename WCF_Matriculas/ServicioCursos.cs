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
        private DBMatricula2Entities MisMatriculas = new DBMatricula2Entities();

        public Boolean ActualizarCurso(CursoDC objCursoDC)
        {
            try
            {
                //***********************************************************//

                Tb_Cursos objCursoActualizar = (from miCurso in MisMatriculas.Tb_Cursos
                                                where miCurso.Cod_Cur == objCursoDC.Cod_Cur
                                                select miCurso).FirstOrDefault();

                objCursoActualizar.Des_Cur = objCursoDC.Des_Cur;
                objCursoActualizar.Cred_Cur = objCursoDC.Cred_Cur;
                objCursoActualizar.Usu_Ult_Mod = objCursoDC.Usu_Ult_Mod;
                objCursoActualizar.Est_Cur = Convert.ToBoolean(objCursoDC.Est_Curso);

                //***********************************************************//
                //retornamos el resultado

                if (MisMatriculas.SaveChanges() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarCurso(String codigo)
        {
            try
            {
                //***********************************************************//

                Tb_Cursos objCursoEliminar = (from miCurso in MisMatriculas.Tb_Cursos
                                              where miCurso.Cod_Cur == codigo
                                              select miCurso).FirstOrDefault();

                MisMatriculas.Tb_Cursos.Remove(objCursoEliminar);

                //***********************************************************//
                //retornamos el resultado
                if (MisMatriculas.SaveChanges() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarCurso(CursoDC objCursoDC)
        {
            try
            {
                //***********************************************************//

                Tb_Cursos objCursoNuevo = new Tb_Cursos();

                objCursoNuevo.Des_Cur = objCursoDC.Des_Cur;
                objCursoNuevo.Cred_Cur = objCursoDC.Cred_Cur;
                objCursoNuevo.Usu_Reg = objCursoDC.Usu_Reg;
                objCursoNuevo.Est_Cur = Convert.ToBoolean(objCursoDC.Est_Curso);

                MisMatriculas.Tb_Cursos.Add(objCursoNuevo);

                //***********************************************************//
                //retornamos el resultado
                if (MisMatriculas.SaveChanges() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CursoDC ConsultarCurso(String codigo)
        {
            try
            {
                //***********************************************************//

                Tb_Cursos objCursoConsulta = (from miCurso in MisMatriculas.Tb_Cursos
                                              where miCurso.Cod_Cur == codigo
                                              select miCurso).FirstOrDefault();

                CursoDC objCursoDC = MetodosReutilizablesCurso.procesarCurso(objCursoConsulta);

                //***********************************************************//
                //retornamos el objeto
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

                //***********************************************************//
                var query = (from miCurso in MisMatriculas.Tb_Cursos select miCurso);

                List<CursoDC> objListaCurso = MetodosReutilizablesCurso.getLista(query);

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
