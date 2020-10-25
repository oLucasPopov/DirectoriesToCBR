namespace DirectoriesToCBR
{
    partial class frmGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            this.lblCapa = new System.Windows.Forms.Label();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.dgVolumes = new System.Windows.Forms.DataGridView();
            this.clVolumes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPastas = new System.Windows.Forms.DataGridView();
            this.clVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPastas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbuttons = new System.Windows.Forms.ToolTip(this.components);
            this.cbCovers = new System.Windows.Forms.ComboBox();
            this.cmsSelectCovers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiLimparSelecionada = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLimparTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.pbVolumeAddOne = new System.Windows.Forms.PictureBox();
            this.pbAddFolders = new System.Windows.Forms.PictureBox();
            this.pbVolumeAddSeveral = new System.Windows.Forms.PictureBox();
            this.pbAddCovers = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnGerar = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiOutputDir = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.edtLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVolumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPastas)).BeginInit();
            this.cmsSelectCovers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeAddOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeAddSeveral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCovers)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Location = new System.Drawing.Point(471, 9);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(40, 13);
            this.lblCapa.TabIndex = 3;
            this.lblCapa.Text = "Covers";
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "add-color.png");
            this.IconsList.Images.SetKeyName(1, "add-several-color.png");
            // 
            // dgVolumes
            // 
            this.dgVolumes.AllowUserToAddRows = false;
            this.dgVolumes.AllowUserToDeleteRows = false;
            this.dgVolumes.AllowUserToResizeColumns = false;
            this.dgVolumes.AllowUserToResizeRows = false;
            this.dgVolumes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgVolumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVolumes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clVolumes,
            this.clCover});
            this.dgVolumes.Location = new System.Drawing.Point(10, 10);
            this.dgVolumes.Margin = new System.Windows.Forms.Padding(10);
            this.dgVolumes.Name = "dgVolumes";
            this.dgVolumes.RowHeadersVisible = false;
            this.dgVolumes.Size = new System.Drawing.Size(219, 350);
            this.dgVolumes.TabIndex = 7;
            this.dgVolumes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVolumes_CellEndEdit);
            this.dgVolumes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVolumes_CellEnter);
            this.dgVolumes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgVolumes_KeyDown);
            // 
            // clVolumes
            // 
            this.clVolumes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clVolumes.HeaderText = "Volumes";
            this.clVolumes.Name = "clVolumes";
            this.clVolumes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clCover
            // 
            this.clCover.HeaderText = "Cover";
            this.clCover.Name = "clCover";
            this.clCover.Visible = false;
            // 
            // dgPastas
            // 
            this.dgPastas.AllowUserToAddRows = false;
            this.dgPastas.AllowUserToResizeColumns = false;
            this.dgPastas.AllowUserToResizeRows = false;
            this.dgPastas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgPastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clVolume,
            this.clPastas});
            this.dgPastas.Location = new System.Drawing.Point(242, 9);
            this.dgPastas.Margin = new System.Windows.Forms.Padding(10);
            this.dgPastas.Name = "dgPastas";
            this.dgPastas.RowHeadersVisible = false;
            this.dgPastas.Size = new System.Drawing.Size(219, 350);
            this.dgPastas.TabIndex = 8;
            this.dgPastas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPastas_KeyDown);
            // 
            // clVolume
            // 
            this.clVolume.HeaderText = "Volume";
            this.clVolume.Name = "clVolume";
            this.clVolume.Visible = false;
            // 
            // clPastas
            // 
            this.clPastas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPastas.HeaderText = "Pastas";
            this.clPastas.Name = "clPastas";
            this.clPastas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbCovers
            // 
            this.cbCovers.ContextMenuStrip = this.cmsSelectCovers;
            this.cbCovers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCovers.FormattingEnabled = true;
            this.cbCovers.Location = new System.Drawing.Point(474, 25);
            this.cbCovers.Name = "cbCovers";
            this.cbCovers.Size = new System.Drawing.Size(191, 21);
            this.cbCovers.TabIndex = 10;
            this.ttbuttons.SetToolTip(this.cbCovers, "Covers que você selecionou.\r\nClique com o botão direito para mais opções.");
            this.cbCovers.SelectedIndexChanged += new System.EventHandler(this.cbCovers_SelectedIndexChanged);
            // 
            // cmsSelectCovers
            // 
            this.cmsSelectCovers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiLimparSelecionada,
            this.smiLimparTudo});
            this.cmsSelectCovers.Name = "cmsSelectCovers";
            this.cmsSelectCovers.Size = new System.Drawing.Size(245, 48);
            // 
            // smiLimparSelecionada
            // 
            this.smiLimparSelecionada.Name = "smiLimparSelecionada";
            this.smiLimparSelecionada.Size = new System.Drawing.Size(244, 22);
            this.smiLimparSelecionada.Text = "Limpar";
            this.smiLimparSelecionada.Click += new System.EventHandler(this.smiLimparSelecionada_Click);
            // 
            // smiLimparTudo
            // 
            this.smiLimparTudo.Name = "smiLimparTudo";
            this.smiLimparTudo.Size = new System.Drawing.Size(244, 22);
            this.smiLimparTudo.Text = "Remover todas as covers da lista";
            this.smiLimparTudo.Click += new System.EventHandler(this.smiLimparTudo_Click);
            // 
            // pbCover
            // 
            this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCover.Location = new System.Drawing.Point(474, 59);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(191, 300);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 11;
            this.pbCover.TabStop = false;
            this.ttbuttons.SetToolTip(this.pbCover, "Capa selecionada para o volume selecionado.");
            // 
            // pbVolumeAddOne
            // 
            this.pbVolumeAddOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolumeAddOne.Image = global::DirectoriesToCBR.Properties.Resources.add_color;
            this.pbVolumeAddOne.Location = new System.Drawing.Point(181, 367);
            this.pbVolumeAddOne.Name = "pbVolumeAddOne";
            this.pbVolumeAddOne.Size = new System.Drawing.Size(21, 21);
            this.pbVolumeAddOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolumeAddOne.TabIndex = 4;
            this.pbVolumeAddOne.TabStop = false;
            this.ttbuttons.SetToolTip(this.pbVolumeAddOne, "Adiciona volumes um de cada vez.");
            this.pbVolumeAddOne.Click += new System.EventHandler(this.pbVolumeAddOne_Click);
            // 
            // pbAddFolders
            // 
            this.pbAddFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddFolders.Image = global::DirectoriesToCBR.Properties.Resources.add_folder_color;
            this.pbAddFolders.Location = new System.Drawing.Point(440, 367);
            this.pbAddFolders.Name = "pbAddFolders";
            this.pbAddFolders.Size = new System.Drawing.Size(21, 21);
            this.pbAddFolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddFolders.TabIndex = 6;
            this.pbAddFolders.TabStop = false;
            this.ttbuttons.SetToolTip(this.pbAddFolders, "Pasta com as imagens para o volume selecionado.");
            this.pbAddFolders.Click += new System.EventHandler(this.pbAddFolders_Click);
            // 
            // pbVolumeAddSeveral
            // 
            this.pbVolumeAddSeveral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolumeAddSeveral.Image = global::DirectoriesToCBR.Properties.Resources.add_several_color;
            this.pbVolumeAddSeveral.Location = new System.Drawing.Point(208, 367);
            this.pbVolumeAddSeveral.Name = "pbVolumeAddSeveral";
            this.pbVolumeAddSeveral.Size = new System.Drawing.Size(21, 21);
            this.pbVolumeAddSeveral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolumeAddSeveral.TabIndex = 5;
            this.pbVolumeAddSeveral.TabStop = false;
            this.ttbuttons.SetToolTip(this.pbVolumeAddSeveral, "Adiciona vários volumes de uma vez.\r\nApenas escreva o prefixo que a gente cuida d" +
        "o resto.\r\nExemplo: \r\n  escreva \"exemplo\" e serão criados:\r\n  exemplo 1\r\n  exempl" +
        "o 2\r\n  exemplo 3");
            this.pbVolumeAddSeveral.Click += new System.EventHandler(this.pbVolumeAddSeveral_Click);
            // 
            // pbAddCovers
            // 
            this.pbAddCovers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddCovers.Image = global::DirectoriesToCBR.Properties.Resources.add_image_color;
            this.pbAddCovers.Location = new System.Drawing.Point(671, 25);
            this.pbAddCovers.Name = "pbAddCovers";
            this.pbAddCovers.Size = new System.Drawing.Size(21, 21);
            this.pbAddCovers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCovers.TabIndex = 9;
            this.pbAddCovers.TabStop = false;
            this.ttbuttons.SetToolTip(this.pbAddCovers, "Busca imagens das capas a serem utilizadas.\r\n");
            this.pbAddCovers.Click += new System.EventHandler(this.pbAddCovers_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.pbCover);
            this.pnlPrincipal.Controls.Add(this.pbVolumeAddOne);
            this.pnlPrincipal.Controls.Add(this.dgPastas);
            this.pnlPrincipal.Controls.Add(this.pbAddFolders);
            this.pnlPrincipal.Controls.Add(this.pbVolumeAddSeveral);
            this.pnlPrincipal.Controls.Add(this.cbCovers);
            this.pnlPrincipal.Controls.Add(this.lblCapa);
            this.pnlPrincipal.Controls.Add(this.pbAddCovers);
            this.pnlPrincipal.Controls.Add(this.dgVolumes);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 27);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(708, 393);
            this.pnlPrincipal.TabIndex = 12;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnGerar);
            this.pnlButtons.Location = new System.Drawing.Point(726, 27);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(145, 393);
            this.pnlButtons.TabIndex = 13;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(5, 4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(133, 42);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "GERAR";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(880, 24);
            this.msMain.TabIndex = 14;
            this.msMain.Text = "menuStrip1";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiOutputDir});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // ttmiOutputDir
            // 
            this.ttmiOutputDir.Name = "ttmiOutputDir";
            this.ttmiOutputDir.Size = new System.Drawing.Size(167, 22);
            this.ttmiOutputDir.Text = "Diretório de Saída";
            this.ttmiOutputDir.Click += new System.EventHandler(this.ttmiOutputDir_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiAutor,
            this.ttmiIcones});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ttmiAutor
            // 
            this.ttmiAutor.Name = "ttmiAutor";
            this.ttmiAutor.Size = new System.Drawing.Size(177, 22);
            this.ttmiAutor.Text = "Autor: Lucas Popov";
            // 
            // ttmiIcones
            // 
            this.ttmiIcones.Name = "ttmiIcones";
            this.ttmiIcones.Size = new System.Drawing.Size(177, 22);
            this.ttmiIcones.Text = "Ícones: Icons8";
            // 
            // edtLog
            // 
            this.edtLog.Location = new System.Drawing.Point(12, 426);
            this.edtLog.Name = "edtLog";
            this.edtLog.ReadOnly = true;
            this.edtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.edtLog.Size = new System.Drawing.Size(859, 170);
            this.edtLog.TabIndex = 15;
            this.edtLog.Text = "";
            this.ttbuttons.SetToolTip(this.edtLog, "Isso aqui só serve para você ver o que está acontecendo enquanto geramos os CBR.");
            this.edtLog.TextChanged += new System.EventHandler(this.edtLog_TextChanged);
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 608);
            this.Controls.Add(this.edtLog);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Files to CBR";
            ((System.ComponentModel.ISupportInitialize)(this.dgVolumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPastas)).EndInit();
            this.cmsSelectCovers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeAddOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeAddSeveral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCovers)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.PictureBox pbVolumeAddOne;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.PictureBox pbVolumeAddSeveral;
        private System.Windows.Forms.PictureBox pbAddFolders;
        private System.Windows.Forms.DataGridView dgVolumes;
        private System.Windows.Forms.ToolTip ttbuttons;
        private System.Windows.Forms.DataGridView dgPastas;
        private System.Windows.Forms.PictureBox pbAddCovers;
        private System.Windows.Forms.ComboBox cbCovers;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttmiOutputDir;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttmiAutor;
        private System.Windows.Forms.ToolStripMenuItem ttmiIcones;
        private System.Windows.Forms.ContextMenuStrip cmsSelectCovers;
        private System.Windows.Forms.ToolStripMenuItem smiLimparTudo;
        private System.Windows.Forms.ToolStripMenuItem smiLimparSelecionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVolumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPastas;
        private System.Windows.Forms.RichTextBox edtLog;
    }
}

