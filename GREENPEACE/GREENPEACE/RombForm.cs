using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENPEACE
{
    public partial class RombForm : Form
    {
        public RombForm()
        {
            InitializeComponent();
        }

        private void RombForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath mypath = 
                new System.Drawing.Drawing2D.GraphicsPath();
            mypath.AddPolygon(new Point[]
            {
                new Point(150, 0),
                new Point(300, 150),
                new Point(150, 300),
                new Point(0, 150) 
            });
            Region myRegion = new Region(mypath);
            this.Region = myRegion;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
