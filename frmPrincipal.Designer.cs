namespace Compilador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuConfiguración = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.ManualInputButton_Click = new System.Windows.Forms.Button();
            this.LoadFromFileButton_Click = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Label();
            this.ManualInputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PuntIn = new System.Windows.Forms.RadioButton();
            this.NumIn = new System.Windows.Forms.RadioButton();
            this.TextIn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PuntOut = new System.Windows.Forms.RadioButton();
            this.NumOut = new System.Windows.Forms.RadioButton();
            this.TextOut = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuConfiguración,
            this.smnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(88, 29);
            this.mnuArchivo.Text = "Archivo";
            // 
            // smnuConfiguración
            // 
            this.smnuConfiguración.Name = "smnuConfiguración";
            this.smnuConfiguración.Size = new System.Drawing.Size(225, 34);
            this.smnuConfiguración.Text = "Configuración";
            // 
            // smnuSalir
            // 
            this.smnuSalir.Name = "smnuSalir";
            this.smnuSalir.Size = new System.Drawing.Size(225, 34);
            this.smnuSalir.Text = "Salir";
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuAcercaDe});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(79, 29);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // smnuAcercaDe
            // 
            this.smnuAcercaDe.Name = "smnuAcercaDe";
            this.smnuAcercaDe.Size = new System.Drawing.Size(191, 34);
            this.smnuAcercaDe.Text = "Acerca de";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnAbrir,
            this.btnGuardar,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.btnAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1254, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(34, 28);
            this.btnNuevo.Text = "&Nuevo";
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(34, 28);
            this.btnAbrir.Text = "&Abrir";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 28);
            this.btnGuardar.Text = "&Guardar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(34, 28);
            this.btnAyuda.Text = "Ay&uda";
            // 
            // ManualInputButton_Click
            // 
            this.ManualInputButton_Click.Location = new System.Drawing.Point(128, 587);
            this.ManualInputButton_Click.Name = "ManualInputButton_Click";
            this.ManualInputButton_Click.Size = new System.Drawing.Size(358, 55);
            this.ManualInputButton_Click.TabIndex = 3;
            this.ManualInputButton_Click.Text = "INGRESO MANUAL";
            this.ManualInputButton_Click.UseVisualStyleBackColor = true;
            this.ManualInputButton_Click.Click += new System.EventHandler(this.ManualInputButton_Click_Click);
            // 
            // LoadFromFileButton_Click
            // 
            this.LoadFromFileButton_Click.Location = new System.Drawing.Point(863, 299);
            this.LoadFromFileButton_Click.Name = "LoadFromFileButton_Click";
            this.LoadFromFileButton_Click.Size = new System.Drawing.Size(317, 55);
            this.LoadFromFileButton_Click.TabIndex = 4;
            this.LoadFromFileButton_Click.Text = "CARGA DESDE ARCHIVOS";
            this.LoadFromFileButton_Click.UseVisualStyleBackColor = true;
            this.LoadFromFileButton_Click.Click += new System.EventHandler(this.LoadFromFileButton_Click_Click);
            // 
            // inicio
            // 
            this.inicio.AutoSize = true;
            this.inicio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.inicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.Location = new System.Drawing.Point(31, 100);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(230, 69);
            this.inicio.TabIndex = 6;
            this.inicio.Text = "INICIO";
            // 
            // ManualInputTextBox
            // 
            this.ManualInputTextBox.Location = new System.Drawing.Point(72, 361);
            this.ManualInputTextBox.Multiline = true;
            this.ManualInputTextBox.Name = "ManualInputTextBox";
            this.ManualInputTextBox.Size = new System.Drawing.Size(481, 220);
            this.ManualInputTextBox.TabIndex = 7;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(600, 361);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(580, 268);
            this.OutputTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PuntIn);
            this.groupBox1.Controls.Add(this.NumIn);
            this.groupBox1.Controls.Add(this.TextIn);
            this.groupBox1.Location = new System.Drawing.Point(72, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 109);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PuntIn
            // 
            this.PuntIn.AutoSize = true;
            this.PuntIn.Location = new System.Drawing.Point(15, 79);
            this.PuntIn.Name = "PuntIn";
            this.PuntIn.Size = new System.Drawing.Size(88, 24);
            this.PuntIn.TabIndex = 21;
            this.PuntIn.Text = "PUNTO";
            this.PuntIn.UseVisualStyleBackColor = true;
            // 
            // NumIn
            // 
            this.NumIn.AutoSize = true;
            this.NumIn.Location = new System.Drawing.Point(15, 53);
            this.NumIn.Name = "NumIn";
            this.NumIn.Size = new System.Drawing.Size(105, 24);
            this.NumIn.TabIndex = 20;
            this.NumIn.Text = "NUMERO";
            this.NumIn.UseVisualStyleBackColor = true;
            // 
            // TextIn
            // 
            this.TextIn.AutoSize = true;
            this.TextIn.Checked = true;
            this.TextIn.Location = new System.Drawing.Point(15, 26);
            this.TextIn.Name = "TextIn";
            this.TextIn.Size = new System.Drawing.Size(86, 24);
            this.TextIn.TabIndex = 19;
            this.TextIn.TabStop = true;
            this.TextIn.Text = "TEXTO";
            this.TextIn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PuntOut);
            this.groupBox3.Controls.Add(this.NumOut);
            this.groupBox3.Controls.Add(this.TextOut);
            this.groupBox3.Location = new System.Drawing.Point(600, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 109);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione:";
            // 
            // PuntOut
            // 
            this.PuntOut.AutoSize = true;
            this.PuntOut.Location = new System.Drawing.Point(15, 79);
            this.PuntOut.Name = "PuntOut";
            this.PuntOut.Size = new System.Drawing.Size(88, 24);
            this.PuntOut.TabIndex = 21;
            this.PuntOut.Text = "PUNTO";
            this.PuntOut.UseVisualStyleBackColor = true;
            // 
            // NumOut
            // 
            this.NumOut.AutoSize = true;
            this.NumOut.Location = new System.Drawing.Point(15, 53);
            this.NumOut.Name = "NumOut";
            this.NumOut.Size = new System.Drawing.Size(105, 24);
            this.NumOut.TabIndex = 20;
            this.NumOut.Text = "NUMERO";
            this.NumOut.UseVisualStyleBackColor = true;
            // 
            // TextOut
            // 
            this.TextOut.AutoSize = true;
            this.TextOut.Checked = true;
            this.TextOut.Location = new System.Drawing.Point(15, 26);
            this.TextOut.Name = "TextOut";
            this.TextOut.Size = new System.Drawing.Size(86, 24);
            this.TextOut.TabIndex = 19;
            this.TextOut.TabStop = true;
            this.TextOut.Text = "TEXTO";
            this.TextOut.UseVisualStyleBackColor = true;
            this.TextOut.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ManualInputTextBox);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.LoadFromFileButton_Click);
            this.Controls.Add(this.ManualInputButton_Click);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem smnuConfiguración;
        private System.Windows.Forms.ToolStripMenuItem smnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem smnuAcercaDe;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.Button ManualInputButton_Click;
        private System.Windows.Forms.Button LoadFromFileButton_Click;
        private System.Windows.Forms.Label inicio;
        private System.Windows.Forms.TextBox ManualInputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PuntIn;
        private System.Windows.Forms.RadioButton NumIn;
        private System.Windows.Forms.RadioButton TextIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton PuntOut;
        private System.Windows.Forms.RadioButton NumOut;
        private System.Windows.Forms.RadioButton TextOut;
    }
}

