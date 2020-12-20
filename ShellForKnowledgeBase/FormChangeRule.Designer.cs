namespace ShellForKnowledgeBase
{
    partial class FormChangeRule
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxClarification = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxConclusion = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConclusionAdd = new System.Windows.Forms.Button();
            this.buttonConclusionChange = new System.Windows.Forms.Button();
            this.buttonConclusionDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxParcel = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonParcelAdd = new System.Windows.Forms.Button();
            this.buttonParcelChange = new System.Windows.Forms.Button();
            this.buttonParcelDelete = new System.Windows.Forms.Button();
            this.textBoxRuleName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCnacel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя правила";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxClarification);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.textBoxRuleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(495, 314);
            this.panel1.TabIndex = 1;
            // 
            // textBoxClarification
            // 
            this.textBoxClarification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxClarification.Location = new System.Drawing.Point(10, 189);
            this.textBoxClarification.Multiline = true;
            this.textBoxClarification.Name = "textBoxClarification";
            this.textBoxClarification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxClarification.Size = new System.Drawing.Size(475, 80);
            this.textBoxClarification.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(10, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пояснение";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 133);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxConclusion);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(240, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заключение";
            // 
            // listBoxConclusion
            // 
            this.listBoxConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxConclusion.FormattingEnabled = true;
            this.listBoxConclusion.Location = new System.Drawing.Point(3, 16);
            this.listBoxConclusion.Name = "listBoxConclusion";
            this.listBoxConclusion.Size = new System.Drawing.Size(226, 82);
            this.listBoxConclusion.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 26);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel1.Controls.Add(this.buttonConclusionAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonConclusionChange, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonConclusionDelete, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonConclusionAdd
            // 
            this.buttonConclusionAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConclusionAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonConclusionAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConclusionAdd.Name = "buttonConclusionAdd";
            this.buttonConclusionAdd.Size = new System.Drawing.Size(75, 26);
            this.buttonConclusionAdd.TabIndex = 0;
            this.buttonConclusionAdd.Text = "Добавить";
            this.buttonConclusionAdd.UseVisualStyleBackColor = true;
            this.buttonConclusionAdd.Click += new System.EventHandler(this.ButtonConclusionAdd_Click);
            // 
            // buttonConclusionChange
            // 
            this.buttonConclusionChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConclusionChange.Location = new System.Drawing.Point(75, 0);
            this.buttonConclusionChange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConclusionChange.Name = "buttonConclusionChange";
            this.buttonConclusionChange.Size = new System.Drawing.Size(75, 26);
            this.buttonConclusionChange.TabIndex = 1;
            this.buttonConclusionChange.Text = "Изменить";
            this.buttonConclusionChange.UseVisualStyleBackColor = true;
            this.buttonConclusionChange.Click += new System.EventHandler(this.ButtonConclusionChange_Click);
            // 
            // buttonConclusionDelete
            // 
            this.buttonConclusionDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConclusionDelete.Location = new System.Drawing.Point(150, 0);
            this.buttonConclusionDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConclusionDelete.Name = "buttonConclusionDelete";
            this.buttonConclusionDelete.Size = new System.Drawing.Size(76, 26);
            this.buttonConclusionDelete.TabIndex = 2;
            this.buttonConclusionDelete.Text = "Удалить";
            this.buttonConclusionDelete.UseVisualStyleBackColor = true;
            this.buttonConclusionDelete.Click += new System.EventHandler(this.ButtonConclusionDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxParcel);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Посылка";
            // 
            // listBoxParcel
            // 
            this.listBoxParcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxParcel.FormattingEnabled = true;
            this.listBoxParcel.Location = new System.Drawing.Point(3, 16);
            this.listBoxParcel.Name = "listBoxParcel";
            this.listBoxParcel.Size = new System.Drawing.Size(225, 82);
            this.listBoxParcel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 26);
            this.panel5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonParcelAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonParcelChange, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonParcelDelete, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 26);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // buttonParcelAdd
            // 
            this.buttonParcelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParcelAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonParcelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParcelAdd.Name = "buttonParcelAdd";
            this.buttonParcelAdd.Size = new System.Drawing.Size(75, 26);
            this.buttonParcelAdd.TabIndex = 0;
            this.buttonParcelAdd.Text = "Добавить";
            this.buttonParcelAdd.UseVisualStyleBackColor = true;
            this.buttonParcelAdd.Click += new System.EventHandler(this.ButtonParcelAdd_Click);
            // 
            // buttonParcelChange
            // 
            this.buttonParcelChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParcelChange.Location = new System.Drawing.Point(75, 0);
            this.buttonParcelChange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParcelChange.Name = "buttonParcelChange";
            this.buttonParcelChange.Size = new System.Drawing.Size(75, 26);
            this.buttonParcelChange.TabIndex = 1;
            this.buttonParcelChange.Text = "Изменить";
            this.buttonParcelChange.UseVisualStyleBackColor = true;
            this.buttonParcelChange.Click += new System.EventHandler(this.ButtonParcelChange_Click);
            // 
            // buttonParcelDelete
            // 
            this.buttonParcelDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParcelDelete.Location = new System.Drawing.Point(150, 0);
            this.buttonParcelDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParcelDelete.Name = "buttonParcelDelete";
            this.buttonParcelDelete.Size = new System.Drawing.Size(75, 26);
            this.buttonParcelDelete.TabIndex = 2;
            this.buttonParcelDelete.Text = "Удалить";
            this.buttonParcelDelete.UseVisualStyleBackColor = true;
            this.buttonParcelDelete.Click += new System.EventHandler(this.ButtonParcelDelete_Click);
            // 
            // textBoxRuleName
            // 
            this.textBoxRuleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxRuleName.Location = new System.Drawing.Point(10, 23);
            this.textBoxRuleName.Name = "textBoxRuleName";
            this.textBoxRuleName.Size = new System.Drawing.Size(475, 20);
            this.textBoxRuleName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonOK);
            this.panel3.Controls.Add(this.buttonCnacel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 35);
            this.panel3.TabIndex = 8;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(292, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 25);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCnacel
            // 
            this.buttonCnacel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCnacel.Location = new System.Drawing.Point(383, 3);
            this.buttonCnacel.Name = "buttonCnacel";
            this.buttonCnacel.Size = new System.Drawing.Size(89, 25);
            this.buttonCnacel.TabIndex = 5;
            this.buttonCnacel.Text = "Отмена";
            this.buttonCnacel.UseVisualStyleBackColor = true;
            this.buttonCnacel.Click += new System.EventHandler(this.ButtonCnacel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormChangeRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 314);
            this.Controls.Add(this.panel1);
            this.Name = "FormChangeRule";
            this.Text = "FormChangeRule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCnacel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRuleName;
        private System.Windows.Forms.TextBox textBoxClarification;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonParcelAdd;
        private System.Windows.Forms.Button buttonParcelChange;
        private System.Windows.Forms.Button buttonParcelDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonConclusionAdd;
        private System.Windows.Forms.Button buttonConclusionChange;
        private System.Windows.Forms.Button buttonConclusionDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listBoxConclusion;
        private System.Windows.Forms.ListBox listBoxParcel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}