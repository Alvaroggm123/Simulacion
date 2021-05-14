
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParticion = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvLlegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tackQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvCola)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.grpbProcesos.Size = new System.Drawing.Size(1037, 184);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvLlegada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagvLlegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvLlegada.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagvLlegada.EnableHeadersVisualStyles = false;
            this.datagvLlegada.Location = new System.Drawing.Point(285, 16);
            this.datagvLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.datagvLlegada.Name = "datagvLlegada";
            this.datagvLlegada.ReadOnly = true;
            this.datagvLlegada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagvLlegada.RowHeadersVisible = false;
            this.datagvLlegada.RowHeadersWidth = 51;
            this.datagvLlegada.RowTemplate.Height = 24;
            this.datagvLlegada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvLlegada.Size = new System.Drawing.Size(745, 158);
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
            this.tackQuantum.BackColor = System.Drawing.Color.Teal;
            this.tackQuantum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.error.SetIconAlignment(this.tackQuantum, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.tackQuantum.LargeChange = 2;
            this.tackQuantum.Location = new System.Drawing.Point(225, 35);
            this.tackQuantum.Minimum = 1;
            this.tackQuantum.Name = "tackQuantum";
            this.tackQuantum.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tackQuantum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tackQuantum.RightToLeftLayout = true;
            this.tackQuantum.Size = new System.Drawing.Size(45, 128);
            this.tackQuantum.TabIndex = 6;
            this.tackQuantum.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
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
            // pnelLlegada
            // 
            this.pnelLlegada.AllowDrop = true;
            this.pnelLlegada.AutoScroll = true;
            this.pnelLlegada.AutoSize = true;
            this.pnelLlegada.BackColor = System.Drawing.Color.DimGray;
            this.pnelLlegada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelLlegada.Location = new System.Drawing.Point(12, 213);
            this.pnelLlegada.Name = "pnelLlegada";
            this.pnelLlegada.Size = new System.Drawing.Size(770, 158);
            this.pnelLlegada.TabIndex = 2;
            // 
            // pnelCola
            // 
            this.pnelCola.BackColor = System.Drawing.Color.DimGray;
            this.pnelCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnelCola.Location = new System.Drawing.Point(12, 396);
            this.pnelCola.Name = "pnelCola";
            this.pnelCola.Size = new System.Drawing.Size(446, 158);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvCola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvCola.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagvCola.EnableHeadersVisualStyles = false;
            this.datagvCola.Location = new System.Drawing.Point(463, 396);
            this.datagvCola.Margin = new System.Windows.Forms.Padding(2);
            this.datagvCola.Name = "datagvCola";
            this.datagvCola.ReadOnly = true;
            this.datagvCola.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagvCola.RowHeadersVisible = false;
            this.datagvCola.RowHeadersWidth = 51;
            this.datagvCola.RowTemplate.Height = 24;
            this.datagvCola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagvCola.Size = new System.Drawing.Size(579, 158);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvParticion);
            this.groupBox1.Location = new System.Drawing.Point(788, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memoria";
            // 
            // dgvParticion
            // 
            this.dgvParticion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticion.EnableHeadersVisualStyles = false;
            this.dgvParticion.Location = new System.Drawing.Point(6, 36);
            this.dgvParticion.Name = "dgvParticion";
            this.dgvParticion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvParticion.RowHeadersVisible = false;
            this.dgvParticion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvParticion.Size = new System.Drawing.Size(249, 53);
            this.dgvParticion.TabIndex = 2;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmSimulacion
            // 
            this.AcceptButton = this.cmdAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1055, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdTick);
            this.Controls.Add(this.datagvCola);
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
            ((System.ComponentModel.ISupportInitialize)(this.datagvCola)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridView dgvParticion;
    }
}

