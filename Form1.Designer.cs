
namespace Simulacion
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
            this.grpbProcesos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProccesN = new System.Windows.Forms.TextBox();
            this.txtProccesT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Procesar = new System.Windows.Forms.Button();
            this.datagProcesos = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProcesos
            // 
            this.grpbProcesos.Controls.Add(this.datagProcesos);
            this.grpbProcesos.Controls.Add(this.Procesar);
            this.grpbProcesos.Controls.Add(this.button1);
            this.grpbProcesos.Controls.Add(this.txtProccesT);
            this.grpbProcesos.Controls.Add(this.label2);
            this.grpbProcesos.Controls.Add(this.txtProccesN);
            this.grpbProcesos.Controls.Add(this.label1);
            this.grpbProcesos.Location = new System.Drawing.Point(12, 12);
            this.grpbProcesos.Name = "grpbProcesos";
            this.grpbProcesos.Size = new System.Drawing.Size(776, 119);
            this.grpbProcesos.TabIndex = 0;
            this.grpbProcesos.TabStop = false;
            this.grpbProcesos.Text = "Agregar nuevo proceso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del proceso: ";
            // 
            // txtProccesN
            // 
            this.txtProccesN.Location = new System.Drawing.Point(120, 25);
            this.txtProccesN.Name = "txtProccesN";
            this.txtProccesN.Size = new System.Drawing.Size(99, 20);
            this.txtProccesN.TabIndex = 1;
            // 
            // txtProccesT
            // 
            this.txtProccesT.Location = new System.Drawing.Point(171, 51);
            this.txtProccesT.Name = "txtProccesT";
            this.txtProccesT.Size = new System.Drawing.Size(48, 20);
            this.txtProccesT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo de ejecucion requerido: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hecho";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(120, 77);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(99, 23);
            this.Procesar.TabIndex = 5;
            this.Procesar.Text = "Procesar";
            this.Procesar.UseVisualStyleBackColor = true;
            // 
            // datagProcesos
            // 
            this.datagProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Tiempo,
            this.Nombre,
            this.Usuario,
            this.Estado});
            this.datagProcesos.Location = new System.Drawing.Point(225, 19);
            this.datagProcesos.Name = "datagProcesos";
            this.datagProcesos.Size = new System.Drawing.Size(545, 94);
            this.datagProcesos.TabIndex = 1;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 291);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpbProcesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbProcesos.ResumeLayout(false);
            this.grpbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagProcesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbProcesos;
        private System.Windows.Forms.Button Procesar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProccesT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProccesN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel panel1;
    }
}

