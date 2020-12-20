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
    public partial class FormAddFact : Form
    {
        public Fact ReturnFact { get; set; }

        public FormAddFact(bool parcel)
        {
            InitializeComponent();

            comboBoxVariable.Items.Clear();
            if(parcel)
            {
                foreach (var variable in Elements.Variables)
                    comboBoxVariable.Items.Add(variable);
            }
            else
            {
                foreach (var variable in Elements.Variables)
                    if(variable.Type == Variable.VariableType.Deduce)
                        comboBoxVariable.Items.Add(variable);
            }
        }

        public FormAddFact(Fact fact, bool parcel)
        {
            InitializeComponent();
            ReturnFact = fact;

            comboBoxVariable.Items.Clear();
            if(parcel)
            {
                foreach (var variable in Elements.Variables)
                    comboBoxVariable.Items.Add(variable);
            }
            else
            {
                foreach (var variable in Elements.Variables)
                    if(variable.Type == Variable.VariableType.Deduce)
                        comboBoxVariable.Items.Add(variable);
            }
            comboBoxVariable.SelectedItem = fact.Variable;

            comboBoxValue.Items.Clear();
            foreach (var value in fact.Variable.Domain.Values)
                comboBoxValue.Items.Add(value);
            comboBoxValue.SelectedItem = fact.Value;

            if (fact.Relation.Value == Relation.Relations.Equally)
                radioButtonEqual.Checked = true;
            else
                radioButtonNotEqual.Checked = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(comboBoxVariable.SelectedIndex < 0)
            {
                errorProvider1.SetError(buttonOK, "Не выбрана переменная!");
                return;
            }
            if(comboBoxValue.SelectedIndex < 0)
            {
                errorProvider1.SetError(buttonOK, "Не выбрано значение переменной!");
                return;
            }
            if (ReturnFact == null)
            {
                ReturnFact = new Fact();
                ReturnFact.Relation = new Relation();
            }
            ReturnFact.Variable = comboBoxVariable.SelectedItem as Variable;
            if (radioButtonEqual.Checked)
                ReturnFact.Relation.Value = Relation.Relations.Equally;
            else
                ReturnFact.Relation.Value = Relation.Relations.NotEqual;
            ReturnFact.Value = (string)comboBoxValue.SelectedItem;
            errorProvider1.Clear();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCnacel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ComboBoxVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxValue.Items.Clear();
            if (comboBoxVariable.SelectedIndex == -1)
                return;
            foreach (var value in (comboBoxVariable.SelectedItem as Variable).Domain.Values)
                comboBoxValue.Items.Add(value);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using(var form = new FormCreateVarible())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    comboBoxVariable.Items.Add(form.ResultVariable);
                    comboBoxVariable.SelectedItem = form.ResultVariable;
                }
            }
        }
    }
}
