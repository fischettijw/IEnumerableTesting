using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.CompilerServices;
using System.IO;

namespace IEnumerableTesting
{
    public partial class FrmIEnumerable : Form
    {
        public FrmIEnumerable()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            IEnumerable<string> lines = File.ReadLines("Data.txt");
            MessageBox.Show(string.Join(Environment.NewLine, lines));
            foreach (string line in lines)
            {
                //MessageBox.Show(line);
                if (MessageBox.Show(line, "Database Output", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            }

        }

    }
}


