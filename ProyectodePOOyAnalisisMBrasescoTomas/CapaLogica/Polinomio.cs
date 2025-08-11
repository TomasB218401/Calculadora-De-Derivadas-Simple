using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaLogica
{
    public  class Polinomio
    {
        #region Atributos
        public List<double> Coeficientes { get; private set; }
        #endregion
        #region Metodos
        //constructor de la clase
        public Polinomio(List<double> coeficientes)
        {
            Coeficientes = coeficientes;
        }
        public double Evaluar(double x)
        {
            //En resumen se encarga de convertir el polinomio a un formato mas adecuado para graficar tomando como valor la x
            //Esta funcion solo se utiliza en la FuncionGraficadora de la CapaPresentacion
            double resultado = 0;

            int grado = Coeficientes.Count - 1; // Define el valor del grado como la cantidad de items de la lista coheficientes -1
            for (int i = 0; i < Coeficientes.Count; i++)
            {
                resultado += Coeficientes[i] * Math.Pow(x, grado - i);//Luego dentro del bucle resuelve el coheficiente * x elevado a (grado - i); 2 * 4^2-1 = 8
            }
            return resultado;
        }
        //Funcion que se encarga de derivar el polinomio
        public Polinomio Derivar()
        {
            //Similar al anterior la variable grado es practicamente lo mismo, solo que aca se crea una nueva lista
            List<double> derivados = new List<double>();
            int grado = Coeficientes.Count - 1;

            for (int i = 0; i < grado; i++)
            {
                double nuevocoef = Coeficientes[i] * (grado - i);//Define una variable de tipo double y le asigna el coheficiente en la posicion i y lo multiplica por su grado - el valor de i
                derivados.Add(nuevocoef);//agrega el item a la nueva lista y continua
            }
            return new Polinomio(derivados);//devuelve un polinomio pero con la lista derivados
        }
        public override string ToString()//Modifica el metodo .tostring()
        {
            //define un objeto de tipo stringBuilder llamado sb
            StringBuilder sb = new StringBuilder();
            int grado = Coeficientes.Count - 1;

            for(int i = 0; i < Coeficientes.Count; i++)
            {
                double coef = Coeficientes[i];//crea una variable double y le asigna el valor del item de coeficientes en la posicion i
                int exp = grado - i;//exp = grado - valor de i

                if (coef == 0)//si el coef es exactamente == 0 corta el for y sigue con el proximo bucle
                    continue;
                if (sb.Length > 0)
                    sb.Append(coef > 0 ? " + " : " - ");//si la cantidad de caracteres del sb es > 0: pregunta con un if acortado, en caso de ser mayor a 0 se le concatena un + y si es menor un -
                else if (coef < 0)
                    sb.Append("-");//y si el coef es < a 0 le concatena un -

                double absCoef = Math.Abs(coef);//Math.abs le saca el signo al numero en caso de ser por ejemplo -1

                if (absCoef != 1 || exp == 0)//si la variable absCOef es distinta de 1 o == 0
                    sb.Append(absCoef);//le concatena el valor de absCoef al final

                if(exp > 0)
                {
                    sb.Append("x");//le concatena el valor "x" al final
                    if (exp > 1)
                        sb.Append("^" + exp);//en caso de exp ser mayor a 1 le agrega esto "^"
                }
            }


            return sb.Length > 0 ? sb.ToString() : "0";//si todo salio bien devuelve la cadena con el metodo .tostring cambiado y si no hay ningun caracter devuelve 0
        }

        #endregion




    }
}
//Alumno:BRASESCO TOMAS