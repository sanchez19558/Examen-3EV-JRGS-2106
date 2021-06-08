using System.Collections.Generic;

namespace Examen3EV_NS
{
    public class EstadisticasDeNotas  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        private int suspensos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        private double medias; // Nota media


        public int Suspensos { get => suspensos; set => suspensos = value; }
        public int Aprobados { get => aprobados; set => aprobados = value; }
        public int Notables { get => notables; set => notables = value; }
        public int Sobresalientes { get => sobresalientes; set => sobresalientes = value; }
        public double Medias { get => medias; set => medias = value; }

        // Constructor vacío
        public EstadisticasDeNotas()
        {
            this.Suspensos = 0;
            this.Aprobados = 0;
            this.Notables = 0;
            this.Sobresalientes = 0;  // inicializamos las variables
            this.Medias = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        public EstadisticasDeNotas(List<int> listnot)
        {
            this.Medias = 0.0;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5)
                {
                    Suspensos++;              // Por debajo de 5 suspenso
                }
                else if (listnot[i] > 5 && listnot[i] < 7)
                {
                    Aprobados++;// Nota para aprobar: 5
                }
                else if (listnot[i] > 7 && listnot[i] < 9)
                {
                    Notables++;// Nota para notable: 7
                }
                else if (listnot[i] > 9)
                {
                    Sobresalientes++;         // Nota para sobresaliente: 9
                }

                this.Medias = Medias + listnot[i];
            }

            this.Medias = Medias / listnot.Count;
        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspenso/aprobado/notable/sobresaliente
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	
        public double CalcularEstadisticas(List<int> listnot)
        {
            this.Medias = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)
            {
                return -1;
            }  // Si la lista no contiene elementos, devolvemos un error


            for (int i = 0; i < 10; i++)
            {
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las notable están entre 0 y 10 (mínimo y máximo), si no, error
                {
                    return -1;
                }
            }


            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5)
                {
                    Suspensos++;              // Por debajo de 5 suspenso
                }
                else if (listnot[i] >= 5 && listnot[i] < 7)
                {
                    Aprobados++;// Nota para aprobar: 5
                }
                else if (listnot[i] >= 7 && listnot[i] < 9)
                {
                    Notables++;// Nota para notable: 7
                }
                else if (listnot[i] > 9)
                {
                    Sobresalientes++;         // Nota para sobresaliente: 9
                }

                this.Medias = Medias + listnot[i];
            }

            this.Medias = Medias / listnot.Count;

            return Medias;
        }



    }
}
