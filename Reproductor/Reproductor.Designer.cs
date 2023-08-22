namespace Reproductor
{
    partial class Reproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.Volume = new XComponent.SliderBar.MACTrackBar();
            this.Progress = new XComponent.SliderBar.MACTrackBar();
            this.MusicName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.NextSong = new System.Windows.Forms.Button();
            this.prevSong = new System.Windows.Forms.Button();
            this.openSong = new System.Windows.Forms.Button();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPausa = new System.Windows.Forms.Button();
            this.musicpicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Volume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Volume.IndentHeight = 6;
            this.Volume.Location = new System.Drawing.Point(76, 308);
            this.Volume.Maximum = 100;
            this.Volume.Minimum = 0;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(215, 28);
            this.Volume.TabIndex = 0;
            this.Volume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Volume.TickHeight = 4;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Volume.TrackerSize = new System.Drawing.Size(16, 16);
            this.Volume.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volume.TrackLineHeight = 3;
            this.Volume.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volume.Value = 0;
            this.Volume.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Volume_ValueChanged);
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.Transparent;
            this.Progress.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Progress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Progress.IndentHeight = 6;
            this.Progress.Location = new System.Drawing.Point(12, 236);
            this.Progress.Maximum = 10;
            this.Progress.Minimum = 0;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(367, 28);
            this.Progress.TabIndex = 1;
            this.Progress.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Progress.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Progress.TickHeight = 4;
            this.Progress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Progress.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Progress.TrackerSize = new System.Drawing.Size(16, 16);
            this.Progress.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Progress.TrackLineHeight = 3;
            this.Progress.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Progress.Value = 0;
            this.Progress.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Progress_ValueChanged);
            // 
            // MusicName
            // 
            this.MusicName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MusicName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicName.ForeColor = System.Drawing.SystemColors.Window;
            this.MusicName.Location = new System.Drawing.Point(12, 12);
            this.MusicName.Multiline = true;
            this.MusicName.Name = "MusicName";
            this.MusicName.Size = new System.Drawing.Size(360, 20);
            this.MusicName.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(162, 270);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 32);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "4";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(224, 270);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "<";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // NextSong
            // 
            this.NextSong.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.NextSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextSong.Location = new System.Drawing.Point(286, 270);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(56, 32);
            this.NextSong.TabIndex = 5;
            this.NextSong.Text = "8";
            this.NextSong.UseVisualStyleBackColor = true;
            this.NextSong.Click += new System.EventHandler(this.NextSong_Click);
            // 
            // prevSong
            // 
            this.prevSong.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.prevSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prevSong.Location = new System.Drawing.Point(38, 270);
            this.prevSong.Name = "prevSong";
            this.prevSong.Size = new System.Drawing.Size(56, 32);
            this.prevSong.TabIndex = 6;
            this.prevSong.Text = "7";
            this.prevSong.UseVisualStyleBackColor = true;
            // 
            // openSong
            // 
            this.openSong.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.openSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openSong.Location = new System.Drawing.Point(12, 38);
            this.openSong.Name = "openSong";
            this.openSong.Size = new System.Drawing.Size(48, 31);
            this.openSong.TabIndex = 7;
            this.openSong.Text = "2";
            this.openSong.UseVisualStyleBackColor = true;
            this.openSong.Click += new System.EventHandler(this.openSong_Click);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(398, 324);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(157, 186);
            this.MediaPlayer.TabIndex = 8;
            // 
            // btnPausa
            // 
            this.btnPausa.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPausa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPausa.Location = new System.Drawing.Point(100, 270);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(56, 32);
            this.btnPausa.TabIndex = 9;
            this.btnPausa.Text = "3";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // musicpicture
            // 
            this.musicpicture.Location = new System.Drawing.Point(121, 89);
            this.musicpicture.Name = "musicpicture";
            this.musicpicture.Size = new System.Drawing.Size(130, 119);
            this.musicpicture.TabIndex = 10;
            this.musicpicture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(337, 220);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "00:00";
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.musicpicture);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.openSong);
            this.Controls.Add(this.prevSong);
            this.Controls.Add(this.NextSong);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.MusicName);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Volume);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reproductor";
            this.Load += new System.EventHandler(this.Reproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XComponent.SliderBar.MACTrackBar Volume;
        private XComponent.SliderBar.MACTrackBar Progress;
        private System.Windows.Forms.TextBox MusicName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button NextSong;
        private System.Windows.Forms.Button prevSong;
        private System.Windows.Forms.Button openSong;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.PictureBox musicpicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}

