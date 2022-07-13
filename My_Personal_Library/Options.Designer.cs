namespace Animeler
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.btn_Animes = new System.Windows.Forms.Button();
            this.Anime_icon = new System.Windows.Forms.ImageList(this.components);
            this.btn_TVshows = new System.Windows.Forms.Button();
            this.TVshow_icon = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Animes
            // 
            this.btn_Animes.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Animes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Animes.ImageIndex = 0;
            this.btn_Animes.ImageList = this.Anime_icon;
            this.btn_Animes.Location = new System.Drawing.Point(30, 21);
            this.btn_Animes.Name = "btn_Animes";
            this.btn_Animes.Size = new System.Drawing.Size(125, 42);
            this.btn_Animes.TabIndex = 0;
            this.btn_Animes.Text = "Animes";
            this.btn_Animes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Animes.UseVisualStyleBackColor = true;
            this.btn_Animes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Anime_icon
            // 
            this.Anime_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Anime_icon.ImageStream")));
            this.Anime_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.Anime_icon.Images.SetKeyName(0, "4043233_anime_away_face_no_nobody_icon.png");
            // 
            // btn_TVshows
            // 
            this.btn_TVshows.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TVshows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TVshows.ImageIndex = 0;
            this.btn_TVshows.ImageList = this.TVshow_icon;
            this.btn_TVshows.Location = new System.Drawing.Point(195, 21);
            this.btn_TVshows.Name = "btn_TVshows";
            this.btn_TVshows.Size = new System.Drawing.Size(125, 42);
            this.btn_TVshows.TabIndex = 0;
            this.btn_TVshows.Text = "TV Shows";
            this.btn_TVshows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TVshows.UseVisualStyleBackColor = true;
            this.btn_TVshows.Click += new System.EventHandler(this.button2_Click);
            // 
            // TVshow_icon
            // 
            this.TVshow_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TVshow_icon.ImageStream")));
            this.TVshow_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.TVshow_icon.Images.SetKeyName(0, "icons8-tv-show-64.png");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 0;
            this.button3.Location = new System.Drawing.Point(30, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Coming Soon";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 0;
            this.button4.Location = new System.Drawing.Point(195, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 42);
            this.button4.TabIndex = 0;
            this.button4.Text = "Coming Soon";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 228);
            this.Controls.Add(this.btn_TVshows);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Animes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Animes;
        private System.Windows.Forms.ImageList Anime_icon;
        private System.Windows.Forms.Button btn_TVshows;
        private System.Windows.Forms.ImageList TVshow_icon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}