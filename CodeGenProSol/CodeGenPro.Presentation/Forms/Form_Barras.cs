using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BarcodeStandard;
using SkiaSharp;
using static CodeGenPro.Presentation.Forms.Form_Barras;

namespace CodeGenPro.Presentation.Forms
{
    public partial class Form_Barras : Form
    {
        Barcode _bar = new Barcode();

        public Form_Barras()
        {
            InitializeComponent();
        }

        private void Form_Barras_Load(object sender, EventArgs e)
        {
            
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                if (colorDialog.ShowDialog() != DialogResult.OK) return;
                _bar.BackColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B, colorDialog.Color.A);
                btnBackColor.BackColor = colorDialog.Color;                
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _bar.ForeColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B, colorDialog.Color.A);
                    btnForeColor.BackColor = colorDialog.Color;
                }//if
            }//using
        }
    }
}
