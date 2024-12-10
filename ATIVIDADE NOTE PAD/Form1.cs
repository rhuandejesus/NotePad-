namespace ATIVIDADE_NOTE_PAD
{
    public partial class Form1 : Form
    {
        bool alterado;
        int zoom = 100;

        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            barraDeStatusToolStripMenuItem.Checked = true;
            this.atualizaPosicao();
        }

        private void atualizaPosicao()
        {
            int linha = rtbconteudo.GetLineFromCharIndex(rtbconteudo.SelectionStart);
            int coluna = rtbconteudo.SelectionStart - rtbconteudo.GetFirstCharIndexFromLine(linha);
            toolStripStatuslabelPosicionamento.Text = "Ln: " + linha.ToString() + " Col: " + coluna.ToString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.Show();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbconteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rtbconteudo.SelectedRtf);
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rtbconteudo.SelectedText = (String)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void rtbconteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }

        private void slavarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ele só irá abrir a caixa de dialogo apenas se o texto for alterado
            if (!alterado)
            {
                this.abrir();
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                }
                else
                {
                    if (this.Text != "")
                    {
                        //significa que ja existe um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }


        private void abrir()
        {
            if (openFileDialogAbrir.ShowDialog() == DialogResult.OK)
            {
                //Coloca o nome do arquivo como titulo do formulario
                this.Text = openFileDialogAbrir.FileName;
                using (StreamReader reader = new StreamReader(openFileDialogAbrir.OpenFile()))
                {
                    rtbconteudo.Rtf = reader.ReadToEnd();
                    alterado = false;
                }
            }
        }

        private void salvar(String arquivo)
        {
            //Esse método salva o arquivo
            if (arquivo != "")
            {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(rtbconteudo.Rtf);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            }
            else
            {
                MessageBox.Show("Nome de Arquivo Inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarComo()
        {
            if (saveFileDialogAbrir.ShowDialog() == DialogResult.OK)
            {
                this.salvar(saveFileDialogAbrir.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                //significa que ja existe um arquivo aberto
                this.salvar(this.Text);
            }
            else
            {
                this.salvarComo();
            }
        }

        private void salvarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void buscarComOBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbconteudo.SelectedRtf != "")
            {
                String texto = rtbconteudo.SelectedText;
                texto.Replace(' ', '+');
                System.Diagnostics.Process.Start("microsoft-edge:https://www.bing.com/search?q=" + texto);
            }
            else
            {
                MessageBox.Show("É necessário selecionar um termo para pesquisar.", "Buscar com o Bing",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void horaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbconteudo.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbconteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rtbconteudo.SelectedRtf);
                rtbconteudo.SelectedRtf = "";
            }
        }

        private void configurarpaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialogConfiguraPagina.ShowDialog();
        }

        private void imprimirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialogImprimir.ShowDialog();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novajanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!alterado)
            {
                this.Text = "";
                rtbconteudo.Text = "";
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    rtbconteudo.Text = "";
                }
                else
                {
                    if (this.Text != "")
                    {
                        //significa que ja existe um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialogFonte.ShowDialog() == DialogResult.OK)
            {
                rtbconteudo.SelectionFont = fontDialogFonte.Font;
            }
        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            statusStripInformacoes.Visible = !statusStripInformacoes.Visible;
        }


        private void atualizaZoom()
        {
            toolStripStatuslabelZoom.Text = this.zoom.ToString() + "%";
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom++;
            rtbconteudo.Font = new Font(rtbconteudo.Font.FontFamily, rtbconteudo.Font.Size + 1, rtbconteudo.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom--;
            rtbconteudo.Font = new Font(rtbconteudo.Font.FontFamily, rtbconteudo.Font.Size - 1, rtbconteudo.Font.Style);
            this.atualizaZoom();
        }

        private void zoomPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            rtbconteudo.Font = new Font(rtbconteudo.Font.FontFamily, 12, rtbconteudo.Font.Style);
            this.atualizaZoom();
        }
    }

}
