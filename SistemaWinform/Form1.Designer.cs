namespace TPFinalNivel2_Apellido
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pictureboxarticulos = new System.Windows.Forms.PictureBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.Labelfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.labelcampo = new System.Windows.Forms.Label();
            this.comboBoxcampo = new System.Windows.Forms.ComboBox();
            this.labelcriterio = new System.Windows.Forms.Label();
            this.comboBoxcriterio = new System.Windows.Forms.ComboBox();
            this.labelfiltroavanzado = new System.Windows.Forms.Label();
            this.textBoxfiltroavanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv.Location = new System.Drawing.Point(22, 123);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(464, 489);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // pictureboxarticulos
            // 
            this.pictureboxarticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxarticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxarticulos.Location = new System.Drawing.Point(510, 123);
            this.pictureboxarticulos.Name = "pictureboxarticulos";
            this.pictureboxarticulos.Size = new System.Drawing.Size(322, 489);
            this.pictureboxarticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxarticulos.TabIndex = 1;
            this.pictureboxarticulos.TabStop = false;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonbuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Location = new System.Drawing.Point(676, 85);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonbuscar.TabIndex = 5;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // Labelfiltro
            // 
            this.Labelfiltro.AutoSize = true;
            this.Labelfiltro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelfiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Labelfiltro.Location = new System.Drawing.Point(24, 34);
            this.Labelfiltro.Name = "Labelfiltro";
            this.Labelfiltro.Size = new System.Drawing.Size(40, 17);
            this.Labelfiltro.TabIndex = 6;
            this.Labelfiltro.Text = "Filtro:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfiltro.Location = new System.Drawing.Point(69, 34);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(665, 20);
            this.txtfiltro.TabIndex = 7;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(285, 642);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "Agregar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(403, 642);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(99, 36);
            this.materialButton2.TabIndex = 9;
            this.materialButton2.Text = "Modificar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(527, 642);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(88, 36);
            this.materialButton3.TabIndex = 10;
            this.materialButton3.Text = "Eliminar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // labelcampo
            // 
            this.labelcampo.AutoSize = true;
            this.labelcampo.Location = new System.Drawing.Point(24, 89);
            this.labelcampo.Name = "labelcampo";
            this.labelcampo.Size = new System.Drawing.Size(43, 13);
            this.labelcampo.TabIndex = 11;
            this.labelcampo.Text = "Campo:";
            // 
            // comboBoxcampo
            // 
            this.comboBoxcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcampo.FormattingEnabled = true;
            this.comboBoxcampo.Location = new System.Drawing.Point(81, 85);
            this.comboBoxcampo.Name = "comboBoxcampo";
            this.comboBoxcampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcampo.TabIndex = 12;
            this.comboBoxcampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxcampo_SelectedIndexChanged);
            // 
            // labelcriterio
            // 
            this.labelcriterio.AutoSize = true;
            this.labelcriterio.Location = new System.Drawing.Point(237, 89);
            this.labelcriterio.Name = "labelcriterio";
            this.labelcriterio.Size = new System.Drawing.Size(42, 13);
            this.labelcriterio.TabIndex = 13;
            this.labelcriterio.Text = "Criterio:";
            // 
            // comboBoxcriterio
            // 
            this.comboBoxcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcriterio.FormattingEnabled = true;
            this.comboBoxcriterio.Location = new System.Drawing.Point(298, 85);
            this.comboBoxcriterio.Name = "comboBoxcriterio";
            this.comboBoxcriterio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcriterio.TabIndex = 14;
            // 
            // labelfiltroavanzado
            // 
            this.labelfiltroavanzado.AutoSize = true;
            this.labelfiltroavanzado.Location = new System.Drawing.Point(451, 89);
            this.labelfiltroavanzado.Name = "labelfiltroavanzado";
            this.labelfiltroavanzado.Size = new System.Drawing.Size(32, 13);
            this.labelfiltroavanzado.TabIndex = 15;
            this.labelfiltroavanzado.Text = "Filtro:";
            // 
            // textBoxfiltroavanzado
            // 
            this.textBoxfiltroavanzado.Location = new System.Drawing.Point(527, 85);
            this.textBoxfiltroavanzado.Name = "textBoxfiltroavanzado";
            this.textBoxfiltroavanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxfiltroavanzado.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(855, 692);
            this.Controls.Add(this.textBoxfiltroavanzado);
            this.Controls.Add(this.labelfiltroavanzado);
            this.Controls.Add(this.comboBoxcriterio);
            this.Controls.Add(this.labelcriterio);
            this.Controls.Add(this.comboBoxcampo);
            this.Controls.Add(this.labelcampo);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.Labelfiltro);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.pictureboxarticulos);
            this.Controls.Add(this.dgv);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox pictureboxarticulos;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Label Labelfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label labelcampo;
        private System.Windows.Forms.ComboBox comboBoxcampo;
        private System.Windows.Forms.Label labelcriterio;
        private System.Windows.Forms.ComboBox comboBoxcriterio;
        private System.Windows.Forms.Label labelfiltroavanzado;
        private System.Windows.Forms.TextBox textBoxfiltroavanzado;
    }
}

