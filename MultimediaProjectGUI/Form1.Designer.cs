namespace MultimediaProjectGUI
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RLCTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRLCDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRLCEncoded = new System.Windows.Forms.TextBox();
            this.btnRLCEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRLCRaw = new System.Windows.Forms.TextBox();
            this.LZWTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLZWDecode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLZWEncoded = new System.Windows.Forms.TextBox();
            this.btnLZWEncode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLZWRaw = new System.Windows.Forms.TextBox();
            this.ShanonTab = new System.Windows.Forms.TabPage();
            this.btnShanonDecode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShanonEncoded = new System.Windows.Forms.TextBox();
            this.btnShanonEncode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShanonRaw = new System.Windows.Forms.TextBox();
            this.ArithmeticTab = new System.Windows.Forms.TabPage();
            this.btnArithmeticDecode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArithmeticEncoded = new System.Windows.Forms.TextBox();
            this.btnArithmeticEncode = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArithmeticRaw = new System.Windows.Forms.TextBox();
            this.HuffmanTab = new System.Windows.Forms.TabPage();
            this.btnHuffmanDraw = new System.Windows.Forms.Button();
            this.huffmanPanel = new System.Windows.Forms.Panel();
            this.btnHuffmanDecode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHuffmanEncoded = new System.Windows.Forms.TextBox();
            this.btnHuffmanEncode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHuffmanRaw = new System.Windows.Forms.TextBox();
            this.AdaptiveHuffmanTab = new System.Windows.Forms.TabPage();
            this.btnAdaptiveHuffmanEncode = new System.Windows.Forms.Button();
            this.btnAdaptiveHuffmanClear = new System.Windows.Forms.Button();
            this.btnAdaptiveHuffmanGrid = new System.Windows.Forms.Button();
            this.adaptiveHuffmanPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdaptiveHuffmanEncoded = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdaptiveHuffmanRaw = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RLCTab.SuspendLayout();
            this.LZWTab.SuspendLayout();
            this.ShanonTab.SuspendLayout();
            this.ArithmeticTab.SuspendLayout();
            this.HuffmanTab.SuspendLayout();
            this.AdaptiveHuffmanTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.RLCTab);
            this.tabControl1.Controls.Add(this.LZWTab);
            this.tabControl1.Controls.Add(this.ShanonTab);
            this.tabControl1.Controls.Add(this.ArithmeticTab);
            this.tabControl1.Controls.Add(this.HuffmanTab);
            this.tabControl1.Controls.Add(this.AdaptiveHuffmanTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1880, 937);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // RLCTab
            // 
            this.RLCTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RLCTab.Controls.Add(this.label13);
            this.RLCTab.Controls.Add(this.btnRLCDecode);
            this.RLCTab.Controls.Add(this.label2);
            this.RLCTab.Controls.Add(this.txtRLCEncoded);
            this.RLCTab.Controls.Add(this.btnRLCEncode);
            this.RLCTab.Controls.Add(this.label1);
            this.RLCTab.Controls.Add(this.txtRLCRaw);
            this.RLCTab.Location = new System.Drawing.Point(4, 25);
            this.RLCTab.Margin = new System.Windows.Forms.Padding(4);
            this.RLCTab.Name = "RLCTab";
            this.RLCTab.Padding = new System.Windows.Forms.Padding(4);
            this.RLCTab.Size = new System.Drawing.Size(1872, 908);
            this.RLCTab.TabIndex = 0;
            this.RLCTab.Text = "RLC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Run Length Coding";
            // 
            // btnRLCDecode
            // 
            this.btnRLCDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRLCDecode.Location = new System.Drawing.Point(454, 245);
            this.btnRLCDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnRLCDecode.Name = "btnRLCDecode";
            this.btnRLCDecode.Size = new System.Drawing.Size(100, 28);
            this.btnRLCDecode.TabIndex = 5;
            this.btnRLCDecode.Text = "Decode";
            this.btnRLCDecode.UseVisualStyleBackColor = true;
            this.btnRLCDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encoded Text";
            // 
            // txtRLCEncoded
            // 
            this.txtRLCEncoded.Location = new System.Drawing.Point(166, 217);
            this.txtRLCEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.txtRLCEncoded.Multiline = true;
            this.txtRLCEncoded.Name = "txtRLCEncoded";
            this.txtRLCEncoded.Size = new System.Drawing.Size(278, 102);
            this.txtRLCEncoded.TabIndex = 3;
            // 
            // btnRLCEncode
            // 
            this.btnRLCEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRLCEncode.Location = new System.Drawing.Point(454, 100);
            this.btnRLCEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnRLCEncode.Name = "btnRLCEncode";
            this.btnRLCEncode.Size = new System.Drawing.Size(100, 28);
            this.btnRLCEncode.TabIndex = 2;
            this.btnRLCEncode.Text = "Encode";
            this.btnRLCEncode.UseVisualStyleBackColor = true;
            this.btnRLCEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raw Text";
            // 
            // txtRLCRaw
            // 
            this.txtRLCRaw.Location = new System.Drawing.Point(166, 82);
            this.txtRLCRaw.Margin = new System.Windows.Forms.Padding(4);
            this.txtRLCRaw.Multiline = true;
            this.txtRLCRaw.Name = "txtRLCRaw";
            this.txtRLCRaw.Size = new System.Drawing.Size(278, 102);
            this.txtRLCRaw.TabIndex = 0;
            // 
            // LZWTab
            // 
            this.LZWTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LZWTab.Controls.Add(this.label14);
            this.LZWTab.Controls.Add(this.btnLZWDecode);
            this.LZWTab.Controls.Add(this.label3);
            this.LZWTab.Controls.Add(this.txtLZWEncoded);
            this.LZWTab.Controls.Add(this.btnLZWEncode);
            this.LZWTab.Controls.Add(this.label4);
            this.LZWTab.Controls.Add(this.txtLZWRaw);
            this.LZWTab.Location = new System.Drawing.Point(4, 25);
            this.LZWTab.Margin = new System.Windows.Forms.Padding(4);
            this.LZWTab.Name = "LZWTab";
            this.LZWTab.Padding = new System.Windows.Forms.Padding(4);
            this.LZWTab.Size = new System.Drawing.Size(1872, 908);
            this.LZWTab.TabIndex = 1;
            this.LZWTab.Text = "LZW";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "LZW";
            // 
            // btnLZWDecode
            // 
            this.btnLZWDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLZWDecode.Location = new System.Drawing.Point(462, 247);
            this.btnLZWDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnLZWDecode.Name = "btnLZWDecode";
            this.btnLZWDecode.Size = new System.Drawing.Size(100, 28);
            this.btnLZWDecode.TabIndex = 11;
            this.btnLZWDecode.Text = "Decode";
            this.btnLZWDecode.UseVisualStyleBackColor = true;
            this.btnLZWDecode.Click += new System.EventHandler(this.BtnLZWDecode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Encoded Text";
            // 
            // txtLZWEncoded
            // 
            this.txtLZWEncoded.Location = new System.Drawing.Point(174, 219);
            this.txtLZWEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.txtLZWEncoded.Multiline = true;
            this.txtLZWEncoded.Name = "txtLZWEncoded";
            this.txtLZWEncoded.Size = new System.Drawing.Size(278, 102);
            this.txtLZWEncoded.TabIndex = 9;
            // 
            // btnLZWEncode
            // 
            this.btnLZWEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLZWEncode.Location = new System.Drawing.Point(462, 102);
            this.btnLZWEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnLZWEncode.Name = "btnLZWEncode";
            this.btnLZWEncode.Size = new System.Drawing.Size(100, 28);
            this.btnLZWEncode.TabIndex = 8;
            this.btnLZWEncode.Text = "Encode";
            this.btnLZWEncode.UseVisualStyleBackColor = true;
            this.btnLZWEncode.Click += new System.EventHandler(this.BtnLZWEncode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raw Text";
            // 
            // txtLZWRaw
            // 
            this.txtLZWRaw.Location = new System.Drawing.Point(174, 84);
            this.txtLZWRaw.Margin = new System.Windows.Forms.Padding(4);
            this.txtLZWRaw.Multiline = true;
            this.txtLZWRaw.Name = "txtLZWRaw";
            this.txtLZWRaw.Size = new System.Drawing.Size(278, 102);
            this.txtLZWRaw.TabIndex = 6;
            // 
            // ShanonTab
            // 
            this.ShanonTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ShanonTab.Controls.Add(this.label15);
            this.ShanonTab.Controls.Add(this.btnShanonDecode);
            this.ShanonTab.Controls.Add(this.label5);
            this.ShanonTab.Controls.Add(this.txtShanonEncoded);
            this.ShanonTab.Controls.Add(this.btnShanonEncode);
            this.ShanonTab.Controls.Add(this.label6);
            this.ShanonTab.Controls.Add(this.txtShanonRaw);
            this.ShanonTab.Location = new System.Drawing.Point(4, 25);
            this.ShanonTab.Margin = new System.Windows.Forms.Padding(4);
            this.ShanonTab.Name = "ShanonTab";
            this.ShanonTab.Padding = new System.Windows.Forms.Padding(4);
            this.ShanonTab.Size = new System.Drawing.Size(1872, 908);
            this.ShanonTab.TabIndex = 2;
            this.ShanonTab.Text = "Shanon";
            // 
            // btnShanonDecode
            // 
            this.btnShanonDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShanonDecode.Location = new System.Drawing.Point(474, 242);
            this.btnShanonDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnShanonDecode.Name = "btnShanonDecode";
            this.btnShanonDecode.Size = new System.Drawing.Size(100, 28);
            this.btnShanonDecode.TabIndex = 11;
            this.btnShanonDecode.Text = "Decode";
            this.btnShanonDecode.UseVisualStyleBackColor = true;
            this.btnShanonDecode.Click += new System.EventHandler(this.BtnShanonDecode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Encoded Text";
            // 
            // txtShanonEncoded
            // 
            this.txtShanonEncoded.Location = new System.Drawing.Point(186, 214);
            this.txtShanonEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.txtShanonEncoded.Multiline = true;
            this.txtShanonEncoded.Name = "txtShanonEncoded";
            this.txtShanonEncoded.Size = new System.Drawing.Size(278, 102);
            this.txtShanonEncoded.TabIndex = 9;
            // 
            // btnShanonEncode
            // 
            this.btnShanonEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShanonEncode.Location = new System.Drawing.Point(474, 98);
            this.btnShanonEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnShanonEncode.Name = "btnShanonEncode";
            this.btnShanonEncode.Size = new System.Drawing.Size(100, 28);
            this.btnShanonEncode.TabIndex = 8;
            this.btnShanonEncode.Text = "Encode";
            this.btnShanonEncode.UseVisualStyleBackColor = true;
            this.btnShanonEncode.Click += new System.EventHandler(this.BtnShanonEncode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Raw Text";
            // 
            // txtShanonRaw
            // 
            this.txtShanonRaw.Location = new System.Drawing.Point(186, 78);
            this.txtShanonRaw.Margin = new System.Windows.Forms.Padding(4);
            this.txtShanonRaw.Multiline = true;
            this.txtShanonRaw.Name = "txtShanonRaw";
            this.txtShanonRaw.Size = new System.Drawing.Size(278, 102);
            this.txtShanonRaw.TabIndex = 6;
            // 
            // ArithmeticTab
            // 
            this.ArithmeticTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ArithmeticTab.Controls.Add(this.label16);
            this.ArithmeticTab.Controls.Add(this.btnArithmeticDecode);
            this.ArithmeticTab.Controls.Add(this.label7);
            this.ArithmeticTab.Controls.Add(this.txtArithmeticEncoded);
            this.ArithmeticTab.Controls.Add(this.btnArithmeticEncode);
            this.ArithmeticTab.Controls.Add(this.label8);
            this.ArithmeticTab.Controls.Add(this.txtArithmeticRaw);
            this.ArithmeticTab.Location = new System.Drawing.Point(4, 25);
            this.ArithmeticTab.Margin = new System.Windows.Forms.Padding(4);
            this.ArithmeticTab.Name = "ArithmeticTab";
            this.ArithmeticTab.Padding = new System.Windows.Forms.Padding(4);
            this.ArithmeticTab.Size = new System.Drawing.Size(1872, 908);
            this.ArithmeticTab.TabIndex = 3;
            this.ArithmeticTab.Text = "Arithmetic";
            // 
            // btnArithmeticDecode
            // 
            this.btnArithmeticDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArithmeticDecode.Location = new System.Drawing.Point(466, 214);
            this.btnArithmeticDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnArithmeticDecode.Name = "btnArithmeticDecode";
            this.btnArithmeticDecode.Size = new System.Drawing.Size(100, 28);
            this.btnArithmeticDecode.TabIndex = 11;
            this.btnArithmeticDecode.Text = "Decode";
            this.btnArithmeticDecode.UseVisualStyleBackColor = true;
            this.btnArithmeticDecode.Click += new System.EventHandler(this.BtnArithmeticDecode_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Encoded Text";
            // 
            // txtArithmeticEncoded
            // 
            this.txtArithmeticEncoded.Location = new System.Drawing.Point(178, 186);
            this.txtArithmeticEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.txtArithmeticEncoded.Multiline = true;
            this.txtArithmeticEncoded.Name = "txtArithmeticEncoded";
            this.txtArithmeticEncoded.Size = new System.Drawing.Size(278, 102);
            this.txtArithmeticEncoded.TabIndex = 9;
            // 
            // btnArithmeticEncode
            // 
            this.btnArithmeticEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArithmeticEncode.Location = new System.Drawing.Point(466, 69);
            this.btnArithmeticEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnArithmeticEncode.Name = "btnArithmeticEncode";
            this.btnArithmeticEncode.Size = new System.Drawing.Size(100, 28);
            this.btnArithmeticEncode.TabIndex = 8;
            this.btnArithmeticEncode.Text = "Encode";
            this.btnArithmeticEncode.UseVisualStyleBackColor = true;
            this.btnArithmeticEncode.Click += new System.EventHandler(this.BtnArithmeticEncode_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Raw Text";
            // 
            // txtArithmeticRaw
            // 
            this.txtArithmeticRaw.Location = new System.Drawing.Point(178, 50);
            this.txtArithmeticRaw.Margin = new System.Windows.Forms.Padding(4);
            this.txtArithmeticRaw.Multiline = true;
            this.txtArithmeticRaw.Name = "txtArithmeticRaw";
            this.txtArithmeticRaw.Size = new System.Drawing.Size(278, 102);
            this.txtArithmeticRaw.TabIndex = 6;
            // 
            // HuffmanTab
            // 
            this.HuffmanTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HuffmanTab.Controls.Add(this.label17);
            this.HuffmanTab.Controls.Add(this.btnHuffmanDraw);
            this.HuffmanTab.Controls.Add(this.huffmanPanel);
            this.HuffmanTab.Controls.Add(this.btnHuffmanDecode);
            this.HuffmanTab.Controls.Add(this.label9);
            this.HuffmanTab.Controls.Add(this.txtHuffmanEncoded);
            this.HuffmanTab.Controls.Add(this.btnHuffmanEncode);
            this.HuffmanTab.Controls.Add(this.label10);
            this.HuffmanTab.Controls.Add(this.txtHuffmanRaw);
            this.HuffmanTab.Location = new System.Drawing.Point(4, 25);
            this.HuffmanTab.Margin = new System.Windows.Forms.Padding(4);
            this.HuffmanTab.Name = "HuffmanTab";
            this.HuffmanTab.Padding = new System.Windows.Forms.Padding(4);
            this.HuffmanTab.Size = new System.Drawing.Size(1872, 908);
            this.HuffmanTab.TabIndex = 4;
            this.HuffmanTab.Text = "Huffman";
            // 
            // btnHuffmanDraw
            // 
            this.btnHuffmanDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuffmanDraw.Location = new System.Drawing.Point(466, 70);
            this.btnHuffmanDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuffmanDraw.Name = "btnHuffmanDraw";
            this.btnHuffmanDraw.Size = new System.Drawing.Size(100, 28);
            this.btnHuffmanDraw.TabIndex = 15;
            this.btnHuffmanDraw.Text = "Draw";
            this.btnHuffmanDraw.Click += new System.EventHandler(this.BtnHuffmanDraw_Click);
            // 
            // huffmanPanel
            // 
            this.huffmanPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.huffmanPanel.BackColor = System.Drawing.Color.Black;
            this.huffmanPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huffmanPanel.Location = new System.Drawing.Point(10, 146);
            this.huffmanPanel.Margin = new System.Windows.Forms.Padding(4);
            this.huffmanPanel.Name = "huffmanPanel";
            this.huffmanPanel.Size = new System.Drawing.Size(1850, 750);
            this.huffmanPanel.TabIndex = 12;
            // 
            // btnHuffmanDecode
            // 
            this.btnHuffmanDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuffmanDecode.Location = new System.Drawing.Point(1070, 66);
            this.btnHuffmanDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuffmanDecode.Name = "btnHuffmanDecode";
            this.btnHuffmanDecode.Size = new System.Drawing.Size(100, 28);
            this.btnHuffmanDecode.TabIndex = 11;
            this.btnHuffmanDecode.Text = "Decode";
            this.btnHuffmanDecode.UseVisualStyleBackColor = true;
            this.btnHuffmanDecode.Click += new System.EventHandler(this.BtnHuffmanDecode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Encoded Text";
            // 
            // txtHuffmanEncoded
            // 
            this.txtHuffmanEncoded.Location = new System.Drawing.Point(782, 37);
            this.txtHuffmanEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.txtHuffmanEncoded.Multiline = true;
            this.txtHuffmanEncoded.Name = "txtHuffmanEncoded";
            this.txtHuffmanEncoded.Size = new System.Drawing.Size(278, 102);
            this.txtHuffmanEncoded.TabIndex = 9;
            // 
            // btnHuffmanEncode
            // 
            this.btnHuffmanEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuffmanEncode.Location = new System.Drawing.Point(466, 34);
            this.btnHuffmanEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuffmanEncode.Name = "btnHuffmanEncode";
            this.btnHuffmanEncode.Size = new System.Drawing.Size(100, 28);
            this.btnHuffmanEncode.TabIndex = 8;
            this.btnHuffmanEncode.Text = "Encode";
            this.btnHuffmanEncode.UseVisualStyleBackColor = true;
            this.btnHuffmanEncode.Click += new System.EventHandler(this.BtnHuffmanEncode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Raw Text";
            // 
            // txtHuffmanRaw
            // 
            this.txtHuffmanRaw.Location = new System.Drawing.Point(178, 37);
            this.txtHuffmanRaw.Margin = new System.Windows.Forms.Padding(4);
            this.txtHuffmanRaw.Multiline = true;
            this.txtHuffmanRaw.Name = "txtHuffmanRaw";
            this.txtHuffmanRaw.Size = new System.Drawing.Size(278, 102);
            this.txtHuffmanRaw.TabIndex = 6;
            // 
            // AdaptiveHuffmanTab
            // 
            this.AdaptiveHuffmanTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AdaptiveHuffmanTab.Controls.Add(this.label18);
            this.AdaptiveHuffmanTab.Controls.Add(this.btnAdaptiveHuffmanEncode);
            this.AdaptiveHuffmanTab.Controls.Add(this.btnAdaptiveHuffmanClear);
            this.AdaptiveHuffmanTab.Controls.Add(this.btnAdaptiveHuffmanGrid);
            this.AdaptiveHuffmanTab.Controls.Add(this.adaptiveHuffmanPanel);
            this.AdaptiveHuffmanTab.Controls.Add(this.label11);
            this.AdaptiveHuffmanTab.Controls.Add(this.txtAdaptiveHuffmanEncoded);
            this.AdaptiveHuffmanTab.Controls.Add(this.label12);
            this.AdaptiveHuffmanTab.Controls.Add(this.txtAdaptiveHuffmanRaw);
            this.AdaptiveHuffmanTab.Location = new System.Drawing.Point(4, 25);
            this.AdaptiveHuffmanTab.Margin = new System.Windows.Forms.Padding(4);
            this.AdaptiveHuffmanTab.Name = "AdaptiveHuffmanTab";
            this.AdaptiveHuffmanTab.Padding = new System.Windows.Forms.Padding(4);
            this.AdaptiveHuffmanTab.Size = new System.Drawing.Size(1872, 908);
            this.AdaptiveHuffmanTab.TabIndex = 5;
            this.AdaptiveHuffmanTab.Text = "Adaptive Huffman";
            // 
            // btnAdaptiveHuffmanEncode
            // 
            this.btnAdaptiveHuffmanEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaptiveHuffmanEncode.Location = new System.Drawing.Point(464, 42);
            this.btnAdaptiveHuffmanEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaptiveHuffmanEncode.Name = "btnAdaptiveHuffmanEncode";
            this.btnAdaptiveHuffmanEncode.Size = new System.Drawing.Size(100, 28);
            this.btnAdaptiveHuffmanEncode.TabIndex = 21;
            this.btnAdaptiveHuffmanEncode.Text = "Encode";
            this.btnAdaptiveHuffmanEncode.UseVisualStyleBackColor = true;
            this.btnAdaptiveHuffmanEncode.Click += new System.EventHandler(this.BtnAdaptiveHuffmanEncode_Click_1);
            // 
            // btnAdaptiveHuffmanClear
            // 
            this.btnAdaptiveHuffmanClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaptiveHuffmanClear.Location = new System.Drawing.Point(464, 110);
            this.btnAdaptiveHuffmanClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaptiveHuffmanClear.Name = "btnAdaptiveHuffmanClear";
            this.btnAdaptiveHuffmanClear.Size = new System.Drawing.Size(100, 28);
            this.btnAdaptiveHuffmanClear.TabIndex = 20;
            this.btnAdaptiveHuffmanClear.Text = "Clear";
            this.btnAdaptiveHuffmanClear.UseVisualStyleBackColor = true;
            this.btnAdaptiveHuffmanClear.Click += new System.EventHandler(this.BtnAdaptiveHuffmanClear_Click);
            // 
            // btnAdaptiveHuffmanGrid
            // 
            this.btnAdaptiveHuffmanGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaptiveHuffmanGrid.Location = new System.Drawing.Point(464, 75);
            this.btnAdaptiveHuffmanGrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaptiveHuffmanGrid.Name = "btnAdaptiveHuffmanGrid";
            this.btnAdaptiveHuffmanGrid.Size = new System.Drawing.Size(100, 28);
            this.btnAdaptiveHuffmanGrid.TabIndex = 19;
            this.btnAdaptiveHuffmanGrid.Text = "Show Grid";
            this.btnAdaptiveHuffmanGrid.UseVisualStyleBackColor = true;
            this.btnAdaptiveHuffmanGrid.Click += new System.EventHandler(this.BtnAdaptiveHuffmanGrid_Click);
            // 
            // adaptiveHuffmanPanel
            // 
            this.adaptiveHuffmanPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adaptiveHuffmanPanel.BackColor = System.Drawing.Color.Black;
            this.adaptiveHuffmanPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaptiveHuffmanPanel.Location = new System.Drawing.Point(4, 146);
            this.adaptiveHuffmanPanel.Margin = new System.Windows.Forms.Padding(4);
            this.adaptiveHuffmanPanel.Name = "adaptiveHuffmanPanel";
            this.adaptiveHuffmanPanel.Size = new System.Drawing.Size(1850, 750);
            this.adaptiveHuffmanPanel.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Encoded Text";
            // 
            // txtAdaptiveHuffmanEncoded
            // 
            this.txtAdaptiveHuffmanEncoded.Location = new System.Drawing.Point(782, 38);
            this.txtAdaptiveHuffmanEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaptiveHuffmanEncoded.Multiline = true;
            this.txtAdaptiveHuffmanEncoded.Name = "txtAdaptiveHuffmanEncoded";
            this.txtAdaptiveHuffmanEncoded.Size = new System.Drawing.Size(278, 102);
            this.txtAdaptiveHuffmanEncoded.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Raw Text";
            // 
            // txtAdaptiveHuffmanRaw
            // 
            this.txtAdaptiveHuffmanRaw.Location = new System.Drawing.Point(176, 38);
            this.txtAdaptiveHuffmanRaw.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaptiveHuffmanRaw.Multiline = true;
            this.txtAdaptiveHuffmanRaw.Name = "txtAdaptiveHuffmanRaw";
            this.txtAdaptiveHuffmanRaw.Size = new System.Drawing.Size(278, 102);
            this.txtAdaptiveHuffmanRaw.TabIndex = 12;
            this.txtAdaptiveHuffmanRaw.TextChanged += new System.EventHandler(this.TxtAdaptiveHuffmanRaw_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Shanon Fan";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 4);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Arithmetic Coding";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Huffman";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 4);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "Adaptive Huffman";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1539, 849);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.RLCTab.ResumeLayout(false);
            this.RLCTab.PerformLayout();
            this.LZWTab.ResumeLayout(false);
            this.LZWTab.PerformLayout();
            this.ShanonTab.ResumeLayout(false);
            this.ShanonTab.PerformLayout();
            this.ArithmeticTab.ResumeLayout(false);
            this.ArithmeticTab.PerformLayout();
            this.HuffmanTab.ResumeLayout(false);
            this.HuffmanTab.PerformLayout();
            this.AdaptiveHuffmanTab.ResumeLayout(false);
            this.AdaptiveHuffmanTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RLCTab;
        private System.Windows.Forms.TabPage LZWTab;
        private System.Windows.Forms.Button btnRLCDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRLCEncoded;
        private System.Windows.Forms.Button btnRLCEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRLCRaw;
        private System.Windows.Forms.Button btnLZWDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLZWEncoded;
        private System.Windows.Forms.Button btnLZWEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLZWRaw;
        private System.Windows.Forms.TabPage ShanonTab;
        private System.Windows.Forms.Button btnShanonDecode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShanonEncoded;
        private System.Windows.Forms.Button btnShanonEncode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShanonRaw;
        private System.Windows.Forms.TabPage ArithmeticTab;
        private System.Windows.Forms.Button btnArithmeticDecode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArithmeticEncoded;
        private System.Windows.Forms.Button btnArithmeticEncode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArithmeticRaw;
        private System.Windows.Forms.TabPage HuffmanTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHuffmanEncoded;
        private System.Windows.Forms.Button btnHuffmanEncode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHuffmanRaw;
        private System.Windows.Forms.TabPage AdaptiveHuffmanTab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdaptiveHuffmanEncoded;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdaptiveHuffmanRaw;
        private System.Windows.Forms.Panel huffmanPanel;
        private System.Windows.Forms.Panel adaptiveHuffmanPanel;
        private System.Windows.Forms.Button btnHuffmanDraw;
        private System.Windows.Forms.Button btnAdaptiveHuffmanGrid;
        private System.Windows.Forms.Button btnAdaptiveHuffmanClear;
        private System.Windows.Forms.Button btnAdaptiveHuffmanEncode;
        private System.Windows.Forms.Button btnHuffmanDecode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

