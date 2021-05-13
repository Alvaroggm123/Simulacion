
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulacion));
            this.grpbProcesos = new System.Windows.Forms.GroupBox();
            this.lblPCB = new System.Windows.Forms.Label();
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
            this.lblPCBoriginal = new System.Windows.Forms.Label();
            this.lblPCBordenado = new System.Windows.Forms.Label();
            this.lblProcesado = new System.Windows.Forms.Label();
            this.timQuant = new System.Windows.Forms.Timer(this.components);
            this.datagvPCB = new System.Windows.Forms.DataGridView();
            this.grpbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPCB)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProcesos
            // 
            this.grpbProcesos.Controls.Add(this.datagvPCB);
            this.grpbProcesos.Controls.Add(this.lblPCB);
            this.grpbProcesos.Controls.Add(this.label4);
            this.grpbProcesos.Controls.Add(this.lblTitulo);
            this.grpbProcesos.Controls.Add(this.tackQuantum);
            this.grpbProcesos.Controls.Add(this.cmdProcesar);
            this.grpbProcesos.Controls.Add(this.cmdAgregar);
            this.grpbProcesos.Controls.Add(this.txtProcessM);
            this.grpbProcesos.Controls.Add(this.lblProcessM);
            this.grpbProcesos.Controls.Add(this.txtProcessN);
            this.grpbProcesos.Controls.Add(this.lblProcessN);
            this.grpbProcesos.Location = new System.Drawing.Point(16, 13);
            this.grpbProcesos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbProcesos.Name = "grpbProcesos";
            this.grpbProcesos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbProcesos.Size = new System.Drawing.Size(1035, 214);
            this.grpbProcesos.TabIndex = 0;
            this.grpbProcesos.TabStop = false;
            this.grpbProcesos.Text = "Simulacion de procesos";
            // 
            // lblPCB
            // 
            this.lblPCB.AutoSize = true;
            this.lblPCB.Location = new System.Drawing.Point(629, 19);
            this.lblPCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCB.Name = "lblPCB";
            this.lblPCB.Size = new System.Drawing.Size(113, 17);
            this.lblPCB.TabIndex = 8;
            this.lblPCB.Text = "PCB del proceso";
            this.lblPCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantums:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(76, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre del proceso: ";
            // 
            // tackQuantum
            // 
            this.tackQuantum.BackColor = System.Drawing.Color.DimGray;
            this.tackQuantum.LargeChange = 2;
            this.tackQuantum.Location = new System.Drawing.Point(300, 43);
            this.tackQuantum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tackQuantum.Minimum = 1;
            this.tackQuantum.Name = "tackQuantum";
            this.tackQuantum.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tackQuantum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tackQuantum.RightToLeftLayout = true;
            this.tackQuantum.Size = new System.Drawing.Size(56, 158);
            this.tackQuantum.TabIndex = 6;
            this.tackQuantum.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tackQuantum.Value = 1;
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Location = new System.Drawing.Point(160, 167);
            this.cmdProcesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(132, 28);
            this.cmdProcesar.TabIndex = 7;
            this.cmdProcesar.Text = "Procesar";
            this.cmdProcesar.UseVisualStyleBackColor = true;
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(12, 167);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(140, 28);
            this.cmdAgregar.TabIndex = 5;
            this.cmdAgregar.Text = "Agregar proceso";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtProcessM
            // 
            this.txtProcessM.BackColor = System.Drawing.Color.DimGray;
            this.txtProcessM.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtProcessM.Location = new System.Drawing.Point(228, 107);
            this.txtProcessM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcessM.MaxLength = 2;
            this.txtProcessM.Name = "txtProcessM";
            this.txtProcessM.Size = new System.Drawing.Size(63, 22);
            this.txtProcessM.TabIndex = 4;
            // 
            // lblProcessM
            // 
            this.lblProcessM.AutoSize = true;
            this.lblProcessM.Location = new System.Drawing.Point(8, 111);
            this.lblProcessM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessM.Name = "lblProcessM";
            this.lblProcessM.Size = new System.Drawing.Size(212, 17);
            this.lblProcessM.TabIndex = 3;
            this.lblProcessM.Text = "Tiempo de ejecucion requerido: ";
            // 
            // txtProcessN
            // 
            this.txtProcessN.BackColor = System.Drawing.Color.DimGray;
            this.txtProcessN.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtProcessN.Location = new System.Drawing.Point(160, 65);
            this.txtProcessN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcessN.Name = "txtProcessN";
            this.txtProcessN.Size = new System.Drawing.Size(131, 22);
            this.txtProcessN.TabIndex = 2;
            // 
            // lblProcessN
            // 
            this.lblProcessN.AutoSize = true;
            this.lblProcessN.Location = new System.Drawing.Point(8, 69);
            this.lblProcessN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessN.Name = "lblProcessN";
            this.lblProcessN.Size = new System.Drawing.Size(144, 17);
            this.lblProcessN.TabIndex = 1;
            this.lblProcessN.Text = "Nombre del proceso: ";
            // 
            // pnelProcessI
            // 
            this.pnelProcessI.BackColor = System.Drawing.Color.DimGray;
            this.pnelProcessI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelProcessI.Location = new System.Drawing.Point(16, 262);
            this.pnelProcessI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnelProcessI.Name = "pnelProcessI";
            this.pnelProcessI.Size = new System.Drawing.Size(511, 194);
            this.pnelProcessI.TabIndex = 2;
            // 
            // pnelProcesO
            // 
            this.pnelProcesO.BackColor = System.Drawing.Color.DimGray;
            this.pnelProcesO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelProcesO.Location = new System.Drawing.Point(539, 262);
            this.pnelProcesO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnelProcesO.Name = "pnelProcesO";
            this.pnelProcesO.Size = new System.Drawing.Size(511, 194);
            this.pnelProcesO.TabIndex = 4;
            // 
            // pnelCinco
            // 
            this.pnelCinco.BackColor = System.Drawing.Color.DimGray;
            this.pnelCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelCinco.Location = new System.Drawing.Point(16, 503);
            this.pnelCinco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnelCinco.Name = "pnelCinco";
            this.pnelCinco.Size = new System.Drawing.Size(1034, 195);
            this.pnelCinco.TabIndex = 6;
            // 
            // lblPCBoriginal
            // 
            this.lblPCBoriginal.AutoSize = true;
            this.lblPCBoriginal.Location = new System.Drawing.Point(151, 242);
            this.lblPCBoriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCBoriginal.Name = "lblPCBoriginal";
            this.lblPCBoriginal.Size = new System.Drawing.Size(240, 17);
            this.lblPCBoriginal.TabIndex = 1;
            this.lblPCBoriginal.Text = "Representación del proceso original:";
            this.lblPCBoriginal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPCBordenado
            // 
            this.lblPCBordenado.AutoSize = true;
            this.lblPCBordenado.Location = new System.Drawing.Point(623, 242);
            this.lblPCBordenado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCBordenado.Name = "lblPCBordenado";
            this.lblPCBordenado.Size = new System.Drawing.Size(341, 17);
            this.lblPCBordenado.TabIndex = 3;
            this.lblPCBordenado.Text = "Ordenamiento del proceso con base en su prioridad:";
            this.lblPCBordenado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProcesado
            // 
            this.lblProcesado.AutoSize = true;
            this.lblProcesado.Location = new System.Drawing.Point(312, 484);
            this.lblProcesado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcesado.Name = "lblProcesado";
            this.lblProcesado.Size = new System.Drawing.Size(428, 17);
            this.lblProcesado.TabIndex = 5;
            this.lblProcesado.Text = "Ejecución de los procesos con base en planificación Round Robin:";
            this.lblProcesado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timQuant
            // 
            this.timQuant.Tick += new System.EventHandler(this.timQuant_Tick);
            // 
            // datagvPCB
            // 
            this.datagvPCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datagvPCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvPCB.Location = new System.Drawing.Point(380, 40);
            this.datagvPCB.Name = "datagvPCB";
            this.datagvPCB.RowHeadersWidth = 51;
            this.datagvPCB.RowTemplate.Height = 24;
            this.datagvPCB.Size = new System.Drawing.Size(648, 167);
            this.datagvPCB.TabIndex = 9;
            // 
            // frmSimulacion
            // 
            this.AcceptButton = this.cmdAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1071, 720);
            this.Controls.Add(this.lblProcesado);
            this.Controls.Add(this.lblPCBordenado);
            this.Controls.Add(this.lblPCBoriginal);
            this.Controls.Add(this.pnelCinco);
            this.Controls.Add(this.pnelProcesO);
            this.Controls.Add(this.pnelProcessI);
            this.Controls.Add(this.grpbProcesos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmSimulacion";
            this.Text = "Simulacion de procesos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSimulacion_FormClosing);
            this.grpbProcesos.ResumeLayout(false);
            this.grpbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPCB)).EndInit();
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
        private System.Windows.Forms.Label lblPCB;
        private System.Windows.Forms.Panel pnelProcessI;
        private System.Windows.Forms.Panel pnelProcesO;
        private System.Windows.Forms.Panel pnelCinco;
        private System.Windows.Forms.Label lblPCBoriginal;
        private System.Windows.Forms.Label lblPCBordenado;
        private System.Windows.Forms.Label lblProcesado;
        private System.Windows.Forms.Timer timQuant;
        private System.Windows.Forms.DataGridView datagvPCB;
    }
}

