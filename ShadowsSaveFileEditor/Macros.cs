using System;
using System.IO;
using System.Windows.Forms;

namespace ShadowsSaveFileEditor
{
    public partial class Macros: Form
    {
        public Macros()
        {
            InitializeComponent();
        }

        private void helplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("find:\ninput text to find into the first inputfield\nand then click find.\n\nreplace:\ninput the text to replace into the first inputfield\nand input the text to replace it with into the second inputfield\nand then click replace\n\nmisc:\nthe all instances checkbox makes it so it applies changes (replaces or outputs it if find was pressed)\nto every instance that it can find", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Output.Text = "finding...";
            if (string.IsNullOrEmpty(Input1.Text))
            {
                Output.Text = Output.Text + "\naction cancelled.";
                return;
            }
            foreach (var item in UnityUtils.getobjects_usr())
            {
                if (File.ReadAllText(item).Contains(Input1.Text) && !allinstances.Checked)
                {
                    Output.Text = Output.Text + "\n" + item;
                    return;
                }else if (File.ReadAllText(item).Contains(Input1.Text) && allinstances.Checked)
                {
                    Output.Text = Output.Text + "\n" + item;
                }
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            Output.Text = "replacing...";
            DialogResult a = MessageBox.Show("WARNING THIS IS AN UNSAFE FUNCTION\n\nif used incorrecly this function may corrupt your save file!!!\n\nare you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes && !(string.IsNullOrEmpty(Input1.Text) || string.IsNullOrEmpty(Input2.Text)))
            {

            }
            else if ((string.IsNullOrEmpty(Input1.Text) || string.IsNullOrEmpty(Input2.Text)))
            {
                Output.Text = Output.Text + "\naction cancelled.";
                return;
            }else
            {
                Output.Text = Output.Text + "\naction cancelled.";
                return;
            }
            foreach (var item in UnityUtils.getobjects_usr())
            {
                if (File.ReadAllText(item).Contains(Input1.Text) && !allinstances.Checked)
                {
                    Output.Text = Output.Text + "\n" + item;
                    File.WriteAllText(item, File.ReadAllText(item).Replace(Input1.Text, Input2.Text));
                    return;
                }
                else if (File.ReadAllText(item).Contains(Input1.Text) && allinstances.Checked)
                {
                    File.WriteAllText(item, File.ReadAllText(item).Replace(Input1.Text, Input2.Text));
                    Output.Text = Output.Text + "\n" + item;
                }
            }
        }

        private void ChangeRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = UnityUtils.getpersistantpath();
            dialog.ShowNewFolderButton = false;
            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.SelectedPath))
            {
                return;
            }
            Data.userselectedroot = dialog.SelectedPath;
            rootlabel.Text = UnityUtils.captext("root variable: " + Data.userselectedroot,64);
            toolTip1.SetToolTip(rootlabel, Data.userselectedroot);
        }

        private void Macros_Load(object sender, EventArgs e)
        {
            rootlabel.Text = UnityUtils.captext("root variable: " + Data.userselectedroot,64);
            toolTip1.SetToolTip(rootlabel, Data.userselectedroot);
        }
    }
}
