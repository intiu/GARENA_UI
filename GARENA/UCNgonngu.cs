using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GARENA
{
    public partial class UCNgonngu : UserControl
    {
        private static UCNgonngu _instance;
        public static UCNgonngu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCNgonngu();
                return _instance;
            }
        }
        public UCNgonngu()
        {
            InitializeComponent();
        }

        private void UCNgonngu_Load(object sender, EventArgs e)
        {

        }
    }
}
