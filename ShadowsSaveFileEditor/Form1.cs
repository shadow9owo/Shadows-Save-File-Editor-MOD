using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using Newtonsoft.Json;

namespace ShadowsSaveFileEditor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #if DEBUG
                        MessageBox.Show("!!! THIS IS THE DEBUG BRANCH !!!\nthis might affect performance (not significantly)","dev note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            #endif

            if (!Directory.Exists(UnityUtils.getpersistantpath()))
            {
                MessageBox.Show($"fatal error path {UnityUtils.getpersistantpath()} does not exist");
                UnityUtils.exit();
            }
            UpdateUI();
        }

        private void highlightjson()
        {
            int start = CodeEditor.SelectionStart;

            CodeEditor.SelectAll();
            CodeEditor.SelectionColor = CodeEditor.ForeColor;

            string strpattern = @"(['""])(.*?)\1";
            string numpattern = @"\b\d+(\.\d+)?\b";
            string boolpattern = @"\b(true|false)\b";

            MatchCollection strmatches = Regex.Matches(CodeEditor.Text, strpattern);
            foreach (Match match in strmatches)
            {
                int starti = match.Index;
                int len = match.Length;
                CodeEditor.Select(starti, len);
                CodeEditor.SelectionColor = Color.Green;
            }

            MatchCollection numbermatch = Regex.Matches(CodeEditor.Text, numpattern);
            foreach (Match match in numbermatch)
            {
                int starti = match.Index;
                int len = match.Length;
                CodeEditor.Select(starti, len);
                CodeEditor.SelectionColor = Color.Red;
            }

            MatchCollection boolmatch = Regex.Matches(CodeEditor.Text, boolpattern);
            foreach (Match match in boolmatch)
            {
                int starti = match.Index;
                int len = match.Length;
                CodeEditor.Select(starti, len);
                CodeEditor.SelectionColor = Color.Purple;
            }

            CodeEditor.Select(start, 0);
        }


        private void UpdateEditorUI()
        {
            string a = "";
            foreach (var item in File.ReadAllLines(Data.openedfilepath))
            {
                a = a + item + "\n";
            }
            CodeEditor.Text = a;
        }

        private void UpdateUI()
        {
            ObjectCount.Text = $"{UnityUtils.getobjects().Count} Objects found";
        }

        private void UpdateUIBTN_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try 
            { 
                var obj = JsonConvert.DeserializeObject(CodeEditor.Text); 
            } 
            catch 
            {
                DialogResult a = MessageBox.Show("The Changes applied are invalid the save file if saved wont most likely work correctly.\nAre you sure you want to save?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {

                }else
                {
                    return;
                }
            }
            Data.edited = false;
            Data.keysclicked = 0;
            File.Move(Data.openedfilepath, Data.openedfilepath + ".bak");
            File.WriteAllLines(Data.openedfilepath, CodeEditor.Text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.None));
        }

        private void credits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("created by shadowdev\nshadow9owo@github\nshadowdevhere@steam","credits",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void OpenObject_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (Directory.Exists(UnityUtils.getpersistantpath()))
            {
                dialog.InitialDirectory = UnityUtils.getpersistantpath();
            }
            else
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
            }

            dialog.Title = "Choose an object file to edit";
            dialog.Filter = "All files (*.json)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Data.openedfilepath = dialog.FileName;
                UpdateEditorUI();
                UpdateUI();
                highlightjson();
                Data.edited = false;
            }
        }

        private void CodeEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult a = MessageBox.Show("Are you sure you want to exit the file without saving?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {

                }
                else
                {
                    SaveChanges_Click(sender,e);
                    return;
                }

                Data.keysclicked = 0;
                CodeEditor.Text = "";
                Data.openedfilepath = "";
                
                return;
            }
            if (Data.keysclicked < 10)
            {
                Data.edited = true;
                Data.keysclicked = Data.keysclicked + 1;
                return;
            }else
            {
                Data.keysclicked = 0;
            }
            highlightjson();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Data.edited)
            {
                DialogResult a = MessageBox.Show("You havent saved are you sure you want to quit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
