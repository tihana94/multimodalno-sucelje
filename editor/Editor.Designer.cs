namespace editor
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bluevalue = new System.Windows.Forms.Label();
            this.greenvalue = new System.Windows.Forms.Label();
            this.redvalue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.circularSuji = new editor.CircularButton();
            this.circularFrozen = new editor.CircularButton();
            this.circularDramatic = new editor.CircularButton();
            this.circularSpike = new editor.CircularButton();
            this.circularKako = new editor.CircularButton();
            this.circularArt = new editor.CircularButton();
            this.circularCrop = new editor.CircularButton();
            this.circularFlash = new editor.CircularButton();
            this.LeftMargin = new System.Windows.Forms.NumericUpDown();
            this.circularBlack = new editor.CircularButton();
            this.TopMargin = new System.Windows.Forms.NumericUpDown();
            this.circularSepia = new editor.CircularButton();
            this.circularReload = new editor.CircularButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopMargin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Red";
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(111, 493);
            this.redBar.Maximum = 100;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(735, 45);
            this.redBar.TabIndex = 9;
            this.redBar.ValueChanged += new System.EventHandler(this.redBar_Scroll);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(111, 529);
            this.greenBar.Maximum = 100;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(735, 45);
            this.greenBar.TabIndex = 11;
            this.greenBar.ValueChanged += new System.EventHandler(this.greenBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(111, 557);
            this.blueBar.Maximum = 100;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(735, 45);
            this.blueBar.TabIndex = 13;
            this.blueBar.Scroll += new System.EventHandler(this.blueBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Blue";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(977, 684);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 109);
            this.button8.TabIndex = 14;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Teal;
            this.button9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(859, 684);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 109);
            this.button9.TabIndex = 15;
            this.button9.Text = "Open";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bluevalue
            // 
            this.bluevalue.AutoSize = true;
            this.bluevalue.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluevalue.ForeColor = System.Drawing.Color.Teal;
            this.bluevalue.Location = new System.Drawing.Point(77, 557);
            this.bluevalue.Name = "bluevalue";
            this.bluevalue.Size = new System.Drawing.Size(29, 16);
            this.bluevalue.TabIndex = 22;
            this.bluevalue.Text = "0,0";
            // 
            // greenvalue
            // 
            this.greenvalue.AutoSize = true;
            this.greenvalue.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenvalue.ForeColor = System.Drawing.Color.Teal;
            this.greenvalue.Location = new System.Drawing.Point(77, 525);
            this.greenvalue.Name = "greenvalue";
            this.greenvalue.Size = new System.Drawing.Size(29, 16);
            this.greenvalue.TabIndex = 21;
            this.greenvalue.Text = "0,0";
            // 
            // redvalue
            // 
            this.redvalue.AutoSize = true;
            this.redvalue.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redvalue.ForeColor = System.Drawing.Color.Teal;
            this.redvalue.Location = new System.Drawing.Point(77, 493);
            this.redvalue.Name = "redvalue";
            this.redvalue.Size = new System.Drawing.Size(29, 16);
            this.redvalue.TabIndex = 20;
            this.redvalue.Text = "0,0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "PhotoEditor";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Teal;
            this.button13.Location = new System.Drawing.Point(111, 684);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 67);
            this.button13.TabIndex = 24;
            this.button13.Text = "Start";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Teal;
            this.button14.Location = new System.Drawing.Point(202, 684);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(85, 67);
            this.button14.TabIndex = 25;
            this.button14.Text = "Stop";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(307, 684);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 109);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 100;
            this.trackBar2.Location = new System.Drawing.Point(111, 596);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(735, 45);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 30;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Brightness";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(97, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "0";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1156, 28);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 447);
            this.vScrollBar1.TabIndex = 47;
            // 
            // circularSuji
            // 
            this.circularSuji.BackColor = System.Drawing.Color.White;
            this.circularSuji.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularSuji.ForeColor = System.Drawing.Color.Teal;
            this.circularSuji.Location = new System.Drawing.Point(71, 285);
            this.circularSuji.Name = "circularSuji";
            this.circularSuji.Size = new System.Drawing.Size(119, 41);
            this.circularSuji.TabIndex = 40;
            this.circularSuji.Text = "Light over";
            this.circularSuji.UseVisualStyleBackColor = false;
            this.circularSuji.Click += new System.EventHandler(this.circularSuji_Click);
            // 
            // circularFrozen
            // 
            this.circularFrozen.BackColor = System.Drawing.Color.White;
            this.circularFrozen.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularFrozen.ForeColor = System.Drawing.Color.Teal;
            this.circularFrozen.Location = new System.Drawing.Point(81, 245);
            this.circularFrozen.Name = "circularFrozen";
            this.circularFrozen.Size = new System.Drawing.Size(90, 34);
            this.circularFrozen.TabIndex = 39;
            this.circularFrozen.Text = "Frozen";
            this.circularFrozen.UseVisualStyleBackColor = false;
            this.circularFrozen.Click += new System.EventHandler(this.circularFrozen_Click);
            // 
            // circularDramatic
            // 
            this.circularDramatic.BackColor = System.Drawing.Color.White;
            this.circularDramatic.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularDramatic.ForeColor = System.Drawing.Color.Teal;
            this.circularDramatic.Location = new System.Drawing.Point(82, 325);
            this.circularDramatic.Name = "circularDramatic";
            this.circularDramatic.Size = new System.Drawing.Size(90, 34);
            this.circularDramatic.TabIndex = 41;
            this.circularDramatic.Text = "Dramatic";
            this.circularDramatic.UseVisualStyleBackColor = false;
            this.circularDramatic.Click += new System.EventHandler(this.circularDramatic_Click);
            // 
            // circularSpike
            // 
            this.circularSpike.BackColor = System.Drawing.Color.White;
            this.circularSpike.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularSpike.ForeColor = System.Drawing.Color.Teal;
            this.circularSpike.Location = new System.Drawing.Point(82, 165);
            this.circularSpike.Name = "circularSpike";
            this.circularSpike.Size = new System.Drawing.Size(89, 34);
            this.circularSpike.TabIndex = 38;
            this.circularSpike.Text = "Brighter";
            this.circularSpike.UseVisualStyleBackColor = false;
            this.circularSpike.Click += new System.EventHandler(this.circularSpike_Click);
            // 
            // circularKako
            // 
            this.circularKako.BackColor = System.Drawing.Color.White;
            this.circularKako.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularKako.ForeColor = System.Drawing.Color.Teal;
            this.circularKako.Location = new System.Drawing.Point(82, 365);
            this.circularKako.Name = "circularKako";
            this.circularKako.Size = new System.Drawing.Size(90, 34);
            this.circularKako.TabIndex = 42;
            this.circularKako.Text = "Kakao";
            this.circularKako.UseVisualStyleBackColor = false;
            this.circularKako.Click += new System.EventHandler(this.circularKako_Click);
            // 
            // circularArt
            // 
            this.circularArt.BackColor = System.Drawing.Color.White;
            this.circularArt.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularArt.ForeColor = System.Drawing.Color.Teal;
            this.circularArt.Location = new System.Drawing.Point(81, 129);
            this.circularArt.Name = "circularArt";
            this.circularArt.Size = new System.Drawing.Size(90, 34);
            this.circularArt.TabIndex = 37;
            this.circularArt.Text = "Winter";
            this.circularArt.UseVisualStyleBackColor = false;
            this.circularArt.Click += new System.EventHandler(this.circularArt_Click);
            // 
            // circularCrop
            // 
            this.circularCrop.BackColor = System.Drawing.Color.White;
            this.circularCrop.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularCrop.ForeColor = System.Drawing.Color.Teal;
            this.circularCrop.Location = new System.Drawing.Point(81, 497);
            this.circularCrop.Name = "circularCrop";
            this.circularCrop.Size = new System.Drawing.Size(90, 34);
            this.circularCrop.TabIndex = 43;
            this.circularCrop.Text = "Crop";
            this.circularCrop.UseVisualStyleBackColor = false;
            this.circularCrop.Click += new System.EventHandler(this.circularCrop_Click);
            // 
            // circularFlash
            // 
            this.circularFlash.BackColor = System.Drawing.Color.White;
            this.circularFlash.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularFlash.ForeColor = System.Drawing.Color.Teal;
            this.circularFlash.Location = new System.Drawing.Point(81, 205);
            this.circularFlash.Name = "circularFlash";
            this.circularFlash.Size = new System.Drawing.Size(90, 34);
            this.circularFlash.TabIndex = 36;
            this.circularFlash.Text = "Flash";
            this.circularFlash.UseVisualStyleBackColor = false;
            this.circularFlash.Click += new System.EventHandler(this.circularFlash_Click);
            // 
            // LeftMargin
            // 
            this.LeftMargin.Location = new System.Drawing.Point(116, 448);
            this.LeftMargin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LeftMargin.Name = "LeftMargin";
            this.LeftMargin.Size = new System.Drawing.Size(43, 20);
            this.LeftMargin.TabIndex = 44;
            // 
            // circularBlack
            // 
            this.circularBlack.BackColor = System.Drawing.Color.White;
            this.circularBlack.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularBlack.ForeColor = System.Drawing.Color.Teal;
            this.circularBlack.Location = new System.Drawing.Point(81, 61);
            this.circularBlack.Name = "circularBlack";
            this.circularBlack.Size = new System.Drawing.Size(90, 62);
            this.circularBlack.TabIndex = 35;
            this.circularBlack.Text = "Black and white";
            this.circularBlack.UseVisualStyleBackColor = false;
            this.circularBlack.Click += new System.EventHandler(this.circularBlack_Click);
            // 
            // TopMargin
            // 
            this.TopMargin.Location = new System.Drawing.Point(116, 472);
            this.TopMargin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Size = new System.Drawing.Size(43, 20);
            this.TopMargin.TabIndex = 46;
            // 
            // circularSepia
            // 
            this.circularSepia.BackColor = System.Drawing.Color.White;
            this.circularSepia.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularSepia.ForeColor = System.Drawing.Color.Teal;
            this.circularSepia.Location = new System.Drawing.Point(81, 35);
            this.circularSepia.Name = "circularSepia";
            this.circularSepia.Size = new System.Drawing.Size(90, 27);
            this.circularSepia.TabIndex = 34;
            this.circularSepia.Text = "Sepia";
            this.circularSepia.UseVisualStyleBackColor = false;
            this.circularSepia.Click += new System.EventHandler(this.circularSepia_Click);
            // 
            // circularReload
            // 
            this.circularReload.BackColor = System.Drawing.Color.White;
            this.circularReload.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularReload.ForeColor = System.Drawing.Color.Teal;
            this.circularReload.Location = new System.Drawing.Point(81, 0);
            this.circularReload.Name = "circularReload";
            this.circularReload.Size = new System.Drawing.Size(90, 34);
            this.circularReload.TabIndex = 33;
            this.circularReload.Text = "Reload";
            this.circularReload.UseVisualStyleBackColor = false;
            this.circularReload.Click += new System.EventHandler(this.circularReload_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.circularReload);
            this.panel1.Controls.Add(this.circularSepia);
            this.panel1.Controls.Add(this.TopMargin);
            this.panel1.Controls.Add(this.circularBlack);
            this.panel1.Controls.Add(this.LeftMargin);
            this.panel1.Controls.Add(this.circularFlash);
            this.panel1.Controls.Add(this.circularCrop);
            this.panel1.Controls.Add(this.circularArt);
            this.panel1.Controls.Add(this.circularKako);
            this.panel1.Controls.Add(this.circularSpike);
            this.panel1.Controls.Add(this.circularDramatic);
            this.panel1.Controls.Add(this.circularFrozen);
            this.panel1.Controls.Add(this.circularSuji);
            this.panel1.Location = new System.Drawing.Point(852, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 534);
            this.panel1.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(25, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 54;
            this.label13.Text = "TopMargin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(25, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "LeftMargin";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(0, 402);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 40);
            this.panel7.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(53, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 38);
            this.label11.TabIndex = 0;
            this.label11.Text = "Crop";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-1, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 40);
            this.panel2.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(562, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Photo Editor with speech recognition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(205, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "RGB and brightness";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(-1, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 40);
            this.panel3.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Browse Image";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(852, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 40);
            this.panel4.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(847, 40);
            this.panel5.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(129, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(610, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Photo Editor without speech recognition";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(852, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 40);
            this.panel6.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Filters";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(963, 796);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 25);
            this.label14.TabIndex = 53;
            this.label14.Text = "PhotoEditor";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1101, 843);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bluevalue);
            this.Controls.Add(this.greenvalue);
            this.Controls.Add(this.redvalue);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoEditor";
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopMargin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label bluevalue;
        private System.Windows.Forms.Label greenvalue;
        private System.Windows.Forms.Label redvalue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private CircularButton circularSuji;
        private CircularButton circularFrozen;
        private CircularButton circularDramatic;
        private CircularButton circularSpike;
        private CircularButton circularKako;
        private CircularButton circularArt;
        private CircularButton circularCrop;
        private CircularButton circularFlash;
        private System.Windows.Forms.NumericUpDown LeftMargin;
        private CircularButton circularBlack;
        private System.Windows.Forms.NumericUpDown TopMargin;
        private CircularButton circularSepia;
        private CircularButton circularReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}

