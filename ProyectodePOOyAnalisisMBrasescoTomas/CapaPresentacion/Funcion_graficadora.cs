using CapaLogica;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal  class Funcion_graficadora
    {

        
        public  PlotView Modelo(PlotView plotv, Polinomio poli)
        {
            try
            {
                Polinomio deripoli = poli.Derivar(); ;
                
                deripoli.Derivar();
                var plotModel = new PlotModel { Title = "Funcion y su Derivada" };

                //var serie = new LineSeries { Title = "f(x)", StrokeThickness = 10 };
                var serieOriginal = new LineSeries
                {
                    Title = "f(x)",
                    StrokeThickness = 2,
                    Color = OxyColors.Red,
                    FontSize = 15

                };
                var serieDerivada = new LineSeries
                {
                    Title = "f(x)'",
                    StrokeThickness = 2,
                    Color = OxyColors.Green,
                    FontSize = 15
                };

                for (double x = -10; x <= 10; x += 0.1)
                {
                    //double w = poli.Coeficientes[0] * Math.Pow(x, poli.Coeficientes.Count - 1) + poli.Coeficientes[1] * Math.Pow(x, poli.Coeficientes.Count - 2) + poli.Coeficientes[2] * Math.Pow(x, poli.Coeficientes.Count - 3);
                    //double d = deripoli.Coeficientes[0] * Math.Pow(x, deripoli.Coeficientes.Count - 1) + deripoli.Coeficientes[1] * Math.Pow(x, deripoli.Coeficientes.Count - 2) + deripoli.Coeficientes[2] * Math.Pow(x, deripoli.Coeficientes.Count - 3);
                    double fn = poli.Evaluar(x);
                    double fd = deripoli.Evaluar(x);
                    serieOriginal.Points.Add(new DataPoint(x, fn));
                    serieDerivada.Points.Add(new DataPoint(x, fd));
                }
                plotModel.Series.Add(serieOriginal);
                plotModel.Series.Add(serieDerivada);
                plotv.Model = plotModel;

                return plotv;
            }
            catch
            {
                return null;
            }

        }

    }
}
//Alumno:BRASESCO TOMAS