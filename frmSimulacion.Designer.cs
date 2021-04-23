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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulacion));
            this.grpbProcesos = new System.Windows.Forms.GroupBox();
            this.lblPCB = new System.Windows.Forms.Label();
            this.tabProcesos = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcbInTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EBT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tackQuantum = new System.Windows.Forms.TrackBar();
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtProcessM = new System.Windows.Forms.TextBox();
            this.lblProcessM = new System.Windows.Forms.Label();
            this.txtProcessN = new System.Windows.Forms.TextBox();
            this.lblProcessN = new System.Windows.Forms.Label();
            this.pnelProcessI = new System.Windows.Forms.Panel();
            this.pnelProcesO = new System.Windows.Forms.Panel();
            this.pnelCinco = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProcesos
            // 
            this.grpbProcesos.Controls.Add(this.lblPCB);
            this.grpbProcesos.Controls.Add(this.tabProcesos);
            this.grpbProcesos.Controls.Add(this.label4);
            this.grpbProcesos.Controls.Add(this.lblTitulo);
            this.grpbProcesos.Controls.Add(this.tackQuantum);
            this.grpbProcesos.Controls.Add(this.cmdProcesar);
            this.grpbProcesos.Controls.Add(this.cmdAgregar);
            this.grpbProcesos.Controls.Add(this.txtProcessM);
            this.grpbProcesos.Controls.Add(this.lblProcessM);
            this.grpbProcesos.Controls.Add(this.txtProcessN);
            this.grpbProcesos.Controls.Add(this.lblProcessN);
            this.grpbProcesos.Location = new System.Drawing.Point(12, 12);
            this.grpbProcesos.Name = "grpbProcesos";
            this.grpbProcesos.Size = new System.Drawing.Size(776, 174);
            this.grpbProcesos.TabIndex = 0;
            this.grpbProcesos.TabStop = false;
            this.grpbProcesos.Text = "Simulacion de procesos";
            // 
            // lblPCB
            // 
            this.lblPCB.AutoSize = true;
            this.lblPCB.Location = new System.Drawing.Point(445, 16);
            this.lblPCB.Name = "lblPCB";
            this.lblPCB.Size = new System.Drawing.Size(86, 13);
            this.lblPCB.TabIndex = 8;
            this.lblPCB.Text = "PCB del proceso";
            this.lblPCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabProcesos
            // 
            this.tabProcesos.BackColor = System.Drawing.Color.DimGray;
            this.tabProcesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.Nombre,
            this.Prioridad,
            this.pcbInTime,
            this.EBT,
            this.Usuario,
            this.Estado});
            this.tabProcesos.HideSelection = false;
            this.tabProcesos.Location = new System.Drawing.Point(276, 35);
            this.tabProcesos.Name = "tabProcesos";
            this.tabProcesos.Size = new System.Drawing.Size(494, 128);
            this.tabProcesos.TabIndex = 9;
            this.tabProcesos.UseCompatibleStateImageBehavior = false;
            this.tabProcesos.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 83;
            // 
            // Prioridad
            // 
            this.Prioridad.Text = "Prioridad";
            // 
            // pcbInTime
            // 
            this.pcbInTime.Text = "Llegada";
            // 
            // EBT
            // 
            this.EBT.Text = "EBT";
            this.EBT.Width = 33;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            this.Usuario.Width = 122;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 46;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(57, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre del proceso: ";
            // 
            // tackQuantum
            // 
            this.tackQuantum.BackColor = System.Drawing.Color.DimGray;
            this.tackQuantum.LargeChange = 2;
            this.tackQuantum.Location = new System.Drawing.Point(225, 35);
            this.tackQuantum.Minimum = 1;
            this.tackQuantum.Name = "tackQuantum";
            this.tackQuantum.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tackQuantum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tackQuantum.RightToLeftLayout = true;
            this.tackQuantum.Size = new System.Drawing.Size(45, 128);
            this.tackQuantum.TabIndex = 6;
            this.tackQuantum.TickStyle = System.Windows.Forms.TickStyle.Both;
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
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
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
            // txtProcessM
            // 
            this.txtProcessM.BackColor = System.Drawing.Color.DimGray;
            this.txtProcessM.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtProcessM.Location = new System.Drawing.Point(171, 87);
            this.txtProcessM.MaxLength = 2;
            this.txtProcessM.Name = "txtProcessM";
            this.txtProcessM.Size = new System.Drawing.Size(48, 20);
            this.txtProcessM.TabIndex = 4;
            // 
            // lblProcessM
            // 
            this.lblProcessM.AutoSize = true;
            this.lblProcessM.Location = new System.Drawing.Point(6, 90);
            this.lblProcessM.Name = "lblProcessM";
            this.lblProcessM.Size = new System.Drawing.Size(159, 13);
            this.lblProcessM.TabIndex = 3;
            this.lblProcessM.Text = "Tiempo de ejecucion requerido: ";
            // 
            // txtProcessN
            // 
            this.txtProcessN.BackColor = System.Drawing.Color.DimGray;
            this.txtProcessN.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtProcessN.Location = new System.Drawing.Point(120, 53);
            this.txtProcessN.Name = "txtProcessN";
            this.txtProcessN.Size = new System.Drawing.Size(99, 20);
            this.txtProcessN.TabIndex = 2;
            // 
            // lblProcessN
            // 
            this.lblProcessN.AutoSize = true;
            this.lblProcessN.Location = new System.Drawing.Point(6, 56);
            this.lblProcessN.Name = "lblProcessN";
            this.lblProcessN.Size = new System.Drawing.Size(108, 13);
            this.lblProcessN.TabIndex = 1;
            this.lblProcessN.Text = "Nombre del proceso: ";
            // 
            // pnelProcessI
            // 
            this.pnelProcessI.BackColor = System.Drawing.Color.DimGray;
            this.pnelProcessI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelProcessI.Location = new System.Drawing.Point(12, 213);
            this.pnelProcessI.Name = "pnelProcessI";
            this.pnelProcessI.Size = new System.Drawing.Size(384, 158);
            this.pnelProcessI.TabIndex = 2;
            // 
            // pnelProcesO
            // 
            this.pnelProcesO.BackColor = System.Drawing.Color.DimGray;
            this.pnelProcesO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelProcesO.Location = new System.Drawing.Point(404, 213);
            this.pnelProcesO.Name = "pnelProcesO";
            this.pnelProcesO.Size = new System.Drawing.Size(384, 158);
            this.pnelProcesO.TabIndex = 4;
            // 
            // pnelCinco
            // 
            this.pnelCinco.BackColor = System.Drawing.Color.DimGray;
            this.pnelCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelCinco.Location = new System.Drawing.Point(12, 409);
            this.pnelCinco.Name = "pnelCinco";
            this.pnelCinco.Size = new System.Drawing.Size(776, 159);
            this.pnelCinco.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Representación del proceso original:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordenamiento del proceso con base en su prioridad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ejecución de los procesos con base en planificación Round Robin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSimulacion
            // 
            this.AcceptButton = this.cmdAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(803, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnelCinco);
            this.Controls.Add(this.pnelProcesO);
            this.Controls.Add(this.pnelProcessI);
            this.Controls.Add(this.grpbProcesos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSimulacion";
            this.Text = "Simulacion de procesos";
            this.grpbProcesos.ResumeLayout(false);
            this.grpbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbProcesos;
        private System.Windows.Forms.Button cmdProcesar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtProcessM;
        private System.Windows.Forms.Label lblProcessM;
        private System.Windows.Forms.TextBox txtProcessN;
        private System.Windows.Forms.Label lblProcessN;
        private System.Windows.Forms.TrackBar tackQuantum;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView tabProcesos;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader EBT;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.Label lblPCB;
        private System.Windows.Forms.Panel pnelProcessI;
        private System.Windows.Forms.Panel pnelProcesO;
        private System.Windows.Forms.Panel pnelCinco;
        private System.Windows.Forms.ColumnHeader Prioridad;
        private System.Windows.Forms.ColumnHeader pcbInTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

