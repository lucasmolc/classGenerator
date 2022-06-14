namespace Generator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnOk = new System.Windows.Forms.Button();
            this.pnl0 = new System.Windows.Forms.Panel();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.gpBox0 = new System.Windows.Forms.GroupBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.gpBoxXSD = new System.Windows.Forms.GroupBox();
            this.btnRemoveImportados = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnProgramaXSD = new System.Windows.Forms.Button();
            this.txtProgramaXSD = new System.Windows.Forms.TextBox();
            this.lblProgramaXSD = new System.Windows.Forms.Label();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnAdicionaImportados = new System.Windows.Forms.Button();
            this.txtXSDImportados = new System.Windows.Forms.TextBox();
            this.lblXSDImportados = new System.Windows.Forms.Label();
            this.btnPastaETC = new System.Windows.Forms.Button();
            this.txtPastaETC = new System.Windows.Forms.TextBox();
            this.lblPastaETC = new System.Windows.Forms.Label();
            this.btnXSDPrincipal = new System.Windows.Forms.Button();
            this.txtXSDPrincipal = new System.Windows.Forms.TextBox();
            this.lblXsdPrincipal = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogXSD_exe = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.classGen = new System.Windows.Forms.TabPage();
            this.xsdGen = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpaXml = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdicionaOutput = new System.Windows.Forms.Button();
            this.btnAdicionaXsdPrograma = new System.Windows.Forms.Button();
            this.txbProgramaXsd = new System.Windows.Forms.TextBox();
            this.lblXSDPrograma = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnAdicionaETC = new System.Windows.Forms.Button();
            this.txbPastaEtc = new System.Windows.Forms.TextBox();
            this.lblpastaETCxml = new System.Windows.Forms.Label();
            this.btnAdicionaXml = new System.Windows.Forms.Button();
            this.txbArquivoXml = new System.Windows.Forms.TextBox();
            this.lblArquivoXML = new System.Windows.Forms.Label();
            this.pnl0.SuspendLayout();
            this.gpBoxXSD.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.classGen.SuspendLayout();
            this.xsdGen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(54, 13);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 45);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Gerar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnl0
            // 
            this.pnl0.Controls.Add(this.btnLimpa);
            this.pnl0.Controls.Add(this.gpBox0);
            this.pnl0.Controls.Add(this.lblDirectory);
            this.pnl0.Controls.Add(this.btnOk);
            this.pnl0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl0.Location = new System.Drawing.Point(3, 218);
            this.pnl0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl0.Name = "pnl0";
            this.pnl0.Size = new System.Drawing.Size(390, 87);
            this.pnl0.TabIndex = 1;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpa.Location = new System.Drawing.Point(200, 13);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(140, 45);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // gpBox0
            // 
            this.gpBox0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBox0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpBox0.Enabled = false;
            this.gpBox0.Location = new System.Drawing.Point(0, 67);
            this.gpBox0.Name = "gpBox0";
            this.gpBox0.Size = new System.Drawing.Size(390, 1);
            this.gpBox0.TabIndex = 2;
            this.gpBox0.TabStop = false;
            // 
            // lblDirectory
            // 
            this.lblDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Enabled = false;
            this.lblDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectory.Location = new System.Drawing.Point(3, 69);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(52, 15);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Diretório";
            // 
            // gpBoxXSD
            // 
            this.gpBoxXSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpBoxXSD.Controls.Add(this.btnRemoveImportados);
            this.gpBoxXSD.Controls.Add(this.txtContador);
            this.gpBoxXSD.Controls.Add(this.btnProgramaXSD);
            this.gpBoxXSD.Controls.Add(this.txtProgramaXSD);
            this.gpBoxXSD.Controls.Add(this.lblProgramaXSD);
            this.gpBoxXSD.Controls.Add(this.btnCycle);
            this.gpBoxXSD.Controls.Add(this.btnAdicionaImportados);
            this.gpBoxXSD.Controls.Add(this.txtXSDImportados);
            this.gpBoxXSD.Controls.Add(this.lblXSDImportados);
            this.gpBoxXSD.Controls.Add(this.btnPastaETC);
            this.gpBoxXSD.Controls.Add(this.txtPastaETC);
            this.gpBoxXSD.Controls.Add(this.lblPastaETC);
            this.gpBoxXSD.Controls.Add(this.btnXSDPrincipal);
            this.gpBoxXSD.Controls.Add(this.txtXSDPrincipal);
            this.gpBoxXSD.Controls.Add(this.lblXsdPrincipal);
            this.gpBoxXSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxXSD.Location = new System.Drawing.Point(8, 3);
            this.gpBoxXSD.Name = "gpBoxXSD";
            this.gpBoxXSD.Size = new System.Drawing.Size(382, 210);
            this.gpBoxXSD.TabIndex = 2;
            this.gpBoxXSD.TabStop = false;
            this.gpBoxXSD.Text = "XSD";
            // 
            // btnRemoveImportados
            // 
            this.btnRemoveImportados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveImportados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImportados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveImportados.Location = new System.Drawing.Point(355, 117);
            this.btnRemoveImportados.Name = "btnRemoveImportados";
            this.btnRemoveImportados.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveImportados.TabIndex = 14;
            this.btnRemoveImportados.Text = "-";
            this.btnRemoveImportados.UseVisualStyleBackColor = true;
            this.btnRemoveImportados.Click += new System.EventHandler(this.btnRemoveImportados_Click);
            // 
            // txtContador
            // 
            this.txtContador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContador.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContador.Cursor = System.Windows.Forms.Cursors.No;
            this.txtContador.Enabled = false;
            this.txtContador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.HideSelection = false;
            this.txtContador.Location = new System.Drawing.Point(263, 117);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(42, 23);
            this.txtContador.TabIndex = 13;
            this.txtContador.TabStop = false;
            this.txtContador.Text = "0/0";
            this.txtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProgramaXSD
            // 
            this.btnProgramaXSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProgramaXSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramaXSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProgramaXSD.Location = new System.Drawing.Point(355, 161);
            this.btnProgramaXSD.Name = "btnProgramaXSD";
            this.btnProgramaXSD.Size = new System.Drawing.Size(23, 23);
            this.btnProgramaXSD.TabIndex = 12;
            this.btnProgramaXSD.Text = "+";
            this.btnProgramaXSD.UseVisualStyleBackColor = true;
            this.btnProgramaXSD.Click += new System.EventHandler(this.btnProgramaXSD_Click);
            // 
            // txtProgramaXSD
            // 
            this.txtProgramaXSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProgramaXSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramaXSD.Enabled = false;
            this.txtProgramaXSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramaXSD.Location = new System.Drawing.Point(115, 161);
            this.txtProgramaXSD.Name = "txtProgramaXSD";
            this.txtProgramaXSD.Size = new System.Drawing.Size(239, 23);
            this.txtProgramaXSD.TabIndex = 0;
            this.txtProgramaXSD.TabStop = false;
            this.txtProgramaXSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramaXSD
            // 
            this.lblProgramaXSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgramaXSD.AutoSize = true;
            this.lblProgramaXSD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProgramaXSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramaXSD.Location = new System.Drawing.Point(5, 165);
            this.lblProgramaXSD.Name = "lblProgramaXSD";
            this.lblProgramaXSD.Size = new System.Drawing.Size(104, 15);
            this.lblProgramaXSD.TabIndex = 0;
            this.lblProgramaXSD.Text = "Programa XSD.exe";
            this.lblProgramaXSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCycle
            // 
            this.btnCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCycle.Location = new System.Drawing.Point(307, 117);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(23, 23);
            this.btnCycle.TabIndex = 9;
            this.btnCycle.Text = "/";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnAdicionaImportados
            // 
            this.btnAdicionaImportados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionaImportados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionaImportados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionaImportados.Location = new System.Drawing.Point(331, 117);
            this.btnAdicionaImportados.Name = "btnAdicionaImportados";
            this.btnAdicionaImportados.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionaImportados.TabIndex = 8;
            this.btnAdicionaImportados.Text = "+";
            this.btnAdicionaImportados.UseVisualStyleBackColor = true;
            this.btnAdicionaImportados.Click += new System.EventHandler(this.btnAdicionaImportados_Click);
            // 
            // txtXSDImportados
            // 
            this.txtXSDImportados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtXSDImportados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXSDImportados.Enabled = false;
            this.txtXSDImportados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXSDImportados.Location = new System.Drawing.Point(115, 117);
            this.txtXSDImportados.Name = "txtXSDImportados";
            this.txtXSDImportados.Size = new System.Drawing.Size(147, 23);
            this.txtXSDImportados.TabIndex = 0;
            this.txtXSDImportados.TabStop = false;
            this.txtXSDImportados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXSDImportados
            // 
            this.lblXSDImportados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXSDImportados.AutoSize = true;
            this.lblXSDImportados.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblXSDImportados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXSDImportados.Location = new System.Drawing.Point(17, 121);
            this.lblXSDImportados.Name = "lblXSDImportados";
            this.lblXSDImportados.Size = new System.Drawing.Size(92, 15);
            this.lblXSDImportados.TabIndex = 0;
            this.lblXSDImportados.Text = "XSD Importados";
            this.lblXSDImportados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPastaETC
            // 
            this.btnPastaETC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPastaETC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPastaETC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPastaETC.Location = new System.Drawing.Point(355, 28);
            this.btnPastaETC.Name = "btnPastaETC";
            this.btnPastaETC.Size = new System.Drawing.Size(23, 23);
            this.btnPastaETC.TabIndex = 5;
            this.btnPastaETC.Text = "+";
            this.btnPastaETC.UseVisualStyleBackColor = true;
            this.btnPastaETC.Click += new System.EventHandler(this.btnPastaETC_Click);
            // 
            // txtPastaETC
            // 
            this.txtPastaETC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPastaETC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPastaETC.Enabled = false;
            this.txtPastaETC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaETC.Location = new System.Drawing.Point(115, 28);
            this.txtPastaETC.Name = "txtPastaETC";
            this.txtPastaETC.Size = new System.Drawing.Size(239, 23);
            this.txtPastaETC.TabIndex = 0;
            this.txtPastaETC.TabStop = false;
            this.txtPastaETC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPastaETC
            // 
            this.lblPastaETC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPastaETC.AutoSize = true;
            this.lblPastaETC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPastaETC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaETC.Location = new System.Drawing.Point(52, 30);
            this.lblPastaETC.Name = "lblPastaETC";
            this.lblPastaETC.Size = new System.Drawing.Size(57, 15);
            this.lblPastaETC.TabIndex = 0;
            this.lblPastaETC.Text = "Pasta ETC";
            this.lblPastaETC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXSDPrincipal
            // 
            this.btnXSDPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXSDPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXSDPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXSDPrincipal.Location = new System.Drawing.Point(355, 72);
            this.btnXSDPrincipal.Name = "btnXSDPrincipal";
            this.btnXSDPrincipal.Size = new System.Drawing.Size(23, 23);
            this.btnXSDPrincipal.TabIndex = 2;
            this.btnXSDPrincipal.Text = "+";
            this.btnXSDPrincipal.UseVisualStyleBackColor = true;
            this.btnXSDPrincipal.Click += new System.EventHandler(this.btnXSDPrincipal_Click);
            // 
            // txtXSDPrincipal
            // 
            this.txtXSDPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtXSDPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXSDPrincipal.Enabled = false;
            this.txtXSDPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXSDPrincipal.Location = new System.Drawing.Point(115, 72);
            this.txtXSDPrincipal.Name = "txtXSDPrincipal";
            this.txtXSDPrincipal.Size = new System.Drawing.Size(239, 23);
            this.txtXSDPrincipal.TabIndex = 0;
            this.txtXSDPrincipal.TabStop = false;
            this.txtXSDPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXsdPrincipal
            // 
            this.lblXsdPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXsdPrincipal.AutoSize = true;
            this.lblXsdPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblXsdPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXsdPrincipal.Location = new System.Drawing.Point(32, 76);
            this.lblXsdPrincipal.Name = "lblXsdPrincipal";
            this.lblXsdPrincipal.Size = new System.Drawing.Size(77, 15);
            this.lblXsdPrincipal.TabIndex = 0;
            this.lblXsdPrincipal.Text = "XSD Principal";
            this.lblXsdPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"xsd(*.xsd)|*.xsd\"";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // openFilesDialog
            // 
            this.openFilesDialog.FileName = "openFileDialog1";
            // 
            // openFileDialogXSD_exe
            // 
            this.openFileDialogXSD_exe.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.classGen);
            this.tabControl1.Controls.Add(this.xsdGen);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 336);
            this.tabControl1.TabIndex = 3;
            // 
            // classGen
            // 
            this.classGen.Controls.Add(this.pnl0);
            this.classGen.Controls.Add(this.gpBoxXSD);
            this.classGen.Location = new System.Drawing.Point(4, 24);
            this.classGen.Name = "classGen";
            this.classGen.Padding = new System.Windows.Forms.Padding(3);
            this.classGen.Size = new System.Drawing.Size(396, 308);
            this.classGen.TabIndex = 0;
            this.classGen.Text = "Classe";
            this.classGen.UseVisualStyleBackColor = true;
            // 
            // xsdGen
            // 
            this.xsdGen.Controls.Add(this.groupBox2);
            this.xsdGen.Controls.Add(this.panel1);
            this.xsdGen.Location = new System.Drawing.Point(4, 24);
            this.xsdGen.Name = "xsdGen";
            this.xsdGen.Padding = new System.Windows.Forms.Padding(3);
            this.xsdGen.Size = new System.Drawing.Size(396, 308);
            this.xsdGen.TabIndex = 1;
            this.xsdGen.Text = "XSD";
            this.xsdGen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpaXml);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblDiretorio);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 87);
            this.panel1.TabIndex = 2;
            // 
            // btnLimpaXml
            // 
            this.btnLimpaXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpaXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpaXml.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpaXml.Location = new System.Drawing.Point(200, 13);
            this.btnLimpaXml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpaXml.Name = "btnLimpaXml";
            this.btnLimpaXml.Size = new System.Drawing.Size(140, 45);
            this.btnLimpaXml.TabIndex = 3;
            this.btnLimpaXml.Text = "Limpa";
            this.btnLimpaXml.UseVisualStyleBackColor = true;
            this.btnLimpaXml.Click += new System.EventHandler(this.btnLimpaXml_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 1);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Enabled = false;
            this.lblDiretorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorio.Location = new System.Drawing.Point(3, 69);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(52, 15);
            this.lblDiretorio.TabIndex = 1;
            this.lblDiretorio.Text = "Diretório";
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.Location = new System.Drawing.Point(54, 13);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(140, 45);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnAdicionaOutput);
            this.groupBox2.Controls.Add(this.btnAdicionaXsdPrograma);
            this.groupBox2.Controls.Add(this.txbProgramaXsd);
            this.groupBox2.Controls.Add(this.lblXSDPrograma);
            this.groupBox2.Controls.Add(this.txbOutput);
            this.groupBox2.Controls.Add(this.lblOutput);
            this.groupBox2.Controls.Add(this.btnAdicionaETC);
            this.groupBox2.Controls.Add(this.txbPastaEtc);
            this.groupBox2.Controls.Add(this.lblpastaETCxml);
            this.groupBox2.Controls.Add(this.btnAdicionaXml);
            this.groupBox2.Controls.Add(this.txbArquivoXml);
            this.groupBox2.Controls.Add(this.lblArquivoXML);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML";
            // 
            // btnAdicionaOutput
            // 
            this.btnAdicionaOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionaOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionaOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionaOutput.Location = new System.Drawing.Point(355, 117);
            this.btnAdicionaOutput.Name = "btnAdicionaOutput";
            this.btnAdicionaOutput.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionaOutput.TabIndex = 14;
            this.btnAdicionaOutput.Text = "+";
            this.btnAdicionaOutput.UseVisualStyleBackColor = true;
            this.btnAdicionaOutput.Click += new System.EventHandler(this.btnAdicionaOutput_Click);
            // 
            // btnAdicionaXsdPrograma
            // 
            this.btnAdicionaXsdPrograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionaXsdPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionaXsdPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionaXsdPrograma.Location = new System.Drawing.Point(355, 161);
            this.btnAdicionaXsdPrograma.Name = "btnAdicionaXsdPrograma";
            this.btnAdicionaXsdPrograma.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionaXsdPrograma.TabIndex = 12;
            this.btnAdicionaXsdPrograma.Text = "+";
            this.btnAdicionaXsdPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionaXsdPrograma.Click += new System.EventHandler(this.btnAdicionaXsdPrograma_Click);
            // 
            // txbProgramaXsd
            // 
            this.txbProgramaXsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbProgramaXsd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProgramaXsd.Enabled = false;
            this.txbProgramaXsd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProgramaXsd.Location = new System.Drawing.Point(115, 161);
            this.txbProgramaXsd.Name = "txbProgramaXsd";
            this.txbProgramaXsd.Size = new System.Drawing.Size(239, 23);
            this.txbProgramaXsd.TabIndex = 0;
            this.txbProgramaXsd.TabStop = false;
            this.txbProgramaXsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXSDPrograma
            // 
            this.lblXSDPrograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblXSDPrograma.AutoSize = true;
            this.lblXSDPrograma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblXSDPrograma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXSDPrograma.Location = new System.Drawing.Point(5, 165);
            this.lblXSDPrograma.Name = "lblXSDPrograma";
            this.lblXSDPrograma.Size = new System.Drawing.Size(104, 15);
            this.lblXSDPrograma.TabIndex = 0;
            this.lblXSDPrograma.Text = "Programa XSD.exe";
            this.lblXSDPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbOutput
            // 
            this.txbOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOutput.Enabled = false;
            this.txbOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOutput.Location = new System.Drawing.Point(115, 117);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(239, 23);
            this.txbOutput.TabIndex = 0;
            this.txbOutput.TabStop = false;
            this.txbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutput.AutoSize = true;
            this.lblOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(63, 119);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 15);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Output";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdicionaETC
            // 
            this.btnAdicionaETC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionaETC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionaETC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionaETC.Location = new System.Drawing.Point(355, 28);
            this.btnAdicionaETC.Name = "btnAdicionaETC";
            this.btnAdicionaETC.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionaETC.TabIndex = 5;
            this.btnAdicionaETC.Text = "+";
            this.btnAdicionaETC.UseVisualStyleBackColor = true;
            this.btnAdicionaETC.Click += new System.EventHandler(this.btnAdicionaETC_Click);
            // 
            // txbPastaEtc
            // 
            this.txbPastaEtc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPastaEtc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPastaEtc.Enabled = false;
            this.txbPastaEtc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPastaEtc.Location = new System.Drawing.Point(115, 28);
            this.txbPastaEtc.Name = "txbPastaEtc";
            this.txbPastaEtc.Size = new System.Drawing.Size(239, 23);
            this.txbPastaEtc.TabIndex = 0;
            this.txbPastaEtc.TabStop = false;
            this.txbPastaEtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblpastaETCxml
            // 
            this.lblpastaETCxml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpastaETCxml.AutoSize = true;
            this.lblpastaETCxml.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblpastaETCxml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpastaETCxml.Location = new System.Drawing.Point(52, 30);
            this.lblpastaETCxml.Name = "lblpastaETCxml";
            this.lblpastaETCxml.Size = new System.Drawing.Size(57, 15);
            this.lblpastaETCxml.TabIndex = 0;
            this.lblpastaETCxml.Text = "Pasta ETC";
            this.lblpastaETCxml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdicionaXml
            // 
            this.btnAdicionaXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionaXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionaXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionaXml.Location = new System.Drawing.Point(355, 72);
            this.btnAdicionaXml.Name = "btnAdicionaXml";
            this.btnAdicionaXml.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionaXml.TabIndex = 2;
            this.btnAdicionaXml.Text = "+";
            this.btnAdicionaXml.UseVisualStyleBackColor = true;
            this.btnAdicionaXml.Click += new System.EventHandler(this.btnAdicionaXml_Click);
            // 
            // txbArquivoXml
            // 
            this.txbArquivoXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbArquivoXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbArquivoXml.Enabled = false;
            this.txbArquivoXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArquivoXml.Location = new System.Drawing.Point(115, 72);
            this.txbArquivoXml.Name = "txbArquivoXml";
            this.txbArquivoXml.Size = new System.Drawing.Size(239, 23);
            this.txbArquivoXml.TabIndex = 0;
            this.txbArquivoXml.TabStop = false;
            this.txbArquivoXml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblArquivoXML
            // 
            this.lblArquivoXML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArquivoXML.AutoSize = true;
            this.lblArquivoXML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblArquivoXML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoXML.Location = new System.Drawing.Point(32, 76);
            this.lblArquivoXML.Name = "lblArquivoXML";
            this.lblArquivoXML.Size = new System.Drawing.Size(76, 15);
            this.lblArquivoXML.TabIndex = 0;
            this.lblArquivoXML.Text = "Arquivo XML";
            this.lblArquivoXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnLimpa;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "classGenerator";
            this.pnl0.ResumeLayout(false);
            this.pnl0.PerformLayout();
            this.gpBoxXSD.ResumeLayout(false);
            this.gpBoxXSD.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.classGen.ResumeLayout(false);
            this.xsdGen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnl0;
        private System.Windows.Forms.GroupBox gpBox0;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.GroupBox gpBoxXSD;
        private System.Windows.Forms.TextBox txtXSDPrincipal;
        private System.Windows.Forms.Label lblXsdPrincipal;
        private System.Windows.Forms.Button btnXSDPrincipal;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnPastaETC;
        private System.Windows.Forms.TextBox txtPastaETC;
        private System.Windows.Forms.Label lblPastaETC;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnAdicionaImportados;
        private System.Windows.Forms.TextBox txtXSDImportados;
        private System.Windows.Forms.Label lblXSDImportados;
        private System.Windows.Forms.OpenFileDialog openFilesDialog;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnProgramaXSD;
        private System.Windows.Forms.TextBox txtProgramaXSD;
        private System.Windows.Forms.Label lblProgramaXSD;
        private System.Windows.Forms.OpenFileDialog openFileDialogXSD_exe;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage classGen;
        private System.Windows.Forms.TabPage xsdGen;
        private System.Windows.Forms.Button btnRemoveImportados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionaOutput;
        private System.Windows.Forms.Button btnAdicionaXsdPrograma;
        private System.Windows.Forms.TextBox txbProgramaXsd;
        private System.Windows.Forms.Label lblXSDPrograma;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnAdicionaETC;
        private System.Windows.Forms.TextBox txbPastaEtc;
        private System.Windows.Forms.Label lblpastaETCxml;
        private System.Windows.Forms.Button btnAdicionaXml;
        private System.Windows.Forms.TextBox txbArquivoXml;
        private System.Windows.Forms.Label lblArquivoXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpaXml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Button btnGerar;
    }
}

