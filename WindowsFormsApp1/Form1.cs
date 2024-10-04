using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isSelecting = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isSelecting)
            {
                isSelecting = false;
                int selectedStart = textBox1.SelectionStart;
                int selectedLength = textBox1.SelectionLength;

                if (selectedLength > 0)
                {

                    ban_ro.SelectionStart = selectedStart;
                    ban_ro.SelectionLength = selectedLength;

                    ban_ro.Focus();
                }
            }
        }

        private void btn_giai_ma_Click(object sender, EventArgs e)
        {
            var replacements = new Dictionary<char, char>();
            var usedReplacements = new HashSet<char>();
            var invalidEntries = new List<string>();

            foreach (DataGridViewRow row in dataGr1.Rows)
            {
                if (row.Cells["Chữ"].Value != null && row.Cells["Thay"].Value != null)
                {
                    string originalValue = row.Cells["Chữ"].Value.ToString().ToUpper();
                    string replacementValue = row.Cells["Thay"].Value.ToString().ToUpper();

                    if (originalValue.Length == 1 && replacementValue.Length == 1)
                    {
                        char original = originalValue[0];
                        char replacement = replacementValue[0];

                        if (char.IsLetter(original) && char.IsLetter(replacement))
                        {
                            if (replacements.ContainsKey(original))
                            {
                                invalidEntries.Add($"Lặp từ '{original}'");
                            }
                            else if (usedReplacements.Contains(replacement))
                            {
                                invalidEntries.Add($"Từ '{replacement}' đã được sử dụng.");
                            }
                            else
                            {
                                replacements[original] = replacement;
                                usedReplacements.Add(replacement);
                            }
                        }
                        else
                        {
                            invalidEntries.Add($"Lỗi kí tự: '{originalValue}' -> '{replacementValue}'");
                        }
                    }
                    else
                    {
                        invalidEntries.Add($"Lỗi kí tự: '{originalValue}' -> '{replacementValue}'");
                    }
                }
            }

            if (invalidEntries.Count > 0)
            {
                MessageBox.Show(string.Join("\n", invalidEntries), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var inputText = textBox1.Text.ToUpper();
            var outputText = new StringBuilder();

            foreach (char c in inputText)
            {
                if (replacements.ContainsKey(c))
                {
                    outputText.Append(replacements[c]);
                }
                else
                {
                    outputText.Append(" ");
                }
            }

            ban_ro.Text = outputText.ToString();
        }

        private void dataGr1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thong_ke_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToUpper();
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            Dictionary<string, int> digramCount = new Dictionary<string, int>();
            Dictionary<string, int> trigramCount = new Dictionary<string, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (letterCount.ContainsKey(c))
                    {
                        letterCount[c]++;
                    }
                    else
                    {
                        letterCount[c] = 1;
                    }
                }
            }

            //digram
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsLetter(input[i]) && char.IsLetter(input[i + 1]))
                {
                    string digram = $"{input[i]}{input[i + 1]}";
                    if (digramCount.ContainsKey(digram))
                    {
                        digramCount[digram]++;
                    }
                    else
                    {
                        digramCount[digram] = 1;
                    }
                }
            }

            //trigram
            for (int i = 0; i < input.Length - 2; i++)
            {
                if (char.IsLetter(input[i]) && char.IsLetter(input[i + 1]) && char.IsLetter(input[i + 2]))
                {
                    string trigram = $"{input[i]}{input[i + 1]}{input[i + 2]}";
                    if (trigramCount.ContainsKey(trigram))
                    {
                        trigramCount[trigram]++;
                    }
                    else
                    {
                        trigramCount[trigram] = 1;
                    }
                }
            }

            dataGr1.Rows.Clear();
            var sortedletterCount = letterCount.OrderByDescending(entry => entry.Value);
            foreach (KeyValuePair<char, int> entry in sortedletterCount)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Key });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Value });
                row.Cells.Add(new DataGridViewTextBoxCell());
                dataGr1.Rows.Add(row);
            }

            dataGr2.Rows.Clear();
            var sorteddigramCount = digramCount.OrderByDescending(entry => entry.Value);
            foreach (KeyValuePair<string, int> entry in sorteddigramCount)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Key });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Value });
                dataGr2.Rows.Add(row);
            }

            dataGr3.Rows.Clear();
            var sortedtrigramCount = trigramCount.OrderByDescending(entry => entry.Value);
            foreach (KeyValuePair<string, int> entry in sortedtrigramCount)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Key });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Value });
                dataGr3.Rows.Add(row);
            }
        }

        private void ban_ro_TextChanged(object sender, EventArgs e)
        {
            // Get the current selection in the decrypted text box
            int selectedStart = ban_ro.SelectionStart;
            int selectedLength = ban_ro.SelectionLength;

            // Update the selection in the original text box based on the selection in ban_ro
            textBox1.SelectionStart = selectedStart;
            textBox1.SelectionLength = selectedLength;
        }

        //
        private void ban_ro_SelectionChanged(object sender, EventArgs e)
        {
            // Get the current selection in the decrypted text box
            int selectedStart = ban_ro.SelectionStart;
            int selectedLength = ban_ro.SelectionLength;

            // Update the selection in the original text box based on the selection in ban_ro
            textBox1.SelectionStart = selectedStart;
            textBox1.SelectionLength = selectedLength;
        }

    }
}
