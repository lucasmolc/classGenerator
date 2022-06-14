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
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnProgramaXSD = new System.Windows.Forms.Button();
            this.txtProgramaXSD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnAdicionaImportados = new System.Windows.Forms.Button();
            this.txtXSDImportados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPastaETC = new System.Windows.Forms.Button();
            this.txtPastaETC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXSDPrincipal = new System.Windows.Forms.Button();
            this.txtXSDPrincipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogXSD_exe = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.classGen = new System.Windows.Forms.TabPage();
            this.xsdGen = new System.Windows.Forms.TabPage();
            this.btnRemoveImportados = new System.Windows.Forms.Button();
            this.pnl0.SuspendLayout();
            this.gpBoxXSD.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.classGen.SuspendLayout();
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
            this.btnOk.Click += new System.EventHandler(this.btnGerar_Click);
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
            this.gpBoxXSD.Controls.Add(this.label4);
            this.gpBoxXSD.Controls.Add(this.btnCycle);
            this.gpBoxXSD.Controls.Add(this.btnAdicionaImportados);
            this.gpBoxXSD.Controls.Add(this.txtXSDImportados);
            this.gpBoxXSD.Controls.Add(this.label3);
            this.gpBoxXSD.Controls.Add(this.btnPastaETC);
            this.gpBoxXSD.Controls.Add(this.txtPastaETC);
            this.gpBoxXSD.Controls.Add(this.label2);
            this.gpBoxXSD.Controls.Add(this.btnXSDPrincipal);
            this.gpBoxXSD.Controls.Add(this.txtXSDPrincipal);
            this.gpBoxXSD.Controls.Add(this.label1);
            this.gpBoxXSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxXSD.Location = new System.Drawing.Point(8, 3);
            this.gpBoxXSD.Name = "gpBoxXSD";
            this.gpBoxXSD.Size = new System.Drawing.Size(382, 210);
            this.gpBoxXSD.TabIndex = 2;
            this.gpBoxXSD.TabStop = false;
            this.gpBoxXSD.Text = "XSD";
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Programa XSD.exe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "XSD Importados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pasta ETC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "XSD Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.xsdGen.Location = new System.Drawing.Point(4, 24);
            this.xsdGen.Name = "xsdGen";
            this.xsdGen.Padding = new System.Windows.Forms.Padding(3);
            this.xsdGen.Size = new System.Drawing.Size(396, 308);
            this.xsdGen.TabIndex = 1;
            this.xsdGen.Text = "XSD";
            this.xsdGen.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnl0;
        private System.Windows.Forms.GroupBox gpBox0;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.GroupBox gpBoxXSD;
        private System.Windows.Forms.TextBox txtXSDPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXSDPrincipal;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnPastaETC;
        private System.Windows.Forms.TextBox txtPastaETC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnAdicionaImportados;
        private System.Windows.Forms.TextBox txtXSDImportados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFilesDialog;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnProgramaXSD;
        private System.Windows.Forms.TextBox txtProgramaXSD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialogXSD_exe;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage classGen;
        private System.Windows.Forms.TabPage xsdGen;
        private System.Windows.Forms.Button btnRemoveImportados;
    }
}

