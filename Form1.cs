using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Calculate_Hash
{
    public partial class Form1 : Form
    {
        string sha1, md5;
        OpenFileDialog ofd;

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lblState.Text = "             Done";
        }

        private void btnCopySHA_Click_1(object sender, EventArgs e)
        {
            if (sha1 != null)
            {
                Clipboard.SetText(sha1.Replace("SHA-1 = ", ""));
                MessageBox.Show("SHA-1 Copied Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            Hash_Comparing();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != null) { txtPastedHash.Text = Clipboard.GetText(); }
        }

        private void btnCopyMD5_Click_1(object sender, EventArgs e)
        {
            if (md5 != null)
            {
                Clipboard.SetText(md5.Replace("MD5 = ", ""));
                MessageBox.Show("MD5 Copied Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select File To Get Hash";
            ofd.Filter = "All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                backgroundWorker1.RunWorkerAsync();
                lblState.Text = "             Working ...";
            }
        }

        private string Calculate_Hash(string file)
        {
            FileStream fs = File.OpenRead(file);
            sha1 = "SHA-1 = " + BitConverter.ToString(SHA1.Create().ComputeHash(fs)).Replace("-", "");
            md5 = "MD5 = " + BitConverter.ToString(MD5.Create().ComputeHash(File.ReadAllBytes(file))).Replace("-", "");
            string hash = sha1 + Environment.NewLine + Environment.NewLine + md5;
            return hash;
        }

        private void Hash_Comparing()
        {          
            string pasted_hash = txtPastedHash.Text != "" ?  txtPastedHash.Text : null;
            if (md5 != null && sha1 != null && pasted_hash != null)
            {                
                bool match = (pasted_hash == md5.Replace("MD5 = ", "") || pasted_hash == sha1.Replace("SHA-1 = ", ""));
                if (match)
                {
                    lblCompareRes.Text = "2 Hashes Matched !";
                    pbCompareRes.Image = Properties.Resources.match;
                }
                else
                {
                    lblCompareRes.Text = "      Not Matched !";
                    pbCompareRes.Image = Properties.Resources.not_match;
                }
            }          
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            txtFileHash.Text = Calculate_Hash(ofd.FileName);           
        }            
    }
}
