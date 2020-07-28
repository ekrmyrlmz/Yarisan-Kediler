namespace Kediler_Yarisiyor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Picboxkedi1 = new System.Windows.Forms.PictureBox();
            this.Picboxkedi2 = new System.Windows.Forms.PictureBox();
            this.Picboxkedi3 = new System.Windows.Forms.PictureBox();
            this.lblyarisdurumu = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lblfinish = new System.Windows.Forms.Label();
            this.Pbxfinish = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picboxkedi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picboxkedi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picboxkedi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxfinish)).BeginInit();
            this.SuspendLayout();
            // 
            // Picboxkedi1
            // 
            this.Picboxkedi1.Image = ((System.Drawing.Image)(resources.GetObject("Picboxkedi1.Image")));
            this.Picboxkedi1.Location = new System.Drawing.Point(25, 85);
            this.Picboxkedi1.Name = "Picboxkedi1";
            this.Picboxkedi1.Size = new System.Drawing.Size(83, 51);
            this.Picboxkedi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picboxkedi1.TabIndex = 0;
            this.Picboxkedi1.TabStop = false;
            // 
            // Picboxkedi2
            // 
            this.Picboxkedi2.Image = ((System.Drawing.Image)(resources.GetObject("Picboxkedi2.Image")));
            this.Picboxkedi2.Location = new System.Drawing.Point(25, 162);
            this.Picboxkedi2.Name = "Picboxkedi2";
            this.Picboxkedi2.Size = new System.Drawing.Size(83, 51);
            this.Picboxkedi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picboxkedi2.TabIndex = 1;
            this.Picboxkedi2.TabStop = false;
            // 
            // Picboxkedi3
            // 
            this.Picboxkedi3.Image = ((System.Drawing.Image)(resources.GetObject("Picboxkedi3.Image")));
            this.Picboxkedi3.Location = new System.Drawing.Point(25, 230);
            this.Picboxkedi3.Name = "Picboxkedi3";
            this.Picboxkedi3.Size = new System.Drawing.Size(83, 51);
            this.Picboxkedi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picboxkedi3.TabIndex = 3;
            this.Picboxkedi3.TabStop = false;
            // 
            // lblyarisdurumu
            // 
            this.lblyarisdurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyarisdurumu.Location = new System.Drawing.Point(12, 310);
            this.lblyarisdurumu.Name = "lblyarisdurumu";
            this.lblyarisdurumu.Size = new System.Drawing.Size(91, 34);
            this.lblyarisdurumu.TabIndex = 4;
            this.lblyarisdurumu.Text = "Yarış Durumu : ";
            this.lblyarisdurumu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstart.Location = new System.Drawing.Point(12, 15);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(114, 34);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "Başlat / Durdur";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(109, 310);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(550, 34);
            this.lblsonuc.TabIndex = 8;
            this.lblsonuc.Text = "Yarış Sonucu ";
            this.lblsonuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblfinish
            // 
            this.lblfinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblfinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinish.Location = new System.Drawing.Point(645, 85);
            this.lblfinish.Name = "lblfinish";
            this.lblfinish.Size = new System.Drawing.Size(14, 216);
            this.lblfinish.TabIndex = 9;
            this.lblfinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pbxfinish
            // 
            this.Pbxfinish.Image = ((System.Drawing.Image)(resources.GetObject("Pbxfinish.Image")));
            this.Pbxfinish.Location = new System.Drawing.Point(610, 15);
            this.Pbxfinish.Name = "Pbxfinish";
            this.Pbxfinish.Size = new System.Drawing.Size(69, 67);
            this.Pbxfinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbxfinish.TabIndex = 10;
            this.Pbxfinish.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnreset.Location = new System.Drawing.Point(176, 15);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(114, 34);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 366);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.Pbxfinish);
            this.Controls.Add(this.lblfinish);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblyarisdurumu);
            this.Controls.Add(this.Picboxkedi3);
            this.Controls.Add(this.Picboxkedi2);
            this.Controls.Add(this.Picboxkedi1);
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picboxkedi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picboxkedi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picboxkedi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbxfinish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picboxkedi1;
        private System.Windows.Forms.PictureBox Picboxkedi2;
        private System.Windows.Forms.PictureBox Picboxkedi3;
        private System.Windows.Forms.Label lblyarisdurumu;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label lblfinish;
        private System.Windows.Forms.PictureBox Pbxfinish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreset;
    }
}

