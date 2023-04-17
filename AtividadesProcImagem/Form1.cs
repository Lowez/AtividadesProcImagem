using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace AtividadesProcImagem
{
    public partial class brightnessLabel : Form
    {

        public brightnessLabel()
        {
            InitializeComponent();
        }

        Bitmap img1;
        byte[,] vImg1Gray;
        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        Bitmap img2;
        byte[,] vImg2Gray;
        byte[,] vImg2R;
        byte[,] vImg2G;
        byte[,] vImg2B;
        byte[,] vImg2A;

        int resultIndex = 0;

        private void load1_Click_1(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            openFileDialog1 = new OpenFileDialog();
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Users\\Computação\\Downloads\\MaterialMatlab\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg1Gray[i, j] = pixelIntensity;

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;
                            vImg1A[i, j] = A;

                        }
                    }
                }
            }
            // pictureBox1.Load("C:\\Users\\Computação\\Downloads\\Material Matlab\\Matlab\\Add1.jpg");
        }

        private void load2_Click_1(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            openFileDialog2 = new OpenFileDialog();
            var filePath = string.Empty;
            openFileDialog2.InitialDirectory = "C:\\Users\\Computação\\Downloads\\MaterialMatlab\\Matlab";
            openFileDialog2.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog2.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox2.Image = img2;
                    vImg2Gray = new byte[img2.Width, img2.Height];
                    vImg2R = new byte[img2.Width, img2.Height];
                    vImg2G = new byte[img2.Width, img2.Height];
                    vImg2B = new byte[img2.Width, img2.Height];
                    vImg2A = new byte[img2.Width, img2.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img2.Width; i++)
                    {
                        for (int j = 0; j < img2.Height; j++)
                        {
                            Color pixel = img2.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg2Gray[i, j] = pixelIntensity;

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg2R[i, j] = R;
                            vImg2G[i, j] = G;
                            vImg2B[i, j] = B;
                            vImg2A[i, j] = A;

                        }
                    }
                }
            }
            // pictureBox1.Load("C:\\Users\\Computação\\Downloads\\Material Matlab\\Matlab\\Add1.jpg");
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            Bitmap addImage = (Bitmap)pictureBox1.Image;
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            Bitmap image2 = (Bitmap)pictureBox2.Image;

            if (Convert.ToInt32(bright.Value) != 10)
            {
                int fator = (Convert.ToInt32(bright.Value) * 10);

                int x, y;

                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {

                        Color newColor = new Color();
                        int newR = (int)vImg1R[x, y] + fator;
                        newR = newR >= 255 ? 255 : newR;
                        int newG = (int)vImg1G[x, y] + fator;
                        newG = newG >= 255 ? 255 : newG;
                        int newB = (int)vImg1B[x, y] + fator;
                        newB = newB >= 255 ? 255 : newB;
                        int newA = (int)vImg1A[x, y] + fator;
                        newA = newA >= 255 ? 255 : newA;

                        newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                        addImage.SetPixel(x, y, newColor);
                    }
                }

                pictureBox3.Image = addImage;
            } else
            {
                int x, y;

                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {

                        Color newColor = new Color();
                        int newR = (int)vImg1R[x, y] + (int)vImg2R[x, y];
                        newR = newR >= 255 ? 255 : newR;
                        int newG = (int)vImg1G[x, y] + (int)vImg2G[x, y];
                        newG = newG >= 255 ? 255 : newG;
                        int newB = (int)vImg1B[x, y] + (int)vImg2B[x, y];
                        newB = newB >= 255 ? 255 : newB;
                        int newA = (int)vImg1A[x, y] + (int)vImg2A[x, y];
                        newA = newA >= 255 ? 255 : newA;

                        newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                        addImage.SetPixel(x, y, newColor);
                    }
                }

                pictureBox3.Image = addImage;
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            Bitmap subtImage = (Bitmap)pictureBox1.Image;
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            Bitmap image2 = (Bitmap)pictureBox2.Image;

            if (Convert.ToInt32(bright.Value) != 10)
            {
                int fator = (Convert.ToInt32(bright.Value) * 10);

                int x, y;

                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {

                        Color newColor = new Color();
                        int newR = (int)vImg1R[x, y] - fator;
                        newR = newR <= 0 ? 0 : newR;
                        int newG = (int)vImg1G[x, y] - fator;
                        newG = newG <= 0 ? 0 : newG;
                        int newB = (int)vImg1B[x, y] - fator;
                        newB = newB <= 0 ? 0 : newB;
                        int newA = (int)vImg1A[x, y] - fator;
                        newA = newA <= 0 ? 0 : newA;

                        newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                        subtImage.SetPixel(x, y, newColor);
                    }
                }

                pictureBox3.Image = subtImage;
            }
            else
            {
                int x, y;

                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {

                        Color newColor = new Color();
                        int newR = (int)vImg1R[x, y] - (int)vImg2R[x, y];
                        newR = newR <= 0 ? 0 : newR;
                        int newG = (int)vImg1G[x, y] - (int)vImg2G[x, y];
                        newG = newG <= 0 ? 0 : newG;
                        int newB = (int)vImg1B[x, y] - (int)vImg2B[x, y];
                        newB = newB <= 0 ? 0 : newB;
                        int newA = (int)vImg1A[x, y] - (int)vImg2A[x, y];
                        newA = newA <= 0 ? 0 : newA;

                        newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                        subtImage.SetPixel(x, y, newColor);
                    }
                }

                pictureBox3.Image = subtImage;
            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            Bitmap multiImage = (Bitmap)pictureBox1.Image;
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            double fator = 1.0;
            if (multiplicacaoInput.Text != "") fator = Convert.ToDouble(multiplicacaoInput.Text);

            int x, y;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {

                    Color newColor = new Color();
                    int newR = (int)((int)vImg1R[x, y] * fator);
                    newR = newR >= 255 ? 255 : newR;
                    int newG = (int)((int)vImg1G[x, y] * fator);
                    newG = newG >= 255 ? 255 : newG;
                    int newB = (int)((int)vImg1B[x, y] * fator);
                    newB = newB >= 255 ? 255 : newB;
                    int newA = (int)((int)vImg1A[x, y] * fator);
                    newA = newA >= 255 ? 255 : newA;

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    multiImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = multiImage;
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            Bitmap divisImage = (Bitmap)pictureBox1.Image;
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            double fator = 1.0;
            if (divisaoInput.Text != "") fator = Convert.ToDouble(divisaoInput.Text);

            int x, y;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {

                    Color newColor = new Color();
                    int newR = (int)((int)vImg1R[x, y] / fator);
                    newR = newR <= 0 ? 0 : newR;
                    int newG = (int)((int)vImg1G[x, y] / fator);
                    newG = newG <= 0 ? 0 : newG;
                    int newB = (int)((int)vImg1B[x, y] / fator);
                    newB = newB <= 0 ? 0 : newB;
                    int newA = (int)((int)vImg1A[x, y] / fator);
                    newA = newA <= 0 ? 0 : newA;

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    divisImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = divisImage;
        }

        private void btNOT_Click(object sender, EventArgs e)
        {
            Bitmap notImage = (Bitmap)pictureBox1.Image;
            int max = 255;
            Bitmap image1 = (Bitmap)pictureBox1.Image;

            int x, y;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {

                    Color newColor = new Color();
                    int newR = max - (int)vImg1R[x, y];
                    newR = newR <= 0 ? 0 : newR;
                    int newG = max - (int)vImg1G[x, y];
                    newG = newG <= 0 ? 0 : newG;
                    int newB = max - (int)vImg1B[x, y];
                    newB = newB <= 0 ? 0 : newB;
                    int newA = max - (int)vImg1A[x, y];
                    newA = newA <= 0 ? 0 : newA;

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    notImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = notImage;
        }

        private void btAND_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            int x, y;

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] & vImg2R[x, y];

                    int newG = vImg1G[x, y] & vImg2G[x, y];

                    int newB = vImg1B[x, y] & vImg2B[x, y];

                    int newA = vImg1A[x, y] & vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }

        private void btOR_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            int x, y;

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] | vImg2R[x, y];

                    int newG = vImg1G[x, y] | vImg2G[x, y];

                    int newB = vImg1B[x, y] | vImg2B[x, y];

                    int newA = vImg1A[x, y] | vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }

        private void btXOR_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            int x, y;

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] ^ vImg2R[x, y];

                    int newG = vImg1G[x, y] ^ vImg2G[x, y];

                    int newB = vImg1B[x, y] ^ vImg2B[x, y];

                    int newA = vImg1A[x, y] ^ vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }

        private void blending_Click(object sender, EventArgs e)
        {
            Bitmap blendImage = (Bitmap)pictureBox1.Image;
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            double fator = 1.0;
            if (blendingFactor.Text != "") fator = Convert.ToDouble(blendingFactor.Text);

            int x, y;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {

                    Color newColor = new Color();
                    int newR = (int)(fator * vImg1R[x, y] + (1 - fator) * vImg2R[x, y]);
                    int newG = (int)(fator * vImg1G[x, y] + (1 - fator) * vImg2G[x, y]);
                    int newB = (int)(fator * vImg1B[x, y] + (1 - fator) * vImg2B[x, y]);
                    int newA = (int)(fator * vImg1A[x, y] + (1 - fator) * vImg2A[x, y]);

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    blendImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = blendImage;
        }

        private void multiplicacaoInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (multiplicacaoInput.Text != "")
            {
                pictureBox2.Enabled = false;
                load2.Enabled = false;
            }
            else
            {
                pictureBox2.Enabled = true;
                load2.Enabled = true;
            }
        }

        private void divisaoInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (divisaoInput.Text != "")
            {
                pictureBox2.Enabled = false;
                load2.Enabled = false;
            }
            else
            {
                pictureBox2.Enabled = true;
                load2.Enabled = true;
            }
        }

        private void bright_ValueChanged(object sender, EventArgs e)
        {
            brightLabel.Text = (Convert.ToInt32(bright.Value) * 10).ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Bitmap finalImage = (Bitmap) pictureBox3.Image;

            finalImage.Save(System.Windows.Forms.Application.StartupPath
                + "\\img" + resultIndex + ".jpg");

            resultIndex++;

            MessageBox.Show("Imagem salva!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rgbToGrey_Click(object sender, EventArgs e)
        {

        }
    }
}
