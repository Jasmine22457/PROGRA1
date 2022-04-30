namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbProd = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbPrec = new System.Windows.Forms.Label();
            this.lbExis = new System.Windows.Forms.Label();
            this.lbEsta = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.txtExis = new System.Windows.Forms.TextBox();
            this.txtEsta = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(407, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(381, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbProd.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProd.Location = new System.Drawing.Point(9, 73);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(91, 24);
            this.lbProd.TabIndex = 1;
            this.lbProd.Text = "Productos";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbDesc.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDesc.Location = new System.Drawing.Point(9, 119);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(105, 24);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Descripcion";
            // 
            // lbPrec
            // 
            this.lbPrec.AutoSize = true;
            this.lbPrec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbPrec.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrec.Location = new System.Drawing.Point(12, 166);
            this.lbPrec.Name = "lbPrec";
            this.lbPrec.Size = new System.Drawing.Size(61, 24);
            this.lbPrec.TabIndex = 3;
            this.lbPrec.Text = "Precio";
            // 
            // lbExis
            // 
            this.lbExis.AutoSize = true;
            this.lbExis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbExis.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExis.Location = new System.Drawing.Point(9, 216);
            this.lbExis.Name = "lbExis";
            this.lbExis.Size = new System.Drawing.Size(94, 24);
            this.lbExis.TabIndex = 4;
            this.lbExis.Text = "Existencia";
            // 
            // lbEsta
            // 
            this.lbEsta.AutoSize = true;
            this.lbEsta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbEsta.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEsta.Location = new System.Drawing.Point(8, 264);
            this.lbEsta.Name = "lbEsta";
            this.lbEsta.Size = new System.Drawing.Size(65, 24);
            this.lbEsta.TabIndex = 5;
            this.lbEsta.Text = "Estado";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(133, 74);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(192, 23);
            this.txtProd.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(133, 123);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(192, 23);
            this.txtDesc.TabIndex = 7;
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(133, 170);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(192, 23);
            this.txtPrec.TabIndex = 8;
            // 
            // txtExis
            // 
            this.txtExis.Location = new System.Drawing.Point(133, 217);
            this.txtExis.Name = "txtExis";
            this.txtExis.Size = new System.Drawing.Size(192, 23);
            this.txtExis.TabIndex = 9;
            // 
            // txtEsta
            // 
            this.txtEsta.Location = new System.Drawing.Point(133, 265);
            this.txtEsta.Name = "txtEsta";
            this.txtEsta.Size = new System.Drawing.Size(192, 23);
            this.txtEsta.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(31, 342);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 84);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEditar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(202, 342);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(112, 84);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Actualizar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnBorrar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBorrar.Location = new System.Drawing.Point(31, 436);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(112, 84);
            this.BtnBorrar.TabIndex = 13;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCerrar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.Location = new System.Drawing.Point(202, 436);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(112, 84);
            this.BtnCerrar.TabIndex = 14;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtEsta);
            this.Controls.Add(this.txtExis);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.lbEsta);
            this.Controls.Add(this.lbExis);
            this.Controls.Add(this.lbPrec);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbProd;
        private Label lbDesc;
        private Label lbPrec;
        private Label lbExis;
        private Label lbEsta;
        private TextBox txtProd;
        private TextBox txtDesc;
        private TextBox txtPrec;
        private TextBox txtExis;
        private TextBox txtEsta;
        private Button BtnGuardar;
        private Button BtnEditar;
        private Button BtnBorrar;
        private Button BtnCerrar;
    }
}