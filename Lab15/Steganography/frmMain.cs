using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class frmMain : Form
    {
        string[,] redArr = new string[400, 400];
        string[,] greenArr = new string[400, 400];
        string[,] blueArr = new string[400, 400];

        public frmMain()
        {
            InitializeComponent();
        }

        Bitmap bmpOriginal, bmpCoded, bmpOpenedCoded;

        public String ReplaceLastBitOfByte(String S, Char C)
        {
            char[] arr = S.ToCharArray();
            arr[7] = C;
            return new string(arr);
        }

        private void btnOpenOriginalPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmpOriginal = new Bitmap(ofd.FileName);
                pbOriginalPic.Image = bmpOriginal;
            }

            for (int y = 0; y < bmpOriginal.Height; y++)
            {
                for (int x = 0; x < bmpOriginal.Width; x++)
                {
                    Color color = bmpOriginal.GetPixel(x, y);
                    redArr[x, y] = Convert.ToString(color.R, 2).PadLeft(8, '0');
                    greenArr[x, y] = Convert.ToString(color.G, 2).PadLeft(8, '0');
                    blueArr[x, y] = Convert.ToString(color.B, 2).PadLeft(8, '0');
                }
            }

            Bitmap colorBitmap = new Bitmap(bmpOriginal.Width, bmpOriginal.Height);

            for (int y = 0; y < bmpOriginal.Height; y++)
            {
                for (int x = 0; x < bmpOriginal.Width; x++)
                {
                    colorBitmap.SetPixel(x, y, Color.FromArgb(Convert.ToInt32(redArr[x, y][7].ToString()) * 255, Convert.ToInt32(greenArr[x, y][7].ToString()) * 255, Convert.ToInt32(blueArr[x, y][7].ToString()) * 255));
                }
            }

            colorImage1.Image = colorBitmap;
        }

        private void btnWriteTextInPic_Click(object sender, EventArgs e)
        {
            String Message_Binary = "";

            Int32 k = 0;
            Color color;

            Int32 red;
            Int32 green;
            Int32 blue;

            String Red_Binary;
            String Green_Binary;
            String Blue_Binary;


            foreach (char c in tbInputText.Text)
            {
                Message_Binary = Message_Binary + (Convert.ToString(c, 2).PadLeft(13, '0'));
            }

            bmpCoded = new Bitmap(bmpOriginal);


            Int32 Text_Len = tbInputText.Text.Length;

            String Text_Len_binary = Convert.ToString(Text_Len, 2).PadLeft(bmpOriginal.Width, '0');

            for (int i = 0; i < bmpCoded.Width ; i++)
            {
                color = bmpCoded.GetPixel(i, 0);

                Red_Binary = Convert.ToString(color.R, 2).PadLeft(8, '0');
                Red_Binary = ReplaceLastBitOfByte(Red_Binary, Text_Len_binary[i]);
                red = Convert.ToInt32(Red_Binary, 2);
                   
                bmpCoded.SetPixel(i, 0, Color.FromArgb(red, color.G, color.B));
            }


            for (int i = 0; i < bmpCoded.Width && k < Message_Binary.Length; i++)
            {
                for (int j = 1; j < bmpCoded.Height && k < Message_Binary.Length; j++)
                {
                    color = bmpCoded.GetPixel(i, j);

                    Red_Binary = Convert.ToString(color.R, 2).PadLeft(8, '0');
                    Red_Binary = ReplaceLastBitOfByte(Red_Binary, Message_Binary[k]);
                    red = Convert.ToInt32(Red_Binary, 2);
                    k++;
                    if (k >= Message_Binary.Length)
                    {
                        bmpCoded.SetPixel(i, j, Color.FromArgb(red, color.G, color.B));
                        break;
                    }

                    Green_Binary = Convert.ToString(color.G, 2).PadLeft(8, '0');
                    Green_Binary = ReplaceLastBitOfByte(Green_Binary, Message_Binary[k]);
                    green = Convert.ToInt32(Green_Binary, 2);
                    k++;
                    if (k >= Message_Binary.Length)
                    {
                        bmpCoded.SetPixel(i, j, Color.FromArgb(red, green, color.B));
                        break;
                    }

                    Blue_Binary = Convert.ToString(color.B, 2).PadLeft(8, '0');
                    Blue_Binary = ReplaceLastBitOfByte(Blue_Binary, Message_Binary[k]);
                    blue = Convert.ToInt32(Blue_Binary, 2);
                    k++;
                    
                    bmpCoded.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }


            int jj = bmpCoded.Height - 1;

            for (int i = 0; i < bmpCoded.Width ; i++)
            {
                color = bmpCoded.GetPixel(i, jj);

                Green_Binary = Convert.ToString(color.G, 2).PadLeft(8, '0');

                if(i%2 == 0)
                {
                    Green_Binary = ReplaceLastBitOfByte(Green_Binary, '0');
                }
                else
                {
                    Green_Binary = ReplaceLastBitOfByte(Green_Binary, '1'); 
                }
                
                green = Convert.ToInt32(Green_Binary, 2);
                
                bmpCoded.SetPixel(i, jj, Color.FromArgb(color.R, green, color.B));                
            }
            

            pbCodedPic.Image = bmpCoded;



            for (int y = 0; y < bmpCoded.Height; y++)
            {
                for (int x = 0; x < bmpCoded.Width; x++)
                {
                    redArr[x, y] = Convert.ToString(bmpCoded.GetPixel(x, y).R, 2).PadLeft(8, '0');
                    greenArr[x, y] = Convert.ToString(bmpCoded.GetPixel(x, y).G, 2).PadLeft(8, '0');
                    blueArr[x, y] = Convert.ToString(bmpCoded.GetPixel(x, y).B, 2).PadLeft(8, '0');
                }
            }

            Bitmap colorBitmap = new Bitmap(bmpCoded.Width, bmpCoded.Height);

            for (int y = 0; y < bmpCoded.Height; y++)
            {
                for (int x = 0; x < bmpCoded.Width; x++)
                {
                    colorBitmap.SetPixel(x, y, Color.FromArgb(Convert.ToInt32(redArr[x, y][7].ToString()) * 255, Convert.ToInt32(greenArr[x, y][7].ToString()) * 255, Convert.ToInt32(blueArr[x, y][7].ToString()) * 255));
                }
            }

            colorImage2.Image = colorBitmap;
        }


        private void btnSaveCodedPic_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Bmp;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbCodedPic.Image.Save(sfd.FileName, format);
            }
        }


        private void btnOpenCodedPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open Coded Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmpOpenedCoded = new Bitmap(ofd.FileName);
                pbOpenedCodedPic.Image = bmpOpenedCoded;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCodedPic_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }


        private void btnReadTextFromPic_Click(object sender, EventArgs e)
        {
            Int32 Text_Len;

            String Text_Len_Binary = "";
            String OutPutText = "";
            String OutPutText_Binary = "";
            String[] OutPutText_Binary_Splited;

            Int32 k = 0;
            Color color;

            Int32 red;
            Int32 green;
            Int32 blue;

            String Red_Binary;
            String Green_Binary;
            String Blue_Binary;

            Boolean flag = true;


            int jj = bmpOpenedCoded.Height - 1;

            for (int i = 0; i < bmpOpenedCoded.Width ; i++)
            {
                color = bmpOpenedCoded.GetPixel(i, jj);

                Green_Binary = Convert.ToString(color.G, 2).PadLeft(8, '0');

                if (i % 2 == 0)
                {
                    if(Green_Binary[7] != '0')
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    if (Green_Binary[7] != '1')
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if(flag == true)
            { 


                for (int i = 0; i < bmpOpenedCoded.Width ; i++)
                {
                    color = bmpOpenedCoded.GetPixel(i, 0);

                    Red_Binary = Convert.ToString(color.R, 2).PadLeft(8, '0');

                    Text_Len_Binary += Red_Binary[7];
                }

                Text_Len = Convert.ToInt32(Text_Len_Binary, 2);


                for (int i = 0; i < bmpOpenedCoded.Width && k < Text_Len * 13; i++)
                {
                    for (int j = 1; j < bmpOpenedCoded.Height && k < Text_Len * 13; j++)
                    {
                        color = bmpOpenedCoded.GetPixel(i, j);

                        Red_Binary = Convert.ToString(color.R, 2).PadLeft(8, '0');
                        OutPutText_Binary += Red_Binary[7];

                        k++;
                        if (k >= Text_Len * 13)
                        {
                            break;
                        }

                        Green_Binary = Convert.ToString(color.G, 2).PadLeft(8, '0');
                        OutPutText_Binary += Green_Binary[7];

                        k++;
                        if (k >= Text_Len * 13)
                        {
                            break;
                        }

                        Blue_Binary = Convert.ToString(color.B, 2).PadLeft(8, '0');
                        OutPutText_Binary += Blue_Binary[7];
                        k++;
                    }
                }

                OutPutText_Binary_Splited = Split(OutPutText_Binary, 13).ToArray();

                Int32[] OutPutText_Splited = new Int32[OutPutText_Binary_Splited.Length];

                int index = 0;

                foreach (String Character_Binary in OutPutText_Binary_Splited)
                    OutPutText_Splited[index++] = Convert.ToInt32(Character_Binary, 2);

                foreach (Int32 Character in OutPutText_Splited)
                    OutPutText += (char)Character;

                tbOutputText.Text = OutPutText;
            }
            else
            {
                tbOutputText.Text = "��������� ���!";
            }
        }
    }
}
