using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioI.Encapsulamiento
{
    public class Estudiante
    {
        
        private string NombreEst;

        private int EdadEst;

        public string Nombre
        {
            get { return NombreEst; }

            set { NombreEst = value; }

        }

        public int Edad
        {
            get { return EdadEst; }
            set { EdadEst = value; }
        }

    }
    /* 
    //ESTA PARTE VA EN PROGRAM*********

    Estudiante objeto = new Estudiante();

    objeto.Nombre = "Angelica";

    objeto.Edad = 19;

    Console.WriteLine("Nombre: " +  objeto.Nombre);
    Console.WriteLine("Edad: " + objeto.Edad);
    */

}
