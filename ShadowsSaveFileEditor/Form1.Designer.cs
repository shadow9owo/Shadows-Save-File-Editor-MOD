namespace ShadowsSaveFileEditor
{
    partial class Form1
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
            this.ObjectCount = new System.Windows.Forms.Label();
            this.UpdateUIBTN = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.LinkLabel();
            this.OpenObject = new System.Windows.Forms.Button();
            this.CodeEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ObjectCount
            // 
            this.ObjectCount.AutoSize = true;
            this.ObjectCount.BackColor = System.Drawing.Color.Transparent;
            this.ObjectCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectCount.ForeColor = System.Drawing.Color.White;
            this.ObjectCount.Location = new System.Drawing.Point(12, 520);
            this.ObjectCount.Name = "ObjectCount";
            this.ObjectCount.Size = new System.Drawing.Size(73, 28);
            this.ObjectCount.TabIndex = 0;
            this.ObjectCount.Text = "label1";
            // 
            // UpdateUIBTN
            // 
            this.UpdateUIBTN.BackColor = System.Drawing.Color.Black;
            this.UpdateUIBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateUIBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUIBTN.ForeColor = System.Drawing.Color.White;
            this.UpdateUIBTN.Location = new System.Drawing.Point(797, 526);
            this.UpdateUIBTN.Name = "UpdateUIBTN";
            this.UpdateUIBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateUIBTN.TabIndex = 1;
            this.UpdateUIBTN.TabStop = false;
            this.UpdateUIBTN.Text = "UpdateUI";
            this.UpdateUIBTN.UseVisualStyleBackColor = false;
            this.UpdateUIBTN.Click += new System.EventHandler(this.UpdateUIBTN_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.Black;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(689, 526);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(102, 23);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.TabStop = false;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // credits
            // 
            this.credits.ActiveLinkColor = System.Drawing.Color.Blue;
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(537, 536);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(38, 13);
            this.credits.TabIndex = 3;
            this.credits.TabStop = true;
            this.credits.Text = "credits";
            this.credits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credits_LinkClicked);
            // 
            // OpenObject
            // 
            this.OpenObject.BackColor = System.Drawing.Color.Black;
            this.OpenObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenObject.ForeColor = System.Drawing.Color.White;
            this.OpenObject.Location = new System.Drawing.Point(581, 526);
            this.OpenObject.Name = "OpenObject";
            this.OpenObject.Size = new System.Drawing.Size(102, 23);
            this.OpenObject.TabIndex = 4;
            this.OpenObject.TabStop = false;
            this.OpenObject.Text = "Open Object";
            this.OpenObject.UseVisualStyleBackColor = false;
            this.OpenObject.Click += new System.EventHandler(this.OpenObject_Click);
            // 
            // CodeEditor
            // 
            this.CodeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.CodeEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeEditor.ForeColor = System.Drawing.Color.White;
            this.CodeEditor.Location = new System.Drawing.Point(8, 10);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Size = new System.Drawing.Size(863, 498);
            this.CodeEditor.TabIndex = 5;
            this.CodeEditor.Text = "";
            this.CodeEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeEditor_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.CodeEditor);
            this.Controls.Add(this.OpenObject);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.UpdateUIBTN);
            this.Controls.Add(this.ObjectCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Shadows Save File Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ObjectCount;
        private System.Windows.Forms.Button UpdateUIBTN;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.LinkLabel credits;
        private System.Windows.Forms.Button OpenObject;
        private System.Windows.Forms.RichTextBox CodeEditor;
    }
}

