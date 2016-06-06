using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EncodingConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            encodingSelector.Items.AddRange(Program.encodingNames);
            encodingSelector.SelectedIndex=0;

            lineEndingSelector.Items.Add("Не преобразовывать");
            lineEndingSelector.Items.Add(Program.lineEndingNames[0]);
            lineEndingSelector.Items.Add(Program.lineEndingNames[1]);
            lineEndingSelector.Items.Add(Program.lineEndingNames[2]);
            lineEndingSelector.SelectedIndex=0;

            convertBtn.Enabled = false;
            analyzeBtn.Enabled = Directory.Exists(pathTextBox.Text.Trim());
            Form1_Resize(this, null);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(this);
            pathTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            convertBtn.Enabled = false;
            analyzeBtn.Enabled = Directory.Exists(pathTextBox.Text.Trim());
        }

        private void analyzeBtn_Click(object sender, EventArgs e)
        {
            resultListView.Items.Clear();
            resultListView.Columns[3].Text="Действие";
            commands = Program.RunAnalyzeProcess(pathTextBox.Text, filterTextBox.Text, subdirCheck.Checked,
                Program.GetEncodingByName(encodingSelector.Text), Program.GetLineEndingByName(lineEndingSelector.Text), AddToActionList);
            convertBtn.Enabled = true;
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            resultListView.Items.Clear();
            resultListView.Columns[3].Text="Результат";
            Program.RunConvertProcess(commands, AddToResultList);
            commands = null;
            convertBtn.Enabled = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resultListView.Width = Size.Width - resultListView.Location.X - 24;
            resultListView.Height = analyzeBtn.Location.Y - resultListView.Location.Y - 12;
            pathTextBox.Width = Size.Width - pathTextBox.Location.X - 96;
            filterTextBox.Width = subdirCheck.Location.X-filterTextBox.Location.X-12;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            convertBtn.Enabled = false;
        }

        private void subdirCheck_CheckedChanged(object sender, EventArgs e)
        {
            convertBtn.Enabled = false;
        }

        private void lineEndingSelector_Changed(object sender, EventArgs e)
        {
            convertBtn.Enabled = false;
        }

        private void encodingSelector_Changed(object sender, EventArgs e)
        {
            convertBtn.Enabled = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, Program.AboutProgram,
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddToActionList(string filename, string oldEncodingName, string oldLineEndingName, ConvertResult action)
        {
            string actionStr = "Convert";
            if(action!=ConvertResult.OK) actionStr = action.ToString();
            resultListView.Items.Add(new ListViewItem(new string[] { filename, oldEncodingName, oldLineEndingName, actionStr}));
        }

        public void AddToResultList(ConvertCommand cmd, ConvertResult result)
        {
            string encodingName = "Unchanged";
            string lineEndingName = "Unchanged";
            if(result==ConvertResult.OK)
            {
                encodingName = Program.GetEncodingName(cmd.newEncoding);
                lineEndingName = Program.GetLineEndingName(cmd.newLineEnding);
            }
            resultListView.Items.Add(new ListViewItem(new string[] {
                cmd.path, encodingName, lineEndingName, result.ToString()}));
        }

        List<ConvertCommand> commands;

    }
}
