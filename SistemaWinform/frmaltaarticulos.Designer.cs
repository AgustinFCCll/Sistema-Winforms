namespace TPFinalNivel2_Apellido
{
    partial class frmanuevoarticulo
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labeldescripcion = new System.Windows.Forms.Label();
            this.labelcodigoarticulo = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.labelimagen = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigoarticulo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.labelmarca = new System.Windows.Forms.Label();
            this.labelcategoria = new System.Windows.Forms.Label();
            this.comboboxmarca = new System.Windows.Forms.ComboBox();
            this.comboboxcategoria = new System.Windows.Forms.ComboBox();
            this.pictureBoxarticulos = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(107, 36);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labeldescripcion
            // 
            this.labeldescripcion.AutoSize = true;
            this.labeldescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescripcion.Location = new System.Drawing.Point(88, 114);
            this.labeldescripcion.Name = "labeldescripcion";
            this.labeldescripcion.Size = new System.Drawing.Size(79, 17);
            this.labeldescripcion.TabIndex = 2;
            this.labeldescripcion.Text = "Descripcion:";
            // 
            // labelcodigoarticulo
            // 
            this.labelcodigoarticulo.AutoSize = true;
            this.labelcodigoarticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodigoarticulo.Location = new System.Drawing.Point(73, 140);
            this.labelcodigoarticulo.Name = "labelcodigoarticulo";
            this.labelcodigoarticulo.Size = new System.Drawing.Size(102, 17);
            this.labelcodigoarticulo.TabIndex = 3;
            this.labelcodigoarticulo.Text = "Codigo Articulo:";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecio.Location = new System.Drawing.Point(115, 62);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(47, 17);
            this.labelprecio.TabIndex = 4;
            this.labelprecio.Text = "Precio:";
            // 
            // labelimagen
            // 
            this.labelimagen.AutoSize = true;
            this.labelimagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelimagen.Location = new System.Drawing.Point(113, 88);
            this.labelimagen.Name = "labelimagen";
            this.labelimagen.Size = new System.Drawing.Size(54, 17);
            this.labelimagen.TabIndex = 5;
            this.labelimagen.Text = "Imagen:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(173, 33);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtcodigoarticulo
            // 
            this.txtcodigoarticulo.Location = new System.Drawing.Point(173, 137);
            this.txtcodigoarticulo.Name = "txtcodigoarticulo";
            this.txtcodigoarticulo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoarticulo.TabIndex = 7;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(173, 111);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 8;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(173, 59);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 9;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(173, 85);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(100, 20);
            this.txtimagen.TabIndex = 10;
            this.txtimagen.Leave += new System.EventHandler(this.txtimagen_Leave);
            // 
            // labelmarca
            // 
            this.labelmarca.AutoSize = true;
            this.labelmarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarca.Location = new System.Drawing.Point(119, 194);
            this.labelmarca.Name = "labelmarca";
            this.labelmarca.Size = new System.Drawing.Size(48, 17);
            this.labelmarca.TabIndex = 13;
            this.labelmarca.Text = "Marca:";
            // 
            // labelcategoria
            // 
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.Location = new System.Drawing.Point(99, 167);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(68, 17);
            this.labelcategoria.TabIndex = 14;
            this.labelcategoria.Text = "Categoria:";
            // 
            // comboboxmarca
            // 
            this.comboboxmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxmarca.FormattingEnabled = true;
            this.comboboxmarca.Location = new System.Drawing.Point(173, 190);
            this.comboboxmarca.Name = "comboboxmarca";
            this.comboboxmarca.Size = new System.Drawing.Size(100, 21);
            this.comboboxmarca.TabIndex = 15;
            // 
            // comboboxcategoria
            // 
            this.comboboxcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxcategoria.FormattingEnabled = true;
            this.comboboxcategoria.Location = new System.Drawing.Point(173, 163);
            this.comboboxcategoria.Name = "comboboxcategoria";
            this.comboboxcategoria.Size = new System.Drawing.Size(100, 21);
            this.comboboxcategoria.TabIndex = 16;
            // 
            // pictureBoxarticulos
            // 
            this.pictureBoxarticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxarticulos.Location = new System.Drawing.Point(325, 33);
            this.pictureBoxarticulos.Name = "pictureBoxarticulos";
            this.pictureBoxarticulos.Size = new System.Drawing.Size(274, 220);
            this.pictureBoxarticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxarticulos.TabIndex = 17;
            this.pictureBoxarticulos.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(81, 277);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = null;
            this.btncancelar.Location = new System.Drawing.Point(192, 277);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(96, 36);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancelar.UseAccentColor = false;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // frmanuevoarticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 353);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBoxarticulos);
            this.Controls.Add(this.comboboxcategoria);
            this.Controls.Add(this.comboboxmarca);
            this.Controls.Add(this.labelcategoria);
            this.Controls.Add(this.labelmarca);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigoarticulo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.labelimagen);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.labelcodigoarticulo);
            this.Controls.Add(this.labeldescripcion);
            this.Controls.Add(this.labelNombre);
            this.Name = "frmanuevoarticulo";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.frmanuevoarticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labeldescripcion;
        private System.Windows.Forms.Label labelcodigoarticulo;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Label labelimagen;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigoarticulo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Label labelmarca;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.ComboBox comboboxmarca;
        private System.Windows.Forms.ComboBox comboboxcategoria;
        private System.Windows.Forms.PictureBox pictureBoxarticulos;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btncancelar;
    }
}