using System.Windows.Forms;

namespace PrzetwarzanieObrazów
{
    public partial class Form1 : Form
    {
        private Bitmap inputImage;
        private Bitmap outputImage;
        private Color chosenColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }
        public Image ResizeImage(Image inputImage, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                // Ustaw tryb wygładzania
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Skopiuj obraz do nowego obrazu z zachowaniem proporcji
                graphics.DrawImage(inputImage, 0, 0, width, height);
            }

            return resizedBitmap;
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.jpg;*.jpeg;*.bmp;*.png;*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Bitmap(dialog.FileName);
                inputPictureBox.Image = inputImage;
                outputPictureBox.Image = null;
                progressBar.Value = 0;
                statusLabel.Text = "Loaded image: " + dialog.FileName;
                HeightTextBox.Text = inputImage.Height.ToString();
                widthTextBox.Text = inputImage.Width.ToString();
            }

        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (inputImage == null)
            {
                MessageBox.Show("Please select an input image first.");
                return;
            }

            // Disable buttons
            openButton.Enabled = false;
            processButton.Enabled = false;
            cancelButton.Enabled = true;

            // Clear previous output
            outputImage = null;
            outputPictureBox.Image = null;

            // Set up progress bar
            int progress = 0;

            // Create a TaskScheduler using the current SynchronizationContext
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            Action<int> updateProgress = value =>
            {
                // Update progress variable
                progress = value;

                // Update progress bar on UI thread
                Task.Factory.StartNew(() =>
                {
                    progressBar.Value = progress;
                }, CancellationToken.None, TaskCreationOptions.None, uiScheduler)
                .ContinueWith(task =>
                {
                    if (task.Exception != null)
                    {
                        // Handle the exception here
                        MessageBox.Show($"An error occurred: {task.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };


            // Set up status label
            Action<string> updateStatus = message =>
            {
                if (statusLabel.InvokeRequired)
                {
                    statusLabel.Invoke(new MethodInvoker(delegate
                    {
                        statusLabel.Text = message;
                    }));
                }
                else
                {
                    statusLabel.Text = message;
                }
            };


            // Set up cancellation token
            var cancellationTokenSource = new System.Threading.CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            // Start processing task
#pragma warning disable CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.
            Task<Bitmap> processTask = Task.Run(() =>
            {
                // Do some processing in parallel using multiple threads
                Bitmap result = inputImage.Clone() as Bitmap;

                for (int y = 0; y < inputImage.Height; y++)
                {
                    for (int x = 0; x < inputImage.Width; x++)
                    {
                        Color pixel = inputImage.GetPixel(x, y);

                        if (KolorObrazuCheckBox.Checked)
                        {
                            int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                            // zmiana kororu Color.FromArgb(pixel.A, zmianaKoloru(), zmianaKoloru(), ZmianaKoloru() ));
                            result.SetPixel(x, y, Color.FromArgb(pixel.A, gray, gray, gray));
                        }
                        else if (SizeChengeCheckBox.Checked)
                        {
                            int newWidth = 0;
                            int newHeight = 0;
                            if (!int.TryParse(widthTextBox.Text, out newWidth) || !int.TryParse(HeightTextBox.Text, out newHeight))
                            {
                                MessageBox.Show("Podano nieprawidłowe wartości szerokości i/lub wysokości.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //return;
                            }
                            Image resizedImage = ResizeImage(inputPictureBox.Image, newWidth, newHeight);

                            outputPictureBox.Image = resizedImage;

                        }
                    }
                    int newProgress = (int)((y + 1) * 100.0 / inputImage.Height);
                    if (newProgress > progress)
                    {
                        // Update progress bar and status label
                        updateProgress(newProgress);
                        updateStatus("Processing image... " + newProgress + "%");
                    }
                    // Check for cancellation
                    cancellationToken.ThrowIfCancellationRequested();
                }
                return result;
            }, cancellationToken);
#pragma warning restore CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.

            // Handle completion and errors
            processTask.ContinueWith(task =>
            {
                if (!task.IsFaulted && !task.IsCanceled)
                {
                    // Display the result
                    outputImage = task.Result;
                    outputPictureBox.Image = outputImage;
                    statusLabel.Text = "Processing complete.";
                }
                else if (task.IsCanceled)
                {
                    // Display cancellation message
                    statusLabel.Text = "Processing cancelled.";
                }
                else
                {
                    // Display error message
                    Exception exception = task.Exception.InnerExceptions[0];
                    MessageBox.Show("An error occurred: " + exception.Message);
                    statusLabel.Text = "An error occurred: " + exception.Message;
                }
                // Enable buttons
                openButton.Enabled = true;
                processButton.Enabled = true;
                // Disable cancel button
                cancelButton.Enabled = false;
            }, TaskScheduler.FromCurrentSynchronizationContext());
            // Set up cancel button
            cancelButton.Click += (cancelSender, cancelArgs) =>
            {
                cancelButton.Enabled = false;
                cancellationTokenSource.Cancel();
            };

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Wyświetlenie dialogu zapisu pliku
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki obrazów (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            saveFileDialog.Title = "Zapisz obraz";
            saveFileDialog.ShowDialog();

            // Jeśli użytkownik wybrał plik i kliknął OK
            if (saveFileDialog.FileName != "")
            {
                // Zapisanie obrazu z kontrolki PictureBox do pliku
                outputPictureBox.Image.Save(saveFileDialog.FileName);
                MessageBox.Show("Pomyślnie zapisano obraz.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void HelperButton_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.ShowDialog();
        }
    }
}