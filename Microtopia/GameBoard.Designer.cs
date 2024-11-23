namespace Microtopia
{
    partial class GameBoard
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
            pnlGameBoard = new Panel();
            SuspendLayout();
            // 
            // pnlGameBoard
            // 
            pnlGameBoard.Location = new Point(242, 65);
            pnlGameBoard.Name = "pnlGameBoard";
            pnlGameBoard.Size = new Size(300, 300);
            pnlGameBoard.TabIndex = 0;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlGameBoard);
            Name = "GameBoard";
            Text = "Microtopia";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGameBoard;
    }
}