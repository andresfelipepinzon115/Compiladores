using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Compilador.AnalisisLexico;



namespace Compilador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ManualInputButton_Click_Click(object sender, EventArgs e)
        {
            string inputText = ManualInputTextBox.Text;
            string translatedText = TranslateText(inputText);
            OutputTextBox.Text = translatedText;
        }

        private string TranslateText(string inputText)
        {
            string inputLanguage = GetSelectedLanguage(groupBox1);
            string outputLanguage = GetSelectedLanguage(groupBox3);


            if (inputLanguage == "TextIn" && outputLanguage == "TextOut")
            {
                using (StreamWriter textOut = new StreamWriter("TextOut.txt")) 
                {
                    AnalizadorLexico textoInstance = new AnalizadorLexico(textOut);
                    textoInstance.ProcesarEstado0T();

                    string resultado = textoInstance.GetResultado();
                    return resultado;
                }
            }
            else if (inputLanguage == "TextIn" && outputLanguage == "NumOut")
            {
                return "Lógica de traducción no implementada";
            }
            else if (inputLanguage == "TextIn" && outputLanguage == "PuntOut")
            {
                return "Lógica de traducción no implementada";
            }
            //NUMERO A
            else if (inputLanguage == "NumIn" && outputLanguage == "NumOut")
            {
                return inputText;
            }
            else if (inputLanguage == "NumIn" && outputLanguage == "TextOut")
            {
                return "Lógica de traducción no implementada";
            }
            else if (inputLanguage == "NumIn" && outputLanguage == "PuntOut")
            {
                return "Lógica de traducción no implementada";
            }

            //PUNTO A
            else if (inputLanguage == "PuntIn" && outputLanguage == "PuntOut")
            {
                return inputText;
            }
            else if (inputLanguage == "PuntIn" && outputLanguage == "TextOut")
            {
                return "Lógica de traducción no implementada";
            }
            else if (inputLanguage == "PuntIn" && outputLanguage == "NumOut")
            {
                return "Lógica de traducción no implementada";
            }

            return "Lógica de traducción no implementada";
        }

        private string GetSelectedLanguage(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Name;
                }
            }
            return string.Empty;
        }
        private void LoadFromFileButton_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de código (*.cs;*.cpp;*.py)|*.cs;*.cpp;*.py|Documentos Word (*.doc;*.docx)|*.doc;*.docx|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    string fileExtension = Path.GetExtension(fileName).ToLower();

                    if (fileExtension == ".txt" || fileExtension == ".cs" || fileExtension == ".cpp" || fileExtension == ".py")
                    {
                        OutputTextBox.Text = File.ReadAllText(fileName);
                    }
                    else
                    {
                        OutputTextBox.Text = "Tipo de archivo no compatible.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}