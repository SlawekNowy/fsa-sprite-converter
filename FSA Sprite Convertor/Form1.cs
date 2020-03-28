using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FSA_Sprite_Convertor
{
    public partial class Form1 : Form
    {
        //byte[] paletteData;

        public Form1()
        {
            InitializeComponent();
            textBoxPaletteNum.Text = "0";
        }

        private void buttonSpriteSheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseSpriteSheet = new OpenFileDialog();
            chooseSpriteSheet.Filter = "sch sprite sheet|*.szs";

            if (chooseSpriteSheet.ShowDialog() == DialogResult.OK)
            {
                textBoxSpriteSheet.Text = chooseSpriteSheet.FileName;

                if (textBoxPalette.Text != "")
                {
                    buttonConvert.Enabled = true;
                }
                else
                {
                    buttonConvert.Enabled = false;
                }
            }
        }

        private void buttonPalette_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePalette = new OpenFileDialog();
            choosePalette.Filter = "scl sprite palette|*.szs";

            if (choosePalette.ShowDialog() == DialogResult.OK)
            {
                textBoxPalette.Text = choosePalette.FileName;

                if (textBoxSpriteSheet.Text != "")
                {
                    buttonConvert.Enabled = true;
                }
                else
                {
                    buttonConvert.Enabled = false;
                }
            }
        }

        private byte[] PaletteColor(int pixel, byte[] inputPalette, int paletteNum)
        {
            byte[] color = new byte[4];

            pixel *= 2;
            paletteNum *= 32;

            int rawColorData = inputPalette[paletteNum + pixel] + (inputPalette[paletteNum + pixel + 1] << 8);
            color[0] = (byte)(((rawColorData & 0x7C00) >> 10) * 8);
            color[1] = (byte)(((rawColorData & 0x3E0) >> 5) * 8);
            color[2] = (byte)((rawColorData & 0x1F) * 8);
            color[3] = 0xff;

            return color;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            //Load SpriteSheet
            FileStream textureInputData = new FileStream(textBoxSpriteSheet.Text, FileMode.Open);

            int width = Convert.ToInt32(textBoxWidth.Text);

            int height = (int)((textureInputData.Length / width) * 2);
            textBoxHeight.Text = height.ToString();
            /*
            if ((textureInputData.Length % width) != 0 || width % 8 != 0)
            {
                textureInputData.Close();
                MessageBox.Show("Width must be a multiple of 8 and of the number of bytes in the sprite file");
                return;
            }
            */
            int textureOffset = Convert.ToInt32(textBoxTexOffset.Text);

            byte[] inputTexture = new byte[width * (height / 2)];
            textureInputData.Read(inputTexture, textureOffset, inputTexture.Length);

            textureInputData.Close();


            FileStream paletteInputData = new FileStream(textBoxPalette.Text, FileMode.Open);

            int paletteOffset = Convert.ToInt32(textBoxPaletteNum.Text);
            int paletteNum = Convert.ToInt32(numericUpDownPalette.Value);

            byte[] inputPalette = new byte[512];

            paletteInputData.Read(inputPalette, paletteOffset, 512);

            paletteInputData.Close();

            Bitmap bitmapOutput = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            int i = 0;
            //For every byte in the input file
            while (i < inputTexture.Length)
            {
                //Each 8x8 block uses 32 bytes
                int x = (i / 32) * 8;
                int y = 0;

                //If past the width of image drop it down and increment height
                while (x >= width)
                {
                    y += 8;
                    x -= width;
                }

                if (y == height)
                    break;

                //For each byte in the 8x8 tile
                for (int curY = 0; curY < 8; curY++)
                {
                    for (int curX = 0; curX < 4; curX++)
                    {
                        //Do low nibble
                        byte firstPixel = (byte)(inputTexture[i + curX + (curY * 4)] & 0x0F);

                        //Do high nibble
                        byte secondPixel = (byte)((inputTexture[i + curX + (curY * 4)] & 0xF0) >> 4);

                        byte[] colour = PaletteColor(firstPixel, inputPalette, paletteNum);
                        bitmapOutput.SetPixel(x + (curX * 2), y + curY, Color.FromArgb(colour[3], colour[2], colour[1], colour[0]));

                        colour = PaletteColor(secondPixel, inputPalette, paletteNum);
                        bitmapOutput.SetPixel(x + (curX * 2) + 1, y + curY, Color.FromArgb(colour[3], colour[2], colour[1], colour[0]));
                    }
                }

                //Next 8x8 tile
                i += 32;
            }


            pictureBoxSprites.Image = bitmapOutput;

            textureInputData.Close();

            if (checkBoxSave.Checked == true)
            {
                string outputFileName = textBoxSpriteSheet.Text + "_Texture-" + textureOffset + ".png";
                bitmapOutput.Save(outputFileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

    }
}
