namespace ATIVIDADE_NOTE_PAD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnStrpPrincipal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            novajanelaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarcomoToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripSeparator();
            configurarpaginaToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem2 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            buscarComOBingToolStripMenuItem = new ToolStripMenuItem();
            horaDataToolStripMenuItem = new ToolStripMenuItem();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            fonteToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            ampliarToolStripMenuItem = new ToolStripMenuItem();
            reduzirToolStripMenuItem = new ToolStripMenuItem();
            zoomPadrãoToolStripMenuItem = new ToolStripMenuItem();
            barraDeStatusToolStripMenuItem = new ToolStripMenuItem();
            rtbconteudo = new RichTextBox();
            statusStripInformacoes = new StatusStrip();
            toolStripStatuslabelCodificacao = new ToolStripStatusLabel();
            toolStripStatuslabelFormato = new ToolStripStatusLabel();
            toolStripStatuslabelZoom = new ToolStripStatusLabel();
            toolStripStatuslabelPosicionamento = new ToolStripStatusLabel();
            openFileDialogAbrir = new OpenFileDialog();
            saveFileDialogAbrir = new SaveFileDialog();
            printdocumentConteudo = new System.Drawing.Printing.PrintDocument();
            pageSetupDialogConfiguraPagina = new PageSetupDialog();
            printDialogImprimir = new PrintDialog();
            fontDialogFonte = new FontDialog();
            mnStrpPrincipal.SuspendLayout();
            statusStripInformacoes.SuspendLayout();
            SuspendLayout();
            // 
            // mnStrpPrincipal
            // 
            mnStrpPrincipal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem, ajudaToolStripMenuItem, exibirToolStripMenuItem });
            mnStrpPrincipal.Location = new Point(0, 0);
            mnStrpPrincipal.Name = "mnStrpPrincipal";
            mnStrpPrincipal.Size = new Size(943, 24);
            mnStrpPrincipal.TabIndex = 1;
            mnStrpPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, novajanelaToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, salvarcomoToolStripMenuItem, imprimirToolStripMenuItem, configurarpaginaToolStripMenuItem, imprimirToolStripMenuItem1, toolStripMenuItem1, sairToolStripMenuItem2 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novoToolStripMenuItem.Size = new Size(222, 22);
            novoToolStripMenuItem.Text = "Novo ";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // novajanelaToolStripMenuItem
            // 
            novajanelaToolStripMenuItem.Name = "novajanelaToolStripMenuItem";
            novajanelaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            novajanelaToolStripMenuItem.Size = new Size(222, 22);
            novajanelaToolStripMenuItem.Text = "Nova Janela";
            novajanelaToolStripMenuItem.Click += novajanelaToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(222, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            abrirToolStripMenuItem.Click += AbrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            salvarToolStripMenuItem.Size = new Size(222, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // salvarcomoToolStripMenuItem
            // 
            salvarcomoToolStripMenuItem.Name = "salvarcomoToolStripMenuItem";
            salvarcomoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            salvarcomoToolStripMenuItem.Size = new Size(222, 22);
            salvarcomoToolStripMenuItem.Text = "Salvar Como...";
            salvarcomoToolStripMenuItem.Click += salvarcomoToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(219, 6);
            // 
            // configurarpaginaToolStripMenuItem
            // 
            configurarpaginaToolStripMenuItem.Name = "configurarpaginaToolStripMenuItem";
            configurarpaginaToolStripMenuItem.Size = new Size(222, 22);
            configurarpaginaToolStripMenuItem.Text = "Configurar Página...";
            configurarpaginaToolStripMenuItem.Click += configurarpaginaToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem1
            // 
            imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            imprimirToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem1.Size = new Size(222, 22);
            imprimirToolStripMenuItem1.Text = "Imprimir";
            imprimirToolStripMenuItem1.Click += imprimirToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(219, 6);
            // 
            // sairToolStripMenuItem2
            // 
            sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            sairToolStripMenuItem2.Size = new Size(222, 22);
            sairToolStripMenuItem2.Text = "Sair";
            sairToolStripMenuItem2.Click += sairToolStripMenuItem2_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, buscarComOBingToolStripMenuItem, horaDataToolStripMenuItem, recortarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(222, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(222, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // buscarComOBingToolStripMenuItem
            // 
            buscarComOBingToolStripMenuItem.Name = "buscarComOBingToolStripMenuItem";
            buscarComOBingToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            buscarComOBingToolStripMenuItem.Size = new Size(222, 22);
            buscarComOBingToolStripMenuItem.Text = "Buscar com o Bing...";
            buscarComOBingToolStripMenuItem.Click += buscarComOBingToolStripMenuItem_Click;
            // 
            // horaDataToolStripMenuItem
            // 
            horaDataToolStripMenuItem.Name = "horaDataToolStripMenuItem";
            horaDataToolStripMenuItem.Size = new Size(222, 22);
            horaDataToolStripMenuItem.Text = "Hora/Data";
            horaDataToolStripMenuItem.Click += horaDataToolStripMenuItem_Click;
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            recortarToolStripMenuItem.Size = new Size(222, 22);
            recortarToolStripMenuItem.Text = "Recortar";
            recortarToolStripMenuItem.Click += recortarToolStripMenuItem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fonteToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "&Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            fonteToolStripMenuItem.Size = new Size(104, 22);
            fonteToolStripMenuItem.Text = "Fonte";
            fonteToolStripMenuItem.Click += fonteToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, barraDeStatusToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(48, 20);
            exibirToolStripMenuItem.Text = "Exibir";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ampliarToolStripMenuItem, reduzirToolStripMenuItem, zoomPadrãoToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(180, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ampliarToolStripMenuItem
            // 
            ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            ampliarToolStripMenuItem.ShortcutKeyDisplayString = "Crtl + sinal de adição";
            ampliarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            ampliarToolStripMenuItem.Size = new Size(248, 22);
            ampliarToolStripMenuItem.Text = "Ampliar";
            ampliarToolStripMenuItem.Click += ampliarToolStripMenuItem_Click;
            // 
            // reduzirToolStripMenuItem
            // 
            reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            reduzirToolStripMenuItem.ShortcutKeyDisplayString = "Crtl + sinal de subtração";
            reduzirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            reduzirToolStripMenuItem.Size = new Size(248, 22);
            reduzirToolStripMenuItem.Text = "Reduzir";
            reduzirToolStripMenuItem.Click += reduzirToolStripMenuItem_Click;
            // 
            // zoomPadrãoToolStripMenuItem
            // 
            zoomPadrãoToolStripMenuItem.Name = "zoomPadrãoToolStripMenuItem";
            zoomPadrãoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            zoomPadrãoToolStripMenuItem.Size = new Size(248, 22);
            zoomPadrãoToolStripMenuItem.Text = "Zoom Padrão";
            zoomPadrãoToolStripMenuItem.Click += zoomPadrãoToolStripMenuItem_Click;
            // 
            // barraDeStatusToolStripMenuItem
            // 
            barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            barraDeStatusToolStripMenuItem.Size = new Size(180, 22);
            barraDeStatusToolStripMenuItem.Text = "Barra de Status";
            barraDeStatusToolStripMenuItem.Click += barraDeStatusToolStripMenuItem_Click;
            // 
            // rtbconteudo
            // 
            rtbconteudo.Dock = DockStyle.Fill;
            rtbconteudo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbconteudo.Location = new Point(0, 24);
            rtbconteudo.Name = "rtbconteudo";
            rtbconteudo.Size = new Size(943, 541);
            rtbconteudo.TabIndex = 2;
            rtbconteudo.Text = "";
            rtbconteudo.TextChanged += rtbconteudo_TextChanged;
            // 
            // statusStripInformacoes
            // 
            statusStripInformacoes.Items.AddRange(new ToolStripItem[] { toolStripStatuslabelCodificacao, toolStripStatuslabelFormato, toolStripStatuslabelZoom, toolStripStatuslabelPosicionamento });
            statusStripInformacoes.Location = new Point(0, 541);
            statusStripInformacoes.Name = "statusStripInformacoes";
            statusStripInformacoes.RightToLeft = RightToLeft.Yes;
            statusStripInformacoes.Size = new Size(943, 24);
            statusStripInformacoes.TabIndex = 3;
            statusStripInformacoes.Text = "statusStrip1";
            // 
            // toolStripStatuslabelCodificacao
            // 
            toolStripStatuslabelCodificacao.Name = "toolStripStatuslabelCodificacao";
            toolStripStatuslabelCodificacao.Size = new Size(38, 19);
            toolStripStatuslabelCodificacao.Text = "UTF-8";
            // 
            // toolStripStatuslabelFormato
            // 
            toolStripStatuslabelFormato.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatuslabelFormato.Name = "toolStripStatuslabelFormato";
            toolStripStatuslabelFormato.Size = new Size(98, 19);
            toolStripStatuslabelFormato.Text = "Window (CR-LF)";
            // 
            // toolStripStatuslabelZoom
            // 
            toolStripStatuslabelZoom.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatuslabelZoom.Name = "toolStripStatuslabelZoom";
            toolStripStatuslabelZoom.Size = new Size(39, 19);
            toolStripStatuslabelZoom.Text = "100%";
            // 
            // toolStripStatuslabelPosicionamento
            // 
            toolStripStatuslabelPosicionamento.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatuslabelPosicionamento.Name = "toolStripStatuslabelPosicionamento";
            toolStripStatuslabelPosicionamento.Size = new Size(57, 19);
            toolStripStatuslabelPosicionamento.Text = "Ln: , Col:";
            // 
            // openFileDialogAbrir
            // 
            openFileDialogAbrir.Filter = "Arquivo de Texto (*.txt)|*.txt|Documentos de Texto (*.rtf)|*.rtf|Todos os Arquivos (*.*)|*.*";
            openFileDialogAbrir.InitialDirectory = "C:";
            openFileDialogAbrir.Title = "Abrir arquivo";
            // 
            // saveFileDialogAbrir
            // 
            saveFileDialogAbrir.Filter = "Arquivo de Texto (*.txt)|*.txt|Documentos de Texto (*.rtf)|*.rtf|Todos os Arquivos (*.*)|*.*";
            saveFileDialogAbrir.Title = "Salvar Como...";
            // 
            // pageSetupDialogConfiguraPagina
            // 
            pageSetupDialogConfiguraPagina.Document = printdocumentConteudo;
            // 
            // printDialogImprimir
            // 
            printDialogImprimir.Document = printdocumentConteudo;
            printDialogImprimir.UseEXDialog = true;
            // 
            // fontDialogFonte
            // 
            fontDialogFonte.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 565);
            Controls.Add(statusStripInformacoes);
            Controls.Add(rtbconteudo);
            Controls.Add(mnStrpPrincipal);
            KeyPreview = true;
            MainMenuStrip = mnStrpPrincipal;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            mnStrpPrincipal.ResumeLayout(false);
            mnStrpPrincipal.PerformLayout();
            statusStripInformacoes.ResumeLayout(false);
            statusStripInformacoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnStrpPrincipal;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem novajanelaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem fonteToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private RichTextBox rtbconteudo;
        private StatusStrip statusStripInformacoes;
        private ToolStripMenuItem salvarcomoToolStripMenuItem;
        private ToolStripSeparator imprimirToolStripMenuItem;
        private ToolStripMenuItem configurarpaginaToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem2;
        private OpenFileDialog openFileDialogAbrir;
        private SaveFileDialog saveFileDialogAbrir;
        private ToolStripMenuItem buscarComOBingToolStripMenuItem;
        private ToolStripMenuItem horaDataToolStripMenuItem;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printdocumentConteudo;
        private PageSetupDialog pageSetupDialogConfiguraPagina;
        private PrintDialog printDialogImprimir;
        private FontDialog fontDialogFonte;
        private ToolStripStatusLabel toolStripStatuslabelCodificacao;
        private ToolStripStatusLabel toolStripStatuslabelFormato;
        private ToolStripStatusLabel toolStripStatuslabelZoom;
        private ToolStripStatusLabel toolStripStatuslabelPosicionamento;
        private ToolStripMenuItem exibirToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private ToolStripMenuItem ampliarToolStripMenuItem;
        private ToolStripMenuItem reduzirToolStripMenuItem;
        private ToolStripMenuItem zoomPadrãoToolStripMenuItem;
    }
}
