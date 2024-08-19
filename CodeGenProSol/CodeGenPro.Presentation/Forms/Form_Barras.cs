using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BarcodeStandard;
using SkiaSharp;
using static CodeGenPro.Presentation.Forms.Form_Barras;
using Type = BarcodeStandard.Type; 
using System.Drawing.Imaging;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using CodeGenPro.Presentation.Helps; 



namespace CodeGenPro.Presentation.Forms
{
    public partial class Form_Barras : Form
    {
        Barcode _bar = new Barcode();
        private Bitmap _imagenCombinada;
         

        public Form_Barras()
        {
            InitializeComponent();
        }

        private void Form_Barras_Load(object sender, EventArgs e)
        {
            cbEncodeType.SelectedIndex = 0;
            cbBarcodeAlign.SelectedIndex = 0;

            //Show library version
            tslblLibraryVersion.Text = @"Barcode Library Version: " + Barcode.Version;

            btnBackColor.BackColor = ColorTranslator.FromHtml(_bar.BackColor.ToString());
            btnForeColor.BackColor = ColorTranslator.FromHtml(_bar.ForeColor.ToString());
        }

        // Evento Paint para dibujar la imagen en el GroupBox
        private void groupBoxBarcode_Paint(object sender, PaintEventArgs e)
        {
            if (_imagenCombinada != null)
            {
                // Calcular la posición para centrar la imagen en el GroupBox
                int posX = (barcode.Width - _imagenCombinada.Width) / 2;
                int posY = (barcode.Height - _imagenCombinada.Height) / 2;

                // Dibujar la imagen en el GroupBox
                e.Graphics.DrawImage(_imagenCombinada, new Point(posX, posY));
            }
        }
        // Método auxiliar para convertir texto en imagen
        public static Bitmap convertirTextoImagen(string texto, int ancho, Color color)
        {
            Bitmap objBitmap = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            Font objFont = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);

            Graphics objGraphics = Graphics.FromImage(objBitmap);

            Width = ancho;
            Height = (int)objGraphics.MeasureString(texto, objFont).Height + 5;
            objBitmap = new Bitmap(objBitmap, new Size(Width, Height));

            objGraphics = Graphics.FromImage(objBitmap);
            objGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            objGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            StringFormat drawFormat = new StringFormat();
            objGraphics.Clear(color);

            drawFormat.Alignment = StringAlignment.Center;
            objGraphics.DrawString(texto, objFont, new SolidBrush(Color.Black), new RectangleF(0, (objBitmap.Height / 2) - (objBitmap.Height - 10), objBitmap.Width, objBitmap.Height), drawFormat);
            objGraphics.Flush();

            return objBitmap;
        }


        private Type GetTypeSelected()
        {
            var type = Type.Unspecified;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = Type.UpcA; break;
                case "UPC-E": type = Type.UpcE; break;
                case "UPC 2 Digit Ext.": type = Type.UpcSupplemental2Digit; break;
                case "UPC 5 Digit Ext.": type = Type.UpcSupplemental5Digit; break;
                case "EAN-13": type = Type.Ean13; break;
                case "JAN-13": type = Type.Jan13; break;
                case "EAN-8": type = Type.Ean8; break;
                case "ITF-14": type = Type.Itf14; break;
                case "Codabar": type = Type.Codabar; break;
                case "PostNet": type = Type.PostNet; break;
                case "Bookland/ISBN": type = Type.Bookland; break;
                case "Code 11": type = Type.Code11; break;
                case "Code 39": type = Type.Code39; break;
                case "Code 39 Extended": type = Type.Code39Extended; break;
                case "Code 39 Mod 43": type = Type.Code39Mod43; break;
                case "Code 93": type = Type.Code93; break;
                case "LOGMARS": type = Type.Logmars; break;
                case "MSI Mod 10": type = Type.MsiMod10; break;
                case "MSI Mod 11": type = Type.MsiMod11; break;
                case "MSI 2 Mod 10": type = Type.Msi2Mod10; break;
                case "MSI Mod 11 Mod 10": type = Type.MsiMod11Mod10; break;
                case "Interleaved 2 of 5": type = Type.Interleaved2Of5; break;
                case "Interleaved 2 of 5 Mod 10": type = Type.Interleaved2Of5Mod10; break;
                case "Standard 2 of 5": type = Type.Standard2Of5; break;
                case "Standard 2 of 5 Mod 10": type = Type.Standard2Of5Mod10; break;
                case "Code 128": type = Type.Code128; break;
                case "Code 128-A": type = Type.Code128A; break;
                case "Code 128-B": type = Type.Code128B; break;
                case "Code 128-C": type = Type.Code128C; break;
                case "Telepen": type = Type.Telepen; break;
                case "FIM": type = Type.Fim; break;
                case "Pharmacode": type = Type.Pharmacode; break;
                case "IATA2of5": type = Type.IATA2of5; break;
                default: MessageBox.Show(@"Please specify the encoding type."); break;
            }//switch

            return type;
        }



        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                if (colorDialog.ShowDialog() != DialogResult.OK) return;
                _bar.BackColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B, colorDialog.Color.A);
                btnForeColor.BackColor = colorDialog.Color;
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
                    btnBackColor.BackColor = colorDialog.Color;
                }//if
            }//using
        }

        private void Encode_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            // Verificar si hay una imagen en el PictureBox
            if (pictureBoxBarcode.Image == null)
            {
                MessageBox.Show("No hay imagen para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configurar el SaveFileDialog
            var sfd = new SaveFileDialog
            {
                Filter = @"JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|WEBP (*.webp)|*.webp",
                FilterIndex = 2,
                AddExtension = true
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            // Determinar el tipo de archivo seleccionado
            ImageFormat format = ImageFormat.Png;
            switch (sfd.FilterIndex)
            {
                case 1: /* JPG */ format = ImageFormat.Jpeg; break;
                case 2: /* PNG */ format = ImageFormat.Png; break;
                case 3: /* WEBP*/ SaveAsWebp((Bitmap)pictureBoxBarcode.Image, sfd.FileName); return;
            }

            // Guardar la imagen en el formato seleccionado
            pictureBoxBarcode.Image.Save(sfd.FileName, format);
        }

        private void SaveAsWebp(Bitmap img, string fileName)
        {
            using (var skBitmap = new SKBitmap(img.Width, img.Height))
            {
                using (var canvas = new SKCanvas(skBitmap))
                {
                    using (var paint = new SKPaint())
                    {
                        paint.IsAntialias = true;

                        using (var ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            ms.Seek(0, SeekOrigin.Begin);

                            using (var skImage = SKImage.FromEncodedData(ms))
                            {
                                canvas.DrawImage(skImage, new SKPoint(0, 0), paint);
                            }
                        }
                    }
                }

                using (var stream = File.OpenWrite(fileName))
                using (var skImage = SKImage.FromBitmap(skBitmap))
                using (var data = skImage.Encode(SKEncodedImageFormat.Webp, 100))
                {
                    data.SaveTo(stream);
                }
            }
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int w = 300; // Ancho fijo
            int h = 100; // Alto fijo
            _bar.Alignment = AlignmentPositions.Center;

            // Barcode alignment
            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": _bar.Alignment = AlignmentPositions.Left; break;
                case "right": _bar.Alignment = AlignmentPositions.Right; break;
                default: _bar.Alignment = AlignmentPositions.Center; break;
            }

            var type = GetTypeSelected();

            try
            {
                if (type != Type.Unspecified)
                {
                    try
                    {
                        _bar.BarWidth = string.IsNullOrEmpty(textBoxBarWidth.Text.Trim()) ? (int?)null : Convert.ToInt32(textBoxBarWidth.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse BarWidth: " + ex.Message, ex);
                    }
                    try
                    {
                        _bar.BarWidth = string.IsNullOrEmpty(textBoxAspectRatio.Text.Trim()) ? (int?)null : Convert.ToInt32(textBoxAspectRatio.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse AspectRatio: " + ex.Message, ex);
                    }

                    _bar.IncludeLabel = false; // Desactivar la etiqueta integrada

                    if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
                        _bar.AlternateLabel = textBox1.Text;
                    else _bar.AlternateLabel = null;

                    // Generar la imagen del código de barras
                    Image imagenCodigo = Image.FromStream(_bar.Encode(type, txtData.Text.Trim(), _bar.ForeColor, _bar.BackColor, w, h).Encode().AsStream());

                    // Generar la imagen del texto (txtData.Text)
                    Bitmap imagenTexto = convertirTextoImagen(txtData.Text.Trim(), w, Color.White);

                    // Crear una nueva imagen que combine ambas
                    int altoImagenNueva = imagenCodigo.Height + imagenTexto.Height;
                    Bitmap imagenCombinada = new Bitmap(w, altoImagenNueva);
                    Graphics g = Graphics.FromImage(imagenCombinada);
                    g.Clear(Color.Transparent); // Hacer transparente el fondo para centrar
                    g.DrawImage(imagenCodigo, new Point(0, 0));
                    g.DrawImage(imagenTexto, new Point(0, imagenCodigo.Height));

                    // Asegurarse de que la imagen no se escale en el PictureBox
                    pictureBoxBarcode.SizeMode = PictureBoxSizeMode.AutoSize;

                    // Crear una imagen de salida con el tamaño del PictureBox
                    Bitmap imagenConCentrado = new Bitmap(pictureBoxBarcode.Width, pictureBoxBarcode.Height);
                    using (Graphics g2 = Graphics.FromImage(imagenConCentrado))
                    {
                        g2.Clear(Color.Transparent);

                        // Calcular la posición para centrar la imagen
                        int x = (pictureBoxBarcode.Width - imagenCombinada.Width) / 2;
                        int y = (pictureBoxBarcode.Height - imagenCombinada.Height) / 2;

                        g2.DrawImage(imagenCombinada, x, y);
                    }

                    // Mostrar la imagen centrada en el PictureBox
                    pictureBoxBarcode.Image = imagenConCentrado;

                    // Mostrar el tiempo de codificación
                    lblEncodingTime.Text = @"(" + Math.Round(_bar.EncodingTime, 0, MidpointRounding.AwayFromZero) + @"ms)";

                    txtEncoded.Text = _bar.EncodedValue;
                    tsslEncodedType.Text = @"Encoding Type: " + _bar.EncodedType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jASONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iconButton4_Click(sender, e);

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = @"JSON Files|*.json";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(_bar.ToJson(chkIncludeImageInSavedData.Checked));
                }
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void jASONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Crear y configurar OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Si el usuario selecciona un archivo y hace clic en "Abrir"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string jsonFilePath = openFileDialog.FileName;

                    // Llamar al método para cargar la imagen desde el JSON
                    LoadBarcodeFromJson(jsonFilePath);
                }
            }
        }
        private void LoadBarcodeFromJson(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(jsonContent))
                {
                    throw new Exception("El contenido del archivo JSON está vacío o es nulo.");
                }

                var barcodeData = JsonConvert.DeserializeObject<BarCodeData>(jsonContent);
                if (barcodeData == null)
                {
                    throw new Exception("No se pudo deserializar el JSON en BarcodeData.");
                }

                if (string.IsNullOrEmpty(barcodeData.Image))
                {
                    MessageBox.Show("No se encontró una imagen en el archivo JSON. Se cargarán otros datos si están disponibles.");
                    LoadBarcodeDataWithoutImage(barcodeData);
                    return;
                }

                byte[] imageData = Convert.FromBase64String(barcodeData.Image);

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);

                    if (pictureBoxBarcode == null)
                    {
                        throw new Exception("El PictureBox no está inicializado.");
                    }

                    pictureBoxBarcode.Image = image;
                }

                LoadBarcodeDataWithoutImage(barcodeData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el código de barras desde JSON: {ex.Message}\n{ex.StackTrace}");
            }
        }
        private void LoadBarcodeDataWithoutImage(BarCodeData barcodeData)
        {
            // Asegúrate de que estos controles existan en tu formulario
            txtData.Text = barcodeData.RawData;
            txtEncoded.Text = barcodeData.EncodedValue;

            // Para el ComboBox, necesitamos encontrar el índice del tipo de código de barras
            int index = cbEncodeType.FindStringExact(barcodeData.Type);
            if (index != -1)
            {
                cbEncodeType.SelectedIndex = index;
            }

            // Configurar otros controles según sea necesario
            // Por ejemplo:
            // textBoxBarWidth.Text = barcodeData.ImageWidth.ToString();
            // textBoxAspectRatio.Text = ... // Si tienes esta propiedad en BarCodeData

            // Configurar colores si es necesario
            if (ColorTranslator.FromHtml(barcodeData.Forecolor) is Color foreColor)
            {
                btnForeColor.BackColor = foreColor;
                _bar.ForeColor = new SKColor(foreColor.R, foreColor.G, foreColor.B, foreColor.A);
            }

            if (ColorTranslator.FromHtml(barcodeData.Backcolor) is Color backColor)
            {
                btnBackColor.BackColor = backColor;
                _bar.BackColor = new SKColor(backColor.R, backColor.G, backColor.B, backColor.A);
            }

            // Actualizar otros campos según sea necesario
            lblEncodingTime.Text = $"({barcodeData.EncodingTime}ms)";
            tsslEncodedType.Text = $"Encoding Type: {barcodeData.Type}";

            // Si tienes más propiedades en BarCodeData, configúralas aquí
        }

    }
}
