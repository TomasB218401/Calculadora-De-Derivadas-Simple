namespace CapaPresentacion
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Pnl_TopBar = new System.Windows.Forms.Panel();
            this.pnl_contenedorArriba = new System.Windows.Forms.Panel();
            this.btn_CierraMenu = new Presentacion.Tb_butones.tb_boton();
            this.btn_MaximizaMenu = new Presentacion.Tb_butones.tb_boton();
            this.btn_minimizaMenu = new Presentacion.Tb_butones.tb_boton();
            this.TlayPanelFull = new System.Windows.Forms.TableLayoutPanel();
            this.SectorTop = new System.Windows.Forms.TableLayoutPanel();
            this.lb_coefi = new System.Windows.Forms.Label();
            this.btn_derivar = new Presentacion.Tb_butones.tb_boton();
            this.txb_listaNumeros = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_AyudaResul = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlView_Grafico = new OxyPlot.WindowsForms.PlotView();
            this.Pnl_TopBar.SuspendLayout();
            this.pnl_contenedorArriba.SuspendLayout();
            this.TlayPanelFull.SuspendLayout();
            this.SectorTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_TopBar
            // 
            this.Pnl_TopBar.BackgroundImage = global::CapaPresentacion.Properties.Resources.madera;
            this.Pnl_TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_TopBar.Controls.Add(this.pnl_contenedorArriba);
            this.Pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopBar.Name = "Pnl_TopBar";
            this.Pnl_TopBar.Size = new System.Drawing.Size(909, 30);
            this.Pnl_TopBar.TabIndex = 0;
            this.Pnl_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopBar_MouseDown);
            this.Pnl_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopBar_MouseMove);
            this.Pnl_TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopBar_MouseUp);
            // 
            // pnl_contenedorArriba
            // 
            this.pnl_contenedorArriba.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contenedorArriba.Controls.Add(this.btn_CierraMenu);
            this.pnl_contenedorArriba.Controls.Add(this.btn_MaximizaMenu);
            this.pnl_contenedorArriba.Controls.Add(this.btn_minimizaMenu);
            this.pnl_contenedorArriba.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_contenedorArriba.Location = new System.Drawing.Point(782, 0);
            this.pnl_contenedorArriba.Name = "pnl_contenedorArriba";
            this.pnl_contenedorArriba.Size = new System.Drawing.Size(127, 30);
            this.pnl_contenedorArriba.TabIndex = 0;
            // 
            // btn_CierraMenu
            // 
            this.btn_CierraMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_CierraMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_CierraMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CierraMenu.BorderRadius = 10;
            this.btn_CierraMenu.BorderSize = 1;
            this.btn_CierraMenu.FlatAppearance.BorderSize = 0;
            this.btn_CierraMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CierraMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CierraMenu.ForeColor = System.Drawing.Color.White;
            this.btn_CierraMenu.Location = new System.Drawing.Point(87, 3);
            this.btn_CierraMenu.Name = "btn_CierraMenu";
            this.btn_CierraMenu.Size = new System.Drawing.Size(33, 24);
            this.btn_CierraMenu.TabIndex = 0;
            this.btn_CierraMenu.Text = "X";
            this.btn_CierraMenu.TextColor = System.Drawing.Color.White;
            this.btn_CierraMenu.UseVisualStyleBackColor = false;
            this.btn_CierraMenu.Click += new System.EventHandler(this.btn_CierraMenu_Click);
            this.btn_CierraMenu.MouseEnter += new System.EventHandler(this.btn_CierraMenu_MouseEnter);
            this.btn_CierraMenu.MouseLeave += new System.EventHandler(this.btn_CierraMenu_MouseLeave);
            // 
            // btn_MaximizaMenu
            // 
            this.btn_MaximizaMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_MaximizaMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_MaximizaMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_MaximizaMenu.BorderRadius = 10;
            this.btn_MaximizaMenu.BorderSize = 1;
            this.btn_MaximizaMenu.FlatAppearance.BorderSize = 0;
            this.btn_MaximizaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaximizaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaximizaMenu.ForeColor = System.Drawing.Color.White;
            this.btn_MaximizaMenu.Location = new System.Drawing.Point(48, 3);
            this.btn_MaximizaMenu.Name = "btn_MaximizaMenu";
            this.btn_MaximizaMenu.Size = new System.Drawing.Size(33, 24);
            this.btn_MaximizaMenu.TabIndex = 1;
            this.btn_MaximizaMenu.Text = "[  ]";
            this.btn_MaximizaMenu.TextColor = System.Drawing.Color.White;
            this.btn_MaximizaMenu.UseVisualStyleBackColor = false;
            this.btn_MaximizaMenu.Click += new System.EventHandler(this.btn_MaximizaMenu_Click);
            this.btn_MaximizaMenu.MouseEnter += new System.EventHandler(this.btn_MaximizaMenu_MouseEnter);
            this.btn_MaximizaMenu.MouseLeave += new System.EventHandler(this.btn_MaximizaMenu_MouseLeave);
            // 
            // btn_minimizaMenu
            // 
            this.btn_minimizaMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizaMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_minimizaMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_minimizaMenu.BorderRadius = 10;
            this.btn_minimizaMenu.BorderSize = 1;
            this.btn_minimizaMenu.FlatAppearance.BorderSize = 0;
            this.btn_minimizaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizaMenu.ForeColor = System.Drawing.Color.White;
            this.btn_minimizaMenu.Location = new System.Drawing.Point(9, 3);
            this.btn_minimizaMenu.Name = "btn_minimizaMenu";
            this.btn_minimizaMenu.Size = new System.Drawing.Size(33, 24);
            this.btn_minimizaMenu.TabIndex = 2;
            this.btn_minimizaMenu.Text = "---";
            this.btn_minimizaMenu.TextColor = System.Drawing.Color.White;
            this.btn_minimizaMenu.UseVisualStyleBackColor = false;
            this.btn_minimizaMenu.Click += new System.EventHandler(this.btn_minimizaMenu_Click);
            this.btn_minimizaMenu.MouseEnter += new System.EventHandler(this.btn_minimizaMenu_MouseEnter);
            this.btn_minimizaMenu.MouseLeave += new System.EventHandler(this.btn_minimizaMenu_MouseLeave);
            // 
            // TlayPanelFull
            // 
            this.TlayPanelFull.ColumnCount = 1;
            this.TlayPanelFull.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlayPanelFull.Controls.Add(this.SectorTop, 0, 0);
            this.TlayPanelFull.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TlayPanelFull.Controls.Add(this.panel1, 0, 2);
            this.TlayPanelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlayPanelFull.Location = new System.Drawing.Point(0, 30);
            this.TlayPanelFull.Name = "TlayPanelFull";
            this.TlayPanelFull.RowCount = 3;
            this.TlayPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.28221F));
            this.TlayPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.509202F));
            this.TlayPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.20859F));
            this.TlayPanelFull.Size = new System.Drawing.Size(909, 652);
            this.TlayPanelFull.TabIndex = 1;
            // 
            // SectorTop
            // 
            this.SectorTop.ColumnCount = 2;
            this.SectorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectorTop.Controls.Add(this.lb_coefi, 0, 0);
            this.SectorTop.Controls.Add(this.btn_derivar, 1, 1);
            this.SectorTop.Controls.Add(this.txb_listaNumeros, 0, 1);
            this.SectorTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectorTop.Location = new System.Drawing.Point(10, 10);
            this.SectorTop.Margin = new System.Windows.Forms.Padding(10);
            this.SectorTop.Name = "SectorTop";
            this.SectorTop.Padding = new System.Windows.Forms.Padding(5);
            this.SectorTop.RowCount = 2;
            this.SectorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectorTop.Size = new System.Drawing.Size(889, 197);
            this.SectorTop.TabIndex = 0;
            // 
            // lb_coefi
            // 
            this.lb_coefi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_coefi.AutoSize = true;
            this.lb_coefi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coefi.Location = new System.Drawing.Point(126, 65);
            this.lb_coefi.Name = "lb_coefi";
            this.lb_coefi.Size = new System.Drawing.Size(197, 33);
            this.lb_coefi.TabIndex = 0;
            this.lb_coefi.Text = "Coeficientes:";
            this.lb_coefi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_derivar
            // 
            this.btn_derivar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_derivar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_derivar.BackgroundColor = System.Drawing.Color.Chocolate;
            this.btn_derivar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_derivar.BorderRadius = 50;
            this.btn_derivar.BorderSize = 0;
            this.btn_derivar.FlatAppearance.BorderSize = 0;
            this.btn_derivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_derivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_derivar.ForeColor = System.Drawing.Color.White;
            this.btn_derivar.Location = new System.Drawing.Point(447, 106);
            this.btn_derivar.Name = "btn_derivar";
            this.btn_derivar.Size = new System.Drawing.Size(434, 77);
            this.btn_derivar.TabIndex = 2;
            this.btn_derivar.Text = "DERIVAR";
            this.btn_derivar.TextColor = System.Drawing.Color.White;
            this.btn_derivar.UseVisualStyleBackColor = false;
            this.btn_derivar.Click += new System.EventHandler(this.btn_derivar_Click);
            // 
            // txb_listaNumeros
            // 
            this.txb_listaNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_listaNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_listaNumeros.Location = new System.Drawing.Point(8, 125);
            this.txb_listaNumeros.Name = "txb_listaNumeros";
            this.txb_listaNumeros.Size = new System.Drawing.Size(433, 40);
            this.txb_listaNumeros.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_AyudaResul, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_resultado, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lb_AyudaResul
            // 
            this.lb_AyudaResul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_AyudaResul.AutoSize = true;
            this.lb_AyudaResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AyudaResul.Location = new System.Drawing.Point(3, 22);
            this.lb_AyudaResul.Name = "lb_AyudaResul";
            this.lb_AyudaResul.Size = new System.Drawing.Size(445, 33);
            this.lb_AyudaResul.TabIndex = 1;
            this.lb_AyudaResul.Text = "RESULTADO:";
            this.lb_AyudaResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_resultado
            // 
            this.lb_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.BackColor = System.Drawing.Color.Transparent;
            this.lb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_resultado.Location = new System.Drawing.Point(454, 31);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(446, 24);
            this.lb_resultado.TabIndex = 2;
            this.lb_resultado.Text = "...";
            this.lb_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.PlView_Grafico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 334);
            this.panel1.TabIndex = 2;
            // 
            // PlView_Grafico
            // 
            this.PlView_Grafico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlView_Grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlView_Grafico.Location = new System.Drawing.Point(0, 0);
            this.PlView_Grafico.Name = "PlView_Grafico";
            this.PlView_Grafico.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlView_Grafico.Size = new System.Drawing.Size(869, 334);
            this.PlView_Grafico.TabIndex = 0;
            this.PlView_Grafico.Text = "Grafico";
            this.PlView_Grafico.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlView_Grafico.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlView_Grafico.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 682);
            this.Controls.Add(this.TlayPanelFull);
            this.Controls.Add(this.Pnl_TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Derivador de Funciones";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Pnl_TopBar.ResumeLayout(false);
            this.pnl_contenedorArriba.ResumeLayout(false);
            this.TlayPanelFull.ResumeLayout(false);
            this.SectorTop.ResumeLayout(false);
            this.SectorTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_TopBar;
        private Presentacion.Tb_butones.tb_boton btn_CierraMenu;
        private Presentacion.Tb_butones.tb_boton btn_minimizaMenu;
        private Presentacion.Tb_butones.tb_boton btn_MaximizaMenu;
        private System.Windows.Forms.Panel pnl_contenedorArriba;
        private System.Windows.Forms.TableLayoutPanel TlayPanelFull;
        private System.Windows.Forms.TableLayoutPanel SectorTop;
        private System.Windows.Forms.Label lb_coefi;
        private Presentacion.Tb_butones.tb_boton btn_derivar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label lb_AyudaResul;
        private System.Windows.Forms.Panel panel1;
        private OxyPlot.WindowsForms.PlotView PlView_Grafico;
        private System.Windows.Forms.TextBox txb_listaNumeros;
    }
}

