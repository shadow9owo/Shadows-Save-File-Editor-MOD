﻿using Newtonsoft.Json;
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
            foreach (var item in UnityUtils.getobjects())
            {
                if (File.ReadAllText(item).Contains(Input1.Text) && !allinstances.Checked)
                {
                    Output.Text = Output.Text + item;
                    return;
                }else if (File.ReadAllText(item).Contains(Input1.Text) && allinstances.Checked)
                {
                    Output.Text = Output.Text + item;
                }
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            Output.Text = "replacing...";
            DialogResult a = MessageBox.Show("WARNING THIS IS AN UNSAFE FUNCTION\n\nif used incorrecly this function may corrupt your save file!!!\n\nare you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Output.Text = Output.Text + "action cancelled.";
            if (a == DialogResult.Yes)
            {

            }
            else
            {
                return;
            }
            foreach (var item in UnityUtils.getobjects())
            {
                if (File.ReadAllText(item).Contains(Input1.Text) && !allinstances.Checked)
                {
                    Output.Text = Output.Text + item;
                    File.WriteAllText(item, File.ReadAllText(item).Replace(Input1.Text, Input2.Text));
                    return;
                }
                else if (File.ReadAllText(item).Contains(Input1.Text) && allinstances.Checked)
                {
                    File.WriteAllText(item,File.ReadAllText(item).Replace(Input1.Text, Input2.Text));
                    Output.Text = Output.Text + item;
                }
            }
        }
    }
}
