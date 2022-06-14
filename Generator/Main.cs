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
 *  v1.2 - Atualizações visuais e adicionado campo XSD para que seja possível gerar arquivos .xsd a partir de arquivos .xml. Ajuste para o contador dos XSD's complementares seja exibido corretamente assim como a função de ciclar pelos arquivos selecionados.
 */

namespace Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int tPos, aPos;

        string filePath, folderPath, exePath, chave, nfse, args;
        string xmlFolderPath, xmlFilePath, xmlOutputFilePath, xmlExePath, xsdName;
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
            tPos = 0;
            aPos = 0;
            txtContador.Text = aPos + "/" + tPos;
            importedFiles = new List<string>();
            chave = "";
            nfse = "";
            args = "";
            filePath = "";
            
        }

        private void btnAdicionaETC_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderDialog.ShowNewFolderButton = true;
            folderDialog.Description = "Select ETC Folder";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txbPastaEtc.Text = folderDialog.SelectedPath;
                lblDiretorio.Text = folderDialog.SelectedPath;
                xmlFolderPath = folderDialog.SelectedPath;
            }
        }

        private void btnLimpaXml_Click(object sender, EventArgs e)
        {
            txbArquivoXml.Text = "";
            txbOutput.Text = "";
            txbPastaEtc.Text = "";
            txbProgramaXsd.Text = "";
            xmlExePath = null;
            xmlFilePath = null;
            xmlFolderPath = null;
            xmlOutputFilePath = null;
            chave = "";
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (xmlExePath != null && xmlFilePath != null && xmlFolderPath != null)
                {
                    chave = "\"" + xmlExePath + "\" " + xmlFilePath;

                    if (!string.IsNullOrEmpty(txbOutput.Text))
                        chave = chave + " /o:" + xmlOutputFilePath;
                    else
                        chave = chave + " /o:" + xmlFolderPath;

                    args = "@\"/k cd " + xmlFolderPath + " && dir && " + chave;
                }
                else
                    throw new OperationCanceledException();

                DialogResult dr = MessageBox.Show(chave, "Código Gerador", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    ProcessStartInfo processStart = new ProcessStartInfo();
                    processStart.FileName = "cmd.exe";
                    processStart.WindowStyle = ProcessWindowStyle.Normal;
                    processStart.Arguments = args;
                    Process.Start(processStart);
                }
                else
                    MessageBox.Show("Geração de arquivo interrompida!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adicione os arquivos necessários!\r\r Erro: " + ex.Message, "Exception caught!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionaXsdPrograma_Click(object sender, EventArgs e)
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
                txbProgramaXsd.Text = xsdFileDialog.FileName;
                xmlExePath = xsdFileDialog.FileName;
            }
        }

        private void btnAdicionaOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderDialog.ShowNewFolderButton = true;
            folderDialog.Description = "Select Output Folder";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txbOutput.Text = folderDialog.SelectedPath;
                xmlOutputFilePath = folderDialog.SelectedPath;
            }
        }

        private void btnAdicionaXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.FilterIndex = 1;
            fileDialog.Filter = "xml(*.xml)|*.xml|All Files|*.*";
            fileDialog.Title = "Select XML";
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = false;
            if (!(string.IsNullOrEmpty(txbPastaEtc.Text)))
                fileDialog.InitialDirectory = xmlFolderPath;
            else
                fileDialog.InitialDirectory = "C:\\";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txbArquivoXml.Text = fileDialog.SafeFileName;
                xmlFilePath = fileDialog.SafeFileName;
            }
        }

        private void btnAdicionaImportados_Click(object sender, EventArgs e)
        {
            OpenFileDialog filesDialog = new OpenFileDialog();
            filesDialog.FilterIndex = 1;
            filesDialog.Filter = "xsd(*.xsd)|*.xsd|All Files|*.*";
            filesDialog.Title = "Select XSD";
            filesDialog.RestoreDirectory = true;
            filesDialog.Multiselect = false;
            if (!(string.IsNullOrEmpty(txtPastaETC.Text)))
                filesDialog.InitialDirectory = folderPath;
            else
                filesDialog.InitialDirectory = "C:\\";

            if (filesDialog.ShowDialog() == DialogResult.OK)
            {
                importedFiles.Add(filesDialog.SafeFileName);
                tPos = importedFiles.Count;
                aPos = 1;
                txtXSDImportados.Text = importedFiles[0];
                txtContador.Text = aPos + "/" + tPos;
            }
        }

        private void btnRemoveImportados_Click(object sender, EventArgs e)
        {
            if (importedFiles.Count != 0)
            {
                if (importedFiles.Count == 1)
                {
                    importedFiles.RemoveAt(0);
                    tPos = 0;
                    aPos = 0;
                    txtXSDImportados.Text = null;
                    txtContador.Text = aPos + "/" + tPos;
                }
                else
                {
                    importedFiles.RemoveAt(aPos - 1);
                    tPos = importedFiles.Count;
                    aPos = 1;
                    txtXSDImportados.Text = importedFiles[0];
                    txtContador.Text = aPos + "/" + tPos;
                }
            }
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            try
            {
                if (aPos < importedFiles.Count)
                {
                    if (aPos == 0)
                    {
                        aPos++;
                    }
                    txtXSDImportados.Text = importedFiles[aPos];
                    txtContador.Text = aPos + 1 + "/" + tPos;
                    aPos++;
                }
                else
                {
                    aPos = 1;
                    txtXSDImportados.Text = importedFiles[aPos - 1];
                    txtContador.Text = aPos + "/" + tPos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adicione os arquivos XSD Importados!\r\r Erro: " + ex.Message, "Exception caught!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                nfse = filePath.Substring(0, filePath.Length - 4);
                if (importedFiles.Count >= 1)
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

                args = "@\"/k cd " + folderPath + " && dir && " + chave;
                DialogResult dr = MessageBox.Show(chave, "Código Gerador", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    ProcessStartInfo processStart = new ProcessStartInfo();
                    processStart.FileName = "cmd.exe";
                    processStart.WindowStyle = ProcessWindowStyle.Normal;
                    processStart.Arguments = args;
                    Process.Start(processStart);
                }
                else
                    MessageBox.Show("Geração de arquivo interrompida!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
