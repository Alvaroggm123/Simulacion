
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
            this.datagvLlegada0 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.datagvLlegada0)).BeginInit();
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
            this.grpbProcesos.Location = new System.Drawing.Point(12, 11);
            this.grpbProcesos.Name = "grpbProcesos";
            this.grpbProcesos.Size = new System.Drawing.Size(776, 174);
            this.grpbProcesos.TabIndex = 0;
            this.grpbProcesos.TabStop = false;
            this.grpbProcesos.Text = "Simulacion de procesos";
            // 
            // datagvLlegada
            // 
            this.datagvLlegada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datagvLlegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvLlegada.Location = new System.Drawing.Point(285, 16);
            this.datagvLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.datagvLlegada.Name = "datagvLlegada";
            this.datagvLlegada.RowHeadersWidth = 51;
            this.datagvLlegada.RowTemplate.Height = 24;
            this.datagvLlegada.Size = new System.Drawing.Size(486, 158);
            this.datagvLlegada.TabIndex = 8;
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(478, 1);
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(88, 13);
            this.lblProcesando.TabIndex = 10;
            this.lblProcesando.Text = "Historial de PCBs";
            this.lblProcesando.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // datagvLlegada0
            // 
            this.datagvLlegada0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datagvLlegada0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvLlegada0.Location = new System.Drawing.Point(401, 213);
            this.datagvLlegada0.Margin = new System.Windows.Forms.Padding(2);
            this.datagvLlegada0.Name = "datagvLlegada0";
            this.datagvLlegada0.RowHeadersWidth = 51;
            this.datagvLlegada0.RowTemplate.Height = 24;
            this.datagvLlegada0.Size = new System.Drawing.Size(391, 158);
            this.datagvLlegada0.TabIndex = 3;
            // 
            // pnelLlegada
            // 
            this.pnelLlegada.BackColor = System.Drawing.Color.DimGray;
            this.pnelLlegada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelLlegada.Location = new System.Drawing.Point(12, 213);
            this.pnelLlegada.Name = "pnelLlegada";
            this.pnelLlegada.Size = new System.Drawing.Size(384, 158);
            this.pnelLlegada.TabIndex = 2;
            // 
            // pnelCola
            // 
            this.pnelCola.BackColor = System.Drawing.Color.DimGray;
            this.pnelCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelCola.Location = new System.Drawing.Point(12, 396);
            this.pnelCola.Name = "pnelCola";
            this.pnelCola.Size = new System.Drawing.Size(384, 158);
            this.pnelCola.TabIndex = 5;
            // 
            // lblPCBLlegada
            // 
            this.lblPCBLlegada.AutoSize = true;
            this.lblPCBLlegada.Location = new System.Drawing.Point(294, 198);
            this.lblPCBLlegada.Name = "lblPCBLlegada";
            this.lblPCBLlegada.Size = new System.Drawing.Size(179, 13);
            this.lblPCBLlegada.TabIndex = 1;
            this.lblPCBLlegada.Text = "Representación del proceso original:";
            this.lblPCBLlegada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPCBCola
            // 
            this.lblPCBCola.AutoSize = true;
            this.lblPCBCola.Location = new System.Drawing.Point(262, 381);
            this.lblPCBCola.Name = "lblPCBCola";
            this.lblPCBCola.Size = new System.Drawing.Size(253, 13);
            this.lblPCBCola.TabIndex = 4;
            this.lblPCBCola.Text = "Ordenamiento del proceso con base en su prioridad:";
            this.lblPCBCola.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timQuant
            // 
            this.timQuant.Tick += new System.EventHandler(this.timQuant_Tick);
            // 
            // datagvCola
            // 
            this.datagvCola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.datagvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvCola.Location = new System.Drawing.Point(401, 396);
            this.datagvCola.Margin = new System.Windows.Forms.Padding(2);
            this.datagvCola.Name = "datagvCola";
            this.datagvCola.RowHeadersWidth = 51;
            this.datagvCola.RowTemplate.Height = 24;
            this.datagvCola.Size = new System.Drawing.Size(391, 158);
            this.datagvCola.TabIndex = 6;
            // 
            // cmdTick
            // 
            this.cmdTick.Location = new System.Drawing.Point(78, 176);
            this.cmdTick.Name = "cmdTick";
            this.cmdTick.Size = new System.Drawing.Size(99, 23);
            this.cmdTick.TabIndex = 11;
            this.cmdTick.Text = "Tick";
            this.cmdTick.UseVisualStyleBackColor = true;
            this.cmdTick.Click += new System.EventHandler(this.timQuant_Tick);
            // 
            // frmSimulacion
            // 
            this.AcceptButton = this.cmdAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(803, 585);
            this.Controls.Add(this.cmdTick);
            this.Controls.Add(this.datagvCola);
            this.Controls.Add(this.datagvLlegada0);
            this.Controls.Add(this.lblPCBCola);
            this.Controls.Add(this.lblPCBLlegada);
            this.Controls.Add(this.pnelCola);
            this.Controls.Add(this.pnelLlegada);
            this.Controls.Add(this.grpbProcesos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSimulacion";
            this.Text = "Simulacion de procesos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSimulacion_FormClosing);
            this.grpbProcesos.ResumeLayout(false);
            this.grpbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvLlegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvLlegada0)).EndInit();
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
        private System.Windows.Forms.DataGridView datagvLlegada0;
        private System.Windows.Forms.DataGridView datagvLlegada;
        private System.Windows.Forms.Label lblProcesando;
        private System.Windows.Forms.DataGridView datagvCola;
        private System.Windows.Forms.Button cmdTick;
    }
}

