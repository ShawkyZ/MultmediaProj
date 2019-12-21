namespace MultimediaProjectGUI
{
    public class f_node
    {
        public string bit;
        public string symbol = "#";
        public int Xpos, Ypos;
        public f_node Left = null;
        public f_node Right = null;
        public int prob = 1;
    }

    public class h_node
    {
        public string bit;
        public string symbol = "#";
        public int Xpos, Ypos;
        public h_node Left = null;
        public h_node Right = null;
        public h_node prev = null;
        public int prob = 1;
        public bool is_new = false;
    }

    public class node
    {
        public char symbol;
        public bool root = false;
        public bool leave;
        public int c = 0;
        public node parent, Right, Left;
        public int Xpos;
        public int Ypos;

        public node()
        {
            leave = false;
            root = true;
            this.Left = null;
            this.parent = null;
            this.Right = null;
        }
        public node(node parent)
        {
            leave = false;
            this.Left = null;
            this.parent = parent;
            this.Right = null;
        }
        public node(node parent, char c)
        {
            leave = true;
            symbol = c;
            this.Left = null;
            this.parent = parent;
            this.Right = null;
        }
    }
}
