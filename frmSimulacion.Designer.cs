
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
            this.datagvLlegada = new System.Windows.Forms.DataGridView();
            this.lblProcesando = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tackQuantum = new System.Windows.Forms.TrackBar();
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtProcessM = new System.Windows.Forms.TextBox();
            this.lblProcessM = new System.Windows.Forms.Label();
            this.txtProcessN = new System.Windows.Forms.TextBox();
            this.lblProcessN = new System.Windows.Forms.Label();
            this.pnelLlegada = new System.Windows.Forms.Panel();
            this.pnelCola = new System.Windows.Forms.Panel();
            this.lblPCBLlegada = new System.Windows.Forms.Label();
            this.lblPCBCola = new System.Windows.Forms.Label();
            this.timQuant = new System.Windows.Forms.Timer(this.components);
            this.datagvCola = new System.Windows.Forms.DataGridView();
            this.cmdTick = new System.Windows.Forms.Button();
            this.grpbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvLlegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProcesos
            // 
            this.grpbProcesos.Controls.Add(this.datagvLlegada);
            this.grpbProcesos.Controls.Add(this.lblProcesando);
            this.grpbProcesos.Controls.Add(this.label4);
            this.grpbProcesos.Controls.Add(this.lblTitulo);
            this.grpbProcesos.Controls.Add(this.tackQuantum);
            this.grpbProcesos.Controls.Add(this.cmdProcesar);
            this.grpbProcesos.Controls.Add(this.cmdAgregar);
            this.grpbProcesos.Controls.Add(this.txtProcessM);
            this.grpbProcesos.Controls.Add(this.lblProcessM);
            this.grpbProcesos.Controls.Add(this.txtProcessN);
            this.grpbProcesos.Controls.Add(this.lblProcessN);
            this.grpbProcesos.Location = new System.Drawing.Point(16, 14);
            this.grpbProcesos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbProcesos.Name = "grpbProcesos";
            this.grpbProcesos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbProcesos.Size = new System.Drawing.Size(1035, 214);
            this.grpbProcesos.TabIndex = 0;
            this.grpbProcesos.TabStop = false;
            this.grpbProcesos.Text = "Simulacion de procesos";
            // 
            // datagvLlegada
            // 
            this.datagvLlegada.AllowUserToAddRows = false;
            this.datagvLlegada.AllowUserToDeleteRows = false;
            this.datagvLlegada.AllowUserToResizeColumns = false;
            this.datagvLlegada.AllowUserToResizeRows = false;
            this.datagvLlegada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvLlegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvLlegada.Location = new System.Drawing.Point(380, 20);
            this.datagvLlegada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagvLlegada.Name = "datagvLlegada";
            this.datagvLlegada.ReadOnly = true;
            this.datagvLlegada.RowHeadersWidth = 51;
            this.datagvLlegada.RowTemplate.Height = 24;
            this.datagvLlegada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvLlegada.Size = new System.Drawing.Size(648, 194);
            this.datagvLlegada.TabIndex = 8;
            this.datagvLlegada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvLlegada_CellContentClick);
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(637, 1);
            this.lblProcesando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(117, 17);
            this.lblProcesando.TabIndex = 10;
            this.lblProcesando.Text = "Historial de PCBs";
            this.lblProcesando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // pnelLlegada
            // 
            this.pnelLlegada.AllowDrop = true;
            this.pnelLlegada.AutoScroll = true;
            this.pnelLlegada.AutoSize = true;
            this.pnelLlegada.BackColor = System.Drawing.Color.DimGray;
            this.pnelLlegada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelLlegada.Location = new System.Drawing.Point(16, 262);
            this.pnelLlegada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnelLlegada.Name = "pnelLlegada";
            this.pnelLlegada.Size = new System.Drawing.Size(1040, 194);
            this.pnelLlegada.TabIndex = 2;
            // 
            // pnelCola
            // 
            this.pnelCola.BackColor = System.Drawing.Color.DimGray;
            this.pnelCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelCola.Location = new System.Drawing.Point(16, 487);
            this.pnelCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnelCola.Name = "pnelCola";
            this.pnelCola.Size = new System.Drawing.Size(511, 194);
            this.pnelCola.TabIndex = 5;
            // 
            // lblPCBLlegada
            // 
            this.lblPCBLlegada.AutoSize = true;
            this.lblPCBLlegada.Location = new System.Drawing.Point(392, 244);
            this.lblPCBLlegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCBLlegada.Name = "lblPCBLlegada";
            this.lblPCBLlegada.Size = new System.Drawing.Size(240, 17);
            this.lblPCBLlegada.TabIndex = 1;
            this.lblPCBLlegada.Text = "Representación del proceso original:";
            this.lblPCBLlegada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPCBCola
            // 
            this.lblPCBCola.AutoSize = true;
            this.lblPCBCola.Location = new System.Drawing.Point(349, 469);
            this.lblPCBCola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCBCola.Name = "lblPCBCola";
            this.lblPCBCola.Size = new System.Drawing.Size(341, 17);
            this.lblPCBCola.TabIndex = 4;
            this.lblPCBCola.Text = "Ordenamiento del proceso con base en su prioridad:";
            this.lblPCBCola.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timQuant
            // 
            this.timQuant.Interval = 500;
            this.timQuant.Tick += new System.EventHandler(this.timQuant_Tick);
            // 
            // datagvCola
            // 
            this.datagvCola.AllowUserToAddRows = false;
            this.datagvCola.AllowUserToDeleteRows = false;
            this.datagvCola.AllowUserToResizeColumns = false;
            this.datagvCola.AllowUserToResizeRows = false;
            this.datagvCola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvCola.Location = new System.Drawing.Point(535, 487);
            this.datagvCola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagvCola.Name = "datagvCola";
            this.datagvCola.ReadOnly = true;
            this.datagvCola.RowHeadersWidth = 51;
            this.datagvCola.RowTemplate.Height = 24;
            this.datagvCola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvCola.Size = new System.Drawing.Size(521, 194);
            this.datagvCola.TabIndex = 6;
            // 
            // cmdTick
            // 
            this.cmdTick.Location = new System.Drawing.Point(104, 217);
            this.cmdTick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdTick.Name = "cmdTick";
            this.cmdTick.Size = new System.Drawing.Size(132, 28);
            this.cmdTick.TabIndex = 11;
            this.cmdTick.Text = "Tick";
            this.cmdTick.UseVisualStyleBackColor = true;
            this.cmdTick.Click += new System.EventHandler(this.timQuant_Tick);
            // 
            // frmSimulacion
            // 
            this.AcceptButton = this.cmdAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1071, 720);
            this.Controls.Add(this.cmdTick);
            this.Controls.Add(this.datagvCola);
            this.Controls.Add(this.lblPCBCola);
            this.Controls.Add(this.lblPCBLlegada);
            this.Controls.Add(this.pnelCola);
            this.Controls.Add(this.pnelLlegada);
            this.Controls.Add(this.grpbProcesos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmSimulacion";
            this.Text = "Simulacion de procesos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSimulacion_FormClosing);
            this.grpbProcesos.ResumeLayout(false);
            this.grpbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvLlegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvCola)).EndInit();
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
        private System.Windows.Forms.Panel pnelLlegada;
        private System.Windows.Forms.Panel pnelCola;
        private System.Windows.Forms.Label lblPCBLlegada;
        private System.Windows.Forms.Label lblPCBCola;
        private System.Windows.Forms.Timer timQuant;
        private System.Windows.Forms.DataGridView datagvLlegada;
        private System.Windows.Forms.Label lblProcesando;
        private System.Windows.Forms.DataGridView datagvCola;
        private System.Windows.Forms.Button cmdTick;
    }
}

