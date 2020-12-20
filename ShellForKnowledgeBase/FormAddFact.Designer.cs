namespace ShellForKnowledgeBase
{
    partial class FormAddFact
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCnacel = new System.Windows.Forms.Button();
            this.comboBoxVariable = new System.Windows.Forms.ComboBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNotEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonEqual = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(141, 122);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 25);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCnacel
            // 
            this.buttonCnacel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCnacel.Location = new System.Drawing.Point(232, 122);
            this.buttonCnacel.Name = "buttonCnacel";
            this.buttonCnacel.Size = new System.Drawing.Size(89, 25);
            this.buttonCnacel.TabIndex = 6;
            this.buttonCnacel.Text = "Отмена";
            this.buttonCnacel.UseVisualStyleBackColor = true;
            this.buttonCnacel.Click += new System.EventHandler(this.ButtonCnacel_Click);
            // 
            // comboBoxVariable
            // 
            this.comboBoxVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxVariable.FormattingEnabled = true;
            this.comboBoxVariable.Location = new System.Drawing.Point(0, 0);
            this.comboBoxVariable.Name = "comboBoxVariable";
            this.comboBoxVariable.Size = new System.Drawing.Size(292, 21);
            this.comboBoxVariable.TabIndex = 7;
            this.comboBoxVariable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVariable_SelectedIndexChanged);
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(0, 90);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(328, 21);
            this.comboBoxValue.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(292, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(36, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Переменная";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxVariable);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 23);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNotEqual);
            this.groupBox1.Controls.Add(this.radioButtonEqual);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 41);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отношение";
            // 
            // radioButtonNotEqual
            // 
            this.radioButtonNotEqual.AutoSize = true;
            this.radioButtonNotEqual.Location = new System.Drawing.Point(49, 19);
            this.radioButtonNotEqual.Name = "radioButtonNotEqual";
            this.radioButtonNotEqual.Size = new System.Drawing.Size(34, 17);
            this.radioButtonNotEqual.TabIndex = 1;
            this.radioButtonNotEqual.Text = "!=";
            this.radioButtonNotEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonEqual
            // 
            this.radioButtonEqual.AutoSize = true;
            this.radioButtonEqual.Checked = true;
            this.radioButtonEqual.Location = new System.Drawing.Point(12, 19);
            this.radioButtonEqual.Name = "radioButtonEqual";
            this.radioButtonEqual.Size = new System.Drawing.Size(31, 17);
            this.radioButtonEqual.TabIndex = 0;
            this.radioButtonEqual.TabStop = true;
            this.radioButtonEqual.Text = "=";
            this.radioButtonEqual.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Значение";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 159);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCnacel);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormAddFact";
            this.Text = "FormAdd";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCnacel;
        private System.Windows.Forms.ComboBox comboBoxVariable;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNotEqual;
        private System.Windows.Forms.RadioButton radioButtonEqual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}