using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellForKnowledgeBase
{
    public partial class FormConsultation : Form
    {
        public FormConsultation()
        {
            InitializeComponent();

            comboBoxAnswer.Items.Clear();
            foreach (var variable in Elements.Variables)
                comboBoxAnswer.Items.Add(variable);

            var label = new Label();
            label.Text = "Выбирете цель консультации";
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Dock = DockStyle.Top;
            label.BorderStyle = BorderStyle.FixedSingle;
            panelConsultation.Controls.Add(label);
        }

        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            if (comboBoxAnswer.SelectedIndex < 0)
            {
                errorProvider1.SetError(buttonAnswer, "Ответ не выбран!");
                return;
            }
            errorProvider1.Clear();

            var label = new Label();
            label.Text = (comboBoxAnswer.SelectedItem as Variable).Name;
            label.TextAlign = ContentAlignment.MiddleRight;
            label.Dock = DockStyle.Top;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.FlatStyle = FlatStyle.Popup;
            panelConsultation.Controls.Add(label);
        }
    }
}
