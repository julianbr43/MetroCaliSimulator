﻿namespace MetroCaliSimulator
{
    partial class MapaMio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gMapMapaMio = new GMap.NET.WindowsForms.GMapControl();
            this.butRegresar = new System.Windows.Forms.Button();
            this.comboFiltrar = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.butEliminar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.butInicio = new System.Windows.Forms.Button();
            this.butPausa = new System.Windows.Forms.Button();
            this.timerBuses = new System.Windows.Forms.Timer(this.components);
            this.labelTiempo = new System.Windows.Forms.Label();
            this.comboRutas = new System.Windows.Forms.ComboBox();
            this.tiempo = new System.Windows.Forms.ComboBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.loadArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(16, 520);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // gMapMapaMio
            // 
            this.gMapMapaMio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapMapaMio.Bearing = 0F;
            this.gMapMapaMio.CanDragMap = true;
            this.gMapMapaMio.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapMapaMio.GrayScaleMode = false;
            this.gMapMapaMio.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapMapaMio.LevelsKeepInMemmory = 5;
            this.gMapMapaMio.Location = new System.Drawing.Point(386, 48);
            this.gMapMapaMio.MarkersEnabled = true;
            this.gMapMapaMio.MaxZoom = 2;
            this.gMapMapaMio.MinZoom = 2;
            this.gMapMapaMio.MouseWheelZoomEnabled = true;
            this.gMapMapaMio.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMapaMio.Name = "gMapMapaMio";
            this.gMapMapaMio.NegativeMode = false;
            this.gMapMapaMio.PolygonsEnabled = true;
            this.gMapMapaMio.RetryLoadTile = 0;
            this.gMapMapaMio.RoutesEnabled = true;
            this.gMapMapaMio.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMapaMio.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMapaMio.ShowTileGridLines = false;
            this.gMapMapaMio.Size = new System.Drawing.Size(454, 334);
            this.gMapMapaMio.TabIndex = 1;
            this.gMapMapaMio.Zoom = 0D;
            this.gMapMapaMio.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.MouseEventHandler);
            // 
            // butRegresar
            // 
            this.butRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRegresar.BackColor = System.Drawing.Color.Black;
            this.butRegresar.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegresar.ForeColor = System.Drawing.Color.White;
            this.butRegresar.Location = new System.Drawing.Point(731, 464);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(85, 23);
            this.butRegresar.TabIndex = 2;
            this.butRegresar.Text = "REGRESAR";
            this.butRegresar.UseVisualStyleBackColor = false;
            this.butRegresar.Click += new System.EventHandler(this.ButRegresar_Click);
            // 
            // comboFiltrar
            // 
            this.comboFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltrar.FormattingEnabled = true;
            this.comboFiltrar.Items.AddRange(new object[] {
            "Estaciones",
            "Calles",
            "Todas"});
            this.comboFiltrar.Location = new System.Drawing.Point(200, 115);
            this.comboFiltrar.Name = "comboFiltrar";
            this.comboFiltrar.Size = new System.Drawing.Size(121, 21);
            this.comboFiltrar.TabIndex = 3;
            this.comboFiltrar.SelectedIndexChanged += new System.EventHandler(this.ComboFiltrar_SelectedIndexChanged);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(200, 156);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscar.TabIndex = 6;
            // 
            // butEliminar
            // 
            this.butEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butEliminar.BackColor = System.Drawing.Color.Black;
            this.butEliminar.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.butEliminar.Location = new System.Drawing.Point(122, 449);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(178, 26);
            this.butEliminar.TabIndex = 8;
            this.butEliminar.Text = "ELIMINAR MARCADORES";
            this.butEliminar.UseVisualStyleBackColor = false;
            this.butEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleName = "";
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(200, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "CENTRO";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(200, 261);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "UNIVERSIDADES";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(200, 284);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "MENGA";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(200, 307);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "CHIMINANGOS";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(200, 330);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(101, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "ANDRÉS SANÍN";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(200, 353);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(94, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "AGUABLANCA";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.Color.Transparent;
            this.checkBox7.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.Location = new System.Drawing.Point(200, 376);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(106, 17);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "CAÑAVERALEJO";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // butInicio
            // 
            this.butInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butInicio.BackColor = System.Drawing.Color.Black;
            this.butInicio.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInicio.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.butInicio.Location = new System.Drawing.Point(423, 464);
            this.butInicio.Name = "butInicio";
            this.butInicio.Size = new System.Drawing.Size(84, 23);
            this.butInicio.TabIndex = 16;
            this.butInicio.Text = "INICIAR";
            this.butInicio.UseVisualStyleBackColor = false;
            this.butInicio.Click += new System.EventHandler(this.ButInicio_Click);
            // 
            // butPausa
            // 
            this.butPausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butPausa.BackColor = System.Drawing.Color.Black;
            this.butPausa.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPausa.ForeColor = System.Drawing.Color.Red;
            this.butPausa.Location = new System.Drawing.Point(576, 464);
            this.butPausa.Name = "butPausa";
            this.butPausa.Size = new System.Drawing.Size(81, 23);
            this.butPausa.TabIndex = 17;
            this.butPausa.Text = "PAUSAR";
            this.butPausa.UseVisualStyleBackColor = false;
            this.butPausa.Click += new System.EventHandler(this.ButPausa_Click);
            // 
            // timerBuses
            // 
            this.timerBuses.Interval = 1000;
            this.timerBuses.Tick += new System.EventHandler(this.TimerBuses_Tick);
            // 
            // labelTiempo
            // 
            this.labelTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.BackColor = System.Drawing.Color.Transparent;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.ForeColor = System.Drawing.Color.White;
            this.labelTiempo.Location = new System.Drawing.Point(452, 422);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(55, 24);
            this.labelTiempo.TabIndex = 18;
            this.labelTiempo.Text = "00:00";
            this.labelTiempo.Click += new System.EventHandler(this.LabelTiempo_Click);
            // 
            // comboRutas
            // 
            this.comboRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRutas.FormattingEnabled = true;
            this.comboRutas.Items.AddRange(new object[] {
            "A01A",
            "A02",
            "A03",
            "A04",
            "A05",
            "A06",
            "A11",
            "A11B",
            "A12A",
            "A12B",
            "A12C",
            "A12D",
            "A13A",
            "A13B",
            "A13C",
            "A14A",
            "A14B",
            "A17A",
            "A17B",
            "A17C",
            "A18",
            "A19A",
            "A19B",
            "A21",
            "A22",
            "A23",
            "A24",
            "A32",
            "A33",
            "A34",
            "A35A",
            "A35B",
            "A36",
            "A37A",
            "A37B",
            "A41A",
            "A41B",
            "A41C",
            "A42A",
            "A42B",
            "A44A",
            "A44B",
            "A45B",
            "A47",
            "A52",
            "A53",
            "A55",
            "A56",
            "A57",
            "A70",
            "A71",
            "A72A",
            "A72B",
            "A73",
            "A75",
            "A76",
            "A77",
            "A78A",
            "A85",
            "D51",
            "E21",
            "E27",
            "E27B",
            "E31",
            "E37",
            "E41",
            "E52",
            "F60",
            "F61",
            "MIO",
            "P10A",
            "P10B",
            "P10D",
            "P12A",
            "P14A",
            "P17",
            "P21A",
            "P21B",
            "P24A",
            "P24B",
            "P24C",
            "P27C",
            "P27D",
            "P30A",
            "P40A",
            "P40B",
            "P43",
            "P47A",
            "P47B",
            "P47C",
            "P51",
            "P52A",
            "P52D",
            "P71",
            "P72",
            "P80A",
            "P82",
            "P83",
            "P84A",
            "P84B",
            "R51",
            "R52",
            "R53",
            "R54",
            "R55",
            "R57",
            "RE1",
            "RE7",
            "RE9",
            "REA",
            "RF16",
            "T31",
            "T40",
            "T42",
            "T47B",
            "T50",
            "T57A",
            "U22",
            "U23",
            "U34",
            "U51",
            "U52",
            "U53",
            "TODAS"});
            this.comboRutas.Location = new System.Drawing.Point(200, 196);
            this.comboRutas.Name = "comboRutas";
            this.comboRutas.Size = new System.Drawing.Size(121, 21);
            this.comboRutas.TabIndex = 19;
            this.comboRutas.SelectedIndexChanged += new System.EventHandler(this.ComboRutas_SelectedIndexChanged);
            // 
            // tiempo
            // 
            this.tiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiempo.FormattingEnabled = true;
            this.tiempo.Items.AddRange(new object[] {
            "1",
            "30",
            "60"});
            this.tiempo.Location = new System.Drawing.Point(803, 422);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(52, 21);
            this.tiempo.TabIndex = 22;
            this.tiempo.SelectedIndexChanged += new System.EventHandler(this.Tiempo_SelectedIndexChanged);
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.BackColor = System.Drawing.Color.Black;
            this.butSearch.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.butSearch.Location = new System.Drawing.Point(306, 154);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(58, 22);
            this.butSearch.TabIndex = 24;
            this.butSearch.Text = "Buscar";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // loadArchive
            // 
            this.loadArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadArchive.BackColor = System.Drawing.Color.Black;
            this.loadArchive.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadArchive.ForeColor = System.Drawing.Color.White;
            this.loadArchive.Location = new System.Drawing.Point(122, 420);
            this.loadArchive.Name = "loadArchive";
            this.loadArchive.Size = new System.Drawing.Size(178, 23);
            this.loadArchive.TabIndex = 25;
            this.loadArchive.Text = "CARGAR ARCHIVO";
            this.loadArchive.UseVisualStyleBackColor = false;
            this.loadArchive.Click += new System.EventHandler(this.loadArchive_Click);
            // 
            // MapaMio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MetroCaliSimulator.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(911, 520);
            this.Controls.Add(this.loadArchive);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.comboRutas);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.butPausa);
            this.Controls.Add(this.butInicio);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.comboFiltrar);
            this.Controls.Add(this.butRegresar);
            this.Controls.Add(this.gMapMapaMio);
            this.Controls.Add(this.splitter1);
            this.Name = "MapaMio";
            this.Text = "MapaMio";
            this.Load += new System.EventHandler(this.MapaMio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl gMapMapaMio;
        private System.Windows.Forms.Button butRegresar;
        private System.Windows.Forms.ComboBox comboFiltrar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button butInicio;
        private System.Windows.Forms.Button butPausa;
        private System.Windows.Forms.Timer timerBuses;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.ComboBox comboRutas;
        private System.Windows.Forms.ComboBox tiempo;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button loadArchive;
    }
}