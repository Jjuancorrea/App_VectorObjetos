using System;

namespace Negocio
{
    //Creación del constructor
    public class clsPersonas
    {
        private String strNombre;
        private String strContacto;
        private int intEdad;
        private String strCorreo;

        public clsPersonas()
        {
            this.strContacto = "";
            this.strNombre = "";
            this.intEdad = 0;
            this.strCorreo = "";
        }

        public void setContacto(String co)
        {
            this.strContacto = co;
        }
        public String getContacto()
        {
            return this.strContacto;
        }
        public void setNombre(String no)
        {
            this.strNombre = no;
        }
        public String getNombre()
        {
            return this.strNombre;
        }
        public void setEdad(int ed)
        {
            this.intEdad = ed;
        }
        public int getEdad()
        {
            return this.intEdad;
        }
        public void setCorreo(String cor)
        {
            this.strNombre = cor;
        }
        public String getCorreo()
        {
            return this.strNombre;
        }
        //Terminación de métodos setters y getters
    }
}
