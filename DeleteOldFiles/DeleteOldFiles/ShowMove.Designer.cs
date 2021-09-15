
namespace DeleteOldFiles
{
    partial class ShowMove
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMove = new System.Windows.Forms.Label();
            this.prgMove = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prgDelete = new System.Windows.Forms.ProgressBar();
            this.lblDelete = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(16, 35);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(80, 20);
            this.lblMove.TabIndex = 0;
            this.lblMove.Text = "Move files:";
            // 
            // prgMove
            // 
            this.prgMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgMove.Location = new System.Drawing.Point(16, 58);
            this.prgMove.Name = "prgMove";
            this.prgMove.Size = new System.Drawing.Size(753, 29);
            this.prgMove.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.prgDelete);
            this.groupBox1.Controls.Add(this.lblDelete);
            this.groupBox1.Controls.Add(this.prgMove);
            this.groupBox1.Controls.Add(this.lblMove);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // prgDelete
            // 
            this.prgDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgDelete.Location = new System.Drawing.Point(16, 139);
            this.prgDelete.Name = "prgDelete";
            this.prgDelete.Size = new System.Drawing.Size(753, 29);
            this.prgDelete.TabIndex = 3;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(16, 116);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(87, 20);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Delete files:";
            // 
            // ShowMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowMove";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShowMove_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.ProgressBar prgMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar prgDelete;
        private System.Windows.Forms.Label lblDelete;
    }
}

