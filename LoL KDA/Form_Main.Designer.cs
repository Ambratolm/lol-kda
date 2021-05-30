namespace LolKda
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.numUD_kills = new System.Windows.Forms.NumericUpDown();
            this.numUD_deaths = new System.Windows.Forms.NumericUpDown();
            this.numUD_assists = new System.Windows.Forms.NumericUpDown();
            this.label_kills = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_feedback = new System.Windows.Forms.TextBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_kills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_deaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_assists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // numUD_kills
            // 
            this.numUD_kills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUD_kills.BackColor = System.Drawing.Color.Black;
            this.numUD_kills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUD_kills.ForeColor = System.Drawing.Color.White;
            this.numUD_kills.Location = new System.Drawing.Point(117, 10);
            this.numUD_kills.Margin = new System.Windows.Forms.Padding(6);
            this.numUD_kills.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_kills.Name = "numUD_kills";
            this.numUD_kills.Size = new System.Drawing.Size(101, 32);
            this.numUD_kills.TabIndex = 1;
            this.numUD_kills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUD_deaths
            // 
            this.numUD_deaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUD_deaths.BackColor = System.Drawing.Color.Black;
            this.numUD_deaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUD_deaths.ForeColor = System.Drawing.Color.White;
            this.numUD_deaths.Location = new System.Drawing.Point(117, 51);
            this.numUD_deaths.Margin = new System.Windows.Forms.Padding(6);
            this.numUD_deaths.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_deaths.Name = "numUD_deaths";
            this.numUD_deaths.Size = new System.Drawing.Size(101, 32);
            this.numUD_deaths.TabIndex = 3;
            this.numUD_deaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUD_assists
            // 
            this.numUD_assists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUD_assists.BackColor = System.Drawing.Color.Black;
            this.numUD_assists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUD_assists.ForeColor = System.Drawing.Color.White;
            this.numUD_assists.Location = new System.Drawing.Point(117, 92);
            this.numUD_assists.Margin = new System.Windows.Forms.Padding(6);
            this.numUD_assists.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_assists.Name = "numUD_assists";
            this.numUD_assists.Size = new System.Drawing.Size(101, 32);
            this.numUD_assists.TabIndex = 5;
            this.numUD_assists.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_kills
            // 
            this.label_kills.AutoSize = true;
            this.label_kills.BackColor = System.Drawing.Color.Transparent;
            this.label_kills.ForeColor = System.Drawing.Color.White;
            this.label_kills.Location = new System.Drawing.Point(19, 10);
            this.label_kills.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_kills.Name = "label_kills";
            this.label_kills.Size = new System.Drawing.Size(59, 24);
            this.label_kills.TabIndex = 0;
            this.label_kills.Text = "Kills :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deaths :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assists :";
            // 
            // textBox_kda
            // 
            this.textBox_kda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_kda.BackColor = System.Drawing.Color.Black;
            this.textBox_kda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_kda.ForeColor = System.Drawing.Color.White;
            this.textBox_kda.Location = new System.Drawing.Point(117, 136);
            this.textBox_kda.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_kda.Name = "textBox_kda";
            this.textBox_kda.ReadOnly = true;
            this.textBox_kda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_kda.Size = new System.Drawing.Size(101, 32);
            this.textBox_kda.TabIndex = 8;
            this.textBox_kda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "KDA  :";
            // 
            // textBox_feedback
            // 
            this.textBox_feedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_feedback.BackColor = System.Drawing.Color.Black;
            this.textBox_feedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_feedback.Font = new System.Drawing.Font("Tahoma", 17F);
            this.textBox_feedback.ForeColor = System.Drawing.Color.White;
            this.textBox_feedback.Location = new System.Drawing.Point(117, 177);
            this.textBox_feedback.Multiline = true;
            this.textBox_feedback.Name = "textBox_feedback";
            this.textBox_feedback.ReadOnly = true;
            this.textBox_feedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_feedback.Size = new System.Drawing.Size(289, 67);
            this.textBox_feedback.TabIndex = 10;
            this.textBox_feedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Image = global::LolKda.Properties.Resources.master_yi;
            this.pictureBox_logo.Location = new System.Drawing.Point(227, 10);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(179, 152);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 10;
            this.pictureBox_logo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result :";
            // 
            // label_copyright
            // 
            this.label_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_copyright.AutoSize = true;
            this.label_copyright.BackColor = System.Drawing.Color.Transparent;
            this.label_copyright.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.label_copyright.ForeColor = System.Drawing.Color.White;
            this.label_copyright.Location = new System.Drawing.Point(311, 301);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(95, 17);
            this.label_copyright.TabIndex = 11;
            this.label_copyright.Text = "by Ambratolm";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::LolKda.Properties.Resources.stitch_pattern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 327);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_feedback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_kda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_kills);
            this.Controls.Add(this.numUD_assists);
            this.Controls.Add(this.numUD_deaths);
            this.Controls.Add(this.numUD_kills);
            this.Controls.Add(this.pictureBox_logo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL KDA";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_kills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_deaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_assists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUD_kills;
        private System.Windows.Forms.NumericUpDown numUD_deaths;
        private System.Windows.Forms.NumericUpDown numUD_assists;
        private System.Windows.Forms.Label label_kills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_feedback;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_copyright;
    }
}

