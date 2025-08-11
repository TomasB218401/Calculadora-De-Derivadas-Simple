using CapaLogica;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        #region COSAS Esteticas del Formulario

        #region LoQueMueveELForm
        private void Pnl_TopBar_MouseDown(object sender, MouseEventArgs e)//utiliza la clase estatica de MenuMovedor para poder movilizar la topBar cuando mantienen click sobre la misma
        {
            MenuMovedor.dragging = true;
            MenuMovedor.startPoint = new Point(e.X, e.Y);
        }

        private void Pnl_TopBar_MouseMove(object sender, MouseEventArgs e)//esto modifica la posicion del formulario
        {
            if (MenuMovedor.dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - MenuMovedor.startPoint.X, p.Y - MenuMovedor.startPoint.Y);
            }
        }

        private void Pnl_TopBar_MouseUp(object sender, MouseEventArgs e)// si se deja de apretar click deja el formulario en la ultima posicion donde se dejo anteriormente
        {
            MenuMovedor.dragging = false;
        }

        #endregion
        #region Botones de abrir/Cerrar/minimizar/MaximizarELForm
        private void btn_CierraMenu_MouseEnter(object sender, EventArgs e)
        {
            btn_CierraMenu.BackColor = Color.PaleVioletRed; btn_CierraMenu.ForeColor = Color.Black;
        }

        private void btn_MaximizaMenu_MouseEnter(object sender, EventArgs e)
        {
            btn_MaximizaMenu.BackColor = Color.PaleVioletRed; btn_MaximizaMenu.ForeColor = Color.Black;
        }

        private void btn_minimizaMenu_MouseEnter(object sender, EventArgs e)
        {
            btn_minimizaMenu.BackColor = Color.PaleVioletRed; btn_minimizaMenu.ForeColor = Color.Black;
        }

        private void btn_CierraMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_CierraMenu.BackColor = Color.Transparent; btn_CierraMenu.ForeColor = Color.White;
        }

        private void btn_MaximizaMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_MaximizaMenu.BackColor = Color.Transparent; btn_MaximizaMenu.ForeColor = Color.White;
        }

        private void btn_minimizaMenu_MouseLeave(object sender, EventArgs e)
        {
            btn_minimizaMenu.BackColor = Color.Transparent; btn_minimizaMenu.ForeColor = Color.White;
        }
        #endregion
        #endregion

        #region ClickBotones
        private void btn_CierraMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MaximizaMenu_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btn_minimizaMenu_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void btn_derivar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //se pasa el txb a un string para luego colocar los numeros separados por , dentro del array partes
                string entrada = txb_listaNumeros.Text;
                string[] partes = entrada.Split(',');

                List<double> coeficientes = new List<double>();
                foreach(string parte in partes)
                {
                    coeficientes.Add(double.Parse(parte.Trim()));
                }

                Polinomio p = new Polinomio(coeficientes);
                Polinomio derivada = p.Derivar();

                lb_resultado.Text = "f'(x) = " + derivada.ToString();
                Funcion_graficadora pp = new Funcion_graficadora();
                PlView_Grafico = pp.Modelo(PlView_Grafico,p);
                
            }
            catch
            {
                MessageBox.Show("ERROR DE ENTRADA \n Por Favor Igrese los Coeficiente separados por , EJ (1,2,3,4,5)");
                txb_listaNumeros.Clear();
                PlView_Grafico.Model = null;
            }

        }
        #endregion



    }
}
//Alumno:BRASESCO TOMAS