using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing;

namespace CodeGenPro.Presentation.Forms
{
    public partial class Forms_Qr : Form
    {
        public Forms_Qr()
        {
            InitializeComponent();
        }

        private void btGenerarQR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEscalaPixel.Text))
            {
                MessageBox.Show("Debe indicar la escala de los píxeles del QR que se generará.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtEscalaPixel.Focus();
                return;
            }

            int escalaPixel = int.TryParse(txtEscalaPixel.Text, out int escala) ? escala : 4;

            var qrOptions = new QrCodeEncodingOptions
            {
                Height = escalaPixel * 25,  // Ajusta según la escala
                Width = escalaPixel * 25,
                Margin = 1
            };

            switch (lsNivelCorreccion.Text)
            {
                case "Bajo (7%)":
                    qrOptions.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.L;
                    break;
                case "Medio (15%)":
                    qrOptions.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M;
                    break;
                case "Alto (25%)":
                    qrOptions.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.Q;
                    break;
                case "Muy alto (30%)":
                    qrOptions.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H;
                    break;
            }

            var qrWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = qrOptions
            };

            try
            {
                var qrCode = qrWriter.Write(txtTextoQR.Text);
                imgQR.Image = qrCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
