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

        private void ZmianiaKoloru()
        {

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
            Task<Bitmap> processTask = (Task<Bitmap>)Task.Run(() =>
            {
                // Do some processing in parallel using multiple threads
                Bitmap result = inputImage.Clone() as Bitmap;
                for (int y = 0; y < inputImage.Height; y++)
                {
                    for (int x = 0; x < inputImage.Width; x++)
                    {
                        Color pixel = inputImage.GetPixel(x, y);

                        // Change pixel color based on chosenColor
                        int r, g, b;
                        if (chosenColor == Color.Red)
                        {
                            r = pixel.R;
                            g = 0;
                            b = 0;
                            result.SetPixel(x, y, Color.FromArgb(pixel.A, r, g, b));

                        }
                        else if (chosenColor == Color.Green)
                        {
                            r = 0;
                            g = pixel.G;
                            b = 0;
                        }
                        else if (chosenColor == Color.Blue)
                        {
                            r = 0;
                            g = 0;
                            b = pixel.B;
                        }
                        else
                        {
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;
                        }
                        // Create new color
                        Color newColor = Color.FromArgb(pixel.A, r, g, b);

                        // Set new color of pixel
                        result.SetPixel(x, y, newColor);
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

                // Return modified image
                return result;

            }, cancellationToken);
#pragma warning restore CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.


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
    }
}