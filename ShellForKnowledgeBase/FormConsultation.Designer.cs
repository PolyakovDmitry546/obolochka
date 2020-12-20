namespace ShellForKnowledgeBase
{
    partial class FormConsultation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.comboBoxAnswer = new System.Windows.Forms.ComboBox();
            this.panelConsultation = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxAnswer);
            this.panel1.Controls.Add(this.buttonAnswer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 38);
            this.panel1.TabIndex = 0;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswer.Location = new System.Drawing.Point(282, 8);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer.TabIndex = 0;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.ButtonAnswer_Click);
            // 
            // comboBoxAnswer
            // 
            this.comboBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAnswer.FormattingEnabled = true;
            this.comboBoxAnswer.Location = new System.Drawing.Point(5, 8);
            this.comboBoxAnswer.Name = "comboBoxAnswer";
            this.comboBoxAnswer.Size = new System.Drawing.Size(271, 21);
            this.comboBoxAnswer.TabIndex = 1;
            // 
            // panelConsultation
            // 
            this.panelConsultation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultation.Location = new System.Drawing.Point(0, 0);
            this.panelConsultation.Name = "panelConsultation";
            this.panelConsultation.Size = new System.Drawing.Size(369, 273);
            this.panelConsultation.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 311);
            this.Controls.Add(this.panelConsultation);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsultation";
            this.Text = "Консультация";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxAnswer;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Panel panelConsultation;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}