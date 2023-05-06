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
            label1 = new Label();
            label2 = new Label();
            Redbutton = new Button();
            GreenButton = new Button();
            BlueButton = new Button();
            YellowButton = new Button();
            ChosenColorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)inputPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputPictureBox).BeginInit();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(12, 565);
            openButton.Name = "openButton";
            openButton.Size = new Size(94, 29);
            openButton.TabIndex = 0;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // inputPictureBox
            // 
            inputPictureBox.BackColor = Color.White;
            inputPictureBox.Location = new Point(12, 44);
            inputPictureBox.Name = "inputPictureBox";
            inputPictureBox.Size = new Size(625, 512);
            inputPictureBox.TabIndex = 1;
            inputPictureBox.TabStop = false;
            // 
            // outputPictureBox
            // 
            outputPictureBox.BackColor = Color.White;
            outputPictureBox.Location = new Point(643, 44);
            outputPictureBox.Name = "outputPictureBox";
            outputPictureBox.Size = new Size(625, 512);
            outputPictureBox.TabIndex = 2;
            outputPictureBox.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(743, 568);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(125, 29);
            progressBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.ForeColor = SystemColors.Info;
            statusLabel.Location = new Point(890, 572);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(47, 20);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            // 
            // processButton
            // 
            processButton.Location = new Point(643, 568);
            processButton.Name = "processButton";
            processButton.Size = new Size(94, 29);
            processButton.TabIndex = 5;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(115, 565);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(126, 21);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 7;
            label1.Text = "Przed obróbką";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(753, 21);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 8;
            label2.Text = "Po obróbce";
            // 
            // Redbutton
            // 
            Redbutton.BackColor = Color.Red;
            Redbutton.Location = new Point(215, 562);
            Redbutton.Name = "Redbutton";
            Redbutton.Size = new Size(35, 35);
            Redbutton.TabIndex = 9;
            Redbutton.UseVisualStyleBackColor = false;
            // 
            // GreenButton
            // 
            GreenButton.BackColor = Color.Lime;
            GreenButton.Location = new Point(256, 562);
            GreenButton.Name = "GreenButton";
            GreenButton.Size = new Size(35, 35);
            GreenButton.TabIndex = 10;
            GreenButton.UseVisualStyleBackColor = false;
            // 
            // BlueButton
            // 
            BlueButton.BackColor = Color.Blue;
            BlueButton.Location = new Point(297, 562);
            BlueButton.Name = "BlueButton";
            BlueButton.Size = new Size(35, 35);
            BlueButton.TabIndex = 11;
            BlueButton.UseVisualStyleBackColor = false;
            // 
            // YellowButton
            // 
            YellowButton.BackColor = Color.Yellow;
            YellowButton.Location = new Point(338, 562);
            YellowButton.Name = "YellowButton";
            YellowButton.Size = new Size(35, 35);
            YellowButton.TabIndex = 12;
            YellowButton.UseVisualStyleBackColor = false;
            // 
            // ChosenColorLabel
            // 
            ChosenColorLabel.AutoSize = true;
            ChosenColorLabel.BackColor = Color.Transparent;
            ChosenColorLabel.ForeColor = SystemColors.Info;
            ChosenColorLabel.Location = new Point(392, 569);
            ChosenColorLabel.Name = "ChosenColorLabel";
            ChosenColorLabel.Size = new Size(142, 20);
            ChosenColorLabel.TabIndex = 13;
            ChosenColorLabel.Text = "Wybrany kolor: Gray";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1275, 603);
            Controls.Add(ChosenColorLabel);
            Controls.Add(YellowButton);
            Controls.Add(BlueButton);
            Controls.Add(GreenButton);
            Controls.Add(Redbutton);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button Redbutton;
        private Button GreenButton;
        private Button BlueButton;
        private Button YellowButton;
        private Label ChosenColorLabel;
    }
}