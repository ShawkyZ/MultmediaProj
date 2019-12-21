using System;
using System.Collections.Generic;
using System.Linq;

namespace MultimediaProjectGUI
{
    public class AdaptiveHuffman
    {
        Dictionary<char, node> nasib = new Dictionary<char, node>();
        Dictionary<int, Queue<node>> des = new Dictionary<int, Queue<node>>();
        public node teqia = new node();
        public node root =new node();
        public node newbie = new node();
        public AdaptiveHuffman(char s)
        {
            insertnew(s);
            root = teqia.parent;
        }

        public void insertnew(char c)
        {
            node u;
            if (nasib.ContainsKey(c))
            {
                u = nasib[c];
            }
            else
            {
                u = new node(teqia, c);
                newbie = u;
                nasib[c] = u;
                teqia.Right = u;
                teqia.Left = new node(teqia);
                teqia = teqia.Left;
            }
            prop(u);

        }

        public void prop(node n)
        {
            node ta;
            if (n.root)
            {
                n.c++;
                return;

            }
            if (des.ContainsKey(n.c) != false && des[n.c].Count != 0 && (!(n == newbie && des[(n.c)].Peek() == n.parent)))
            {
                ta = des[n.c].Dequeue();
                if (des[(n.c)].Count == 0)
                    des.Remove(n.c);
                swap(ta, n);
                nasib[ta.symbol] = ta;
                nasib[n.symbol] = n;
            }
            else
                ta = n;
            ta.c++;
            Queue<node> q = new Queue<node>();
            
            if (!des.ContainsKey(ta.c))
            {
                des[ta.c] = q;
                //q = null;
            }
            else
            {
                q = des[ta.c];
            }

            if (des.ContainsKey(n.c) != false && des[n.c].Count() != 0 && ((n == newbie && des[n.c].Peek() == n.parent)))
                des.Remove(n.c);

            prop(ta.parent);
            q.Enqueue(ta);
        }

        public void makefather(node father, node son)
        {
            if (son == null)
                return;
            son.parent = father;
        }

        public void swap(node n1, node n2)
        {
            node t = n1.Left;
            n1.Left = n2.Left;
            n2.Left = t;
            t = n1.Right;
            n1.Right = n2.Right;
            n2.Right = t;

            char c = n1.symbol;
            n1.symbol = n2.symbol;
            n2.symbol = c;
            makefather(n1, n1.Left);
            makefather(n1, n1.Right);
            makefather(n2, n2.Right);
            makefather(n2, n2.Left);
        }

    }
}
