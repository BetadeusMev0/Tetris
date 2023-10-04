namespace TetrisTest
{
    partial class TetrisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TetrisForm));
            this.GameArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameArea.Location = new System.Drawing.Point(12, 12);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(205, 405);
            this.GameArea.TabIndex = 0;
            this.GameArea.TabStop = false;
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.GameArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 900);
            this.Name = "TetrisForm";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.TetrisForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TetrisForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TetrisForm_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox GameArea;
    }
}