namespace Calculate_Hash
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCompareRes = new System.Windows.Forms.Label();
            this.pbCompareRes = new System.Windows.Forms.PictureBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.txtPastedHash = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopyMD5 = new System.Windows.Forms.Button();
            this.btnCopySHA = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileHash = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompareRes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(122, 25);
            this.lblState.Text = "                      ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.lblCompareRes);
            this.groupBox1.Controls.Add(this.pbCompareRes);
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Controls.Add(this.btnPaste);
            this.groupBox1.Controls.Add(this.txtPastedHash);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(0, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2 Hashes Comparing";
            // 
            // lblCompareRes
            // 
            this.lblCompareRes.AutoSize = true;
            this.lblCompareRes.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblCompareRes.Location = new System.Drawing.Point(462, 75);
            this.lblCompareRes.Name = "lblCompareRes";
            this.lblCompareRes.Size = new System.Drawing.Size(111, 16);
            this.lblCompareRes.TabIndex = 16;
            this.lblCompareRes.Text = "_____________";
            // 
            // pbCompareRes
            // 
            this.pbCompareRes.Image = global::Calculate_Hash.Properties.Resources.hash;
            this.pbCompareRes.Location = new System.Drawing.Point(497, 19);
            this.pbCompareRes.Name = "pbCompareRes";
            this.pbCompareRes.Size = new System.Drawing.Size(77, 53);
            this.pbCompareRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompareRes.TabIndex = 15;
            this.pbCompareRes.TabStop = false;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCompare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCompare.FlatAppearance.BorderSize = 3;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.ForeColor = System.Drawing.Color.White;
            this.btnCompare.Location = new System.Drawing.Point(313, 73);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(89, 42);
            this.btnCompare.TabIndex = 14;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaste.FlatAppearance.BorderSize = 3;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.Location = new System.Drawing.Point(200, 73);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(89, 42);
            this.btnPaste.TabIndex = 13;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // txtPastedHash
            // 
            this.txtPastedHash.BackColor = System.Drawing.Color.White;
            this.txtPastedHash.Enabled = false;
            this.txtPastedHash.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPastedHash.Location = new System.Drawing.Point(24, 24);
            this.txtPastedHash.Margin = new System.Windows.Forms.Padding(4);
            this.txtPastedHash.Multiline = true;
            this.txtPastedHash.Name = "txtPastedHash";
            this.txtPastedHash.ReadOnly = true;
            this.txtPastedHash.Size = new System.Drawing.Size(448, 40);
            this.txtPastedHash.TabIndex = 12;
            this.txtPastedHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.btnCopyMD5);
            this.groupBox2.Controls.Add(this.btnCopySHA);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.txtFileHash);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Location = new System.Drawing.Point(0, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 156);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate Hash";
            // 
            // btnCopyMD5
            // 
            this.btnCopyMD5.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCopyMD5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopyMD5.FlatAppearance.BorderSize = 3;
            this.btnCopyMD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyMD5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyMD5.ForeColor = System.Drawing.Color.White;
            this.btnCopyMD5.Location = new System.Drawing.Point(313, 105);
            this.btnCopyMD5.Name = "btnCopyMD5";
            this.btnCopyMD5.Size = new System.Drawing.Size(158, 42);
            this.btnCopyMD5.TabIndex = 15;
            this.btnCopyMD5.Text = "Copy MD5";
            this.btnCopyMD5.UseVisualStyleBackColor = false;
            this.btnCopyMD5.Click += new System.EventHandler(this.btnCopyMD5_Click_1);
            // 
            // btnCopySHA
            // 
            this.btnCopySHA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCopySHA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopySHA.FlatAppearance.BorderSize = 3;
            this.btnCopySHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopySHA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopySHA.ForeColor = System.Drawing.Color.White;
            this.btnCopySHA.Location = new System.Drawing.Point(131, 105);
            this.btnCopySHA.Name = "btnCopySHA";
            this.btnCopySHA.Size = new System.Drawing.Size(158, 42);
            this.btnCopySHA.TabIndex = 14;
            this.btnCopySHA.Text = "Copy SHA-1";
            this.btnCopySHA.UseVisualStyleBackColor = false;
            this.btnCopySHA.Click += new System.EventHandler(this.btnCopySHA_Click_1);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectFile.FlatAppearance.BorderSize = 3;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(11, 36);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(89, 38);
            this.btnSelectFile.TabIndex = 13;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // txtFileHash
            // 
            this.txtFileHash.BackColor = System.Drawing.Color.White;
            this.txtFileHash.Enabled = false;
            this.txtFileHash.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFileHash.Location = new System.Drawing.Point(109, 21);
            this.txtFileHash.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileHash.Multiline = true;
            this.txtFileHash.Name = "txtFileHash";
            this.txtFileHash.ReadOnly = true;
            this.txtFileHash.Size = new System.Drawing.Size(487, 74);
            this.txtFileHash.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(602, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Calculator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompareRes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TextBox txtPastedHash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopyMD5;
        private System.Windows.Forms.Button btnCopySHA;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileHash;
        private System.Windows.Forms.PictureBox pbCompareRes;
        private System.Windows.Forms.Label lblCompareRes;
    }
}

