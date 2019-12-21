using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MultimediaProjectGUI
{
    public class HuffmanTree
    {
        public static int totalNodes = 0, maxTreeHeight = 0;
        public static node huffmanTree;
        static Dictionary<char, int> repeatedChars = new Dictionary<char, int>();
        public static node generate_Tree_for_huffman(List<node> list)
        {
            if (list.Count <= 1)
            {
                list[0].symbol = Convert.ToChar(list[0].c.ToString());
                return list[0];
            }
            if (list.Count == 2)
            {
                node node_left = new node();
                node node_right = new node();

                node_left = list[0];
                node_right = list[1];

                node final = new node();
                final.Left = node_left;
                final.Right = node_right;
                final.c = node_right.c + node_left.c;
                final.symbol = Convert.ToChar(final.c.ToString());
                return final;
            }

            List<node> temp_lest = new List<node>();
            temp_lest = list;

            node node_left1 = new node();
            node node_right1 = new node();

            node_left1 = list[0];

            node_right1 = list[1];

            node left_or_right = new node();
            left_or_right.Left = node_left1;
            left_or_right.Right = node_right1;
            left_or_right.c = node_right1.c + node_left1.c;
            left_or_right.symbol = Convert.ToChar(left_or_right.c.ToString());
            temp_lest.RemoveAt(0);
            temp_lest.RemoveAt(0);

            temp_lest.Add(left_or_right);
            temp_lest.Sort((x, y) => x.c.CompareTo(y.c));

            node last_final = new node();
            last_final = generate_Tree_for_huffman(temp_lest);

            return last_final;
        }
        public static void DrawHuffmanTree(string code, List<List<string>> encodedBits, Panel huffmanPanel)
        {
            repeatedChars.Clear();
            for (int i = 0; i < code.Length; i++)
            {
                if (repeatedChars.ContainsKey(code[i]))
                {
                    repeatedChars[code[i]]++;
                }
                else repeatedChars[code[i]] = 1;
            }

            var rep = new List<Tuple<int, char>>();
            var arrayOfAllKeys = repeatedChars.Keys.ToArray();

            for (int i = 0; i < arrayOfAllKeys.Length; i++)
            {
                rep.Add(Tuple.Create(repeatedChars[arrayOfAllKeys[i]], arrayOfAllKeys[i]));
            }

            rep.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            List<node> rep_node = new List<node>();

            for (int i = 0; i < rep.Count; i++)
            {
                node temp = new node();
                temp.c = rep[i].Item1;
                temp.symbol = rep[i].Item2;

                rep_node.Add(temp);
            }

            node c = new node();

            huffmanTree = generate_Tree_for_huffman(rep_node);
            encodedBits.Clear();

            encodedBits.Add(new List<string> { "Symbol", "bits", "frequency" });

            calculateBits(huffmanTree, "", encodedBits);
            int depth = 1;
            totalNodes = 0;
            InOrderTraversal(huffmanTree, depth); // calculate position of each node 
            maxTreeHeight = TreeHeight(huffmanTree);
            huffmanPanel.Invalidate();
        }
        public static void InOrderTraversal(node t, int depth)
        {
            if (t != null)
            {
                InOrderTraversal(t.Left, depth + 1); //add 1 to depth (y coordinate) 
                t.Xpos = totalNodes++ + 1; //x coord is node number in inorder traversal
                t.Ypos = depth - 1; // mark y coord as depth
                InOrderTraversal(t.Right, depth + 1);
            }
        }
        public static void calculateBits(node root, string code, List<List<string>> encodedBits)
        {
            if (root.Left == null && root.Right == null)
            {
                var temp = new List<string> {root.symbol.ToString(), code, root.c.ToString()};
                encodedBits.Add(temp);
                return;
            }
            calculateBits(root.Left, code + "0", encodedBits);
            calculateBits(root.Right, code + "1", encodedBits);
            return;
        }
        public static int TreeHeight(node t)
        {
            if (t == null) return -1;
            else return 1 + Math.Max(TreeHeight(t.Left), TreeHeight(t.Right));
        }
        public static void DrawTree(node root, Graphics g, Panel huffmanPanel, Size ClientSize, Brush blackBrush, Pen blackPen)
        {
                huffmanPanel.Width = ClientSize.Width - 20;
                huffmanPanel.Height = ClientSize.Height - 20;

                int Width = huffmanPanel.Width;
                int Height = huffmanPanel.Height;
                int dx = 0, dy = 0, dx2 = 0, dy2 = 0, ys = 20;
                int XSCALE, YSCALE;
                int treeHeight = TreeHeight(root);

                XSCALE = (int)(Width / totalNodes); //scale x by total nodes in tree
                YSCALE = (int)((Height - ys) / (maxTreeHeight + 1)); //scale y by tree height

                if (root != null)
                {
                    // inorder traversal to draw each node
                    DrawTree(root.Left, g, huffmanPanel, ClientSize, blackBrush, blackPen); // do left side of inorder traversal 
                    dx = root.Xpos * XSCALE; // get x,y coords., and scale them 
                    dy = root.Ypos * YSCALE;
                    string s = root.symbol.ToString(); //get the word at this node
                    s += "(" + root.c.ToString() + ")";
                    g.DrawString(s, huffmanPanel.Font, blackBrush, new PointF(dx - ys, dy));
                    // this draws the lines from a node to its children, if any
                    if (root.Left != null)
                    {
                        //draws the line to left child if it exists
                        dx2 = root.Left.Xpos * XSCALE;
                        dy2 = root.Left.Ypos * YSCALE;
                        g.DrawLine(blackPen, dx, dy, dx2, dy2);
                    }

                    if (root.Right != null)
                    {
                        //draws the line to right child if it exists
                        dx2 = root.Right.Xpos * XSCALE;//get right child x,y scaled position
                        dy2 = root.Right.Ypos * YSCALE;
                        g.DrawLine(blackPen, dx, dy, dx2, dy2);
                    }

                    DrawTree(root.Right, g, huffmanPanel,ClientSize,blackBrush,blackPen); //now do right side of inorder traversal 
                }
        }
    }
}