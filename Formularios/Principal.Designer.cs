
namespace AutoPeca.Formularios
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editMenu = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip = new System.Windows.Forms.ToolStrip();
            newToolStripButton = new System.Windows.Forms.ToolStripButton();
            openToolStripButton = new System.Windows.Forms.ToolStripButton();
            saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            printToolStripButton = new System.Windows.Forms.ToolStripButton();
            printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            statusStrip = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolTip = new System.Windows.Forms.ToolTip(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileMenu, editMenu, viewMenu, toolsMenu, windowsMenu, helpMenu });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(898, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator4, printToolStripMenuItem, printPreviewToolStripMenuItem, printSetupToolStripMenuItem, toolStripSeparator5, exitToolStripMenuItem, ferramentasToolStripMenuItem });
            fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new System.Drawing.Size(71, 20);
            fileMenu.Text = "&Cadastros";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            newToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            newToolStripMenuItem.Text = "&Cadastro Veiculos";
            newToolStripMenuItem.Click += ShowNewForm;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            openToolStripMenuItem.Text = "&Cadastro Fabricantes";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            saveToolStripMenuItem.Text = "Cadastro Clientes";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            saveAsToolStripMenuItem.Text = "Cadastro Peças";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(224, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            printToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            printToolStripMenuItem.Text = "Cadastro Pedidos";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            printPreviewToolStripMenuItem.Text = "&Vizualizar impressão";
            // 
            // printSetupToolStripMenuItem
            // 
            printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            printSetupToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            printSetupToolStripMenuItem.Text = "Configurar Impressão";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(224, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            exitToolStripMenuItem.Text = "Sai&r";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            ferramentasToolStripMenuItem.Text = "&Ferramentas";
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator6, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator7, selectAllToolStripMenuItem });
            editMenu.Name = "editMenu";
            editMenu.Size = new System.Drawing.Size(49, 20);
            editMenu.Text = "&Editar";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            undoToolStripMenuItem.Text = "&Desfazer";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            redoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            redoToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(197, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            cutToolStripMenuItem.Text = "&Recortar";
            cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            copyToolStripMenuItem.Text = "&Copiar";
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            pasteToolStripMenuItem.Text = "&Colar";
            pasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(197, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selectAllToolStripMenuItem.Text = "Selecion&ar Tudo";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolBarToolStripMenuItem, statusBarToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new System.Drawing.Size(48, 20);
            viewMenu.Text = "&Exibir";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.Checked = true;
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            toolBarToolStripMenuItem.Text = "&Barra de Ferramentas";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            statusBarToolStripMenuItem.Text = "&Barra de Status";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // toolsMenu
            // 
            toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem });
            toolsMenu.Name = "toolsMenu";
            toolsMenu.Size = new System.Drawing.Size(84, 20);
            toolsMenu.Text = "&Ferramentas";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            optionsToolStripMenuItem.Text = "&Opções";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new System.Drawing.Size(56, 20);
            windowsMenu.Text = "&Janelas";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            newWindowToolStripMenuItem.Text = "&Nova Janela";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            cascadeToolStripMenuItem.Text = "&Cascata";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            tileVerticalToolStripMenuItem.Text = "Empilhar &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            tileHorizontalToolStripMenuItem.Text = "Empilhar &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            closeAllToolStripMenuItem.Text = "Fec&har todos";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            arrangeIconsToolStripMenuItem.Text = "&Organizar Ícones";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator8, aboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new System.Drawing.Size(50, 20);
            helpMenu.Text = "&Ajuda";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1;
            contentsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            contentsToolStripMenuItem.Text = "&Conteúdo";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("indexToolStripMenuItem.Image");
            indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            searchToolStripMenuItem.Text = "&Procurar";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(170, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            aboutToolStripMenuItem.Text = "&Sobre ... ...";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator1, printToolStripButton, printPreviewToolStripButton, toolStripSeparator2, helpToolStripButton });
            toolStrip.Location = new System.Drawing.Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(898, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (System.Drawing.Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new System.Drawing.Size(23, 22);
            newToolStripButton.Text = "Novo";
            newToolStripButton.Click += ShowNewForm;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (System.Drawing.Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new System.Drawing.Size(23, 22);
            openToolStripButton.Text = "Abrir";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (System.Drawing.Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            saveToolStripButton.Text = "Salvar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (System.Drawing.Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new System.Drawing.Size(23, 22);
            printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            printPreviewToolStripButton.Image = (System.Drawing.Image)resources.GetObject("printPreviewToolStripButton.Image");
            printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            printPreviewToolStripButton.Text = "Vizualizer Impressão";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (System.Drawing.Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            helpToolStripButton.Text = "Ajuda";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(898, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // Principal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(898, 523);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Principal";
            Text = "Sistema de Autopeças";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
    }
}



