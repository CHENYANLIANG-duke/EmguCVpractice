using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Runtime.InteropServices;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Text;
using System.Diagnostics;
using FaceDetection;
using Emgu.CV.UI;
using Emgu.CV.Cuda;

namespace CVpractice
{
    public partial class Form1 : Form
    {
        private Tesseract _ocr;

        public Form1()
        {
            InitializeComponent();

        }
        Image<Bgr, Byte> img;
        Image<Gray, Byte> imgDst;
        Image<Gray, Byte> imgLBP;
        Image<Gray, Byte> newimgLBP;
        String datapath = @"D:\abc.csv";


        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;

                //  img = new Image<Bgr, byte>(txtPath.Text).Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);
                img = new Image<Bgr, Byte>(txtPath.Text);
                imageBox1.Image = img;
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            imgDst = img.Convert<Gray, byte>();

            imageBox2.Image = imgDst;
        }

        private void btnGetRedChanel_Click(object sender, EventArgs e)
        {
            // remove blue and green channels, ie. only red channel is saved
            int[] zeroCHs = new int[2] { 0, 1 };

            Image<Gray, byte>[] channels;
            Mat outMat = new Mat();
            channels = img.Split();    // img: original image(color)
            for (int i = 0; i < 2; i++)
                channels[zeroCHs[i]].SetZero();

            using (VectorOfMat vm = new VectorOfMat(channels[0].Mat, channels[1].Mat, channels[2].Mat))
            {
                CvInvoke.Merge(vm, outMat);
            }
            imageBox2.Image = outMat;
        }

        private void btnThreshold_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> GRAY = img.Convert<Gray, byte>();
            Image<Gray, Byte> adaptivethreshimg = new Image<Gray, Byte>(img.Width, img.Height);
            CvInvoke.Threshold(GRAY, adaptivethreshimg, 100, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            imageBox2.Image = adaptivethreshimg;
        }

        private void btnLaplacian_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> LaplacianImg = new Image<Gray, byte>(img.Width, img.Height);
            CvInvoke.Canny(img, LaplacianImg, 50, 150, 3, false);

            imageBox2.Image = LaplacianImg;
        }

        private void btnCalcHist_Click(object sender, EventArgs e)
        {
            // histogramBox1.GenerateHistograms(img, 256);
            //histogramBox1.Refresh();
            //用這種方式產生出來的直方圖數據沒有辦法被程式拿來利用。

            //這種時候要用到DenseHistogram這個class

            DenseHistogram DenImage = new DenseHistogram(256, new RangeF(0, 256));
            float[] bluehist;
            DenImage.Calculate(new Image<Gray, byte>[] { imgDst }, false, null);
            bluehist = DenImage.GetBinValues();
            histogramBox1.AddHistogram("像素值", Color.Black, DenImage, 256, new float[] { 0, 256 });
            histogramBox1.Refresh();

        }

        private void btnPryUp_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> UpImage = img.PyrUp();
            imageBox2.Image = UpImage;
        }

        private void btnPryDown_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> UpImage = img.PyrDown();
            imageBox2.Image = UpImage;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            //如果是要擷取、切割影像中的單一前景物件，GrabCut將會是非常適合的方法

            //define bounding rectangle
            //the pixels outside this rectangle
            //will be labeled as background
            Rectangle rect = new Rectangle(100, 200, 300, 300);
            //GrabCut segmentation
            Image<Gray, Byte> mask = img.GrabCut(rect, 5);
            //Generate output image
            Image<Bgr, Byte> result = img.Copy(mask);

            imageBox2.Image = result;


        }

        private void btn_findred_Click(object sender, EventArgs e)
        {
            Image<Hsv, Byte> Hsvimage = img.Convert<Hsv, Byte>();

            // Image<Gray, Byte>[] HSVimages = Hsvimage.Split();

            Hsv lowerLimit = new Hsv(0, 10, 10);
            Hsv upperLimit = new Hsv(40, 245, 245);

            var imageHSVDest = Hsvimage.InRange(lowerLimit, upperLimit);

            imageBox2.Image = imageHSVDest;

            //Image<Gray, Byte> lowSatnMask = HSVimages[0].ThresholdBinary(new Gray(130), new Gray(255));

            //  imageBox2.Image = lowSatnMask;

        }

        private void btnLP_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> GRAY = img.Convert<Gray, byte>();
            Image<Gray, Byte> medianBlurimg = new Image<Gray, Byte>(img.Width, img.Height);

            CvInvoke.MedianBlur(GRAY, medianBlurimg, 3);

            imageBox2.Image = medianBlurimg;

        }

        private void btnWord_Click(object sender, EventArgs e)
        {

            float[,] matrixKernel = new float[3, 3] {
                  { 0,-1, 0 },
                  {-1, 5,-1 },
                  { 0,-1, 0 } };

            ConvolutionKernelF kernel = new ConvolutionKernelF(matrixKernel);

            Image<Gray, float> result = img.Convert<Gray, float>().Convolution(kernel);

            Image<Gray, Byte> GRAYResult = result.Convert<Gray, Byte>();

            imageBox2.Image = GRAYResult;

            //file to d:

            StreamWriter sw = File.CreateText(datapath);

            for (int y = 0; y < GRAYResult.Cols; y++)
            {
                for (int x = 0; x < GRAYResult.Rows; x++)
                {
                    string pixel = GRAYResult.Data[x, y, 0].ToString() + ";";

                    sw.Write(pixel);
                }
            }

            sw.Close();


        }

        private Image<Gray, Byte> Sharpen(Image<Gray, Byte> image)
        {
            Image<Gray, Byte> result = image.CopyBlank(); //copy a blank image

            MIplImage MIpImg = (MIplImage)System.Runtime.InteropServices.Marshal.PtrToStructure(image.Ptr, typeof(MIplImage));
            MIplImage MIpImgResult = (MIplImage)System.Runtime.InteropServices.Marshal.PtrToStructure(result.Ptr, typeof(MIplImage));

            int imageHeight = MIpImg.Height;
            int imageWidth = MIpImg.Width;
            unsafe
            {
                for (int height = 1; height < imageHeight - 1; height++)
                {
                    //current_pixel line
                    byte* currentPixel = (byte*)MIpImg.ImageData + imageWidth * height;
                    //up_pixel line
                    byte* uplinePixel = currentPixel - MIpImg.WidthStep;
                    //down_pixel line
                    byte* downlinePixel = currentPixel + MIpImg.WidthStep;
                    //result current_pixel line
                    byte* resultPixel = (byte*)MIpImgResult.ImageData + imageWidth * height;

                    for (int width = 1; width < imageWidth - 1; width++)
                    {
                        //5*current_pixel-left_pixel-right_pixel-up_pixel-down_pixel
                        int sharpValue = 5 * currentPixel[width] - currentPixel[width - 1]
                                            - currentPixel[width + 1] - uplinePixel[width]
                                            - downlinePixel[width];

                        if (sharpValue < 0) sharpValue = 0;     //Gray level 0~255
                        if (sharpValue > 255) sharpValue = 255; //Gray level 0~255

                        resultPixel[width] = (byte)sharpValue;
                    }
                }
            }

            //  imageBox2.Image = result;
            imgDst = result;

            return result;
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> GRAY = img.Convert<Gray, byte>();

            Sharpen(GRAY);

            imageBox2.Image = imgDst;
        }


        private void btnLbp_Click(object sender, EventArgs e)
        {
            imgDst = img.Convert<Gray, Byte>();
            imgLBP = new Image<Gray, byte>(img.Cols, img.Rows);

            byte[,] padding = new byte[img.Rows + 2, img.Cols + 2];

            // image to array
            for (int row = 1; row < imgDst.Rows + 1; ++row)
            {
                for (int col = 1; col < imgDst.Cols + 1; ++col)
                {
                    padding[row, col] = imgDst.Data[row - 1, col - 1, 0];
                }
            }

            // cacluate lbp
            double[] LBP = new double[8];

            for (int x = 1; x < imgDst.Rows - 1; x++)
            {
                for (int y = 1; y < imgDst.Cols - 1; y++)
                {
                    Byte center = padding[x, y];
                    LBP[0] = padding[x - 1, y - 1];
                    LBP[1] = padding[x, y - 1];
                    LBP[2] = padding[x + 1, y - 1];
                    LBP[3] = padding[x + 1, y];
                    LBP[4] = padding[x + 1, y + 1];
                    LBP[5] = padding[x, y + 1];
                    LBP[6] = padding[x - 1, y + 1];
                    LBP[7] = padding[x - 1, y];

                    Byte temp = 0;

                    // 计算LBP的值
                    for (int k = 0; k < 8; k++)
                    {
                        if (LBP[k] > center)
                        {
                            //temp +=  Math.Pow(2, k);
                            temp |= (Byte)(1 << k);
                        }
                    }
                    imgLBP.Data[x, y, 0] = temp;
                }//for x  
            }//for y

            imageBox2.Image = imgLBP;
        }

        private void btnSLBP_Click(object sender, EventArgs e)
        {
            imgDst = img.Convert<Gray, Byte>();
            imgLBP = new Image<Gray, byte>(img.Cols, img.Rows);

            byte[,] padding = new byte[img.Rows + 2, img.Cols + 2];

            // image to array
            for (int row = 1; row < imgDst.Rows + 1; ++row)
            {
                for (int col = 1; col < imgDst.Cols + 1; ++col)
                {
                    padding[row, col] = imgDst.Data[row - 1, col - 1, 0];
                }
            }

            // cacluate lbp
            double[] LBP = new double[8];

            for (int x = 1; x < imgDst.Rows - 1; x++)
            {
                for (int y = 1; y < imgDst.Cols - 1; y++)
                {
                    Byte center = padding[x, y];
                    LBP[0] = padding[x - 1, y - 1];
                    LBP[1] = padding[x, y - 1];
                    LBP[2] = padding[x + 1, y - 1];
                    LBP[3] = padding[x + 1, y];
                    LBP[4] = padding[x + 1, y + 1];
                    LBP[5] = padding[x, y + 1];
                    LBP[6] = padding[x - 1, y + 1];
                    LBP[7] = padding[x - 1, y];

                    Byte temp = 0;

                    // 计算LBP的值

                    if ((Math.Abs(LBP[1] - LBP[7]) / center) - 0.1 > 0)
                    {
                        temp |= (Byte)(1 << 0);
                    }

                    for (int k = 1; k < 7; k++)
                    {
                        if ((Math.Abs(LBP[k + 1] - LBP[k - 1]) / center) - 0.1 > 0)
                        {
                            //temp +=  Math.Pow(2, k);
                            temp |= (Byte)(1 << k);
                        }
                    }

                    if ((Math.Abs(LBP[6] - LBP[0]) / center) - 0.1 > 0)
                    {
                        temp |= (Byte)(1 << 7);
                    }

                    imgLBP.Data[x, y, 0] = temp;
                }//for x  
            }//for y

            imageBox2.Image = imgLBP;
        }

        private void btnasLBP_Click(object sender, EventArgs e)
        {
            imgDst = img.Convert<Gray, Byte>();
            imgLBP = new Image<Gray, byte>(img.Cols, img.Rows);

            byte[,] padding = new byte[img.Rows + 2, img.Cols + 2];

            // image to array
            for (int row = 1; row < imgDst.Rows + 1; ++row)
            {
                for (int col = 1; col < imgDst.Cols + 1; ++col)
                {
                    padding[row, col] = imgDst.Data[row - 1, col - 1, 0];
                }
            }

            // cacluate lbp
            double[] LBP = new double[8];

            for (int x = 1; x < imgDst.Rows - 1; x++)
            {
                for (int y = 1; y < imgDst.Cols - 1; y++)
                {
                    Byte center = padding[x, y];
                    LBP[0] = padding[x - 1, y - 1];
                    LBP[1] = padding[x, y - 1];
                    LBP[2] = padding[x + 1, y - 1];
                    LBP[3] = padding[x + 1, y];
                    LBP[4] = padding[x + 1, y + 1];
                    LBP[5] = padding[x, y + 1];
                    LBP[6] = padding[x - 1, y + 1];
                    LBP[7] = padding[x - 1, y];

                    Byte temp = 0;

                    // 计算LBP的值

                    if ((Math.Abs(LBP[1] - LBP[7]) / center) - 1 > 0)
                    {
                        temp |= (Byte)(1 << 0);
                    }

                    for (int k = 1; k < 7; k++)
                    {
                        if ((Math.Abs(LBP[k + 1] - LBP[k - 1]) / center) - Math.Pow(0.1, k) > 0)
                        {
                            //temp +=  Math.Pow(2, k);
                            temp |= (Byte)(1 << k);
                        }
                    }

                    if ((Math.Abs(LBP[6] - LBP[0]) / center) - Math.Pow(0.1, 7) > 0)
                    {
                        temp |= (Byte)(1 << 7);
                    }

                    imgLBP.Data[x, y, 0] = temp;
                }//for x  
            }//for y

            imageBox2.Image = imgLBP;
        }

        private void btnOutLBP_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(datapath);

            for (int y = 0; y < imgLBP.Cols; y++)
            {
                for (int x = 0; x < imgLBP.Rows; x++)
                {
                    string pixel = imgLBP.Data[x, y, 0].ToString() + ";";

                    sw.Write(pixel);
                }
            }

            sw.Close();

        }

        private void btnLTP_Click(object sender, EventArgs e)
        {
            imgDst = img.Convert<Gray, Byte>();
            imgLBP = new Image<Gray, byte>(img.Cols, img.Rows);

            byte ltp_threshold = 10; //threshold

            byte[,] padding = new byte[img.Rows + 2, img.Cols + 2];

            // image to array
            for (int row = 1; row < imgDst.Rows + 1; ++row)
            {
                for (int col = 1; col < imgDst.Cols + 1; ++col)
                {
                    padding[row, col] = imgDst.Data[row - 1, col - 1, 0];
                }
            }

            // cacluate ltp
            double[] LTP = new double[8];

            for (int x = 1; x < imgDst.Rows - 1; x++)
            {
                for (int y = 1; y < imgDst.Cols - 1; y++)
                {
                    Byte center = padding[x, y];
                    LTP[0] = padding[x - 1, y - 1];
                    LTP[1] = padding[x, y - 1];
                    LTP[2] = padding[x + 1, y - 1];
                    LTP[3] = padding[x + 1, y];
                    LTP[4] = padding[x + 1, y + 1];
                    LTP[5] = padding[x, y + 1];
                    LTP[6] = padding[x - 1, y + 1];
                    LTP[7] = padding[x - 1, y];

                    Byte temp = 0;

                    // 计算LTP的值
                    for (int k = 0; k < 8; k++)
                    {

                        LTP[k] = LTP[k] - center;

                        ////upper pattern
                        //if (LTP[k] > ltp_threshold)
                        //{
                        //    temp |= (Byte)(1 << k);
                        //}

                        //lower pattern
                        if (LTP[k] < -ltp_threshold)
                        {
                            temp |= (Byte)(1 << k);
                        }

                    }
                    imgLBP.Data[x, y, 0] = temp;
                }//for x  
            }//for y

            imageBox2.Image = imgLBP;
        }
    }
}

