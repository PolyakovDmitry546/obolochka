namespace ShellForKnowledgeBase
{
    partial class FormCreateVarible
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
            this.textBoxVariableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.buttonAddDomain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCnacel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonRequested = new System.Windows.Forms.RadioButton();
            this.radioButtonDeduce = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя переменной";
            // 
            // textBoxVariableName
            // 
            this.textBoxVariableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxVariableName.Location = new System.Drawing.Point(0, 13);
            this.textBoxVariableName.Name = "textBoxVariableName";
            this.textBoxVariableName.Size = new System.Drawing.Size(554, 20);
            this.textBoxVariableName.TabIndex = 1;
            this.textBoxVariableName.TextChanged += new System.EventHandler(this.TextBoxVariableName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Домен";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxDomain);
            this.panel1.Controls.Add(this.buttonAddDomain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 22);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(0, 0);
            this.comboBoxDomain.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(516, 21);
            this.comboBoxDomain.TabIndex = 0;
            // 
            // buttonAddDomain
            // 
            this.buttonAddDomain.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddDomain.Location = new System.Drawing.Point(516, 0);
            this.buttonAddDomain.Name = "buttonAddDomain";
            this.buttonAddDomain.Size = new System.Drawing.Size(38, 22);
            this.buttonAddDomain.TabIndex = 1;
            this.buttonAddDomain.Text = "+";
            this.buttonAddDomain.UseVisualStyleBackColor = true;
            this.buttonAddDomain.Click += new System.EventHandler(this.ButtonAddDomain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 68);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип переменной";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 106);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Текст вопроса";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Location = new System.Drawing.Point(0, 119);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(554, 165);
            this.textBoxQuestion.TabIndex = 7;
            this.textBoxQuestion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxQuestion_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCnacel);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // buttonCnacel
            // 
            this.buttonCnacel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCnacel.Location = new System.Drawing.Point(459, 12);
            this.buttonCnacel.Name = "buttonCnacel";
            this.buttonCnacel.Size = new System.Drawing.Size(89, 25);
            this.buttonCnacel.TabIndex = 7;
            this.buttonCnacel.Text = "Отмена";
            this.buttonCnacel.UseVisualStyleBackColor = true;
            this.buttonCnacel.Click += new System.EventHandler(this.ButtonCnacel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(368, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 25);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonRequested);
            this.panel2.Controls.Add(this.radioButtonDeduce);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 25);
            this.panel2.TabIndex = 9;
            // 
            // radioButtonRequested
            // 
            this.radioButtonRequested.AutoSize = true;
            this.radioButtonRequested.Location = new System.Drawing.Point(102, 3);
            this.radioButtonRequested.Name = "radioButtonRequested";
            this.radioButtonRequested.Size = new System.Drawing.Size(108, 17);
            this.radioButtonRequested.TabIndex = 1;
            this.radioButtonRequested.TabStop = true;
            this.radioButtonRequested.Text = "Запрашиваемая";
            this.radioButtonRequested.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeduce
            // 
            this.radioButtonDeduce.AutoSize = true;
            this.radioButtonDeduce.Checked = true;
            this.radioButtonDeduce.Location = new System.Drawing.Point(12, 3);
            this.radioButtonDeduce.Name = "radioButtonDeduce";
            this.radioButtonDeduce.Size = new System.Drawing.Size(84, 17);
            this.radioButtonDeduce.TabIndex = 0;
            this.radioButtonDeduce.TabStop = true;
            this.radioButtonDeduce.Text = "Выводимая";
            this.radioButtonDeduce.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCreateVarible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 327);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVariableName);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateVarible";
            this.Text = "FormCreateVarible";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVariableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.Button buttonAddDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCnacel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonRequested;
        private System.Windows.Forms.RadioButton radioButtonDeduce;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}