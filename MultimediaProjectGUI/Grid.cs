using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimediaProjectGUI
{
    public partial class Grid : Form
    {
        List<List<String>> mylist = new List<List<string>>();
        public Grid()
        {
            InitializeComponent();
        }
        public Grid(List<List<String>> mylist)
        {
            this.mylist = mylist;
            InitializeComponent();
        }
        private void Grid_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = mylist.Count;
            dataGridView1.ColumnCount = mylist[0].Count;

            for (int i = 0; i < mylist[0].Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = mylist[0][i];
            }

            for (int i = 0; i < mylist.Count; i++)
            {

                for (int j = 0; j < mylist[0].Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mylist[i][j];
                }
            }
        }
    }
}
