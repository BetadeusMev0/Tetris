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
            GameArea = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GameArea).BeginInit();
            SuspendLayout();
            // 
            // GameArea
            // 
            GameArea.BorderStyle = BorderStyle.Fixed3D;
            GameArea.Location = new Point(12, 12);
            GameArea.Name = "GameArea";
            GameArea.Size = new Size(205, 405);
            GameArea.TabIndex = 0;
            GameArea.TabStop = false;
            // 
            // TetrisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 861);
            Controls.Add(GameArea);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1000, 900);
            MinimumSize = new Size(1000, 900);
            Name = "TetrisForm";
            Text = "Tetris";
            KeyUp += TetrisForm_KeyUp;
            ((System.ComponentModel.ISupportInitialize)GameArea).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox GameArea;
    }
}