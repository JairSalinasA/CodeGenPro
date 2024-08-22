namespace CodeGenPro.Presentation.Forms
{
    partial class Form_Barras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Barras));
            this.stsInformation = new System.Windows.Forms.StatusStrip();
            this.tsslEncodedType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblLibraryVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jASONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jASONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cc = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEncodingTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblAverageGenerationTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnGuardaImagen = new FontAwesome.Sharp.IconButton();
            this.LoadXML = new FontAwesome.Sharp.IconButton();
            this.btnLoadJSON = new FontAwesome.Sharp.IconButton();
            this.btnSaveXML = new FontAwesome.Sharp.IconButton();
            this.btnSaveJSON = new FontAwesome.Sharp.IconButton();
            this.btnEncode = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBarcodeAlign = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEncodeType = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxAspectRatio = new System.Windows.Forms.TextBox();
            this.textBoxBarWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkGenerateLabel = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIncludeImageInSavedData = new System.Windows.Forms.CheckBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.stsInformation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsInformation
            // 
            this.stsInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEncodedType,
            this.tslblLibraryVersion,
            this.stsAuthor});
            this.stsInformation.Location = new System.Drawing.Point(0, 687);
            this.stsInformation.Name = "stsInformation";
            this.stsInformation.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.stsInformation.Size = new System.Drawing.Size(963, 22);
            this.stsInformation.TabIndex = 0;
            this.stsInformation.Text = "statusStrip1";
            // 
            // tsslEncodedType
            // 
            this.tsslEncodedType.Name = "tsslEncodedType";
            this.tsslEncodedType.Size = new System.Drawing.Size(129, 17);
            this.tsslEncodedType.Text = "Estatus de la aplicacion";
            // 
            // tslblLibraryVersion
            // 
            this.tslblLibraryVersion.Name = "tslblLibraryVersion";
            this.tslblLibraryVersion.Size = new System.Drawing.Size(674, 17);
            this.tslblLibraryVersion.Spring = true;
            this.tslblLibraryVersion.Text = "     Version:";
            // 
            // stsAuthor
            // 
            this.stsAuthor.Name = "stsAuthor";
            this.stsAuthor.Size = new System.Drawing.Size(145, 17);
            this.stsAuthor.Text = "Hecho por: Jair Switch MX";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportarToolStripMenuItem1,
            this.toolStripSeparator3,
            this.configurarToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.jASONToolStripMenuItem1});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // jASONToolStripMenuItem1
            // 
            this.jASONToolStripMenuItem1.Name = "jASONToolStripMenuItem1";
            this.jASONToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.jASONToolStripMenuItem1.Text = "JASON";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jASONToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem.Text = "Guardar Como";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // jASONToolStripMenuItem
            // 
            this.jASONToolStripMenuItem.Name = "jASONToolStripMenuItem";
            this.jASONToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.jASONToolStripMenuItem.Text = "JASON";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exportarToolStripMenuItem1
            // 
            this.exportarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.exportarToolStripMenuItem1.Name = "exportarToolStripMenuItem1";
            this.exportarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem1.Text = "Exportar";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 338);
            this.panel1.TabIndex = 4;
            // 
            // cc
            // 
            this.cc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cc.Location = new System.Drawing.Point(0, 0);
            this.cc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cc.Name = "cc";
            this.cc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cc.Size = new System.Drawing.Size(957, 338);
            this.cc.TabIndex = 37;
            this.cc.TabStop = false;
            this.cc.Text = "Codigo de barras";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.93906F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.06094F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 663);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.00418F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.2581F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36984F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 347);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(957, 313);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.txtEncoded);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(532, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 307);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Valor codificado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIncludeImageInSavedData);
            this.groupBox1.Controls.Add(this.lblEncodingTime);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.lblAverageGenerationTime);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(268, 158);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones masivas";
            // 
            // lblEncodingTime
            // 
            this.lblEncodingTime.AutoSize = true;
            this.lblEncodingTime.Location = new System.Drawing.Point(224, 117);
            this.lblEncodingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncodingTime.Name = "lblEncodingTime";
            this.lblEncodingTime.Size = new System.Drawing.Size(28, 13);
            this.lblEncodingTime.TabIndex = 82;
            this.lblEncodingTime.Text = "0.00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 90);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 19);
            this.progressBar1.TabIndex = 79;
            // 
            // lblAverageGenerationTime
            // 
            this.lblAverageGenerationTime.AutoSize = true;
            this.lblAverageGenerationTime.Location = new System.Drawing.Point(181, 78);
            this.lblAverageGenerationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageGenerationTime.Name = "lblAverageGenerationTime";
            this.lblAverageGenerationTime.Size = new System.Drawing.Size(0, 13);
            this.lblAverageGenerationTime.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 113);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 17);
            this.label14.TabIndex = 80;
            this.label14.Text = "Tiempo promedio de generación:";
            // 
            // txtEncoded
            // 
            this.txtEncoded.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEncoded.Location = new System.Drawing.Point(3, 16);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.ReadOnly = true;
            this.txtEncoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncoded.Size = new System.Drawing.Size(268, 125);
            this.txtEncoded.TabIndex = 63;
            this.txtEncoded.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.iconButton6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardaImagen, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.LoadXML, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnLoadJSON, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveXML, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveJSON, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEncode, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(812, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(142, 307);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 25;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(3, 261);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.iconButton6.Size = new System.Drawing.Size(136, 43);
            this.iconButton6.TabIndex = 25;
            this.iconButton6.Text = "Imprimir";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // btnGuardaImagen
            // 
            this.btnGuardaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardaImagen.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.btnGuardaImagen.IconColor = System.Drawing.Color.Black;
            this.btnGuardaImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardaImagen.IconSize = 25;
            this.btnGuardaImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardaImagen.Location = new System.Drawing.Point(3, 218);
            this.btnGuardaImagen.Name = "btnGuardaImagen";
            this.btnGuardaImagen.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGuardaImagen.Size = new System.Drawing.Size(136, 37);
            this.btnGuardaImagen.TabIndex = 24;
            this.btnGuardaImagen.Text = "Guarda Imagen";
            this.btnGuardaImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardaImagen.UseVisualStyleBackColor = true;
            this.btnGuardaImagen.Click += new System.EventHandler(this.btnGuardaImagen_Click);
            // 
            // LoadXML
            // 
            this.LoadXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadXML.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.LoadXML.IconColor = System.Drawing.Color.Black;
            this.LoadXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoadXML.IconSize = 25;
            this.LoadXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadXML.Location = new System.Drawing.Point(3, 175);
            this.LoadXML.Name = "LoadXML";
            this.LoadXML.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoadXML.Size = new System.Drawing.Size(136, 37);
            this.LoadXML.TabIndex = 23;
            this.LoadXML.Text = "Abrir XML";
            this.LoadXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadXML.UseVisualStyleBackColor = true;
            this.LoadXML.Click += new System.EventHandler(this.LoadXML_Click);
            // 
            // btnLoadJSON
            // 
            this.btnLoadJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadJSON.IconChar = FontAwesome.Sharp.IconChar.Js;
            this.btnLoadJSON.IconColor = System.Drawing.Color.Black;
            this.btnLoadJSON.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadJSON.IconSize = 25;
            this.btnLoadJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadJSON.Location = new System.Drawing.Point(3, 132);
            this.btnLoadJSON.Name = "btnLoadJSON";
            this.btnLoadJSON.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLoadJSON.Size = new System.Drawing.Size(136, 37);
            this.btnLoadJSON.TabIndex = 22;
            this.btnLoadJSON.Text = "Abrir JSON";
            this.btnLoadJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadJSON.UseVisualStyleBackColor = true;
            this.btnLoadJSON.Click += new System.EventHandler(this.btnLoadJSON_Click);
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveXML.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.btnSaveXML.IconColor = System.Drawing.Color.Black;
            this.btnSaveXML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveXML.IconSize = 25;
            this.btnSaveXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveXML.Location = new System.Drawing.Point(3, 89);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveXML.Size = new System.Drawing.Size(136, 37);
            this.btnSaveXML.TabIndex = 21;
            this.btnSaveXML.Text = "Guarda XML";
            this.btnSaveXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnSaveJSON
            // 
            this.btnSaveJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveJSON.IconChar = FontAwesome.Sharp.IconChar.Js;
            this.btnSaveJSON.IconColor = System.Drawing.Color.Black;
            this.btnSaveJSON.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveJSON.IconSize = 25;
            this.btnSaveJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveJSON.Location = new System.Drawing.Point(3, 46);
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveJSON.Size = new System.Drawing.Size(136, 37);
            this.btnSaveJSON.TabIndex = 20;
            this.btnSaveJSON.Text = "Guarda JSON";
            this.btnSaveJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveJSON.UseVisualStyleBackColor = true;
            this.btnSaveJSON.Click += new System.EventHandler(this.btnSaveJSON_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncode.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btnEncode.IconColor = System.Drawing.Color.Black;
            this.btnEncode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncode.IconSize = 25;
            this.btnEncode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.Location = new System.Drawing.Point(3, 3);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEncode.Size = new System.Drawing.Size(136, 37);
            this.btnEncode.TabIndex = 19;
            this.btnEncode.Text = "Generar Código";
            this.btnEncode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBarcodeAlign);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.cbEncodeType);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 307);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(10, 42);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(232, 22);
            this.txtData.TabIndex = 83;
            this.txtData.Text = "038000356216";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Código de barras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Alineación";
            // 
            // cbBarcodeAlign
            // 
            this.cbBarcodeAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarcodeAlign.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarcodeAlign.FormattingEnabled = true;
            this.cbBarcodeAlign.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbBarcodeAlign.Location = new System.Drawing.Point(10, 144);
            this.cbBarcodeAlign.Name = "cbBarcodeAlign";
            this.cbBarcodeAlign.Size = new System.Drawing.Size(230, 25);
            this.cbBarcodeAlign.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Codificación";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.ItemHeight = 17;
            this.cbEncodeType.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Interleaved 2 of 5 Mod 10",
            "Standard 2 of 5",
            "Standard 2 of 5 Mod 10",
            "IATA2of5",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI Mod 10",
            "MSI Mod 11",
            "MSI 2 Mod 10",
            "MSI Mod 11 Mod 10",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.cbEncodeType.Location = new System.Drawing.Point(10, 91);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(229, 25);
            this.cbEncodeType.TabIndex = 79;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.chkGenerateLabel);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(3, 176);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(249, 128);
            this.groupBox7.TabIndex = 79;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Texto Alternativo";
            // 
            // textBoxAspectRatio
            // 
            this.textBoxAspectRatio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAspectRatio.Location = new System.Drawing.Point(129, 118);
            this.textBoxAspectRatio.Name = "textBoxAspectRatio";
            this.textBoxAspectRatio.Size = new System.Drawing.Size(112, 22);
            this.textBoxAspectRatio.TabIndex = 55;
            // 
            // textBoxBarWidth
            // 
            this.textBoxBarWidth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarWidth.Location = new System.Drawing.Point(12, 118);
            this.textBoxBarWidth.Name = "textBoxBarWidth";
            this.textBoxBarWidth.Size = new System.Drawing.Size(111, 22);
            this.textBoxBarWidth.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(134, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "AspectRatio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "BarWidth";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(12, 65);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(111, 22);
            this.txtWidth.TabIndex = 43;
            this.txtWidth.Text = "300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(129, 65);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(112, 22);
            this.txtHeight.TabIndex = 44;
            this.txtHeight.Text = "100";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox10);
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(264, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 307);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuración de Colores";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.textBoxAspectRatio);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.textBoxBarWidth);
            this.groupBox10.Controls.Add(this.txtHeight);
            this.groupBox10.Controls.Add(this.txtWidth);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 111);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(256, 193);
            this.groupBox10.TabIndex = 80;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Configurar tamaño";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 54;
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerateLabel.Location = new System.Drawing.Point(8, 28);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(244, 21);
            this.chkGenerateLabel.TabIndex = 40;
            this.chkGenerateLabel.Text = "Agregar el texto al codigo de barras";
            this.chkGenerateLabel.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Texto alternativo";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnBackColor);
            this.groupBox9.Controls.Add(this.btnForeColor);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(3, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(256, 95);
            this.groupBox9.TabIndex = 79;
            this.groupBox9.TabStop = false;
            // 
            // btnBackColor
            // 
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.Location = new System.Drawing.Point(134, 34);
            this.btnBackColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(104, 28);
            this.btnBackColor.TabIndex = 79;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForeColor.Location = new System.Drawing.Point(9, 34);
            this.btnForeColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(98, 28);
            this.btnForeColor.TabIndex = 78;
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Color del Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Color de fondo";
            // 
            // chkIncludeImageInSavedData
            // 
            this.chkIncludeImageInSavedData.AutoSize = true;
            this.chkIncludeImageInSavedData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeImageInSavedData.Location = new System.Drawing.Point(11, 61);
            this.chkIncludeImageInSavedData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIncludeImageInSavedData.Name = "chkIncludeImageInSavedData";
            this.chkIncludeImageInSavedData.Size = new System.Drawing.Size(112, 21);
            this.chkIncludeImageInSavedData.TabIndex = 1;
            this.chkIncludeImageInSavedData.Text = "Include Image";
            this.chkIncludeImageInSavedData.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(8, 24);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(254, 30);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Generar Códigos Masivos";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Form_Barras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 709);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.stsInformation);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Barras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Gen Pro";
            this.Load += new System.EventHandler(this.Form_Barras_Load);
            this.stsInformation.ResumeLayout(false);
            this.stsInformation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsInformation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jASONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jASONToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslEncodedType;
        private System.Windows.Forms.ToolStripStatusLabel tslblLibraryVersion;
        private System.Windows.Forms.ToolStripStatusLabel stsAuthor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox cc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnEncode;
        private FontAwesome.Sharp.IconButton btnSaveJSON;
        private FontAwesome.Sharp.IconButton btnSaveXML;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnGuardaImagen;
        private FontAwesome.Sharp.IconButton LoadXML;
        private FontAwesome.Sharp.IconButton btnLoadJSON;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEncodingTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblAverageGenerationTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBarcodeAlign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEncodeType;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxAspectRatio;
        private System.Windows.Forms.TextBox textBoxBarWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIncludeImageInSavedData;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkGenerateLabel;
        private System.Windows.Forms.Label label11;
    }
}