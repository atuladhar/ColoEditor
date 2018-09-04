using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Telerik.WinControls.UI;
using WpfApp2;

namespace ColorEditor
{
    public partial class Form1 : RadForm
    {
        CustomControl control=new CustomControl();
        

        public Form1()
        {
            InitializeComponent();

            //elementHost1.Child = control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ElementHost host = new ElementHost();
            host.Child = control;
            host.Dock = DockStyle.Fill;
            this.Controls.Add(host);

           //elementHost1.Child = control;
           // var g = elementHost1.CreateGraphics();
           // g.Dispose();
        }
    }
}
