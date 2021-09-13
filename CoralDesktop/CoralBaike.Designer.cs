
namespace CoralDesktop
{
    partial class CoralBaike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoralBaike));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCoralSearch = new System.Windows.Forms.TextBox();
            this.buttonCoralSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(70, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 316);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 232);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCoralSearch
            // 
            this.textBoxCoralSearch.Location = new System.Drawing.Point(358, 68);
            this.textBoxCoralSearch.Name = "textBoxCoralSearch";
            this.textBoxCoralSearch.Size = new System.Drawing.Size(229, 21);
            this.textBoxCoralSearch.TabIndex = 2;
            // 
            // buttonCoralSearch
            // 
            this.buttonCoralSearch.Location = new System.Drawing.Point(640, 68);
            this.buttonCoralSearch.Name = "buttonCoralSearch";
            this.buttonCoralSearch.Size = new System.Drawing.Size(75, 52);
            this.buttonCoralSearch.TabIndex = 3;
            this.buttonCoralSearch.Text = "检索";
            this.buttonCoralSearch.UseVisualStyleBackColor = true;
            this.buttonCoralSearch.Click += new System.EventHandler(this.buttonCoralSearch_Click);
            // 
            // CoralBaike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.buttonCoralSearch);
            this.Controls.Add(this.textBoxCoralSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoralBaike";
            this.Text = "珊瑚百科";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCoralSearch;
        private System.Windows.Forms.Button buttonCoralSearch;
    }
}