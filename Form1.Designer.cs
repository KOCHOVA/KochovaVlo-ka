using System.Windows.Forms;

namespace KochovaVlocka
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnSpust = new System.Windows.Forms.Button();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtFarba = new System.Windows.Forms.TextBox();
            this.txtFarbaCiary = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Location = new System.Drawing.Point(5, 82);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(428, 338);
            this.picCanvas.TabIndex = 18;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // btnSpust
            // 
            this.btnSpust.Location = new System.Drawing.Point(370, 24);
            this.btnSpust.Name = "btnSpust";
            this.btnSpust.Size = new System.Drawing.Size(60, 24);
            this.btnSpust.TabIndex = 17;
            this.btnSpust.Text = "Spust";
            this.btnSpust.Click += new System.EventHandler(this.btnSpusti_Click);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(114, 4);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(32, 20);
            this.txtDepth.TabIndex = 16;
            this.txtDepth.Text = "4";
            this.txtDepth.TextChanged += new System.EventHandler(this.txtDepth_TextChanged);
            // 
            // txtFarba
            // 
            this.txtFarba.Location = new System.Drawing.Point(114, 30);
            this.txtFarba.Name = "txtFarba";
            this.txtFarba.Size = new System.Drawing.Size(32, 20);
            this.txtFarba.TabIndex = 16;
            this.txtFarba.Text = "3";
            // 
            // txtFarbaCiary
            // 
            this.txtFarbaCiary.Location = new System.Drawing.Point(114, 56);
            this.txtFarbaCiary.Name = "txtFarbaCiary";
            this.txtFarbaCiary.Size = new System.Drawing.Size(32, 20);
            this.txtFarbaCiary.TabIndex = 0;
            this.txtFarbaCiary.Text = "3";
            this.txtFarbaCiary.TextChanged += new System.EventHandler(this.txtFarbaCiary_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "PočetIteraci:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(25, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "FarbaPozadia:";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(25, 59);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "FarbyCiary:";
            this.Label3.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(152, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(278, 23);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "1-Cierna, 2-Biela, 3-Modra, 4-Cervena";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(152, 56);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(195, 23);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "1-Cierna, 2-Modra, 3-Zlta, 4-Cervena";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSpust;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 429);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnSpust);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtFarba);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtFarbaCiary);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Name = "Form1";
            this.Text = "KochovaVločka";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picCanvas;
        internal System.Windows.Forms.Button btnSpust;
        internal System.Windows.Forms.TextBox txtDepth;
        internal System.Windows.Forms.TextBox txtFarba;
        internal System.Windows.Forms.TextBox txtFarbaCiary;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

