namespace ShellForKnowledgeBase
{
    partial class FormChangeDomain
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
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCnacel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя домена";
            // 
            // textBoxDomainName
            // 
            this.textBoxDomainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDomainName.Location = new System.Drawing.Point(0, 13);
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(405, 20);
            this.textBoxDomainName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возможные значения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCnacel);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonCnacel
            // 
            this.buttonCnacel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCnacel.Location = new System.Drawing.Point(310, 14);
            this.buttonCnacel.Name = "buttonCnacel";
            this.buttonCnacel.Size = new System.Drawing.Size(89, 25);
            this.buttonCnacel.TabIndex = 8;
            this.buttonCnacel.Text = "Отмена";
            this.buttonCnacel.UseVisualStyleBackColor = true;
            this.buttonCnacel.Click += new System.EventHandler(this.ButtonCnacel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(219, 14);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 25);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.Location = new System.Drawing.Point(0, 0);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(405, 132);
            this.listBoxDomainValues.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxDomainValues);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 163);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonChange, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 31);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 25);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(273, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 25);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChange.Location = new System.Drawing.Point(138, 3);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(129, 25);
            this.buttonChange.TabIndex = 7;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormChangeDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDomainName);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeDomain";
            this.Text = "FormChangeDomain";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDomainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCnacel;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}