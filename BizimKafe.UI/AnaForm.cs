using BizimKafe.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimKafe.UI
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();

        public AnaForm()
        {
            InitializeComponent();
            MasalariOlustur();
        }

        private void MasalariOlustur()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                var lvi = new ListViewItem();
                lvi.Text = $"Masa {i}";
                lvi.ImageKey = "bos";
                lvi.Tag = i;
                lvwMasalar.Items.Add(lvi);
            }
        }
    }
}
