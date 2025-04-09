namespace ShadowsSaveFileEditor
{
    partial class Macros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Input1 = new System.Windows.Forms.RichTextBox();
            this.Input2 = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Replace = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.allinstances = new System.Windows.Forms.CheckBox();
            this.helplink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.ChangeRoot = new System.Windows.Forms.Button();
            this.rootlabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Input1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input1.DetectUrls = false;
            this.Input1.ForeColor = System.Drawing.Color.White;
            this.Input1.Location = new System.Drawing.Point(12, 44);
            this.Input1.Multiline = false;
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(268, 18);
            this.Input1.TabIndex = 0;
            this.Input1.TabStop = false;
            this.Input1.Text = "";
            // 
            // Input2
            // 
            this.Input2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Input2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input2.DetectUrls = false;
            this.Input2.ForeColor = System.Drawing.Color.White;
            this.Input2.Location = new System.Drawing.Point(12, 123);
            this.Input2.Multiline = false;
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(268, 18);
            this.Input2.TabIndex = 1;
            this.Input2.TabStop = false;
            this.Input2.Text = "";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.DetectUrls = false;
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(12, 195);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(268, 76);
            this.Output.TabIndex = 2;
            this.Output.TabStop = false;
            this.Output.Text = "";
            // 
            // Replace
            // 
            this.Replace.BackColor = System.Drawing.Color.Black;
            this.Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replace.ForeColor = System.Drawing.Color.White;
            this.Replace.Location = new System.Drawing.Point(333, 248);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 3;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = false;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // Find
            // 
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find.ForeColor = System.Drawing.Color.White;
            this.Find.Location = new System.Drawing.Point(333, 219);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 4;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // allinstances
            // 
            this.allinstances.AutoSize = true;
            this.allinstances.BackColor = System.Drawing.Color.Transparent;
            this.allinstances.ForeColor = System.Drawing.Color.White;
            this.allinstances.Location = new System.Drawing.Point(333, 196);
            this.allinstances.Name = "allinstances";
            this.allinstances.Size = new System.Drawing.Size(84, 17);
            this.allinstances.TabIndex = 6;
            this.allinstances.Text = "all instances";
            this.allinstances.UseVisualStyleBackColor = false;
            // 
            // helplink
            // 
            this.helplink.AutoSize = true;
            this.helplink.Location = new System.Drawing.Point(373, 44);
            this.helplink.Name = "helplink";
            this.helplink.Size = new System.Drawing.Size(35, 13);
            this.helplink.TabIndex = 7;
            this.helplink.TabStop = true;
            this.helplink.Text = "HELP";
            this.helplink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.helplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helplink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find (what) / Replace (what) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Replace (with) :";
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.ForeColor = System.Drawing.Color.White;
            this.outputlabel.Location = new System.Drawing.Point(8, 158);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(71, 20);
            this.outputlabel.TabIndex = 10;
            this.outputlabel.Text = "output :";
            // 
            // ChangeRoot
            // 
            this.ChangeRoot.BackColor = System.Drawing.Color.Black;
            this.ChangeRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeRoot.ForeColor = System.Drawing.Color.White;
            this.ChangeRoot.Location = new System.Drawing.Point(333, 13);
            this.ChangeRoot.Name = "ChangeRoot";
            this.ChangeRoot.Size = new System.Drawing.Size(75, 23);
            this.ChangeRoot.TabIndex = 11;
            this.ChangeRoot.Text = "Change root";
            this.ChangeRoot.UseVisualStyleBackColor = false;
            this.ChangeRoot.Click += new System.EventHandler(this.ChangeRoot_Click);
            // 
            // rootlabel
            // 
            this.rootlabel.AutoSize = true;
            this.rootlabel.BackColor = System.Drawing.Color.Transparent;
            this.rootlabel.ForeColor = System.Drawing.Color.White;
            this.rootlabel.Location = new System.Drawing.Point(9, 178);
            this.rootlabel.Name = "rootlabel";
            this.rootlabel.Size = new System.Drawing.Size(35, 13);
            this.rootlabel.TabIndex = 12;
            this.rootlabel.Text = "label3";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.Transparent;
            this.toolTip1.ForeColor = System.Drawing.Color.IndianRed;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Path";
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // Macros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(420, 283);
            this.Controls.Add(this.rootlabel);
            this.Controls.Add(this.ChangeRoot);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helplink);
            this.Controls.Add(this.allinstances);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Macros";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Macros";
            this.Load += new System.EventHandler(this.Macros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input1;
        private System.Windows.Forms.RichTextBox Input2;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.CheckBox allinstances;
        private System.Windows.Forms.LinkLabel helplink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button ChangeRoot;
        private System.Windows.Forms.Label rootlabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}