using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intellisense
{

    public partial class Form1 : Form
    {
        public int i = 0;
        private int lastIndex=-1;
        private String selectedWord = "";
        private String clickedWord = "";
        private List<String> dictionary;
        string pattern="";
        bool sortedAscending = false;

        public Form1()
        {
            InitializeComponent();
            this.splitContainerButtons.SplitterDistance = (splitContainerButtons.Size.Width - splitContainerButtons.SplitterWidth) / 2;
            this.splitContainerButtons.TabIndex = 6;
            this.btnNewWord.Width = splitContainerButtons.SplitterDistance;
            this.btnSort.Width = splitContainerButtons.SplitterDistance;
            this.btnNewWord.Left = (splitContainerButtons.SplitterDistance - btnNewWord.Width) / 2;
            this.btnSort.Left = (splitContainerButtons.SplitterDistance - btnSort.Width) / 2;

            this.ActiveControl = richTextBox;

            dictionary = new List<string>();
            openFileDialog.Filter = "Text files (*.txt) | *.txt";
            openFileDialog.RestoreDirectory = true;

            saveFileDialog.Filter = "txt files (*.txt) | *.txt";
            saveFileDialog.RestoreDirectory = true;

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
                this.changeFontTool.Items.Add(font.Name);
            this.changeFontTool.Text = "Calibri";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadDictionaryFromFile(openFileDialog.FileName);
            }
        }

        private void loadDictionaryFromFile(String path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line;
                    dictionaryBox.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        bool validWord = true;
                        for (int i = 0; i < line.Length; i++)
                            if (!char.IsLetter(line[i]))
                            {
                                validWord = false;
                                break;
                            }
                        if (validWord)
                            dictionaryBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during opening file:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = richTextBox.SelectionStart;
            char c = '0';
            if(index>0 && index>lastIndex)
                c = richTextBox.Text[index - 1];
            if ((c>='a'&&c<='z')||(c>='A'&&c<='Z'))
            {
                if (dictionaryBox.Items.Count > 0)
                {
                    if (char.IsUpper(c))
                        c = char.ToLower(c);
                    pattern += c;
                    listBox.Items.Clear();
                    bool fits;
                    
                    foreach (String s in dictionaryBox.Items)
                    {
                        fits = true;
                        if (pattern.Length > s.Length)
                            fits = false;
                        else
                            for(int i=0; i < pattern.Length; i++)
                                if(s[i]!=pattern[i])
                                {
                                    fits = false;
                                    break;
                                }
                        if (fits)
                        {
                            listBox.Items.Add(s);
                            if (selectedWord == s)
                                listBox.SelectedIndex = listBox.Items.Count - 1;
                        }
                    }
                    if (listBox.Items.Count > 0)
                    {
                        Point p = richTextBox.GetPositionFromCharIndex(index);
                        //p.X -= (int)richTextBox.Font.Size;
                        p.Y += 2*(int)richTextBox.Font.Size;
                        listBox.Location = p;
                        if (listBox.Items.Count > 0 && listBox.SelectedIndex < 0)
                        {
                            listBox.SelectedIndex = 0;
                            var iter = listBox.Items.GetEnumerator();
                            iter.MoveNext();
                            selectedWord = (String)iter.Current;
                        }
                        
                        listBox.Show();
                    }
                    else
                        hideDictionary();
                }
            }
            else
            {
                hideDictionary();
            }
        }

        private void hideDictionary()
        {
            listBox.Hide();
            lastIndex = -1;
            pattern = "";
            selectedWord = "";
        }

        private void completeWord()
        {
            string left = selectedWord.Substring(pattern.Length);
            int index = richTextBox.SelectionStart;
            richTextBox.Text = richTextBox.Text.Insert(richTextBox.SelectionStart, left);
            richTextBox.SelectionStart = index + left.Length;
        }

        private void richTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastIndex = richTextBox.SelectionStart;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (listBox.Items.Count > 0)
                    {
                        if(listBox.SelectedIndex < listBox.Items.Count - 1)
                            listBox.SelectedIndex++;
                        int i = 0;
                        foreach (String s in listBox.Items)
                            if (listBox.SelectedIndex == i++)
                            {
                                selectedWord = s;
                                break;
                            }
                    }
 
                    break;
                case Keys.Up:
                    if (listBox.Items.Count > 0)
                    {
                        if (listBox.SelectedIndex > 0)
                            listBox.SelectedIndex--;
                        int i = 0;
                        foreach (String s in listBox.Items)
                            if (listBox.SelectedIndex == i++)
                            {
                                selectedWord = s;
                                break;
                            }
                    }
                    break;
                case Keys.Right:
                    hideDictionary();
                    break;
                case Keys.Left:
                    hideDictionary();
                    break;
                case Keys.Tab:
                    completeWord();
                    break;
            }
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainerButtons.SplitterDistance = (splitContainerButtons.Size.Width - splitContainerButtons.SplitterWidth)/ 2;
            btnNewWord.Width = splitContainerButtons.SplitterDistance;
            btnSort.Width = splitContainerButtons.SplitterDistance;
            btnNewWord.Left = (splitContainerButtons.SplitterDistance - btnNewWord.Width) / 2;
            btnSort.Left = (splitContainerButtons.SplitterDistance - btnSort.Width) / 2;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            AddWordForm addWord = new AddWordForm();
            addWord.ShowDialog(this);
            String word = addWord.Word;
            addWord.Dispose();
            if(!dictionaryBox.Items.Contains(word))
                dictionaryBox.Items.Add(word);
        }

        private void dictionaryBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                var indexes = dictionaryBox.SelectedIndices;
                if(indexes!=null)
                {
                    List<String> tmpList = new List<String>();
                    int i = 0;
                    var iter = indexes.GetEnumerator();
                    if(iter.MoveNext())
                    {
                        int currIndex = (int)iter.Current;
                        foreach (String s in dictionaryBox.Items)
                        {
                            if (i != currIndex)
                                tmpList.Add(s);
                            else if (iter.MoveNext())
                                currIndex = (int)iter.Current;
                            else
                                currIndex = -1;
                            i++;
                        }
                        dictionaryBox.Items.Clear();
                        foreach (String s in tmpList)
                            dictionaryBox.Items.Add(s);
                    }
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortedSet<String> tmpSet = new SortedSet<String>();
            foreach (String s in dictionaryBox.Items)
                tmpSet.Add(s);
            IEnumerable<String> sortedDict = tmpSet;
            if (sortedAscending)
            {
                sortedDict = tmpSet.Reverse();
                sortedAscending = false;
            }
            else
                sortedAscending = true;

            dictionaryBox.Items.Clear();
            foreach (String s in sortedDict)
                dictionaryBox.Items.Add(s);
        }

        private void richTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = richTextBox.GetCharIndexFromPosition(e.Location);
                int start, end;
                if(richTextBox.Text.Length>0 && index>=0)
                {
                    for (start = index; start > 0; start--)
                        if (richTextBox.Text[start] == ' ')
                        {
                            start++;
                            break;
                        }
                    for (end = index; end < richTextBox.Text.Length; end++)
                        if (richTextBox.Text[end] == ' ')
                        {
                            end--;
                            break;
                        }
                    if (end > start)
                    {
                        //this.Text = start.ToString() + " " + end.ToString();
                        clickedWord = richTextBox.Text.Substring(start, end - start);
                        if(dictionaryBox.Items.Contains(clickedWord))
                        {
                            deleteWordMenu.Items.Clear();
                            deleteWordToolStripMenuItem.Text = "Remove " + clickedWord;
                            deleteWordMenu.Items.Add(deleteWordToolStripMenuItem);
                            deleteWordMenu.Show(richTextBox, e.Location);
                        }
                        else
                        {
                            addWordMenu.Items.Clear();
                            addWordToolStripMenuItem.Text = "Add " + clickedWord;
                            addWordMenu.Items.Add(addWordToolStripMenuItem);
                            addWordMenu.Show(richTextBox, e.Location);
                        }
                    }
                }
            }
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWordForm addWord = new AddWordForm();
            addWord.Word = clickedWord;
            addWord.ShowDialog(this);
            String word = addWord.Word;
            addWord.Dispose();
            if (!dictionaryBox.Items.Contains(word))
                dictionaryBox.Items.Add(word);
        }

        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dictionaryBox.Items.Remove(clickedWord);
            listBox.Items.Remove(clickedWord);
            if (listBox.Items.Count == 0)
                listBox.Hide();
        }

        private void btnToolBold_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox.Font.Style;
            style ^= FontStyle.Bold;
            richTextBox.Font = new Font(richTextBox.Font, style);
        }

        private void btnToolItalic_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox.Font.Style;
            style ^= FontStyle.Italic;
            richTextBox.Font = new Font(richTextBox.Font, style);
        }

        private void btnToolUnderline_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox.Font.Style;
            style ^= FontStyle.Underline;
            richTextBox.Font = new Font(richTextBox.Font, style);
        }

        private void btnToolFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ForeColor = colorDialog.Color;
            }
        }

        private void btnToolBgColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.BackColor = colorDialog.Color;
            }
        }

        private void changeFontTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Text = (i++).ToString();
            var style = richTextBox.Font.Style & (FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            richTextBox.Font = new Font(changeFontTool.Text, 12, style);
        }

        private void dictionaryBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            loadDictionaryFromFile(file[0]);
        }

        private void dictionaryBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (((String[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".txt"))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(saveFileDialog.FileName.ToString());
                    foreach (String word in dictionaryBox.Items)
                        file.WriteLine(word);
                    file.Close();
                }
        }
    }
}
