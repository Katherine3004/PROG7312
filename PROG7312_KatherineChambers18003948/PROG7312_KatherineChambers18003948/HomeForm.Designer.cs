namespace PROG7312_KatherineChambers18003948
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnReplacing = new System.Windows.Forms.Button();
            this.btnIdentifying = new System.Windows.Forms.Button();
            this.btnFinding = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReplacing
            // 
            this.btnReplacing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReplacing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplacing.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacing.Location = new System.Drawing.Point(226, 85);
            this.btnReplacing.Name = "btnReplacing";
            this.btnReplacing.Size = new System.Drawing.Size(351, 65);
            this.btnReplacing.TabIndex = 0;
            this.btnReplacing.Text = "Replacing Books";
            this.btnReplacing.UseVisualStyleBackColor = true;
            this.btnReplacing.Click += new System.EventHandler(this.btnReplacing_Click);
            // 
            // btnIdentifying
            // 
            this.btnIdentifying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIdentifying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentifying.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifying.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIdentifying.Location = new System.Drawing.Point(226, 195);
            this.btnIdentifying.Name = "btnIdentifying";
            this.btnIdentifying.Size = new System.Drawing.Size(351, 65);
            this.btnIdentifying.TabIndex = 1;
            this.btnIdentifying.Text = "Identifying Areas";
            this.btnIdentifying.UseVisualStyleBackColor = true;
            // 
            // btnFinding
            // 
            this.btnFinding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinding.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinding.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFinding.Location = new System.Drawing.Point(226, 305);
            this.btnFinding.Name = "btnFinding";
            this.btnFinding.Size = new System.Drawing.Size(351, 65);
            this.btnFinding.TabIndex = 2;
            this.btnFinding.Text = "Finding Call Numbers";
            this.btnFinding.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(748, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Location = new System.Drawing.Point(702, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(40, 40);
            this.btnMini.TabIndex = 4;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFinding);
            this.Controls.Add(this.btnIdentifying);
            this.Controls.Add(this.btnReplacing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReplacing;
        private System.Windows.Forms.Button btnIdentifying;
        private System.Windows.Forms.Button btnFinding;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMini;
    }
}

