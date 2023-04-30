namespace PrzetwarzanieObrazów
{
    partial class Form1
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
            openButton = new Button();
            inputPictureBox = new PictureBox();
            outputPictureBox = new PictureBox();
            progressBar = new ProgressBar();
            statusLabel = new Label();
            processButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inputPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputPictureBox).BeginInit();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(169, 476);
            openButton.Name = "openButton";
            openButton.Size = new Size(94, 29);
            openButton.TabIndex = 0;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // inputPictureBox
            // 
            inputPictureBox.Location = new Point(12, 12);
            inputPictureBox.Name = "inputPictureBox";
            inputPictureBox.Size = new Size(416, 423);
            inputPictureBox.TabIndex = 1;
            inputPictureBox.TabStop = false;
            // 
            // outputPictureBox
            // 
            outputPictureBox.Location = new Point(460, 12);
            outputPictureBox.Name = "outputPictureBox";
            outputPictureBox.Size = new Size(446, 423);
            outputPictureBox.TabIndex = 2;
            outputPictureBox.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(469, 476);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(125, 29);
            progressBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(611, 485);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(47, 20);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            // 
            // processButton
            // 
            processButton.Location = new Point(269, 476);
            processButton.Name = "processButton";
            processButton.Size = new Size(94, 29);
            processButton.TabIndex = 5;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(369, 476);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 527);
            Controls.Add(cancelButton);
            Controls.Add(processButton);
            Controls.Add(statusLabel);
            Controls.Add(progressBar);
            Controls.Add(outputPictureBox);
            Controls.Add(inputPictureBox);
            Controls.Add(openButton);
            Name = "Form1";
            Text = "LepszyGIMP";
            ((System.ComponentModel.ISupportInitialize)inputPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)outputPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openButton;
        private PictureBox inputPictureBox;
        private PictureBox outputPictureBox;
        private ProgressBar progressBar;
        private Label statusLabel;
        private Button processButton;
        private Button cancelButton;
    }
}