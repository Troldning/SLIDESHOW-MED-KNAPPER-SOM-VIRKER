namespace SLIDESHOW_MED_KNAPPER_SOM_VIRKER
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextKnap = new System.Windows.Forms.Button();
            this.prevKnap = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nextKnap
            // 
            this.nextKnap.Location = new System.Drawing.Point(610, 191);
            this.nextKnap.Name = "nextKnap";
            this.nextKnap.Size = new System.Drawing.Size(75, 23);
            this.nextKnap.TabIndex = 1;
            this.nextKnap.Text = "---->";
            this.nextKnap.UseVisualStyleBackColor = true;
            this.nextKnap.Click += new System.EventHandler(this.nextKnap_Click);
            // 
            // prevKnap
            // 
            this.prevKnap.Location = new System.Drawing.Point(103, 191);
            this.prevKnap.Name = "prevKnap";
            this.prevKnap.Size = new System.Drawing.Size(75, 23);
            this.prevKnap.TabIndex = 2;
            this.prevKnap.Text = "<----";
            this.prevKnap.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ligger ved mor-800px.jpg");
            this.imageList1.Images.SetKeyName(1, "Løver i sne-800px.jpg");
            this.imageList1.Images.SetKeyName(2, "Løveunger-800px.jpg");
            this.imageList1.Images.SetKeyName(3, "Parring0_-800px.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevKnap);
            this.Controls.Add(this.nextKnap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextKnap;
        private System.Windows.Forms.Button prevKnap;
        private System.Windows.Forms.ImageList imageList1;
    }
}

