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
            SaveButton = new Button();
            BlackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inputPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputPictureBox).BeginInit();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(48, 924);
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
            inputPictureBox.Location = new Point(48, 86);
            inputPictureBox.Name = "inputPictureBox";
            inputPictureBox.Size = new Size(872, 805);
            inputPictureBox.TabIndex = 1;
            inputPictureBox.TabStop = false;
            // 
            // outputPictureBox
            // 
            outputPictureBox.BackColor = Color.White;
            outputPictureBox.Location = new Point(1018, 86);
            outputPictureBox.Name = "outputPictureBox";
            outputPictureBox.Size = new Size(872, 805);
            outputPictureBox.TabIndex = 2;
            outputPictureBox.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(883, 924);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(125, 29);
            progressBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.ForeColor = SystemColors.Info;
            statusLabel.Location = new Point(1014, 924);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(47, 20);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            // 
            // processButton
            // 
            processButton.Location = new Point(746, 924);
            processButton.Name = "processButton";
            processButton.Size = new Size(94, 29);
            processButton.TabIndex = 5;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(151, 924);
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
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 37);
            label1.Name = "label1";
            label1.Size = new Size(151, 26);
            label1.TabIndex = 12;
            label1.Text = "Przed obróbką";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1018, 57);
            label2.Name = "label2";
            label2.Size = new Size(121, 26);
            label2.TabIndex = 8;
            label2.Text = "Po obróbce";
            // 
            // Redbutton
            // 
            Redbutton.BackColor = Color.Red;
            Redbutton.Location = new Point(251, 921);
            Redbutton.Name = "Redbutton";
            Redbutton.Size = new Size(35, 35);
            Redbutton.TabIndex = 9;
            Redbutton.UseVisualStyleBackColor = false;
            // 
            // GreenButton
            // 
            GreenButton.BackColor = Color.Lime;
            GreenButton.Location = new Point(292, 921);
            GreenButton.Name = "GreenButton";
            GreenButton.Size = new Size(35, 35);
            GreenButton.TabIndex = 10;
            GreenButton.UseVisualStyleBackColor = false;
            // 
            // BlueButton
            // 
            BlueButton.BackColor = Color.Blue;
            BlueButton.Location = new Point(333, 921);
            BlueButton.Name = "BlueButton";
            BlueButton.Size = new Size(35, 35);
            BlueButton.TabIndex = 11;
            BlueButton.UseVisualStyleBackColor = false;
            // 
            // YellowButton
            // 
            YellowButton.BackColor = Color.Yellow;
            YellowButton.Location = new Point(374, 921);
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
            ChosenColorLabel.Location = new Point(490, 936);
            ChosenColorLabel.Name = "ChosenColorLabel";
            ChosenColorLabel.Size = new Size(142, 20);
            ChosenColorLabel.TabIndex = 13;
            ChosenColorLabel.Text = "Wybrany kolor: Gray";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(48, 959);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BlackButton
            // 
            BlackButton.BackColor = Color.Black;
            BlackButton.Location = new Point(415, 921);
            BlackButton.Name = "BlackButton";
            BlackButton.Size = new Size(35, 35);
            BlackButton.TabIndex = 15;
            BlackButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1902, 1033);
            Controls.Add(BlackButton);
            Controls.Add(SaveButton);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "LepszyGIMP";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
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
        private Button SaveButton;
        private Button BlackButton;
    }
}