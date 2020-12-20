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
    public partial class FormCreateVarible : Form
    {
        public Variable ResultVariable { get; set; }

        bool userQuestion = false;

        public FormCreateVarible()
        {
            InitializeComponent();

            comboBoxDomain.Items.Clear();
            foreach (var domain in Elements.Domains)
                comboBoxDomain.Items.Add(domain);
        }

        public FormCreateVarible(Variable variable)
        {
            InitializeComponent();
            ResultVariable = variable;
            userQuestion = true;
            textBoxVariableName.Text = variable.Name;

            comboBoxDomain.Items.Clear();
            foreach (var domain in Elements.Domains)
                comboBoxDomain.Items.Add(domain);
            comboBoxDomain.SelectedItem = variable.Domain;

            if (variable.Type == Variable.VariableType.Deduce)
                radioButtonDeduce.Checked = true;
            else
                radioButtonRequested.Checked = true;
            textBoxQuestion.Text = variable.Question;
        }

        private void ButtonAddDomain_Click(object sender, EventArgs e)
        {
            using(var form = new FormChangeDomain())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    comboBoxDomain.Items.Add(form.ReturnDomain);
                    comboBoxDomain.SelectedItem = form.ReturnDomain;
                }
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var variableName = textBoxVariableName.Text.Trim().ToLower();
            if(String.IsNullOrWhiteSpace(variableName))
            {
                errorProvider1.SetError(buttonOK, "Введено некорректное имя переменной!");
                return;
            }
            if(Elements.CheckVariableName(variableName, ResultVariable))
            {
                errorProvider1.SetError(buttonOK, "Такая переменная уже существует!");
                return;
            }
            if(comboBoxDomain.SelectedIndex < 0)
            {
                errorProvider1.SetError(buttonOK, "Домен не выбран!");
                return;
            }
            if (ResultVariable == null)
                ResultVariable = new Variable();
            ResultVariable.Name = variableName;
            ResultVariable.Domain = comboBoxDomain.SelectedItem as Domain;
            if (radioButtonDeduce.Checked)
                ResultVariable.Type = Variable.VariableType.Deduce;
            else
                ResultVariable.Type = Variable.VariableType.Requested;
            ResultVariable.Question = textBoxQuestion.Text;
            errorProvider1.Clear();
            DialogResult = DialogResult.OK;
            Elements.Variables.Add(ResultVariable);
            Close();
        }

        private void ButtonCnacel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TextBoxVariableName_TextChanged(object sender, EventArgs e)
        {
            if (!userQuestion)
                textBoxQuestion.Text = textBoxVariableName.Text + "?";
        }

        private void TextBoxQuestion_MouseClick(object sender, MouseEventArgs e)
        {
            userQuestion = true;
        }
    }
}
