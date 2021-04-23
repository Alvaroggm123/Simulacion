
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
            this.lblPCB = new System.Windows.Forms.Label();
            this.tabProcesos = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Prioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblPCB.Location = new System.Drawing.Point(471, 19);
            this.lblPCB.Name = "lblPCB";
            this.lblPCB.Size = new System.Drawing.Size(89, 13);
            this.lblPCB.TabIndex = 8;
            this.lblPCB.Text = "PCB del proceso.";
            this.lblPCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabProcesos
            // 
            this.tabProcesos.BackColor = System.Drawing.Color.DimGray;
            this.tabProcesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.Nombre,
            this.Prioridad,
            this.EBT,
            this.Usuario,
            this.Estado});
            this.tabProcesos.HideSelection = false;
            this.tabProcesos.Location = new System.Drawing.Point(330, 35);
            this.tabProcesos.Name = "tabProcesos";
            this.tabProcesos.Size = new System.Drawing.Size(440, 128);
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
            // EBT
            // 
            this.EBT.Text = "EBT";
            this.EBT.Width = 53;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 19);
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
            this.tackQuantum.Location = new System.Drawing.Point(253, 35);
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
            this.pnelProcessI.Location = new System.Drawing.Point(12, 192);
            this.pnelProcessI.Name = "pnelProcessI";
            this.pnelProcessI.Size = new System.Drawing.Size(384, 179);
            this.pnelProcessI.TabIndex = 1;
            // 
            // pnelProcesO
            // 
            this.pnelProcesO.BackColor = System.Drawing.Color.DimGray;
            this.pnelProcesO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelProcesO.Location = new System.Drawing.Point(404, 192);
            this.pnelProcesO.Name = "pnelProcesO";
            this.pnelProcesO.Size = new System.Drawing.Size(384, 179);
            this.pnelProcesO.TabIndex = 2;
            // 
            // pnelCinco
            // 
            this.pnelCinco.BackColor = System.Drawing.Color.DimGray;
            this.pnelCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelCinco.Location = new System.Drawing.Point(12, 377);
            this.pnelCinco.Name = "pnelCinco";
            this.pnelCinco.Size = new System.Drawing.Size(776, 191);
            this.pnelCinco.TabIndex = 3;
            // 
            // Prioridad
            // 
            this.Prioridad.Text = "Prioridad";
            // 
            // frmSimulacion
            // 
            this.AcceptButton = this.cmdAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(803, 585);
            this.Controls.Add(this.pnelCinco);
            this.Controls.Add(this.pnelProcesO);
            this.Controls.Add(this.pnelProcessI);
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
    }
}

