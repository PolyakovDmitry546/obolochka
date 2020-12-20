namespace ShellForKnowledgeBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.panelRules1 = new System.Windows.Forms.Panel();
            this.dataGridViewRules = new System.Windows.Forms.DataGridView();
            this.ColumnRuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRuleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRules5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxParcels = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxConclusions = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxRuleClarification = new System.Windows.Forms.TextBox();
            this.panelRules2 = new System.Windows.Forms.Panel();
            this.buttonRulesDelete = new System.Windows.Forms.Button();
            this.buttonRulesChange = new System.Windows.Forms.Button();
            this.buttonRulesAdd = new System.Windows.Forms.Button();
            this.tabPageVariables = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewVariables = new System.Windows.Forms.DataGridView();
            this.ColumnVariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVariableType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVariableDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonVariablesDelete = new System.Windows.Forms.Button();
            this.buttonVariablesChange = new System.Windows.Forms.Button();
            this.buttonVariablesAdd = new System.Windows.Forms.Button();
            this.tabPageDomains = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewDomains = new System.Windows.Forms.DataGridView();
            this.ColumnDomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDomainsDelete = new System.Windows.Forms.Button();
            this.buttonDomainsChange = new System.Windows.Forms.Button();
            this.buttonDomainsAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.panelRules1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).BeginInit();
            this.panelRules5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelRules2.SuspendLayout();
            this.tabPageVariables.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageDomains.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomains)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newToolStripMenuItem.Text = "Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.консультацияToolStripMenuItem.Text = "Консультация";
            this.консультацияToolStripMenuItem.Click += new System.EventHandler(this.КонсультацияToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRules);
            this.tabControl1.Controls.Add(this.tabPageVariables);
            this.tabControl1.Controls.Add(this.tabPageDomains);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.panelRules1);
            this.tabPageRules.Controls.Add(this.panelRules5);
            this.tabPageRules.Location = new System.Drawing.Point(4, 22);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRules.Size = new System.Drawing.Size(800, 399);
            this.tabPageRules.TabIndex = 0;
            this.tabPageRules.Text = "Правила";
            this.tabPageRules.UseVisualStyleBackColor = true;
            this.tabPageRules.Enter += new System.EventHandler(this.TabPageRules_Enter);
            // 
            // panelRules1
            // 
            this.panelRules1.Controls.Add(this.dataGridViewRules);
            this.panelRules1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRules1.Location = new System.Drawing.Point(3, 3);
            this.panelRules1.Name = "panelRules1";
            this.panelRules1.Size = new System.Drawing.Size(553, 393);
            this.panelRules1.TabIndex = 1;
            // 
            // dataGridViewRules
            // 
            this.dataGridViewRules.AllowDrop = true;
            this.dataGridViewRules.AllowUserToAddRows = false;
            this.dataGridViewRules.AllowUserToDeleteRows = false;
            this.dataGridViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRuleName,
            this.ColumnRuleDescription});
            this.dataGridViewRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRules.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRules.MultiSelect = false;
            this.dataGridViewRules.Name = "dataGridViewRules";
            this.dataGridViewRules.ReadOnly = true;
            this.dataGridViewRules.RowHeadersVisible = false;
            this.dataGridViewRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRules.Size = new System.Drawing.Size(553, 393);
            this.dataGridViewRules.TabIndex = 0;
            this.dataGridViewRules.SelectionChanged += new System.EventHandler(this.DataGridViewRules_SelectionChanged);
            this.dataGridViewRules.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGridViewRules_DragDrop);
            this.dataGridViewRules.DragOver += new System.Windows.Forms.DragEventHandler(this.DataGridViewRules_DragOver);
            this.dataGridViewRules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewRules_MouseDown);
            this.dataGridViewRules.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataGridViewRules_MouseMove);
            // 
            // ColumnRuleName
            // 
            this.ColumnRuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnRuleName.HeaderText = "Имя";
            this.ColumnRuleName.Name = "ColumnRuleName";
            this.ColumnRuleName.ReadOnly = true;
            this.ColumnRuleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnRuleDescription
            // 
            this.ColumnRuleDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRuleDescription.HeaderText = "Описание";
            this.ColumnRuleDescription.Name = "ColumnRuleDescription";
            this.ColumnRuleDescription.ReadOnly = true;
            this.ColumnRuleDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelRules5
            // 
            this.panelRules5.Controls.Add(this.tableLayoutPanel1);
            this.panelRules5.Controls.Add(this.panelRules2);
            this.panelRules5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRules5.Location = new System.Drawing.Point(556, 3);
            this.panelRules5.Name = "panelRules5";
            this.panelRules5.Size = new System.Drawing.Size(241, 393);
            this.panelRules5.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 315);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxParcels);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 99);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Посылка";
            // 
            // listBoxParcels
            // 
            this.listBoxParcels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxParcels.FormattingEnabled = true;
            this.listBoxParcels.Location = new System.Drawing.Point(3, 16);
            this.listBoxParcels.Name = "listBoxParcels";
            this.listBoxParcels.Size = new System.Drawing.Size(229, 80);
            this.listBoxParcels.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxConclusions);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 99);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Заключение";
            // 
            // listBoxConclusions
            // 
            this.listBoxConclusions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxConclusions.FormattingEnabled = true;
            this.listBoxConclusions.Location = new System.Drawing.Point(3, 16);
            this.listBoxConclusions.Name = "listBoxConclusions";
            this.listBoxConclusions.Size = new System.Drawing.Size(229, 80);
            this.listBoxConclusions.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxRuleClarification);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 99);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Объяснение правила";
            // 
            // textBoxRuleClarification
            // 
            this.textBoxRuleClarification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRuleClarification.Location = new System.Drawing.Point(3, 16);
            this.textBoxRuleClarification.Multiline = true;
            this.textBoxRuleClarification.Name = "textBoxRuleClarification";
            this.textBoxRuleClarification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRuleClarification.Size = new System.Drawing.Size(229, 80);
            this.textBoxRuleClarification.TabIndex = 0;
            // 
            // panelRules2
            // 
            this.panelRules2.Controls.Add(this.buttonRulesDelete);
            this.panelRules2.Controls.Add(this.buttonRulesChange);
            this.panelRules2.Controls.Add(this.buttonRulesAdd);
            this.panelRules2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRules2.Location = new System.Drawing.Point(0, 0);
            this.panelRules2.Name = "panelRules2";
            this.panelRules2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelRules2.Size = new System.Drawing.Size(241, 78);
            this.panelRules2.TabIndex = 0;
            // 
            // buttonRulesDelete
            // 
            this.buttonRulesDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRulesDelete.Location = new System.Drawing.Point(0, 51);
            this.buttonRulesDelete.Name = "buttonRulesDelete";
            this.buttonRulesDelete.Size = new System.Drawing.Size(241, 23);
            this.buttonRulesDelete.TabIndex = 2;
            this.buttonRulesDelete.Text = "Удалить";
            this.buttonRulesDelete.UseVisualStyleBackColor = true;
            this.buttonRulesDelete.Click += new System.EventHandler(this.ButtonRulesDelete_Click);
            // 
            // buttonRulesChange
            // 
            this.buttonRulesChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRulesChange.Location = new System.Drawing.Point(0, 28);
            this.buttonRulesChange.Name = "buttonRulesChange";
            this.buttonRulesChange.Size = new System.Drawing.Size(241, 23);
            this.buttonRulesChange.TabIndex = 1;
            this.buttonRulesChange.Text = "Изменить";
            this.buttonRulesChange.UseVisualStyleBackColor = true;
            this.buttonRulesChange.Click += new System.EventHandler(this.ButtonRulesChange_Click);
            // 
            // buttonRulesAdd
            // 
            this.buttonRulesAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRulesAdd.Location = new System.Drawing.Point(0, 5);
            this.buttonRulesAdd.Name = "buttonRulesAdd";
            this.buttonRulesAdd.Size = new System.Drawing.Size(241, 23);
            this.buttonRulesAdd.TabIndex = 0;
            this.buttonRulesAdd.Text = "Добавить";
            this.buttonRulesAdd.UseVisualStyleBackColor = true;
            this.buttonRulesAdd.Click += new System.EventHandler(this.ButtonRulesAdd_Click);
            // 
            // tabPageVariables
            // 
            this.tabPageVariables.Controls.Add(this.panel6);
            this.tabPageVariables.Controls.Add(this.panel1);
            this.tabPageVariables.Location = new System.Drawing.Point(4, 22);
            this.tabPageVariables.Name = "tabPageVariables";
            this.tabPageVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariables.Size = new System.Drawing.Size(800, 399);
            this.tabPageVariables.TabIndex = 1;
            this.tabPageVariables.Text = "Переменные";
            this.tabPageVariables.UseVisualStyleBackColor = true;
            this.tabPageVariables.Enter += new System.EventHandler(this.TabPageVariables_Enter);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridViewVariables);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(576, 393);
            this.panel6.TabIndex = 2;
            // 
            // dataGridViewVariables
            // 
            this.dataGridViewVariables.AllowUserToAddRows = false;
            this.dataGridViewVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVariableName,
            this.ColumnVariableType,
            this.ColumnVariableDomain});
            this.dataGridViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVariables.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVariables.MultiSelect = false;
            this.dataGridViewVariables.Name = "dataGridViewVariables";
            this.dataGridViewVariables.ReadOnly = true;
            this.dataGridViewVariables.RowHeadersVisible = false;
            this.dataGridViewVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVariables.Size = new System.Drawing.Size(576, 393);
            this.dataGridViewVariables.TabIndex = 1;
            this.dataGridViewVariables.SelectionChanged += new System.EventHandler(this.DataGridViewVariables_SelectionChanged);
            // 
            // ColumnVariableName
            // 
            this.ColumnVariableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnVariableName.HeaderText = "Имя";
            this.ColumnVariableName.Name = "ColumnVariableName";
            this.ColumnVariableName.ReadOnly = true;
            // 
            // ColumnVariableType
            // 
            this.ColumnVariableType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnVariableType.HeaderText = "Тип";
            this.ColumnVariableType.Name = "ColumnVariableType";
            this.ColumnVariableType.ReadOnly = true;
            // 
            // ColumnVariableDomain
            // 
            this.ColumnVariableDomain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnVariableDomain.HeaderText = "Домен";
            this.ColumnVariableDomain.Name = "ColumnVariableDomain";
            this.ColumnVariableDomain.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(579, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 393);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxQuestionText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 311);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Текст вопроса";
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestionText.Location = new System.Drawing.Point(3, 16);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestionText.Size = new System.Drawing.Size(212, 292);
            this.textBoxQuestionText.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonVariablesDelete);
            this.panel2.Controls.Add(this.buttonVariablesChange);
            this.panel2.Controls.Add(this.buttonVariablesAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(218, 82);
            this.panel2.TabIndex = 1;
            // 
            // buttonVariablesDelete
            // 
            this.buttonVariablesDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVariablesDelete.Location = new System.Drawing.Point(0, 51);
            this.buttonVariablesDelete.Name = "buttonVariablesDelete";
            this.buttonVariablesDelete.Size = new System.Drawing.Size(218, 23);
            this.buttonVariablesDelete.TabIndex = 2;
            this.buttonVariablesDelete.Text = "Удалить";
            this.buttonVariablesDelete.UseVisualStyleBackColor = true;
            this.buttonVariablesDelete.Click += new System.EventHandler(this.ButtonVariablesDelete_Click);
            // 
            // buttonVariablesChange
            // 
            this.buttonVariablesChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVariablesChange.Location = new System.Drawing.Point(0, 28);
            this.buttonVariablesChange.Name = "buttonVariablesChange";
            this.buttonVariablesChange.Size = new System.Drawing.Size(218, 23);
            this.buttonVariablesChange.TabIndex = 1;
            this.buttonVariablesChange.Text = "Изменить";
            this.buttonVariablesChange.UseVisualStyleBackColor = true;
            this.buttonVariablesChange.Click += new System.EventHandler(this.ButtonVariablesChange_Click);
            // 
            // buttonVariablesAdd
            // 
            this.buttonVariablesAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVariablesAdd.Location = new System.Drawing.Point(0, 5);
            this.buttonVariablesAdd.Name = "buttonVariablesAdd";
            this.buttonVariablesAdd.Size = new System.Drawing.Size(218, 23);
            this.buttonVariablesAdd.TabIndex = 0;
            this.buttonVariablesAdd.Text = "Добавить";
            this.buttonVariablesAdd.UseVisualStyleBackColor = true;
            this.buttonVariablesAdd.Click += new System.EventHandler(this.ButtonVariablesAdd_Click);
            // 
            // tabPageDomains
            // 
            this.tabPageDomains.Controls.Add(this.panel4);
            this.tabPageDomains.Controls.Add(this.panel5);
            this.tabPageDomains.Location = new System.Drawing.Point(4, 22);
            this.tabPageDomains.Name = "tabPageDomains";
            this.tabPageDomains.Size = new System.Drawing.Size(800, 399);
            this.tabPageDomains.TabIndex = 2;
            this.tabPageDomains.Text = "Домены";
            this.tabPageDomains.UseVisualStyleBackColor = true;
            this.tabPageDomains.Enter += new System.EventHandler(this.TabPageDomains_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewDomains);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 399);
            this.panel4.TabIndex = 3;
            // 
            // dataGridViewDomains
            // 
            this.dataGridViewDomains.AllowUserToAddRows = false;
            this.dataGridViewDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDomains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDomainName});
            this.dataGridViewDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDomains.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDomains.MultiSelect = false;
            this.dataGridViewDomains.Name = "dataGridViewDomains";
            this.dataGridViewDomains.ReadOnly = true;
            this.dataGridViewDomains.RowHeadersVisible = false;
            this.dataGridViewDomains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDomains.Size = new System.Drawing.Size(582, 399);
            this.dataGridViewDomains.TabIndex = 1;
            this.dataGridViewDomains.SelectionChanged += new System.EventHandler(this.DataGridViewDomains_SelectionChanged);
            // 
            // ColumnDomainName
            // 
            this.ColumnDomainName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDomainName.HeaderText = "Имя";
            this.ColumnDomainName.Name = "ColumnDomainName";
            this.ColumnDomainName.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(582, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 399);
            this.panel5.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxDomainValues);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значение домена";
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.Location = new System.Drawing.Point(3, 16);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(212, 301);
            this.listBoxDomainValues.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDomainsDelete);
            this.panel3.Controls.Add(this.buttonDomainsChange);
            this.panel3.Controls.Add(this.buttonDomainsAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(218, 79);
            this.panel3.TabIndex = 2;
            // 
            // buttonDomainsDelete
            // 
            this.buttonDomainsDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDomainsDelete.Location = new System.Drawing.Point(0, 51);
            this.buttonDomainsDelete.Name = "buttonDomainsDelete";
            this.buttonDomainsDelete.Size = new System.Drawing.Size(218, 23);
            this.buttonDomainsDelete.TabIndex = 2;
            this.buttonDomainsDelete.Text = "Удалить";
            this.buttonDomainsDelete.UseVisualStyleBackColor = true;
            this.buttonDomainsDelete.Click += new System.EventHandler(this.ButtonDomainsDelete_Click);
            // 
            // buttonDomainsChange
            // 
            this.buttonDomainsChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDomainsChange.Location = new System.Drawing.Point(0, 28);
            this.buttonDomainsChange.Name = "buttonDomainsChange";
            this.buttonDomainsChange.Size = new System.Drawing.Size(218, 23);
            this.buttonDomainsChange.TabIndex = 1;
            this.buttonDomainsChange.Text = "Изменить";
            this.buttonDomainsChange.UseVisualStyleBackColor = true;
            this.buttonDomainsChange.Click += new System.EventHandler(this.ButtonDomainsChange_Click);
            // 
            // buttonDomainsAdd
            // 
            this.buttonDomainsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDomainsAdd.Location = new System.Drawing.Point(0, 5);
            this.buttonDomainsAdd.Name = "buttonDomainsAdd";
            this.buttonDomainsAdd.Size = new System.Drawing.Size(218, 23);
            this.buttonDomainsAdd.TabIndex = 0;
            this.buttonDomainsAdd.Text = "Добавить";
            this.buttonDomainsAdd.UseVisualStyleBackColor = true;
            this.buttonDomainsAdd.Click += new System.EventHandler(this.ButtonDomainsAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRules.ResumeLayout(false);
            this.panelRules1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).EndInit();
            this.panelRules5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panelRules2.ResumeLayout(false);
            this.tabPageVariables.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPageDomains.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDomains)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.Panel panelRules2;
        private System.Windows.Forms.Button buttonRulesDelete;
        private System.Windows.Forms.Button buttonRulesChange;
        private System.Windows.Forms.Button buttonRulesAdd;
        private System.Windows.Forms.TabPage tabPageVariables;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonVariablesDelete;
        private System.Windows.Forms.Button buttonVariablesChange;
        private System.Windows.Forms.Button buttonVariablesAdd;
        private System.Windows.Forms.TabPage tabPageDomains;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDomainsDelete;
        private System.Windows.Forms.Button buttonDomainsChange;
        private System.Windows.Forms.Button buttonDomainsAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelRules1;
        private System.Windows.Forms.Panel panelRules5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewRules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVariableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVariableType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVariableDomain;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.DataGridView dataGridViewDomains;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDomainName;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxParcels;
        private System.Windows.Forms.ListBox listBoxConclusions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxRuleClarification;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRuleDescription;
    }
}

