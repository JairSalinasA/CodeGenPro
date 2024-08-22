using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BarcodeStandard;
using SkiaSharp;
using Type = BarcodeStandard.Type;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using CodeGenPro.Presentation.Helps;
 
using ClosedXML.Excel;
using System.Drawing.Printing;


namespace CodeGenPro.Presentation.Forms
{
    public partial class Form_Barras : Form
    {
        // Importa la función para modificar el estilo de la ventana
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_STYLE = -16;
        private const int WS_MAXIMIZEBOX = 0x00010000;
        private const int WS_MINIMIZEBOX = 0x00020000;

        private Barcode _b; // Suponiendo que tienes una clase Barcode 
        public Form_Barras()
        {
            InitializeComponent();
            _b = new Barcode(); // Inicializa tu objeto Barcode
            errorProvider1 = new ErrorProvider(); // Inicializa el ErrorProvider 
            Load += Form_Barras_Load;
        }

        private void Form_Barras_Load(object sender, EventArgs e)
        {

            // Obtiene el estilo actual de la ventana
            int style = GetWindowLong(this.Handle, GWL_STYLE);

            // Elimina el estilo de maximización
            style &= ~WS_MAXIMIZEBOX;

            // Aplica el nuevo estilo a la ventana
            SetWindowLong(this.Handle, GWL_STYLE, style);

            barcode = new PictureBox(); // O el tipo específico del control
            barcode.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(barcode);


            cbEncodeType.SelectedIndex = 0;
            cbBarcodeAlign.SelectedIndex = 0;

            //Show library version
            tslblLibraryVersion.Text = @"Barcode Library Version: " + Barcode.Version;

            btnBackColor.BackColor = ColorTranslator.FromHtml(_b.BackColor.ToString());
            btnForeColor.BackColor = ColorTranslator.FromHtml(_b.ForeColor.ToString());


        }

        #region Botones

        private void btnEncode_Click(object sender, EventArgs e)
        {
            GenerateBarcode();
        }
        private void btnSaveJSON_Click(object sender, EventArgs e)
        {
            var barcode = new BarcodeData.BarcodeDataJson
            {
                Width = _b.Width,
                Height = _b.Height,
                Alignment = _b.Alignment.ToString(),
                EncodedValue = _b.EncodedValue, // Asegúrate de que EncodedValue es de lectura y escritura
                EncodedType = _b.EncodedType.ToString(), // Ajustado para convertir a string
                EncodingTime = _b.EncodingTime
            };

            barcode.SaveAsJson("barcode.json");
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            var barcode = new BarcodeData.BarcodeDataXml
            {
                Width = _b.Width,
                Height = _b.Height,
                Alignment = _b.Alignment.ToString(),
                EncodedValue = _b.EncodedValue, // Asegúrate de que EncodedValue es de lectura y escritura
                EncodedType = _b.EncodedType.ToString(), // Ajustado para convertir a string
                EncodingTime = _b.EncodingTime
            };

            barcode.SaveAsXml("barcode.xml");
        }

        private void btnLoadJSON_Click(object sender, EventArgs e)
        {
            var barcode = BarcodeData.BarcodeDataJson.LoadFromJson("barcode.json");
            _b.Width = barcode.Width;
            _b.Height = barcode.Height;
            //_b.Alignment = (Type)Enum.Parse(typeof(Type), barcode.Alignment); // Convertir de string a enumeración
            // Ajusta según sea necesario si EncodedValue es de solo lectura
            _b.EncodedType = (Type)Enum.Parse(typeof(Type), barcode.EncodedType); // Convertir de string a enumeración
            _b.EncodingTime = barcode.EncodingTime;
        }

        private void LoadXML_Click(object sender, EventArgs e)
        {
            var barcode = BarcodeData.BarcodeDataXml.LoadFromXml("barcode.xml");
            _b.Width = barcode.Width;
            _b.Height = barcode.Height;
            //_b.Alignment = (Type)Enum.Parse(typeof(Type), barcode.Alignment); // Convertir de string a enumeración
            // Ajusta según sea necesario si EncodedValue es de solo lectura
            _b.EncodedType = (Type)Enum.Parse(typeof(Type), barcode.EncodedType); // Convertir de string a enumeración
            _b.EncodingTime = barcode.EncodingTime;
        }

        private void btnGuardaImagen_Click(object sender, EventArgs e)
        {
            SaveBarcodeAsImage();
        }
        #endregion
        #region Config
        private Type GetTypeSelected()
        {
            var type = Type.Unspecified;
            var requiredLengths = new Dictionary<Type, int?>
    {
        { Type.UpcA, 12 },
        { Type.UpcE, 8 },
        { Type.UpcSupplemental2Digit, 2 },
        { Type.UpcSupplemental5Digit, 5 },
        { Type.Ean13, 13 },
        { Type.Jan13, 13 },
        { Type.Ean8, 8 },
        { Type.Itf14, 14 },
        { Type.Codabar, null }, // No tiene una longitud fija
        { Type.PostNet, null },
        { Type.Bookland, 13 },
        { Type.Code11, null },
        { Type.Code39, null },
        { Type.Code39Extended, null },
        { Type.Code39Mod43, null },
        { Type.Code93, null },
        { Type.Logmars, null },
        { Type.MsiMod10, null },
        { Type.MsiMod11, null },
        { Type.Msi2Mod10, null },
        { Type.MsiMod11Mod10, null },
        { Type.Interleaved2Of5, null },
        { Type.Interleaved2Of5Mod10, null },
        { Type.Standard2Of5, null },
        { Type.Standard2Of5Mod10, null },
        { Type.Code128, null },
        { Type.Code128A, null },
        { Type.Code128B, null },
        { Type.Code128C, null },
        { Type.Telepen, null },
        { Type.Fim, null },
        { Type.Pharmacode, null },
        { Type.IATA2of5, null }
    };

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
                default:
                    MessageBox.Show(@"Please specify the encoding type.");
                    return Type.Unspecified;
            }

            // Validar la longitud de los datos según el tipo seleccionado
            if (type != Type.Unspecified && requiredLengths.ContainsKey(type))
            {
                int? requiredLength = requiredLengths[type];
                if (requiredLength.HasValue && txtData.Text.Trim().Length != requiredLength.Value)
                {
                    MessageBox.Show($"El tipo de codificación '{cbEncodeType.SelectedItem}' requiere exactamente {requiredLength.Value} dígitos.");
                    return Type.Unspecified; // O maneja este caso según lo necesites
                }
            }

            return type;
        }
        #endregion
        #region Colores
        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _b.ForeColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B, colorDialog.Color.A);
                    btnForeColor.BackColor = colorDialog.Color;
                }//if
            }//using
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                if (colorDialog.ShowDialog() != DialogResult.OK) return;
                _b.BackColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B, colorDialog.Color.A);
                btnBackColor.BackColor = colorDialog.Color;
                //if
            }//using
        }

        #endregion


        private void SaveBarcodeAsImage()
        {
            try
            {
                if (cc.BackgroundImage != null)
                {
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PNG Image|*.png";
                        saveFileDialog.Title = "Save Barcode Image";
                        saveFileDialog.FileName = "barcode.png";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            cc.BackgroundImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            MessageBox.Show("¡Imagen guardada exitosamente!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen para guardar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message);
            }
        }
        private void SaveBarcodeImage(SKBitmap bitmapWithLabel)
        {
            using (var image = SKImage.FromBitmap(bitmapWithLabel))
            {
                using (var imageStream = image.Encode())
                {
                    using (var ms = new MemoryStream(imageStream.ToArray()))
                    {
                        cc.BackgroundImage = Image.FromStream(ms);
                    }
                }
            }
        }
        private void GenerateBarcode()
        {
            errorProvider1.Clear();

            var w = Convert.ToInt32(txtWidth.Text.Trim());
            var h = Convert.ToInt32(txtHeight.Text.Trim());
            _b.Alignment = AlignmentPositions.Center;

            // Barcode alignment
            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": _b.Alignment = AlignmentPositions.Left; break;
                case "right": _b.Alignment = AlignmentPositions.Right; break;
                default: _b.Alignment = AlignmentPositions.Center; break;
            }

            var type = GetTypeSelected();

            try
            {
                if (type != Type.Unspecified)
                {
                    try
                    {
                        _b.BarWidth = string.IsNullOrWhiteSpace(textBoxBarWidth.Text) ? (int?)null : Convert.ToInt32(textBoxBarWidth.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("No se puede analizar BarWidth: " + ex.Message, ex);
                    }

                    try
                    {
                        _b.AspectRatio = string.IsNullOrWhiteSpace(textBoxAspectRatio.Text) ? (double?)null : Convert.ToDouble(textBoxAspectRatio.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("No se puede analizar AspectRatio: " + ex.Message, ex);
                    }

                    _b.IncludeLabel = chkGenerateLabel.Checked;

                    // Store the values separately
                    string dataText = txtData.Text.Trim();
                    string labelText = chkGenerateLabel.Checked ? textBox1.Text.Trim() : "";

                    // Encoding performed here
                    using (var skiaImage = _b.Encode(type, dataText, _b.ForeColor, _b.BackColor, w, h))
                    {
                        using (var skBitmap = SKBitmap.Decode(skiaImage.Encode().AsStream()))
                        {
                            // Create a new bitmap with extra space for the label
                            int extraHeight = 20; // Increase this value for more space at the top
                            using (var bitmapWithLabel = new SKBitmap(skBitmap.Width, skBitmap.Height + extraHeight))
                            {
                                using (var canvas = new SKCanvas(bitmapWithLabel))
                                {
                                    // Draw the label text at the top
                                    if (!string.IsNullOrEmpty(labelText))
                                    {
                                        // Set up font and paint
                                        var labelPaint = new SKPaint
                                        {
                                            Typeface = SKTypeface.FromFamilyName("Century Gothic", SKFontStyle.Bold),
                                            Color = SKColors.Black,
                                            TextSize = 16,
                                            IsAntialias = true,
                                            TextAlign = SKTextAlign.Center
                                        };

                                        // Measure the string to center it
                                        var textBounds = new SKRect();
                                        labelPaint.MeasureText(labelText, ref textBounds);
                                        var textPosition = new SKPoint(
                                            skBitmap.Width / 2,
                                            textBounds.Height // Position at the top
                                        );

                                        // Draw the text at the calculated position
                                        canvas.DrawText(labelText, textPosition, labelPaint);
                                    }

                                    // Draw the original barcode image onto the new bitmap
                                    canvas.DrawBitmap(skBitmap, new SKRect(0, extraHeight, skBitmap.Width, skBitmap.Height + extraHeight));
                                }

                                // Convert SKBitmap to System.Drawing.Image and set it as BackgroundImage
                                SaveBarcodeImage(bitmapWithLabel);
                            }
                        }
                    }

                    // Show the encoding time
                    lblEncodingTime.Text = @"(" + Math.Round(_b.EncodingTime, 0, MidpointRounding.AwayFromZero) + @"ms)";
                    txtEncoded.Text = _b.EncodedValue; // Keep the encoded value unchanged
                    tsslEncodedType.Text = @"Encoding Type: " + _b.EncodedType;

                    // Read dynamically calculated Width/Height
                    if (_b.BarWidth.HasValue)
                        txtWidth.Text = _b.Width.ToString();
                    if (_b.AspectRatio.HasValue)
                        txtHeight.Text = _b.Height.ToString();
                }

                if (barcode != null)
                {
                    barcode.Location = new Point(
                        (barcode.Parent.ClientSize.Width - barcode.Width) / 2,
                        (barcode.Parent.ClientSize.Height - barcode.Height) / 2);
                }
                else
                {
                    MessageBox.Show("El control de código de barras no está inicializado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExportarMasivo_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDown1.Value;
            ExportBarcodesToExcel(count);
        }

        private void ExportBarcodesToExcel(int count)
        {
            try
            {
                // Generar el nombre del archivo con la fecha y hora actuales
                string fileName = $"DatosCodigos_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                // Crear un nuevo libro de Excel
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una hoja de trabajo
                    var worksheet = workbook.Worksheets.Add("Barcode Data");

                    // Agregar los encabezados
                    worksheet.Cell("A1").Value = "Código";
                    worksheet.Cell("B1").Value = "Descripción";
                    worksheet.Cell("C1").Value = "Imagen";

                    // Generar y agregar cada código de barras
                    for (int i = 0; i < count; i++)
                    {
                        // Aquí puedes agregar la lógica para generar cada código de barras
                        // y la información correspondiente. Este es solo un ejemplo simple.
                        var row = i + 2;
                        string dataText = $"Código {i + 1}";
                        string labelText = $"Descripción {i + 1}";

                        // Establecer los datos
                        worksheet.Cell($"A{row}").Value = dataText;
                        worksheet.Cell($"B{row}").Value = labelText;

                        // Agregar la imagen generada (solo un ejemplo, adapta esto según tu lógica)
                        using (var ms = new MemoryStream())
                        {
                            // Generar el código de barras (aquí debes implementar la lógica para cada imagen)
                            GenerateBarcode(); // Modifica esta función según tu implementación

                            if (cc.BackgroundImage != null)
                            {
                                cc.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                ms.Seek(0, SeekOrigin.Begin);

                                // Agregar la imagen a la hoja de trabajo en la columna C
                                var picture = worksheet.AddPicture(ms)
                                    .MoveTo(worksheet.Cell($"C{row}"))
                                    .WithSize(200, 100); // Ajusta el tamaño según sea necesario
                            }
                        }
                    }

                    // Guardar el archivo de Excel
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Guardar datos de códigos de barras en Excel";
                        saveFileDialog.FileName = fileName;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Datos exportados exitosamente!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }

       

        private NumericUpDown numericUpDownCount = new NumericUpDown
        {
            Minimum = 1,
            Maximum = 100, // Ajusta según sea necesario
            Value = 1
        };

        private void btnPrint_Click(object sender, EventArgs e)
        {

            // Validación: Verificar si hay un código de barras generado en cc.BackgroundImage
            if (cc.BackgroundImage == null)
            {
                MessageBox.Show("No hay un código de barras generado para imprimir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si no hay código de barras generado
            }
            // Tamaño del código de barras (en milímetros)
            double anchoCodigoMm = 43.75;  // Ancho del código de barras en mm
            double altoCodigoMm = 26.33;   // Alto del código de barras en mm

            // Espacio entre códigos (en milímetros)
            double espacioHorizontalMm = 5; // Espacio horizontal entre códigos en mm
            double espacioVerticalMm = 5;   // Espacio vertical entre códigos en mm

            // Márgenes (en milímetros)
            double margenIzquierdoMm = 10; // Margen izquierdo en mm
            double margenSuperiorMm = 10;  // Margen superior en mm

            // Conversión de milímetros a pulgadas (1 pulgada = 25.4 mm)
            double mmToInch = 25.4;
            float anchoCodigoInch = (float)(anchoCodigoMm / mmToInch);
            float altoCodigoInch = (float)(altoCodigoMm / mmToInch);
            float espacioHorizontalInch = (float)(espacioHorizontalMm / mmToInch);
            float espacioVerticalInch = (float)(espacioVerticalMm / mmToInch);
            float margenIzquierdoInch = (float)(margenIzquierdoMm / mmToInch);
            float margenSuperiorInch = (float)(margenSuperiorMm / mmToInch);

            // Conversión de pulgadas a píxeles (basado en 100 dpi, que es común en impresión)
            float dpi = 100; // Ajusta este valor según la configuración de tu impresora
            float anchoCodigoPx = anchoCodigoInch * dpi;
            float altoCodigoPx = altoCodigoInch * dpi;
            float espacioHorizontalPx = espacioHorizontalInch * dpi;
            float espacioVerticalPx = espacioVerticalInch * dpi;
            float margenIzquierdoPx = margenIzquierdoInch * dpi;
            float margenSuperiorPx = margenSuperiorInch * dpi;

            // Configuración de impresión
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false; // Orientación vertical

            printDoc.PrintPage += (senderPrint, ePrint) =>
            {
                // Posición inicial
                float xPos = margenIzquierdoPx;
                float yPos = margenSuperiorPx;

                // Número total de códigos que queremos imprimir por hoja
                int totalCodigos = 36; // 9 filas x 4 columnas

                int contador = 0;
                for (int y = 0; y < 9; y++) // 9 filas
                {
                    for (int x = 0; x < 4; x++) // 4 columnas
                    {
                        // Verifica si el índice del código excede el total
                        if (contador >= totalCodigos)
                            return;

                        // Calcula la posición del siguiente código
                        float xPosActual = xPos + (x * (anchoCodigoPx + espacioHorizontalPx));
                        float yPosActual = yPos + (y * (altoCodigoPx + espacioVerticalPx));

                        // Ajustar el dibujo de la imagen
                        if (cc.BackgroundImage != null)
                        {
                            ePrint.Graphics.DrawImage(cc.BackgroundImage, xPosActual, yPosActual, anchoCodigoPx, altoCodigoPx);
                        }
                        else
                        {
                            // Si no hay código de barras, dibuja un rectángulo vacío
                            ePrint.Graphics.DrawRectangle(Pens.Black, xPosActual, yPosActual, anchoCodigoPx, altoCodigoPx);
                        }

                        contador++;
                    }
                }
            };

            // Mostrar la vista previa antes de imprimir
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = printDoc
            };
            printPreview.ShowDialog();
        }





    }
}
