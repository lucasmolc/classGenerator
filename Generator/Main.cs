using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

/*
 *  v1.0 - Desenvolvida uma ferramenta para auxiliar na geração de arquivos .cs a partir de arquivos .xsd
 *  v1.1 - Atualizada a solução para que seja possível criar os arquivos .cs a partir de 1 arquivo .xsd. Adicionado um contador para os XSD's complementares.
 */

namespace Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int tCount;
        int count = 0;
        string filePath, folderPath, exePath;
        List<string> importedFiles = new List<string>();

        private void btnXSDPrincipal_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.FilterIndex = 1;
            fileDialog.Filter = "xsd(*.xsd)|*.xsd|All Files|*.*";
            fileDialog.Title = "Select XSD";
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = false;
            if (!(string.IsNullOrEmpty(txtPastaETC.Text)))
                fileDialog.InitialDirectory = folderPath;
            else
            fileDialog.InitialDirectory = "C:\\";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtXSDPrincipal.Text = fileDialog.SafeFileName;
                filePath = fileDialog.SafeFileName;
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtPastaETC.Text = "";
            txtXSDPrincipal.Text = "";
            txtXSDImportados.Text = "";
            txtPastaETC.Text = "";
            txtProgramaXSD.Text = "";
            txtContador.Text = "0/0";
            importedFiles = new List<string>();
        }

        private void btnXSDImportados_Click(object sender, EventArgs e)
        {
            OpenFileDialog filesDialog = new OpenFileDialog();
            filesDialog.FilterIndex = 1;
            filesDialog.Filter = "xsd(*.xsd)|*.xsd|All Files|*.*";
            filesDialog.Title = "Select XSD";
            filesDialog.RestoreDirectory = true;
            filesDialog.Multiselect = true;
            if (!(string.IsNullOrEmpty(txtPastaETC.Text)))
                filesDialog.InitialDirectory = folderPath;
            else
                filesDialog.InitialDirectory = "C:\\";

            if (filesDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < filesDialog.FileNames.Length; i++)
                {
                    importedFiles.Add(filesDialog.SafeFileNames[i]);
                }
                tCount = importedFiles.Count;
                txtXSDImportados.Text = importedFiles[0];
                txtContador.Text = "1/" + tCount;
            }
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            try
            {
                if (count < importedFiles.Count)
                {
                    if (count == 0)
                    {
                        count++;
                    }
                    txtXSDImportados.Text = importedFiles[count];
                    txtContador.Text = count + 1 + "/" + tCount;
                    count++;
                }
                else
                {
                    count = 0;
                    txtXSDImportados.Text = importedFiles[count];
                    txtContador.Text = count + 1 + "/" + tCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adicione os arquivos XSD Importados!\r\r Erro: " + ex.Message, "Exception caught!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                string nfse = filePath.Substring(0, filePath.Length - 4);
                string chave;
                if (importedFiles.Count > 1)
                {
                    chave = "\"" + exePath + "\" -c -l:c# -n:" + nfse + " " + filePath + " " + importedFiles[0];
                    for (int i = 1; i < importedFiles.Count; i++)
                    {
                        chave = chave + " " + importedFiles[i];
                    }
                }
                else
                {
                    chave = "\"" + exePath + "\" -c -l:c# -n:" + nfse + " " + filePath;
                }

                string args = "@\"/k cd " + folderPath + " && dir && " + chave;
                DialogResult dr = MessageBox.Show(chave, "Código Gerador", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    ProcessStartInfo processStart = new ProcessStartInfo();
                    processStart.FileName = "cmd.exe";
                    processStart.WindowStyle = ProcessWindowStyle.Normal;
                    processStart.Arguments = args;
                    Process.Start(processStart);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adicione os arquivos necessários!\r\r Erro: " + ex.Message, "Exception caught!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProgramaXSD_Click(object sender, EventArgs e)
        {
            OpenFileDialog xsdFileDialog = new OpenFileDialog();
            xsdFileDialog.FilterIndex = 1;
            xsdFileDialog.Filter = "exe(*.exe)|*.exe|All Files|*.*";
            xsdFileDialog.Title = "Select XSD.exe";
            xsdFileDialog.RestoreDirectory = true;
            xsdFileDialog.Multiselect = false;
            if (Directory.Exists(@"C:\Program Files\Microsoft SDKs\Windows"))
                xsdFileDialog.InitialDirectory = @"C:\Program Files\Microsoft SDKs\Windows";
            else if (Directory.Exists(@"C:\Program Files (x86)\Microsoft SDKs\Windows"))
                xsdFileDialog.InitialDirectory = @"C:\Program Files (x86)\Microsoft SDKs\Windows";
            else if (Directory.Exists(@"C:\Program Files (x86)\Microsoft.NET\SDK"))
                xsdFileDialog.InitialDirectory = @"C:\Program Files (x86)\Microsoft.NET\SDK";
            else
                xsdFileDialog.InitialDirectory = "C:\\";

            if (xsdFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtProgramaXSD.Text = xsdFileDialog.FileName;
                exePath = xsdFileDialog.FileName;
            }
        }

        private void btnPastaETC_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderDialog.ShowNewFolderButton = true;
            folderDialog.Description = "Select ETC Folder";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtPastaETC.Text = folderDialog.SelectedPath;
                lblDirectory.Text = folderDialog.SelectedPath;
                folderPath = folderDialog.SelectedPath;
            }
        }
    }
}
