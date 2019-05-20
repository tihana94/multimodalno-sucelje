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
using System.Drawing.Imaging;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Diagnostics;



namespace editor
{
    public partial class Editor : Form
    {


        //Deklaracija Forme
        
        public Editor()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }
        //za splash
        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        //metoda za otvorit sliku
        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }
        //metoda za spremit sliku
        void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Slika nije učitana, učitajte sliku!");
            }


        }
        //metoda za ponovno učitavanje slike
        void reload()
        {
            if (!opened)
            {
                //Message.Box("Otvori sliku!");
            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }
        //metode za uređivanje slika
        void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");   //ako slika nije učitana potrebno ju je otvoriti
            }
            else
            {

                Image img = pictureBox1.Image;   
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }
        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f+0.2f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.9f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }
        void filter1()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }


        }
        void redscale()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");     //ako slika nije učitana potrebno ju je otvoriti
            }
            else
            {

                Image img = pictureBox1.Image;       //pohraniti sliku iz pictureBox u img varijablu pomoću klase Image
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                //stvaramo bmpInverted pomoću Bitmap klase koju inicijaliziramo i prima dva parametra, širinu i visinu
                //učitane slike iz pictureBoxa

                ImageAttributes ia = new ImageAttributes(); //pravi objekt klase ImageAttributes ia da bi promijeniti atribute slike
                ColorMatrix cmPicture = new ColorMatrix(new float[][]     // zatim pravimo matricu boja koja je zapravo 5x5 matricu RGBAW boja
                {
                    new float[]{.393f, .349f, .272f, 0, 0}, //red
            new float[]{.769f, .686f, .534f, 0, 0}, //green
            new float[]{.189f, .168f, .131f, 0, 0}, //blue
            new float[]{0, 0, 0, 1, 0}, 
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture); //dodajemo matricu boja u objekt klase ImageAttributes
                Graphics g = Graphics.FromImage(bmpInverted); //kreiramo novi objekct klase Graphics nazvan g, zbog izmjena

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                //g.DrawImage(Image, new Rectangle(lokacija od rectangle(pravokutnika) po x-u, lokacija od pravokuntika po y, visina pravokutnika
                //širina pravokutnika), lokacija slike u pravokutniku po x-u, lokacija slika u pravokutniku po y-u, visina slike, širina slike,
                //format grafičke jedinice, objekt slike) 
                

                g.Dispose();                            //predstavlja sva sredstva korištena ovom Graphics
                pictureBox1.Image = bmpInverted;

            }

        }
        void grayscale()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }

        }
        void Winter()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }

        }
        void fog()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0.7f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }

        }
        void Flash()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }

        }
        void Frozen()
        {
            if (!opened)
            {
                MessageBox.Show("Otvori sliku!");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0f, 0, 0, 0},
            new float[]{0, 0, 1+5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }

        }
        void Hue()
        {
            float changered = redBar.Value * 0.1f;
            float changegreen = greenBar.Value * 0.1f;
            float changeblue = blueBar.Value * 0.1f;

            redvalue.Text = changered.ToString();
            greenvalue.Text = changeblue.ToString();
            bluevalue.Text = changegreen.ToString();

            reload();
            if (!opened)
            {
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+changered, 0, 0, 0, 0},
            new float[]{0, 1+changegreen, 0, 0, 0},
            new float[]{0, 0, 1+changeblue, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);


                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;


            }

        }







        Image file;
        Boolean opened = false; // da se checkira je li picture box otvoren ili ne


        private void button9_Click(object sender, EventArgs e)
        {
            openImage();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            saveImage();
        }





        private void redBar_Scroll(object sender, EventArgs e)
        {
            Hue();
        }

        private void greenBar_Scroll(object sender, EventArgs e)
        {
            Hue();
        }

        private void blueBar_Scroll(object sender, EventArgs e)
        {
            Hue();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clists = new Choices();
        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false; //tipka Start
            button14.Enabled = true; //tipka Stop
            clists.Add(new string[] { "thank you", "I want to open the picture that i am going to edit",
            "i want to save my picture", "I want to reload the picture", "i want to change the image filter in black and white",
            "Please change the image filter in the sepia", "I am interested in a dramatic image filter, so i want to apply in my picture",
            "I'm not happy with the choice of pictures on my computer so I would like to see what other pictures are on the internet",
            "i want to crop my picture", "i want to illuminate the picture", "i want to darken the picture",
            "i am interested in a frozen image filter",
            "i love winter very much and i want winter image filter", "I want a bit brighter picture", "i want to change the image filter in cocoa",
            "I want to intensify the red, green and blue colors in my picture",
            "I want to use the light in my picture"}); 
            Grammar gr = new Grammar(new GrammarBuilder(clists));
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "thank you":
                    ss.SpeakAsync("You are welcome");
                    break;
                case "I want to open the picture that i am going to edit":
                    ss.SpeakAsync("your desire is my command, please choose the picture");
                    openImage();
                    break;
                case "i want to save my picture":
                    ss.SpeakAsync("Yes sir, please choose the place where you will save the picture");
                    saveImage();
                    break;
                case "I want to reload the picture":
                    ss.SpeakAsync("Ok sir");
                    reload();
                    break;
                case "i want to change the image filter in black and white":
                    ss.SpeakAsync("it would be my pleasure");
                    grayscale();
                    break;
                case "Please change the image filter in the sepia":
                    ss.SpeakAsync("No problem");
                    redscale();
                    break;
                case "I am interested in a dramatic image filter, so i want to apply in my picture":
                    ss.SpeakAsync("ok sir");
                    filter3();
                    break;
                case "i want to change the image filter in cocoa":
                    ss.SpeakAsync("OK! i am sure you like chocolate");
                    filter1();
                    break;
                case "I'm not happy with the choice of pictures on my computer so I would like to see what other pictures are on the internet":
                    ss.SpeakAsync("ok i'll open you browser and find the picture you want");
                    Process.Start("chrome", "https://www.google.hr/search?q=slike&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjE65fS2YPdAhWho4sKHZFmDGMQ_AUICigB&biw=1409&bih=767");
                    break;
                case "i want to crop my picture":
                    ss.SpeakAsync("Ok! i will help you, but you need to enter the left and top margins");
                    break;
                case "I want to intensify the red, green and blue colors in my picture":
                    ss.SpeakAsync("Ok! But you need to choose the color level in the track box");
                    break;
                case "I want to use the light in my picture":
                    ss.SpeakAsync("Please choose the light level in the track box");
                        break;
                case "i want to illuminate the picture":
                    ss.SpeakAsync("No problem!");
                    filter2();
                    break;
                case "i want to darken the picture":
                    ss.SpeakAsync("ok sir");
                    Flash();
                    break;
                case "i am interested in a frozen image filter":
                    ss.SpeakAsync("Your desire is my command");
                    Frozen();
                    break;
                case "i love winter very much and i want winter image filter":
                    ss.SpeakAsync("Ok sir");
                    Winter();
                    break;
                case "I want a bit brighter picture":
                    ss.SpeakAsync("No problem sir");
                    fog();
                    break;

            }
            richTextBox1.Text += e.Result.Text.ToString() + Environment.NewLine;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            button13.Enabled = true;
            button14.Enabled = false;
        }

        private Bitmap AdjustBrightness(Image image, float brightness)
        {
            // napravi matricu bje
            float b = brightness;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
            new float[] {b, 0, 0, 0, 0},
            new float[] {0, b, 0, 0, 0},
            new float[] {0, 0, b, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);


            Point[] points =
            {
        new Point(0, 0),
        new Point(image.Width, 0),
        new Point(0, image.Height),
    };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);


            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }


            return bm;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            label5.Text = trackBar2.Value.ToString();
            pictureBox1.Image = AdjustBrightness(img, trackBar2.Value);

        }


        private void circularReload_Click(object sender, EventArgs e)
        {
            greenBar.Value = 0;
            redBar.Value = 0;
            blueBar.Value = 0;
            greenvalue.Text = "0";
            reload();
        }

        //filteri za slike

        private void circularSepia_Click(object sender, EventArgs e)
        {
            reload();
            redscale();
        }

        private void circularBlack_Click(object sender, EventArgs e)
        {
            reload();
            grayscale();
        }

        private void circularArt_Click(object sender, EventArgs e)
        {
            reload();
            Winter();
        }

        private void circularSpike_Click(object sender, EventArgs e)
        {
            reload();
            fog();
        }

        private void circularFlash_Click(object sender, EventArgs e)
        {
            reload();
            Flash();
        }

        private void circularFrozen_Click(object sender, EventArgs e)
        {
            reload();
            Frozen();
        }

        private void circularSuji_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }

        private void circularDramatic_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }

        private void circularKako_Click(object sender, EventArgs e)
        {
            reload();
            filter1();
        }



        private void circularCrop_Click(object sender, EventArgs e)
        {
            Crop();
        }
        void Crop()
        {
            Image myImage = pictureBox1.Image; 
            Bitmap croppedBitmap = new Bitmap(myImage);
            croppedBitmap = croppedBitmap.Clone(
                        new Rectangle(
                            (int)LeftMargin.Value, (int)TopMargin.Value,
                            myImage.Width - (int)LeftMargin.Value,
                            myImage.Height - (int)TopMargin.Value),
                       PixelFormat.DontCare);
            pictureBox1.Image = croppedBitmap;

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naslovna naa = new Naslovna();
            naa.Show();
        }
    }
}








