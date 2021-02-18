
namespace WindowsFormsApp1
{
    partial class FormularioAduanas
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
            this.components = new System.ComponentModel.Container();
            this.Transporte = new System.Windows.Forms.GroupBox();
            this.radioTren = new System.Windows.Forms.RadioButton();
            this.radioCarretera = new System.Windows.Forms.RadioButton();
            this.Destino = new System.Windows.Forms.GroupBox();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.textLote_Num_UK = new System.Windows.Forms.TextBox();
            this.textLote_Num_Japon = new System.Windows.Forms.TextBox();
            this.textLote_Num_Suiza = new System.Windows.Forms.TextBox();
            this.textLote_Num_Turquia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLote_Letras_UK = new System.Windows.Forms.TextBox();
            this.textLote_Letras_Japon = new System.Windows.Forms.TextBox();
            this.textLote_Letras_Suiza = new System.Windows.Forms.TextBox();
            this.textLote_Letras_Turquia = new System.Windows.Forms.TextBox();
            this.regUK = new System.Windows.Forms.TextBox();
            this.checkUK = new System.Windows.Forms.CheckBox();
            this.regJapon = new System.Windows.Forms.TextBox();
            this.regSuiza = new System.Windows.Forms.TextBox();
            this.regTurquia = new System.Windows.Forms.TextBox();
            this.checkJapon = new System.Windows.Forms.CheckBox();
            this.checkSuiza = new System.Windows.Forms.CheckBox();
            this.checkTurquia = new System.Windows.Forms.CheckBox();
            this.GenerarListado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboPuertos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupTren = new System.Windows.Forms.GroupBox();
            this.textTren = new System.Windows.Forms.TextBox();
            this.generarListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Transporte.SuspendLayout();
            this.Destino.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupTren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generarListadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Transporte
            // 
            this.Transporte.Controls.Add(this.radioTren);
            this.Transporte.Controls.Add(this.radioCarretera);
            this.Transporte.Location = new System.Drawing.Point(39, 25);
            this.Transporte.Name = "Transporte";
            this.Transporte.Size = new System.Drawing.Size(160, 106);
            this.Transporte.TabIndex = 0;
            this.Transporte.TabStop = false;
            this.Transporte.Text = "Medio";
            // 
            // radioTren
            // 
            this.radioTren.AutoSize = true;
            this.radioTren.Location = new System.Drawing.Point(37, 57);
            this.radioTren.Name = "radioTren";
            this.radioTren.Size = new System.Drawing.Size(47, 17);
            this.radioTren.TabIndex = 1;
            this.radioTren.Text = "Tren";
            this.radioTren.UseVisualStyleBackColor = true;
            this.radioTren.CheckedChanged += new System.EventHandler(this.radioTren_CheckedChanged);
            // 
            // radioCarretera
            // 
            this.radioCarretera.AutoSize = true;
            this.radioCarretera.Checked = true;
            this.radioCarretera.Location = new System.Drawing.Point(37, 34);
            this.radioCarretera.Name = "radioCarretera";
            this.radioCarretera.Size = new System.Drawing.Size(68, 17);
            this.radioCarretera.TabIndex = 0;
            this.radioCarretera.TabStop = true;
            this.radioCarretera.Text = "Carretera";
            this.radioCarretera.UseVisualStyleBackColor = true;
            this.radioCarretera.CheckedChanged += new System.EventHandler(this.radioCarretera_CheckedChanged);
            // 
            // Destino
            // 
            this.Destino.Controls.Add(this.botonBorrar);
            this.Destino.Controls.Add(this.textLote_Num_UK);
            this.Destino.Controls.Add(this.textLote_Num_Japon);
            this.Destino.Controls.Add(this.textLote_Num_Suiza);
            this.Destino.Controls.Add(this.textLote_Num_Turquia);
            this.Destino.Controls.Add(this.label2);
            this.Destino.Controls.Add(this.label1);
            this.Destino.Controls.Add(this.textLote_Letras_UK);
            this.Destino.Controls.Add(this.textLote_Letras_Japon);
            this.Destino.Controls.Add(this.textLote_Letras_Suiza);
            this.Destino.Controls.Add(this.textLote_Letras_Turquia);
            this.Destino.Controls.Add(this.regUK);
            this.Destino.Controls.Add(this.checkUK);
            this.Destino.Controls.Add(this.regJapon);
            this.Destino.Controls.Add(this.regSuiza);
            this.Destino.Controls.Add(this.regTurquia);
            this.Destino.Controls.Add(this.checkJapon);
            this.Destino.Controls.Add(this.checkSuiza);
            this.Destino.Controls.Add(this.checkTurquia);
            this.Destino.Location = new System.Drawing.Point(205, 25);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(283, 207);
            this.Destino.TabIndex = 3;
            this.Destino.TabStop = false;
            this.Destino.Text = "Selecciona destino y nº registros";
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.Red;
            this.botonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(94, 156);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(181, 23);
            this.botonBorrar.TabIndex = 16;
            this.botonBorrar.Text = "Borrar Contenido";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // textLote_Num_UK
            // 
            this.textLote_Num_UK.Location = new System.Drawing.Point(200, 111);
            this.textLote_Num_UK.Name = "textLote_Num_UK";
            this.textLote_Num_UK.Size = new System.Drawing.Size(66, 20);
            this.textLote_Num_UK.TabIndex = 15;
            // 
            // textLote_Num_Japon
            // 
            this.textLote_Num_Japon.Location = new System.Drawing.Point(200, 85);
            this.textLote_Num_Japon.Name = "textLote_Num_Japon";
            this.textLote_Num_Japon.Size = new System.Drawing.Size(66, 20);
            this.textLote_Num_Japon.TabIndex = 11;
            // 
            // textLote_Num_Suiza
            // 
            this.textLote_Num_Suiza.Location = new System.Drawing.Point(200, 60);
            this.textLote_Num_Suiza.Name = "textLote_Num_Suiza";
            this.textLote_Num_Suiza.Size = new System.Drawing.Size(66, 20);
            this.textLote_Num_Suiza.TabIndex = 7;
            // 
            // textLote_Num_Turquia
            // 
            this.textLote_Num_Turquia.Location = new System.Drawing.Point(200, 34);
            this.textLote_Num_Turquia.Name = "textLote_Num_Turquia";
            this.textLote_Num_Turquia.Size = new System.Drawing.Size(66, 20);
            this.textLote_Num_Turquia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lotes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registros";
            // 
            // textLote_Letras_UK
            // 
            this.textLote_Letras_UK.Location = new System.Drawing.Point(165, 112);
            this.textLote_Letras_UK.Name = "textLote_Letras_UK";
            this.textLote_Letras_UK.Size = new System.Drawing.Size(29, 20);
            this.textLote_Letras_UK.TabIndex = 14;
            // 
            // textLote_Letras_Japon
            // 
            this.textLote_Letras_Japon.Location = new System.Drawing.Point(165, 85);
            this.textLote_Letras_Japon.Name = "textLote_Letras_Japon";
            this.textLote_Letras_Japon.Size = new System.Drawing.Size(29, 20);
            this.textLote_Letras_Japon.TabIndex = 10;
            // 
            // textLote_Letras_Suiza
            // 
            this.textLote_Letras_Suiza.Location = new System.Drawing.Point(165, 60);
            this.textLote_Letras_Suiza.Name = "textLote_Letras_Suiza";
            this.textLote_Letras_Suiza.Size = new System.Drawing.Size(29, 20);
            this.textLote_Letras_Suiza.TabIndex = 6;
            // 
            // textLote_Letras_Turquia
            // 
            this.textLote_Letras_Turquia.Location = new System.Drawing.Point(165, 34);
            this.textLote_Letras_Turquia.Name = "textLote_Letras_Turquia";
            this.textLote_Letras_Turquia.Size = new System.Drawing.Size(29, 20);
            this.textLote_Letras_Turquia.TabIndex = 2;
            // 
            // regUK
            // 
            this.regUK.Location = new System.Drawing.Point(94, 112);
            this.regUK.Name = "regUK";
            this.regUK.Size = new System.Drawing.Size(51, 20);
            this.regUK.TabIndex = 13;
            // 
            // checkUK
            // 
            this.checkUK.AutoSize = true;
            this.checkUK.Location = new System.Drawing.Point(20, 114);
            this.checkUK.Name = "checkUK";
            this.checkUK.Size = new System.Drawing.Size(70, 17);
            this.checkUK.TabIndex = 12;
            this.checkUK.Text = "Inglaterra";
            this.checkUK.UseVisualStyleBackColor = true;
            this.checkUK.CheckedChanged += new System.EventHandler(this.checkUK_CheckedChanged);
            // 
            // regJapon
            // 
            this.regJapon.Location = new System.Drawing.Point(94, 86);
            this.regJapon.Name = "regJapon";
            this.regJapon.Size = new System.Drawing.Size(51, 20);
            this.regJapon.TabIndex = 9;
            // 
            // regSuiza
            // 
            this.regSuiza.Location = new System.Drawing.Point(94, 60);
            this.regSuiza.Name = "regSuiza";
            this.regSuiza.Size = new System.Drawing.Size(51, 20);
            this.regSuiza.TabIndex = 5;
            // 
            // regTurquia
            // 
            this.regTurquia.CausesValidation = false;
            this.regTurquia.Location = new System.Drawing.Point(94, 34);
            this.regTurquia.Name = "regTurquia";
            this.regTurquia.Size = new System.Drawing.Size(51, 20);
            this.regTurquia.TabIndex = 1;
            // 
            // checkJapon
            // 
            this.checkJapon.AutoSize = true;
            this.checkJapon.Location = new System.Drawing.Point(20, 88);
            this.checkJapon.Name = "checkJapon";
            this.checkJapon.Size = new System.Drawing.Size(55, 17);
            this.checkJapon.TabIndex = 8;
            this.checkJapon.Text = "Japón";
            this.checkJapon.UseVisualStyleBackColor = true;
            this.checkJapon.CheckedChanged += new System.EventHandler(this.checkJapon_CheckedChanged);
            // 
            // checkSuiza
            // 
            this.checkSuiza.AutoSize = true;
            this.checkSuiza.Location = new System.Drawing.Point(20, 62);
            this.checkSuiza.Name = "checkSuiza";
            this.checkSuiza.Size = new System.Drawing.Size(54, 17);
            this.checkSuiza.TabIndex = 4;
            this.checkSuiza.Text = "Suíza";
            this.checkSuiza.UseVisualStyleBackColor = true;
            this.checkSuiza.CheckedChanged += new System.EventHandler(this.checkSuiza_CheckedChanged);
            // 
            // checkTurquia
            // 
            this.checkTurquia.AutoSize = true;
            this.checkTurquia.Location = new System.Drawing.Point(20, 39);
            this.checkTurquia.Name = "checkTurquia";
            this.checkTurquia.Size = new System.Drawing.Size(64, 17);
            this.checkTurquia.TabIndex = 0;
            this.checkTurquia.Text = "Turquía";
            this.checkTurquia.UseVisualStyleBackColor = true;
            this.checkTurquia.CheckedChanged += new System.EventHandler(this.checkTurquia_CheckedChanged);
            // 
            // GenerarListado
            // 
            this.GenerarListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GenerarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarListado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerarListado.Location = new System.Drawing.Point(205, 243);
            this.GenerarListado.Name = "GenerarListado";
            this.GenerarListado.Size = new System.Drawing.Size(283, 74);
            this.GenerarListado.TabIndex = 4;
            this.GenerarListado.Text = "Generar listado";
            this.GenerarListado.UseVisualStyleBackColor = false;
            this.GenerarListado.Click += new System.EventHandler(this.GenerarListado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 323);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(449, 16);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // comboPuertos
            // 
            this.comboPuertos.FormattingEnabled = true;
            this.comboPuertos.Items.AddRange(new object[] {
            "SANTANDER",
            "VALENCIA",
            "ZEEBRUGGE"});
            this.comboPuertos.Location = new System.Drawing.Point(18, 35);
            this.comboPuertos.Name = "comboPuertos";
            this.comboPuertos.Size = new System.Drawing.Size(121, 21);
            this.comboPuertos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboPuertos);
            this.groupBox1.Location = new System.Drawing.Point(39, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pto Descarga";
            // 
            // groupTren
            // 
            this.groupTren.Controls.Add(this.textTren);
            this.groupTren.Location = new System.Drawing.Point(39, 243);
            this.groupTren.Name = "groupTren";
            this.groupTren.Size = new System.Drawing.Size(160, 74);
            this.groupTren.TabIndex = 2;
            this.groupTren.TabStop = false;
            this.groupTren.Text = "Tren";
            // 
            // textTren
            // 
            this.textTren.Location = new System.Drawing.Point(26, 33);
            this.textTren.Name = "textTren";
            this.textTren.Size = new System.Drawing.Size(100, 20);
            this.textTren.TabIndex = 0;
            // 
            // generarListadoBindingSource
            // 
            this.generarListadoBindingSource.DataSource = typeof(WindowsFormsApp1.GenerarListado);
            // 
            // FormularioAduanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 359);
            this.Controls.Add(this.groupTren);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerarListado);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Transporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormularioAduanas";
            this.Text = "Formulario Aduanas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Transporte.ResumeLayout(false);
            this.Transporte.PerformLayout();
            this.Destino.ResumeLayout(false);
            this.Destino.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupTren.ResumeLayout(false);
            this.groupTren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generarListadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Transporte;
        private System.Windows.Forms.RadioButton radioTren;
        private System.Windows.Forms.RadioButton radioCarretera;
        private System.Windows.Forms.GroupBox Destino;
        private System.Windows.Forms.CheckBox checkJapon;
        private System.Windows.Forms.CheckBox checkSuiza;
        private System.Windows.Forms.CheckBox checkTurquia;
        private System.Windows.Forms.Button GenerarListado;
        private System.Windows.Forms.TextBox regTurquia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regUK;
        private System.Windows.Forms.CheckBox checkUK;
        private System.Windows.Forms.TextBox regJapon;
        private System.Windows.Forms.TextBox regSuiza;
        private System.Windows.Forms.BindingSource generarListadoBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textLote_Num_UK;
        private System.Windows.Forms.TextBox textLote_Num_Japon;
        private System.Windows.Forms.TextBox textLote_Num_Suiza;
        private System.Windows.Forms.TextBox textLote_Num_Turquia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLote_Letras_UK;
        private System.Windows.Forms.TextBox textLote_Letras_Japon;
        private System.Windows.Forms.TextBox textLote_Letras_Suiza;
        private System.Windows.Forms.TextBox textLote_Letras_Turquia;
        private System.Windows.Forms.ComboBox comboPuertos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.GroupBox groupTren;
        private System.Windows.Forms.TextBox textTren;
    }
}

