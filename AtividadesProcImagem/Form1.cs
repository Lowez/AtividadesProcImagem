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
using System.Windows.Forms.DataVisualization.Charting;

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

            if (Convert.ToInt32(bright.Value) != 0)
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

            if (Convert.ToInt32(bright.Value) != 0)
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
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            Bitmap image2 = (Bitmap)pictureBox2.Image;

            if (image1 == null || image2 == null)
            {
                MessageBox.Show("Selecione duas imagens.");
                return;
            }

            if (image1.Width != image2.Width || image1.Height != image2.Height || image1.PixelFormat != image2.PixelFormat)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho e formato.");
            }

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (image1 != null)
                    {

                        //Greyscale
                        int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                        //1bit
                        if (grey >= 128) grey = 255;
                        else if (grey < 128) grey = 0;

                        Color p = Color.FromArgb(grey, grey, grey);

                        vImg1R[i, j] = (byte)grey;
                        vImg1G[i, j] = (byte)grey;
                        vImg1B[i, j] = (byte)grey;

                        image1.SetPixel(i, j, p);
                    }

                    if (image2 != null)
                    {

                        //Greyscale
                        int grey = (vImg2R[i, j] + vImg2G[i, j] + vImg2B[i, j]) / 3;

                        //1bit
                        if (grey >= 128) grey = 255;
                        else if (grey < 128) grey = 0;

                        vImg2R[i, j] = (byte)grey;
                        vImg2G[i, j] = (byte)grey;
                        vImg2B[i, j] = (byte)grey;

                        Color p = Color.FromArgb(grey, grey, grey);



                        image2.SetPixel(i, j, p);
                    }
                }
            }

            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
        }

        private void applySDBIS(Bitmap image1)
        {
            // To do
        }

        private void applyNegativo(Bitmap image1)
        {
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem no primeiro campo");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color cor1 = ((Bitmap)image1).GetPixel(i, j);
                    int novoR = 255 - Math.Min(255, Math.Max(0, cor1.R + cor1.R));
                    int novoG = 255 - Math.Min(255, Math.Max(0, cor1.G + cor1.G));
                    int novoB = 255 - Math.Min(255, Math.Max(0, cor1.B + cor1.B));

                    Color novaCor = Color.FromArgb(novoR, novoG, novoB);
                    image3.SetPixel(i, j, novaCor);
                }
            }

            pictureBox3.Image = image3;
        }

        private void applyEqualizacao(Bitmap image1)
        {
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            int width = image1.Width;
            int height = image1.Height;

            int[] pixelIntensityRate = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int y = 0; y < height; y++)
                {
                    //A imagem deve ser em greyscale, portanto, qualquer pixel vale
                    int pixelVal = image1.GetPixel(i, y).R;
                    pixelIntensityRate[pixelVal]++;
                }
            }

            double[] CFD = new double[256];
            int pixelsCount = width * width;
            CFD[0] = pixelIntensityRate[0] / (double)pixelsCount;
            for (int i = 1; i < 256; i++)
            {
                CFD[i] = CFD[i - 1] + pixelIntensityRate[i] / (double)pixelsCount;
            }


            byte[,] finalImg = new byte[width, height];

            int[] finalPixelRate = new int[256];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int pixel = vImg1Gray[i, j];
                    finalImg[i, j] = (byte)Math.Round(CFD[pixel] * 255.0);
                    finalPixelRate[finalImg[i, j]]++;
                }
            }

            histogramaOriginal.Series.Clear();
            histogramaOriginal.Series.Add("Histograma A");
            histogramaOriginal.Series["Histograma A"].ChartType = SeriesChartType.Column;
            histogramaOriginal.Series["Histograma A"].Points.DataBindY(pixelIntensityRate);
            histogramaOriginal.ChartAreas[0].AxisY.Maximum = pixelIntensityRate.Max() + 10;

            histogramaEqualizado.Series.Clear();
            histogramaEqualizado.Series.Add("Resultado");
            histogramaEqualizado.Series["Resultado"].ChartType = SeriesChartType.Column;
            histogramaEqualizado.Series["Resultado"].Points.DataBindY(finalPixelRate);
            histogramaEqualizado.ChartAreas[0].AxisY.Maximum = finalPixelRate.Max() + 10;

            for (int i = 0; i < image3.Width; i++)
            {
                for (int j = 0; j < image3.Height; j++)
                {
                    byte color = finalImg[i, j];
                    Color p = Color.FromArgb(255, color, color, color);

                    image3.SetPixel(i, j, p);
                }
            }

            pictureBox3.Image = image3;
        }

        private void btAplicarMelhoria_Click(object sender, EventArgs e)
        {
            String SDBIS = "SDBIS";
            String Negativo = "Negativo";
            String Equalizacao = "Equalização de Histograma";

            Bitmap image1 = (Bitmap)pictureBox1.Image;

            if (cbMelhorias.SelectedIndex != -1)
            {
                if (cbMelhorias.Text == SDBIS)
                {
                    applySDBIS(image1);
                }
                else if (cbMelhorias.Text == Negativo)
                {
                    applyNegativo(image1);
                }
                else if (cbMelhorias.Text == Equalizacao)
                {
                    applyEqualizacao(image1);
                }
            }
        }

        private void filtroMax(Bitmap image1)
        {
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            for (int i = 1; i < image1.Width - 1; i++)
            {
                for (int j = 1; j < image1.Height - 1; j++)
                {

                    if (image1 != null)
                    {

                        //Greyscale
                        int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                        Color p = Color.FromArgb(grey, grey, grey);

                        vImg1R[i, j] = (byte)grey;
                        vImg1G[i, j] = (byte)grey;
                        vImg1B[i, j] = (byte)grey;

                        image1.SetPixel(i, j, p);
                    }

                    byte[] mask = new byte[9];
                    for (int w = 0; w < mask.Length; w++)
                        mask[w] = 1;

                    mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
                    mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
                    mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

                    mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
                    mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
                    mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

                    mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
                    mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
                    mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);


                    byte max = mask.Max();
                    Color p2 = Color.FromArgb(max, max, max);

                    image3.SetPixel(i, j, p2);
                }
            }

            pictureBox3.Image = image3;
        }

        private void filtroMin(Bitmap image1)
        {
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            for (int i = 1; i < image1.Width - 1; i++)
            {
                for (int j = 1; j < image1.Height - 1; j++)
                {

                    if (image1 != null)
                    {

                        //Greyscale
                        int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                        Color p = Color.FromArgb(grey, grey, grey);

                        vImg1R[i, j] = (byte)grey;
                        vImg1G[i, j] = (byte)grey;
                        vImg1B[i, j] = (byte)grey;

                        image1.SetPixel(i, j, p);
                    }

                    byte[] mask = new byte[9];
                    for (int w = 0; w < mask.Length; w++)
                        mask[w] = 1;

                    mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
                    mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
                    mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

                    mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
                    mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
                    mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

                    mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
                    mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
                    mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);


                    byte min = mask.Min();
                    Color p2 = Color.FromArgb(min, min, min);

                    image3.SetPixel(i, j, p2);
                }
            }

            pictureBox3.Image = image3;
        }

        private void filtroMean(Bitmap image1)
        {
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            for (int i = 1; i < image1.Width - 1; i++)
            {
                for (int j = 1; j < image1.Height - 1; j++)
                {

                    if (image1 != null)
                    {

                        //Greyscale
                        int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                        Color p = Color.FromArgb(grey, grey, grey);

                        vImg1R[i, j] = (byte)grey;
                        vImg1G[i, j] = (byte)grey;
                        vImg1B[i, j] = (byte)grey;

                        image1.SetPixel(i, j, p);
                    }

                    byte[] mask = new byte[9];
                    for (int w = 0; w < mask.Length; w++)
                        mask[w] = 1;

                    mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
                    mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
                    mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

                    mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
                    mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
                    mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

                    mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
                    mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
                    mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);

                    int acc = 0;
                    for (int k = 0; k < mask.Length; k++)
                    {
                        acc += mask[k];
                    }

                    byte mean = (byte)(acc / 9);

                    Color p2 = Color.FromArgb(mean, mean, mean);

                    image3.SetPixel(i, j, p2);
                }
            }

            pictureBox3.Image = image3;
        }

        private void btAplicarFiltros_Click(object sender, EventArgs e)
        {
            String max = "Max";
            String min = "Min";
            String media = "Mean(Media)";

            Bitmap image1 = (Bitmap)pictureBox1.Image;

            if (cbFiltros.SelectedIndex != -1)
            {
                if (cbFiltros.Text == max)
                {
                    filtroMax(image1);
                }
                else if (cbFiltros.Text == min)
                {
                    filtroMin(image1);
                }
                else if (cbFiltros.Text == media)
                {
                    filtroMean(image1);
                }
            }
        }

        private void btRBGto8bits_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            Bitmap image2 = (Bitmap)pictureBox2.Image;

            if (image1 == null || image2 == null)
            {
                MessageBox.Show("Selecione duas imagens.");
                return;
            }

            if (image1.Width != image2.Width || image1.Height != image2.Height || image1.PixelFormat != image2.PixelFormat)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho e formato.");
            }

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    if (image1 != null)
                    {

                        //Greyscale
                        int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                        Color p = Color.FromArgb(grey, grey, grey);

                        vImg1R[i, j] = (byte)grey;
                        vImg1G[i, j] = (byte)grey;
                        vImg1B[i, j] = (byte)grey;

                        image1.SetPixel(i, j, p);
                    }

                    if (image2 != null)
                    {

                        //Greyscale
                        int grey = (vImg2R[i, j] + vImg2G[i, j] + vImg2B[i, j]) / 3; ;

                        vImg2R[i, j] = (byte)grey;
                        vImg2G[i, j] = (byte)grey;
                        vImg2B[i, j] = (byte)grey;

                        Color p = Color.FromArgb(grey, grey, grey);



                        image2.SetPixel(i, j, p);
                    }
                }
            }

            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
        }

        private void btToDouble_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            Bitmap image2 = (Bitmap)pictureBox2.Image;

            if (image1 == null || image2 == null)
            {
                MessageBox.Show("Selecione duas imagens.");
                return;
            }

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    // To do
                }
            }
        }
    }
}
