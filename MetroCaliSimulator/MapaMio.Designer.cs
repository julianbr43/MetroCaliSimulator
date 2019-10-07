namespace MetroCaliSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(711, 504);
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
            this.gMapMapaMio.Location = new System.Drawing.Point(12, 12);
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
            this.gMapMapaMio.Size = new System.Drawing.Size(686, 480);
            this.gMapMapaMio.TabIndex = 1;
            this.gMapMapaMio.Zoom = 0D;
            // 
            // butRegresar
            // 
            this.butRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRegresar.Location = new System.Drawing.Point(762, 393);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(85, 34);
            this.butRegresar.TabIndex = 2;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = true;
            this.butRegresar.Click += new System.EventHandler(this.ButRegresar_Click);
            // 
            // comboFiltrar
            // 
            this.comboFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltrar.FormattingEnabled = true;
            this.comboFiltrar.Items.AddRange(new object[] {
            "Estaciones",
            "Troncales",
            "Todas"});
            this.comboFiltrar.Location = new System.Drawing.Point(747, 28);
            this.comboFiltrar.Name = "comboFiltrar";
            this.comboFiltrar.Size = new System.Drawing.Size(121, 21);
            this.comboFiltrar.TabIndex = 3;
            this.comboFiltrar.SelectedIndexChanged += new System.EventHandler(this.ComboFiltrar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar Paradas";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Parada";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(747, 84);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(121, 20);
            this.textBoxBuscar.TabIndex = 6;
            // 
            // butEliminar
            // 
            this.butEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butEliminar.Location = new System.Drawing.Point(762, 342);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(85, 34);
            this.butEliminar.TabIndex = 8;
            this.butEliminar.Text = "Eliminar Marcadores";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleName = "";
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(747, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Zona Centro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(747, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Zona Universidades";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(747, 166);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Zona Menga";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(747, 189);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(114, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Zona Chiminangos";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(747, 212);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(117, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Zona Andres Sanin";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(747, 235);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(111, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Zona Aguablanca";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(747, 258);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(116, 17);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "Zona Cañaveralejo";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // butInicio
            // 
            this.butInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butInicio.Location = new System.Drawing.Point(717, 297);
            this.butInicio.Name = "butInicio";
            this.butInicio.Size = new System.Drawing.Size(75, 23);
            this.butInicio.TabIndex = 16;
            this.butInicio.Text = "Inicio";
            this.butInicio.UseVisualStyleBackColor = true;
            this.butInicio.Click += new System.EventHandler(this.ButInicio_Click);
            // 
            // butPausa
            // 
            this.butPausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butPausa.Location = new System.Drawing.Point(814, 297);
            this.butPausa.Name = "butPausa";
            this.butPausa.Size = new System.Drawing.Size(75, 23);
            this.butPausa.TabIndex = 17;
            this.butPausa.Text = "Pausa";
            this.butPausa.UseVisualStyleBackColor = true;
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
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(768, 440);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(66, 25);
            this.labelTiempo.TabIndex = 18;
            this.labelTiempo.Text = "00:00";
            // 
            // MapaMio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 504);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFiltrar);
            this.Controls.Add(this.butRegresar);
            this.Controls.Add(this.gMapMapaMio);
            this.Controls.Add(this.splitter1);
            this.Name = "MapaMio";
            this.Text = "MapaMio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl gMapMapaMio;
        private System.Windows.Forms.Button butRegresar;
        private System.Windows.Forms.ComboBox comboFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
    }
}