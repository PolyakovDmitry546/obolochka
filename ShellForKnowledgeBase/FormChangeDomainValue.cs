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
    public partial class FormChangeDomainValue : Form
    {
        public string ReturnDomainValue { get; set; }

        public FormChangeDomainValue()
        {
            InitializeComponent();
        }

        public FormChangeDomainValue(string value)
        {
            InitializeComponent();
            ReturnDomainValue = value;
            textBoxValue.Text = ReturnDomainValue;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var newValue = textBoxValue.Text.Trim().ToLower();
            if(String.IsNullOrWhiteSpace(newValue))
            {
                errorProvider1.SetError(buttonOK, "Значение не указано!");
                return;
            }
            FormChangeDomain form = Owner as FormChangeDomain;
            if(!form.CheckDomainValue(newValue))
            {
                ReturnDomainValue = newValue;
                errorProvider1.Clear();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                errorProvider1.SetError(buttonOK, "Такое значение уже существует!");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
