using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShellForKnowledgeBase
{
    public partial class MainForm : Form
    {
        string filePath = string.Empty;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public MainForm()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewRules.Rows.Clear();
            dataGridViewVariables.Rows.Clear();
            dataGridViewDomains.Rows.Clear();
            Elements.Rules.Clear();
            Elements.Variables.Clear();
            Elements.Domains.Clear();
            filePath = string.Empty;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jss files (*.jss)|*.jss";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                FileManager.Open(filePath);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "jss files (*.jss)|*.jss";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                FileManager.Save(filePath);
            }

        }

        private void TabPageRules_Enter(object sender, EventArgs e)
        {
            dataGridViewRules.Rows.Clear();

            foreach(var rule in Elements.Rules)
            {
                var rowIndex = dataGridViewRules.Rows.Add(rule.Name, RuleDecorator.GetRuleDescription(rule));
                dataGridViewRules.Rows[rowIndex].Tag = rule;
            }
        }

        private void DataGridViewRules_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRules.SelectedRows.Count == 0)
                return;

            var rule = dataGridViewRules.SelectedRows[0].Tag as Rule;

            if (rule == null)
                return;

            listBoxParcels.Items.Clear();
            listBoxConclusions.Items.Clear();

            foreach (var parcel in rule.Parcels)
                listBoxParcels.Items.Add(parcel);
            foreach (var conclusion in rule.Conclusions)
                listBoxConclusions.Items.Add(conclusion);
            textBoxRuleClarification.Text = rule.Clarification;
        }

        private void ButtonRulesDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRules.SelectedRows.Count == 0)
                return;

            dataGridViewRules.Rows.Remove(dataGridViewRules.SelectedRows[0]);
        }

        private void ButtonRulesChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewRules.SelectedRows.Count == 0)
                return;

            var form = new FormChangeRule(dataGridViewRules.SelectedRows[0].Tag as Rule);
            var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                dataGridViewRules.SelectedRows[0].Tag = form.ReturnRule;
                dataGridViewRules.SelectedRows[0].Cells[0].Value = form.ReturnRule.Name;
                dataGridViewRules.SelectedRows[0].Cells[1].Value = RuleDecorator.GetRuleDescription(form.ReturnRule);
            }
        }

        private void ButtonRulesAdd_Click(object sender, EventArgs e)
        {
            var form = new FormChangeRule();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var row = new DataGridViewRow();
                if (dataGridViewRules.SelectedRows.Count == 0)
                {
                    var rowIndex = dataGridViewRules.Rows.Add(form.ReturnRule.Name, RuleDecorator.GetRuleDescription(form.ReturnRule));
                    dataGridViewRules.Rows[rowIndex].Tag = form.ReturnRule;
                }
                else
                {
                    var index = dataGridViewRules.SelectedRows[0].Index + 1;
                    dataGridViewRules.Rows.Insert(index, form.ReturnRule.Name, RuleDecorator.GetRuleDescription(form.ReturnRule));
                    dataGridViewRules.Rows[index].Tag = form.ReturnRule;
                }
            }
        }

        private void TabPageVariables_Enter(object sender, EventArgs e)
        {
            dataGridViewVariables.Rows.Clear();

            foreach (var variable in Elements.Variables)
            {
                var rowIndex = dataGridViewVariables.Rows.Add(variable.Name, variable.Type, variable.Domain.Name);
                dataGridViewVariables.Rows[rowIndex].Tag = variable;
            }
        }

        private void ButtonVariablesAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCreateVarible();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var rowIndex = dataGridViewVariables.Rows.Add(form.ResultVariable.Name, form.ResultVariable.Type, form.ResultVariable.Domain.Name);
                dataGridViewVariables.Rows[rowIndex].Tag = form.ResultVariable;
            }
        }

        private void ButtonVariablesChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewVariables.SelectedRows.Count == 0)
                return;
            var form = new FormCreateVarible(dataGridViewVariables.SelectedRows[0].Tag as Variable);
            var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                dataGridViewVariables.SelectedRows[0].Tag = form.ResultVariable;
                dataGridViewVariables.SelectedRows[0].Cells[0].Value = form.ResultVariable.Name;
                dataGridViewVariables.SelectedRows[0].Cells[1].Value = form.ResultVariable.Type;
                dataGridViewVariables.SelectedRows[0].Cells[2].Value = form.ResultVariable.Domain.Name;
            }
        }

        private void ButtonVariablesDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVariables.SelectedRows.Count == 0)
                return;

            dataGridViewVariables.Rows.Remove(dataGridViewVariables.SelectedRows[0]);
        }

        private void DataGridViewVariables_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVariables.SelectedRows.Count == 0)
                return;

            var variable = dataGridViewVariables.SelectedRows[0].Tag as Variable;

            if (variable == null)
                return;

            textBoxQuestionText.Text = variable.Question;
        }

        private void TabPageDomains_Enter(object sender, EventArgs e)
        {
            dataGridViewDomains.Rows.Clear();

            foreach (var domain in Elements.Domains)
            {
                var rowIndex = dataGridViewDomains.Rows.Add(domain.Name);
                dataGridViewDomains.Rows[rowIndex].Tag = domain;
            }
        }

        private void ButtonDomainsAdd_Click(object sender, EventArgs e)
        {
            var form = new FormChangeDomain();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var rowIndex = dataGridViewDomains.Rows.Add(form.ReturnDomain.Name);
                dataGridViewDomains.Rows[rowIndex].Tag = form.ReturnDomain;
            }
        }

        private void ButtonDomainsChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewDomains.SelectedRows.Count == 0)
                return;
            var form = new FormChangeDomain(dataGridViewDomains.SelectedRows[0].Tag as Domain);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridViewDomains.SelectedRows[0].Tag = form.ReturnDomain;
                dataGridViewDomains.SelectedRows[0].Cells[0].Value = form.ReturnDomain.Name;
            }
        }

        private void ButtonDomainsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDomains.SelectedRows.Count == 0)
                return;

            dataGridViewDomains.Rows.Remove(dataGridViewDomains.SelectedRows[0]);
        }

        private void DataGridViewDomains_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDomains.SelectedRows.Count == 0)
                return;

            listBoxDomainValues.Items.Clear();

            var domain = dataGridViewDomains.SelectedRows[0].Tag as Domain;

            if (domain == null)
                return;

            foreach (var value in domain.Values)
                listBoxDomainValues.Items.Add(value);
        }

        private void DataGridViewRules_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGridViewRules.DoDragDrop(
                    dataGridViewRules.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void DataGridViewRules_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dataGridViewRules.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void DataGridViewRules_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DataGridViewRules_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGridViewRules.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dataGridViewRules.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;

                dataGridViewRules.Rows.RemoveAt(rowIndexFromMouseDown);

                var rule = Elements.Rules[rowIndexFromMouseDown];
                Elements.Rules.RemoveAt(rowIndexFromMouseDown);

                dataGridViewRules.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                Elements.Rules.Insert(rowIndexFromMouseDown, rule);
            }
        }

        private void КонсультацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormConsultation();
            form.ShowDialog();
        }
    }
}
