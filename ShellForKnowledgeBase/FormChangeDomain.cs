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
    public partial class FormChangeDomain : Form
    {
        public Domain ReturnDomain { get; set; }

        public FormChangeDomain()
        {
            InitializeComponent();
        }

        public FormChangeDomain(Domain domain)
        {
            InitializeComponent();
            ReturnDomain = domain;
            textBoxDomainName.Text = domain.Name;
            foreach (var value in domain.Values)
                listBoxDomainValues.Items.Add(value);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var domainName = textBoxDomainName.Text.Trim().ToLower();
            if (String.IsNullOrWhiteSpace(domainName))
            {
                errorProvider1.SetError(buttonOK, "Введено недопустимое название домена!");
                return;
            }
            if(Elements.CheckDomain(domainName, ReturnDomain))
            {
                errorProvider1.SetError(buttonOK, "Такое имя уже существет!");
                return;
            }
            if(listBoxDomainValues.Items.Count == 0)
            {
                errorProvider1.SetError(buttonOK, "У домена должно быть хотя бы одно значение!");
                return;
            }
            if (ReturnDomain == null)
                ReturnDomain = new Domain();
            ReturnDomain.Name = domainName;
            ReturnDomain.Values.Clear();
            foreach (var value in listBoxDomainValues.Items)
                ReturnDomain.AddValue((string)value);
            Elements.Domains.Add(ReturnDomain);
            DialogResult = DialogResult.OK;
            errorProvider1.Clear();
            Close();
        }

        private void ButtonCnacel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormChangeDomainValue())
            {
                form.Owner = this;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listBoxDomainValues.Items.Add(form.ReturnDomainValue);
                }
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (listBoxDomainValues.SelectedIndex != -1)
            {
                using (var form = new FormChangeDomainValue((string)listBoxDomainValues.Items[listBoxDomainValues.SelectedIndex]))
                {
                    form.Owner = this;
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        listBoxDomainValues.Items[listBoxDomainValues.SelectedIndex] = form.ReturnDomainValue;
                    }
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDomainValues.SelectedIndex != -1)
                listBoxDomainValues.Items.RemoveAt(listBoxDomainValues.SelectedIndex);
        }

        public bool CheckDomainValue(string value)
        {
            for (int i = 0; i < listBoxDomainValues.Items.Count; i++) 
                if ((string)listBoxDomainValues.Items[i] == value && i != listBoxDomainValues.SelectedIndex)
                    return true;
            return false;
        }
    }
}
