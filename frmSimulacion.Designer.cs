﻿
namespace Simulacion
{
    partial class frmSimulacion
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
            this.tackQuantum = new System.Windows.Forms.TrackBar();
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtProccesT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProccesN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabProcesos = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProcesos
            // 
            this.grpbProcesos.Controls.Add(this.tabProcesos);
            this.grpbProcesos.Controls.Add(this.label4);
            this.grpbProcesos.Controls.Add(this.label3);
            this.grpbProcesos.Controls.Add(this.tackQuantum);
            this.grpbProcesos.Controls.Add(this.cmdProcesar);
            this.grpbProcesos.Controls.Add(this.cmdAgregar);
            this.grpbProcesos.Controls.Add(this.txtProccesT);
            this.grpbProcesos.Controls.Add(this.label2);
            this.grpbProcesos.Controls.Add(this.txtProccesN);
            this.grpbProcesos.Controls.Add(this.label1);
            this.grpbProcesos.Location = new System.Drawing.Point(12, 12);
            this.grpbProcesos.Name = "grpbProcesos";
            this.grpbProcesos.Size = new System.Drawing.Size(776, 187);
            this.grpbProcesos.TabIndex = 0;
            this.grpbProcesos.TabStop = false;
            this.grpbProcesos.Text = "Simulacion de procesos";
            // 
            // tackQuantum
            // 
            this.tackQuantum.Location = new System.Drawing.Point(225, 35);
            this.tackQuantum.Minimum = 1;
            this.tackQuantum.Name = "tackQuantum";
            this.tackQuantum.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tackQuantum.Size = new System.Drawing.Size(45, 128);
            this.tackQuantum.TabIndex = 6;
            this.tackQuantum.Value = 1;
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Location = new System.Drawing.Point(120, 136);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(99, 23);
            this.cmdProcesar.TabIndex = 7;
            this.cmdProcesar.Text = "Procesar";
            this.cmdProcesar.UseVisualStyleBackColor = true;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(9, 136);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(105, 23);
            this.cmdAgregar.TabIndex = 5;
            this.cmdAgregar.Text = "Agregar proceso";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtProccesT
            // 
            this.txtProccesT.Location = new System.Drawing.Point(171, 87);
            this.txtProccesT.Name = "txtProccesT";
            this.txtProccesT.Size = new System.Drawing.Size(48, 20);
            this.txtProccesT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo de ejecucion requerido: ";
            // 
            // txtProccesN
            // 
            this.txtProccesN.Location = new System.Drawing.Point(120, 53);
            this.txtProccesN.Name = "txtProccesN";
            this.txtProccesN.Size = new System.Drawing.Size(99, 20);
            this.txtProccesN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del proceso: ";
            // 
            // panelLoading
            // 
            this.panelLoading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLoading.CausesValidation = false;
            this.panelLoading.Enabled = false;
            this.panelLoading.Location = new System.Drawing.Point(12, 184);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(390, 244);
            this.panelLoading.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del proceso: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantums:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.CausesValidation = false;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(408, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 244);
            this.panel1.TabIndex = 2;
            // 
            // tabProcesos
            // 
            this.tabProcesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.Nombre,
            this.Memoria,
            this.Usuario,
            this.Estado});
            this.tabProcesos.HideSelection = false;
            this.tabProcesos.Location = new System.Drawing.Point(286, 10);
            this.tabProcesos.Name = "tabProcesos";
            this.tabProcesos.Size = new System.Drawing.Size(484, 149);
            this.tabProcesos.TabIndex = 9;
            this.tabProcesos.UseCompatibleStateImageBehavior = false;
            this.tabProcesos.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "Identificador";
            this.PID.Width = 71;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 86;
            // 
            // Memoria
            // 
            this.Memoria.Text = "Memoria";
            this.Memoria.Width = 53;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 82;
            // 
            // frmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.grpbProcesos);
            this.Name = "frmSimulacion";
            this.Text = "Simulacion de procesos";
            this.grpbProcesos.ResumeLayout(false);
            this.grpbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbProcesos;
        private System.Windows.Forms.Button cmdProcesar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtProccesT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProccesN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.TrackBar tackQuantum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView tabProcesos;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Memoria;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader Estado;
    }
}

