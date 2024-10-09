namespace CinemanaDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getLinks = new System.Windows.Forms.Button();
            this.filesListView = new System.Windows.Forms.ListView();
            this.subListView = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.thumbPic = new System.Windows.Forms.PictureBox();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.movieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 26F);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(246, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cinemana\r\nDownloader";
            // 
            // urlBox
            // 
            this.urlBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.urlBox.Location = new System.Drawing.Point(143, 46);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(292, 27);
            this.urlBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(139, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(250, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "By OsaMa v0.2";
            // 
            // getLinks
            // 
            this.getLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getLinks.Font = new System.Drawing.Font("Tahoma", 12F);
            this.getLinks.ForeColor = System.Drawing.Color.Red;
            this.getLinks.Location = new System.Drawing.Point(143, 79);
            this.getLinks.Name = "getLinks";
            this.getLinks.Size = new System.Drawing.Size(366, 51);
            this.getLinks.TabIndex = 6;
            this.getLinks.Text = "Download";
            this.getLinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.getLinks.UseVisualStyleBackColor = true;
            this.getLinks.Click += new System.EventHandler(this.getLinks_Click);
            // 
            // filesListView
            // 
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(12, 136);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(108, 119);
            this.filesListView.TabIndex = 7;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.Visible = false;
            this.filesListView.SelectedIndexChanged += new System.EventHandler(this.filesListView_SelectedIndexChanged);
            // 
            // subListView
            // 
            this.subListView.HideSelection = false;
            this.subListView.Location = new System.Drawing.Point(126, 136);
            this.subListView.Name = "subListView";
            this.subListView.Size = new System.Drawing.Size(114, 119);
            this.subListView.TabIndex = 9;
            this.subListView.UseCompatibleStateImageBehavior = false;
            this.subListView.Visible = false;
            this.subListView.SelectedIndexChanged += new System.EventHandler(this.subListView_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 189);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // thumbPic
            // 
            this.thumbPic.Image = global::CinemanaDownload.Properties.Resources.placeholder;
            this.thumbPic.Location = new System.Drawing.Point(529, 46);
            this.thumbPic.Name = "thumbPic";
            this.thumbPic.Size = new System.Drawing.Size(174, 207);
            this.thumbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbPic.TabIndex = 12;
            this.thumbPic.TabStop = false;
            this.thumbPic.Visible = false;
            this.thumbPic.WaitOnLoad = true;
            // 
            // pasteBtn
            // 
            this.pasteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pasteBtn.BackgroundImage = global::CinemanaDownload.Properties.Resources._6583091;
            this.pasteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pasteBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pasteBtn.Image = global::CinemanaDownload.Properties.Resources._6583091;
            this.pasteBtn.Location = new System.Drawing.Point(441, 46);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(31, 27);
            this.pasteBtn.TabIndex = 11;
            this.pasteBtn.UseVisualStyleBackColor = false;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clrBtn.BackgroundImage = global::CinemanaDownload.Properties.Resources.clear_icon_3;
            this.clrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.clrBtn.Location = new System.Drawing.Point(478, 46);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(31, 27);
            this.clrBtn.TabIndex = 8;
            this.clrBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemanaDownload.Properties.Resources.logoc_3b853c59;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.movieLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.movieLabel.Location = new System.Drawing.Point(529, 17);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(109, 19);
            this.movieLabel.TabIndex = 13;
            this.movieLabel.Text = "Movie Name";
            this.movieLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(715, 265);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.thumbPic);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.subListView);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.getLinks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cinemana Dowloader by OsaMa hawkiq v0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getLinks;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ListView subListView;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.PictureBox thumbPic;
        private System.Windows.Forms.Label movieLabel;
    }
}

