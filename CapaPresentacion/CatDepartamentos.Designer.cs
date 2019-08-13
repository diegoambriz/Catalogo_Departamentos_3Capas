namespace CapaPresentacion
{
    partial class CatDepartamentos
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Lbl_IdOficina = new System.Windows.Forms.Label();
            this.Txt_IdOficina = new System.Windows.Forms.TextBox();
            this.Txt_DescripcionDepto = new System.Windows.Forms.TextBox();
            this.Lbl_DescripcionDepto = new System.Windows.Forms.Label();
            this.Lbl_DeptoActivo = new System.Windows.Forms.Label();
            this.Btn_InsertarDepto = new System.Windows.Forms.Button();
            this.Grd_Departamentos = new System.Windows.Forms.DataGridView();
            this.Txt_IdDpto = new System.Windows.Forms.TextBox();
            this.Lbl_IdDpto = new System.Windows.Forms.Label();
            this.Cbo_DeptoActivo = new System.Windows.Forms.ComboBox();
            this.Btn_ModificarDepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Departamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(2, -1);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(133, 20);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Departamentos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_IdOficina
            // 
            this.Lbl_IdOficina.AutoSize = true;
            this.Lbl_IdOficina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_IdOficina.Location = new System.Drawing.Point(24, 141);
            this.Lbl_IdOficina.Name = "Lbl_IdOficina";
            this.Lbl_IdOficina.Size = new System.Drawing.Size(52, 13);
            this.Lbl_IdOficina.TabIndex = 1;
            this.Lbl_IdOficina.Text = "Id Oficina";
            // 
            // Txt_IdOficina
            // 
            this.Txt_IdOficina.Location = new System.Drawing.Point(123, 138);
            this.Txt_IdOficina.Name = "Txt_IdOficina";
            this.Txt_IdOficina.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdOficina.TabIndex = 2;
            // 
            // Txt_DescripcionDepto
            // 
            this.Txt_DescripcionDepto.Location = new System.Drawing.Point(123, 182);
            this.Txt_DescripcionDepto.Name = "Txt_DescripcionDepto";
            this.Txt_DescripcionDepto.Size = new System.Drawing.Size(100, 20);
            this.Txt_DescripcionDepto.TabIndex = 4;
            // 
            // Lbl_DescripcionDepto
            // 
            this.Lbl_DescripcionDepto.AutoSize = true;
            this.Lbl_DescripcionDepto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_DescripcionDepto.Location = new System.Drawing.Point(24, 176);
            this.Lbl_DescripcionDepto.Name = "Lbl_DescripcionDepto";
            this.Lbl_DescripcionDepto.Size = new System.Drawing.Size(74, 26);
            this.Lbl_DescripcionDepto.TabIndex = 3;
            this.Lbl_DescripcionDepto.Text = "Descripcion\r\nDepartamento";
            // 
            // Lbl_DeptoActivo
            // 
            this.Lbl_DeptoActivo.AutoSize = true;
            this.Lbl_DeptoActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_DeptoActivo.Location = new System.Drawing.Point(24, 221);
            this.Lbl_DeptoActivo.Name = "Lbl_DeptoActivo";
            this.Lbl_DeptoActivo.Size = new System.Drawing.Size(74, 26);
            this.Lbl_DeptoActivo.TabIndex = 5;
            this.Lbl_DeptoActivo.Text = "Departamento\r\nActivo";
            // 
            // Btn_InsertarDepto
            // 
            this.Btn_InsertarDepto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_InsertarDepto.Location = new System.Drawing.Point(27, 284);
            this.Btn_InsertarDepto.Name = "Btn_InsertarDepto";
            this.Btn_InsertarDepto.Size = new System.Drawing.Size(75, 23);
            this.Btn_InsertarDepto.TabIndex = 7;
            this.Btn_InsertarDepto.Text = "Insertar";
            this.Btn_InsertarDepto.UseVisualStyleBackColor = true;
            this.Btn_InsertarDepto.Click += new System.EventHandler(this.Btn_InsertarDepto_Click);
            // 
            // Grd_Departamentos
            // 
            this.Grd_Departamentos.AllowUserToAddRows = false;
            this.Grd_Departamentos.AllowUserToDeleteRows = false;
            this.Grd_Departamentos.ColumnHeadersHeight = 30;
            this.Grd_Departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grd_Departamentos.Location = new System.Drawing.Point(274, 95);
            this.Grd_Departamentos.Name = "Grd_Departamentos";
            this.Grd_Departamentos.ReadOnly = true;
            this.Grd_Departamentos.Size = new System.Drawing.Size(563, 212);
            this.Grd_Departamentos.TabIndex = 8;
            this.Grd_Departamentos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grd_Departamentos_CellMouseClick);
            // 
            // Txt_IdDpto
            // 
            this.Txt_IdDpto.Enabled = false;
            this.Txt_IdDpto.Location = new System.Drawing.Point(123, 95);
            this.Txt_IdDpto.Name = "Txt_IdDpto";
            this.Txt_IdDpto.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdDpto.TabIndex = 10;
            // 
            // Lbl_IdDpto
            // 
            this.Lbl_IdDpto.AutoSize = true;
            this.Lbl_IdDpto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_IdDpto.Location = new System.Drawing.Point(24, 98);
            this.Lbl_IdDpto.Name = "Lbl_IdDpto";
            this.Lbl_IdDpto.Size = new System.Drawing.Size(86, 13);
            this.Lbl_IdDpto.TabIndex = 9;
            this.Lbl_IdDpto.Text = "Id Departamento";
            // 
            // Cbo_DeptoActivo
            // 
            this.Cbo_DeptoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_DeptoActivo.FormattingEnabled = true;
            this.Cbo_DeptoActivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_DeptoActivo.Location = new System.Drawing.Point(123, 226);
            this.Cbo_DeptoActivo.Name = "Cbo_DeptoActivo";
            this.Cbo_DeptoActivo.Size = new System.Drawing.Size(100, 21);
            this.Cbo_DeptoActivo.TabIndex = 11;
            this.Cbo_DeptoActivo.Tag = "";
            // 
            // Btn_ModificarDepto
            // 
            this.Btn_ModificarDepto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ModificarDepto.Location = new System.Drawing.Point(123, 284);
            this.Btn_ModificarDepto.Name = "Btn_ModificarDepto";
            this.Btn_ModificarDepto.Size = new System.Drawing.Size(75, 23);
            this.Btn_ModificarDepto.TabIndex = 12;
            this.Btn_ModificarDepto.Text = "Modificar";
            this.Btn_ModificarDepto.UseVisualStyleBackColor = true;
            this.Btn_ModificarDepto.Click += new System.EventHandler(this.Btn_ModificarDepto_Click);
            // 
            // CatDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.Btn_ModificarDepto);
            this.Controls.Add(this.Cbo_DeptoActivo);
            this.Controls.Add(this.Txt_IdDpto);
            this.Controls.Add(this.Lbl_IdDpto);
            this.Controls.Add(this.Grd_Departamentos);
            this.Controls.Add(this.Btn_InsertarDepto);
            this.Controls.Add(this.Lbl_DeptoActivo);
            this.Controls.Add(this.Txt_DescripcionDepto);
            this.Controls.Add(this.Lbl_DescripcionDepto);
            this.Controls.Add(this.Txt_IdOficina);
            this.Controls.Add(this.Lbl_IdOficina);
            this.Controls.Add(this.LblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CatDepartamentos";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.CatDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Departamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label Lbl_IdOficina;
        private System.Windows.Forms.TextBox Txt_IdOficina;
        private System.Windows.Forms.TextBox Txt_DescripcionDepto;
        private System.Windows.Forms.Label Lbl_DescripcionDepto;
        private System.Windows.Forms.Label Lbl_DeptoActivo;
        private System.Windows.Forms.Button Btn_InsertarDepto;
        private System.Windows.Forms.DataGridView Grd_Departamentos;
        private System.Windows.Forms.TextBox Txt_IdDpto;
        private System.Windows.Forms.Label Lbl_IdDpto;
        private System.Windows.Forms.ComboBox Cbo_DeptoActivo;
        private System.Windows.Forms.Button Btn_ModificarDepto;
    }
}

