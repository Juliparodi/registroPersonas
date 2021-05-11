using System.Windows.Forms;

namespace registroPersonasConsole
{
    partial class Form1
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
            this.t = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ti = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.tiso = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmbTipoDNI = new System.Windows.Forms.ComboBox();
            this.tis = new System.Windows.Forms.Label();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(85, 57);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(44, 13);
            this.t.TabIndex = 0;
            this.t.Text = "Nombre";
            this.t.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // ti
            // 
            this.ti.AutoSize = true;
            this.ti.Location = new System.Drawing.Point(85, 93);
            this.ti.Name = "ti";
            this.ti.Size = new System.Drawing.Size(44, 13);
            this.ti.TabIndex = 2;
            this.ti.Text = "Apellido";
            this.ti.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // tiso
            // 
            this.tiso.AutoSize = true;
            this.tiso.Location = new System.Drawing.Point(103, 200);
            this.tiso.Name = "tiso";
            this.tiso.Size = new System.Drawing.Size(26, 13);
            this.tiso.TabIndex = 4;
            this.tiso.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(157, 197);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // cmbTipoDNI
            // 
            this.cmbTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDNI.FormattingEnabled = true;
            this.cmbTipoDNI.Location = new System.Drawing.Point(157, 129);
            this.cmbTipoDNI.Name = "cmbTipoDNI";
            this.cmbTipoDNI.Size = new System.Drawing.Size(90, 21);
            this.cmbTipoDNI.TabIndex = 7;
            this.cmbTipoDNI.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDNI_SelectedIndexChanged);
            // 
            // tis
            // 
            this.tis.AutoSize = true;
            this.tis.Location = new System.Drawing.Point(94, 132);
            this.tis.Name = "tis";
            this.tis.Size = new System.Drawing.Size(43, 13);
            this.tis.TabIndex = 8;
            this.tis.Text = "tipoDNI";
            // 
            // btnVerLista
            // 
            this.btnVerLista.Location = new System.Drawing.Point(433, 299);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(94, 38);
            this.btnVerLista.TabIndex = 9;
            this.btnVerLista.Text = "Ver Lista";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(106, 299);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 38);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(225, 253);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(55, 17);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.tis);
            this.Controls.Add(this.cmbTipoDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.tiso);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.ti);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label ti;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label tiso;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cmbTipoDNI;
        private System.Windows.Forms.Label tis;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private CheckBox chkActivo;
    }
}

