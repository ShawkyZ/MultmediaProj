using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Multimedia_Project;

namespace MultimediaProjectGUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private SolidBrush blackBrush;
        private Pen blackPen;

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRLCRaw.Text))
            {
                MessageBox.Show("Enter Raw Value");
                return;
            }

            txtRLCEncoded.Text = RunTimeLength.Encode(txtRLCRaw.Text);
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRLCEncoded.Text))
            {
                MessageBox.Show("Enter Encoded Value");
                return;
            }

            txtRLCRaw.Text = RunTimeLength.Decode(txtRLCEncoded.Text);
        }

        private void BtnLZWEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLZWRaw.Text))
            {
                MessageBox.Show("Enter Raw Value");
                return;
            }

            txtLZWEncoded.Text = string.Join(",", Lzw.Compress(txtLZWRaw.Text));
        }

        private void BtnLZWDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLZWEncoded.Text))
            {
                MessageBox.Show("Enter Encoded Value");
                return;
            }

            var bitList = txtLZWEncoded.Text.Split(',').Select(int.Parse).ToList();
            txtLZWRaw.Text = Lzw.Decompress(bitList);
        }

        private byte[] _shanonCompressedData;
        private int _shanonCompressedDataSize;
        private uint originalDataSize;
        private void BtnShanonEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtShanonRaw.Text))
            {
                MessageBox.Show("Enter Raw Value");
                return;
            }
            var originalData = Encoding.Default.GetBytes(txtShanonRaw.Text);
            originalDataSize = (uint)txtShanonRaw.Text.Length;
            _shanonCompressedData = new byte[originalDataSize * (101 / 100) + 384];
            _shanonCompressedDataSize = Shanon.Compress(originalData, _shanonCompressedData, originalDataSize);
            txtShanonEncoded.Text = string.Join(",", _shanonCompressedData.Where(x => x != 0));
        }

        private void BtnShanonDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtShanonEncoded.Text) || _shanonCompressedDataSize == 0)
            {
                MessageBox.Show("Enter Encoded Value");
                return;
            }

            var decompressedData = new byte[originalDataSize];

            Shanon.Decompress(_shanonCompressedData, decompressedData, (uint)_shanonCompressedDataSize, originalDataSize);
            txtShanonRaw.Text = Encoding.UTF8.GetString(decompressedData);
        }

        private ArithmeticCoder c;
        private MemoryStream ms;
        private int _arithmeticTextLength;
        private void BtnArithmeticEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArithmeticRaw.Text))
            {
                MessageBox.Show("Enter Raw Value");
                return;
            }

            _arithmeticTextLength = txtArithmeticRaw.Text.Length;
            List<ArithmeticCoder.symbol> dict =
          new List<ArithmeticCoder.symbol>
          {
                new ArithmeticCoder.symbol('0',0,1),//0x00
                new ArithmeticCoder.symbol('1',1,2),//0x01
                new ArithmeticCoder.symbol('2',2,3),//0x02
                new ArithmeticCoder.symbol('3',3,4),//0x03
                new ArithmeticCoder.symbol('4',4,5),//0x04
                new ArithmeticCoder.symbol('5',5,6),//0x05
                new ArithmeticCoder.symbol('6',6,7),//0x06
                new ArithmeticCoder.symbol('7',7,8),//0x07
                new ArithmeticCoder.symbol('8',8,9),//0x08
                new ArithmeticCoder.symbol('9',9,10),//0x09
                new ArithmeticCoder.symbol('A',10,11),//0x10
                new ArithmeticCoder.symbol('B',11,12),//0x11
                new ArithmeticCoder.symbol('C',12,13),//0x12
                new ArithmeticCoder.symbol('D',13,14),//0x13
                new ArithmeticCoder.symbol('E',14,15),//0x14
                new ArithmeticCoder.symbol('F',15,16),//0x15                
                new ArithmeticCoder.symbol('G',16,17),//0x15                
                new ArithmeticCoder.symbol('H',17,18),//0x15                
                new ArithmeticCoder.symbol('I',18,19),//0x15                
                new ArithmeticCoder.symbol('J',19,20),//0x15                
                new ArithmeticCoder.symbol('K',20,21),//0x15                
                new ArithmeticCoder.symbol('L',21,22),//0x15                
                new ArithmeticCoder.symbol('M',22,23),//0x15                
                new ArithmeticCoder.symbol('N',23,24),//0x15                
                new ArithmeticCoder.symbol('O',24,25),//0x15                
                new ArithmeticCoder.symbol('P',25,26),//0x15                
                new ArithmeticCoder.symbol('Q',26,27),//0x15                
                new ArithmeticCoder.symbol('R',27,28),//0x15                
                new ArithmeticCoder.symbol('S',28,29),//0x15                
                new ArithmeticCoder.symbol('T',29,30),//0x15                
                new ArithmeticCoder.symbol('U',30,31),//0x15                
                new ArithmeticCoder.symbol('V',31,32),//0x15                
                new ArithmeticCoder.symbol('W',32,33),//0x15                
                new ArithmeticCoder.symbol('X',33,34),//0x15                
                new ArithmeticCoder.symbol('Y',34,35),//0x15                
                new ArithmeticCoder.symbol('Z',35,36),//0x15    
                new ArithmeticCoder.symbol('a',36,37),//0x10
                new ArithmeticCoder.symbol('b',37,38),//0x11
                new ArithmeticCoder.symbol('c',38,39),//0x12
                new ArithmeticCoder.symbol('d',39,40),//0x13
                new ArithmeticCoder.symbol('e',40,41),//0x14
                new ArithmeticCoder.symbol('f',41,42),//0x15                
                new ArithmeticCoder.symbol('g',42,43),//0x15                
                new ArithmeticCoder.symbol('h',43,44),//0x15                
                new ArithmeticCoder.symbol('i',44,45),//0x15                
                new ArithmeticCoder.symbol('j',45,46),//0x15                
                new ArithmeticCoder.symbol('k',46,47),//0x15                
                new ArithmeticCoder.symbol('l',47,48),//0x15                
                new ArithmeticCoder.symbol('m',48,49),//0x15                
                new ArithmeticCoder.symbol('n',49,50),//0x15                
                new ArithmeticCoder.symbol('o',50,51),//0x15                
                new ArithmeticCoder.symbol('p',51,52),//0x15                
                new ArithmeticCoder.symbol('q',52,53),//0x15                
                new ArithmeticCoder.symbol('r',53,54),//0x15                
                new ArithmeticCoder.symbol('s',54,55),//0x15                
                new ArithmeticCoder.symbol('t',55,56),//0x15                
                new ArithmeticCoder.symbol('u',56,57),//0x15                
                new ArithmeticCoder.symbol('v',57,58),//0x15                
                new ArithmeticCoder.symbol('w',58,59),//0x15                
                new ArithmeticCoder.symbol('x',59,60),//0x15               
                new ArithmeticCoder.symbol('y',60,61),//0x15                
                new ArithmeticCoder.symbol('z',61,62),//0x15 
                new ArithmeticCoder.symbol(' ',62,63)//0x15                
          };

            c = new ArithmeticCoder(dict) { Scale = 63 };

            ms = c.compress(txtArithmeticRaw.Text);
            var compressed = "";
            foreach (var b in ms.ToArray())
                compressed += b.ToString();
            txtArithmeticEncoded.Text = compressed;
        }

        private void BtnArithmeticDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArithmeticEncoded.Text) || c == null)
            {
                MessageBox.Show("Enter Encoded Value");
                return;
            }
            txtArithmeticRaw.Text = c.decompress(ms, _arithmeticTextLength);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            huffmanPanel.AutoScroll = true;
            adaptiveHuffmanPanel.AutoScroll = true;
            huffmanPanel.Paint += huffmanPanel_Paint;
            adaptiveHuffmanPanel.Paint += AdaptiveHuffmanPanel_Paint;
            blackPen = new Pen(Color.SpringGreen,2);
            blackBrush = new SolidBrush(Color.White);
        }

        private AdaptiveHuffman ad;
        private void AdaptiveHuffmanPanel_Paint(object sender, PaintEventArgs e)
        {
            if (HuffmanTree.huffmanTree != null)
                HuffmanTree.DrawTree(HuffmanTree.huffmanTree, e.Graphics, adaptiveHuffmanPanel,ClientSize,blackBrush,blackPen);
        }

        private Huffman<char> huffman;
        private List<int> huffmanEncodedBits;
        private void BtnHuffmanEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHuffmanRaw.Text))
            {
                MessageBox.Show("Enter Raw Value");
                return;
            }

            huffman = new Huffman<char>(txtHuffmanRaw.Text);
            huffmanEncodedBits = huffman.Encode(txtHuffmanRaw.Text);
            txtHuffmanEncoded.Text = string.Join("", huffmanEncodedBits);
        }

       
        private void huffmanPanel_Paint(object sender, PaintEventArgs e)
        {
            if (HuffmanTree.huffmanTree != null)
                HuffmanTree.DrawTree(HuffmanTree.huffmanTree,e.Graphics, huffmanPanel, ClientSize, blackBrush, blackPen);
        }

        private void BtnHuffmanDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHuffmanEncoded.Text) || huffman == null)
            {
                MessageBox.Show("Enter Encoded Value");
                return;
            }

            var rawValue = string.Join("",huffman.Decode(huffmanEncodedBits));
            txtHuffmanRaw.Text = rawValue;
        }
        List<List<string>> encodedBits = new List<List<string>>();
        private void BtnHuffmanDraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHuffmanRaw.Text))
            {
                MessageBox.Show("Enter Raw Value");
                return;
            }
            var code = txtHuffmanRaw.Text;
            HuffmanTree.DrawHuffmanTree(code, encodedBits, huffmanPanel);
        }

        private void TxtAdaptiveHuffmanRaw_TextChanged(object sender, EventArgs e)
        {
            if (txtAdaptiveHuffmanRaw.Text == "")
            {
                return;
            }

            if (ad == null)
                ad = new AdaptiveHuffman(txtAdaptiveHuffmanRaw.Text.Last());
            else
                ad.insertnew(txtAdaptiveHuffmanRaw.Text.Last());

            HuffmanTree.huffmanTree = ad.root;
            label1.Text += txtAdaptiveHuffmanRaw.Text[0];
            //node temp = ad.root;

            int depth = 1;
            HuffmanTree.totalNodes = 0;
            HuffmanTree.InOrderTraversal(HuffmanTree.huffmanTree, depth);

            HuffmanTree.maxTreeHeight = HuffmanTree.TreeHeight(HuffmanTree.huffmanTree);

            adaptiveHuffmanPanel.Invalidate();
        }

        private void BtnAdaptiveHuffmanClear_Click(object sender, EventArgs e)
        {
            ad = null;
            adaptiveHuffmanPanel.Controls.Clear();
            adaptiveHuffmanPanel.Invalidate();
            HuffmanTree.huffmanTree = null;
            int depth = 1;
            HuffmanTree.InOrderTraversal(HuffmanTree.huffmanTree, 1);
            txtAdaptiveHuffmanRaw.Clear();
        }

        private void BtnAdaptiveHuffmanGrid_Click(object sender, EventArgs e)
        {
            encodedBits.Clear();
            var temp1 = new List<string> {"Symbol", "bits", "frequency"};
            encodedBits.Add(temp1);
            HuffmanTree.calculateBits(HuffmanTree.huffmanTree, "", encodedBits);
            var gridData = new Grid(encodedBits);
            gridData.ShowDialog();
        }

        private void BtnAdaptiveHuffmanEncode_Click_1(object sender, EventArgs e)
        {
            encodedBits.Clear();
            HuffmanTree.calculateBits(HuffmanTree.huffmanTree, "", encodedBits);
            string encodedTxt = string.Empty;
            var rawText = txtAdaptiveHuffmanRaw.Text;
           
                for (int i = encodedBits.Count - 1; i >= 0 ; i--)
                {
                    for (int j = 0; j < rawText.Length; j++)
                    {
                        if (rawText[j].ToString() == encodedBits[i][0])
                        {
                            encodedTxt += encodedBits[i][1];
                            continue;
                        }
                    }
                }
            txtAdaptiveHuffmanEncoded.Text = encodedTxt;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ad = null;
            adaptiveHuffmanPanel.Controls.Clear();
            adaptiveHuffmanPanel.Invalidate();
            HuffmanTree.huffmanTree = null;
            int depth = 1;
            HuffmanTree.InOrderTraversal(HuffmanTree.huffmanTree, 1);
            txtAdaptiveHuffmanRaw.Clear();
        }
    }
}
