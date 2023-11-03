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
using Compilador.AnalisisSintactico;
using Compilador.Cache;
using Compilador.TablaComponentes;

namespace Compilador
{

    public partial class frmPrincipal : Form
    {
        public AnalisisSintacticoTraduccion gramatica;
        public int inputControl = 0;
        public int outputControl = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void LoadFromFileButton_Click_Click(object sender, EventArgs e)
        {
            ingresoArchivo();
            DataCache.Limpiar();
        }
        private void ManualInputButton_Click_Click(object sender, EventArgs e)
        {
            
        }

        
        //TEXTO A
        private void OptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            if (sender is RadioButton radioButton && radioButton.Checked)
            {


                if (radioButton == TextIn)
                {
                    inputControl = 0;
                }

                if (radioButton == NumIn)
                {
                    inputControl = 1;
                }

                if (radioButton == PuntIn)
                {
                    inputControl = 2;
                }


            }

        }
        private void OptionOutputRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            if (sender is RadioButton radioButton && radioButton.Checked)
            {



                if (radioButton == TextOut)
                {
                    outputControl = 0;
                }

                if (radioButton == NumOut)
                {
                    outputControl = 1;
                }

                if (radioButton == PuntOut)
                {
                    outputControl = 2;
                }

            }

        }

        private void ingresoArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de Texto|*.txt;*.html;*.xml;*.json;*.htm"
            };
            TablaMaestra.ObtenerTablaMaestra().Limpiar();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> fileLines = File.ReadAllLines(filePath).ToList();
                mostrarEntrada(fileLines);

                try
                {
                    gramatica = new AnalisisSintacticoTraduccion(0);
                    gramatica.Analizar();
                    SalidaTexto(gramatica.PasoPuntosTextoNumeros(1));
                }
                catch (Exception ex)
                {
                    SalidaTexto(ex.Message);
                    OutputTextBox.AppendText(Environment.NewLine);
                    OutputTextBox.AppendText(ex.Message);
                }
            }
        }



        private void mostrarEntrada(List<string> fileLines)
        {
            ManualInputTextBox.Clear();
            for (int lineNumber = 1; lineNumber <= fileLines.Count; lineNumber++)
            {
                ManualInputTextBox.AppendText($"{lineNumber}: {fileLines[lineNumber - 1]}{Environment.NewLine}");
            }

        }
        private void SalidaTexto(string result)
        {
            OutputTextBox.Clear();
            OutputTextBox.AppendText(result);
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

        private void TextIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManualInputTextBox_TextChanged(object sender, EventArgs e)
        {
     

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}