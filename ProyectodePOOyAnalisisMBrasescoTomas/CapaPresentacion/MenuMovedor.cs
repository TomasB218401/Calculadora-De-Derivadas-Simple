using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public static class MenuMovedor//lo dice el propio nombre pero igual por la dudas lo explico
    {
        //Crea un bool estatico llamado dragging y lo hace = a false
        public static bool dragging = false;
        public  static Point startPoint = new Point(0, 0);//luego crea un punto de inicio
    }
}
//Alumno:BRASESCO TOMAS