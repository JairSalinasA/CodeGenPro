# CodeGenPro 🖨️📦

## Descripción 📖
CodeGenPro es una aplicación de escritorio desarrollada en Windows Forms para generar códigos de barras y códigos QR. Los códigos pueden ser generados de manera individual o masiva mediante un archivo de Excel. La aplicación permite imprimir los códigos en una impresora física o en una impresora virtual de Microsoft, generando un PDF.

## Funcionalidades 🔧
- **Generación de Códigos:** Genera códigos de barras y QR de forma individual o masiva.
- **Codificaciones Soportadas:**
  - QR: L, H, M, Q
  - Barras: Code128, Code128A, Code39, Ean13, UPC-A, UPC-E
- **Formatos de Impresión:** A4, 76mm, 60mm, 58mm, 50mm, o formato de imagen personalizado.
- **Exportación:** Genera archivos PDF o PNG.
- **Ajuste de Colores:** Personaliza los colores de los códigos generados.

## Requisitos del Sistema 🖥️
- **Windows:** Versión 7 o superior.
- **.NET Framework:** Versión 8.
- **SQL Server:** Versión 2017 o superior.

## Instalación 🚀
1. Clona el repositorio:
    ```bash
    git clone https://github.com/JairSalinasA/CodeGenPro.git
    ```

2. Abre la solución en Visual Studio.

3. Configura la cadena de conexión a tu instancia de SQL Server en el archivo de configuración.

4. Compila y ejecuta la aplicación.

## Uso 📂
1. Inicia la aplicación desde Visual Studio.
2. Selecciona la opción de generación individual o masiva.
3. Si seleccionas la generación masiva, carga la plantilla de Excel con los datos necesarios.
4. Personaliza el formato y las opciones de impresión.
5. Genera y guarda los códigos en formato PDF o PNG.

## Contribuciones 🤝
¡Las contribuciones son bienvenidas! Por favor, sigue los pasos a continuación:
1. Haz un fork del repositorio.
2. Crea una nueva rama para tu funcionalidad (`git checkout -b nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -am 'Añadir nueva funcionalidad'`).
4. Empuja la rama (`git push origin nueva-funcionalidad`).
5. Abre un Pull Request.

## Licencia 📄
Este proyecto está licenciado bajo la MIT License.

¡Gracias por usar CodeGenPro! Si tienes alguna pregunta o sugerencia, no dudes en contactarnos.
