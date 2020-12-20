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
    public partial class FormChangeRule : Form
    {
        public Rule ReturnRule { get; set; }

        public FormChangeRule()
        {
            InitializeComponent();
        }

        public FormChangeRule(Rule rule)
        {
            InitializeComponent();
            ReturnRule = rule;
            textBoxRuleName.Text = rule.Name;
            foreach (var parcel in rule.Parcels)
                listBoxParcel.Items.Add(parcel);
            foreach (var conclusion in rule.Conclusions)
                listBoxConclusion.Items.Add(conclusion);
            textBoxClarification.Text = rule.Clarification;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var ruleName = textBoxRuleName.Text.Trim().ToLower();
            if(String.IsNullOrWhiteSpace(ruleName))
            {
                errorProvider1.SetError(buttonOK, "Неверное имя правила!");
                return;
            }
            if(Elements.CheckRuleName(ruleName, ReturnRule))
            {
                errorProvider1.SetError(buttonOK, "Такое имя правила уже занято!");
                return;
            }
            if(listBoxParcel.Items.Count == 0)
            {
                errorProvider1.SetError(buttonOK, "Введите хотя бы одну посылку!");
                return;
            }
            if(listBoxConclusion.Items.Count == 0)
            {
                errorProvider1.SetError(buttonOK, "Введите хотя бы одно заключение!");
                return;
            }
            if (ReturnRule == null)
            {
                ReturnRule = new Rule();
                Elements.Rules.Add(ReturnRule);
            }
            ReturnRule.Name = ruleName;
            ReturnRule.Parcels.Clear();
            foreach (var parcel in listBoxParcel.Items)
                ReturnRule.AddParcel(parcel as Fact);
            ReturnRule.Conclusions.Clear();
            foreach (var conclusion in listBoxConclusion.Items)
                ReturnRule.AddConclusion(conclusion as Fact);
            ReturnRule.Clarification = textBoxClarification.Text;
            errorProvider1.Clear();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCnacel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonParcelAdd_Click(object sender, EventArgs e)
        {
            using(var form = new FormAddFact(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listBoxParcel.Items.Add(form.ReturnFact);
                }
            }
        }

        private void ButtonConclusionAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddFact(false))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    listBoxConclusion.Items.Add(form.ReturnFact);
                }
            }
        }

        private void ButtonParcelDelete_Click(object sender, EventArgs e)
        {
            if (listBoxParcel.SelectedIndex < 0)
                return;
            listBoxParcel.Items.RemoveAt(listBoxParcel.SelectedIndex);
        }

        private void ButtonConclusionDelete_Click(object sender, EventArgs e)
        {
            if (listBoxConclusion.SelectedIndex < 0)
                return;
            listBoxConclusion.Items.RemoveAt(listBoxConclusion.SelectedIndex);
        }

        private void ButtonParcelChange_Click(object sender, EventArgs e)
        {
            if (listBoxParcel.SelectedIndex < 0)
                return;
            using (var form = new FormAddFact(listBoxParcel.SelectedItem as Fact, true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var index = listBoxParcel.SelectedIndex;
                    listBoxParcel.Items.RemoveAt(index);
                    listBoxParcel.Items.Insert(index, form.ReturnFact);
                }
            }
        }

        private void ButtonConclusionChange_Click(object sender, EventArgs e)
        {
            if (listBoxConclusion.SelectedIndex < 0)
                return;
            using (var form = new FormAddFact(listBoxConclusion.SelectedItem as Fact, false))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var index = listBoxConclusion.SelectedIndex;
                    listBoxConclusion.Items.RemoveAt(index);
                    listBoxConclusion.Items.Insert(index, form.ReturnFact);
                }
            }
        }
    }
}
