using ComiladorTraductor.AnalizadorLexico;
using ComiladorTraductor.AnalizadorSintactico;
using ComiladorTraductor.Cache;
using ComiladorTraductor.ManejadorErrores;
using ComiladorTraductor.Tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComiladorTraductor
{
    public partial class Form1 : Form
    {
        public AnalisisSintatico gramatica;
        public TablaMaestra tablaMaestra;
        public ManejadorTodosErrores manejadorErrores;
        public List<ComponenteLexico> listaRetorno;
        public List<Error> listaErrores;

        public int Entrada = 0;
        public int Salida = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresoArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //Filter = "Text Files (*.txt)|*.txt"
                //Filter = "Archivos de Texto|*.txt;*.html;*.xml;*.json;*.htm|Todos los archivos|*.*"
                Filter = "Archivos de Texto|*.txt;*.html;*.xml;*.json;*.htm"
            };
            TablaMaestra.ObtenerTablaMaestra().Limpiar();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> fileLines = File.ReadAllLines(filePath).ToList();
                mostrarEntrada(fileLines);
                for (int lineNumber = 0; lineNumber < fileLines.Count; lineNumber++)
                {
                    DataCache.AgregarLinea(fileLines[lineNumber]);
                }
                try
                {
                    gramatica = new AnalisisSintatico(Entrada);
                    gramatica.Analizar();
                    SalidaTexto(gramatica.Traducir(Salida));
                }
                catch (Exception ex)
                {
                    SalidaTexto(ex.Message);
                    salidaTextBox.AppendText(Environment.NewLine);
                    salidaTextBox.AppendText(ex.Message);
                }
            }
        }
        private void mostrarEntrada(List<string> fileLines)
        {
            entradatextBox.Clear();
            for (int lineNumber = 1; lineNumber <= fileLines.Count; lineNumber++)
            {
                entradatextBox.AppendText($"{lineNumber}: {fileLines[lineNumber - 1]}{Environment.NewLine}");
            }

        }
        private void SalidaTexto(string result)
        {
            salidaTextBox.Clear();
            salidaTextBox.AppendText(result);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresoArchivo();
            DataCache.limpiar();
            ImprimirComponentes();
            ImprimirErrores();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                if (radioButton == radioButton1)
                {
                    Entrada = 0;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                if (radioButton == radioButton2)
                {
                    Entrada = 1;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                if (radioButton == radioButton3)
                {
                    Entrada = 2;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                if (radioButton == radioButton4)
                {
                    Salida = 0;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {

                if (radioButton == radioButton5)
                {
                    Salida = 1;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                if (radioButton == radioButton6)
                {
                    Salida = 2;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManualInput();
            DataCache.limpiar();
            ImprimirComponentes();
            ImprimirErrores();


        }
        private void ImprimirComponentes()
        {
            tablaMaestra = TablaMaestra.ObtenerTablaMaestra();
            listaRetorno = tablaMaestra.ObtenerTodosSimbolos(TipoComponente.LITERAL);
            int i = 0;

            foreach (var item in listaRetorno)
            {
                dataGridView1.Rows.Add(i, item.Categoria, item.Lexema, item.NumeroLinea, item.PosicionInicial, item.PosicionFinal);
                i++;
            }
        }
        private void ImprimirErrores()
        {
            int i = 0;

            manejadorErrores = ManejadorTodosErrores.ObtenerManejadorDeErrores();
            listaErrores = manejadorErrores.ObtenerErrores(TipoError.LEXICO);


            foreach (var item in listaErrores)
            {
                dataGridView2.Rows.Add(i, item.NumeroLinea, item.PosicionInicial, item.PosicionFinal, item.Lexema, item.Falla, item.Causa, item.Solucion, item.Tipo, item.Categoria);
                i++;
            }
            i = 0;

           
        }
        private void ManualInput()
        {
            var ingresoTextoManual = IngresoManual.Text;
            TablaMaestra.ObtenerTablaMaestra().Limpiar();

            if (!string.IsNullOrWhiteSpace(ingresoTextoManual))
            {
                List<string> lineasAnalex = ingresoTextoManual.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int i = 0; i < lineasAnalex.Count; i++)
                {
                    lineasAnalex[i].Replace("\r\n", "\r");
                }
                mostrarEntrada(lineasAnalex);

                for (int lineNumber = 0; lineNumber < lineasAnalex.Count; lineNumber++)
                {
                    DataCache.AgregarLinea(lineasAnalex[lineNumber]);
                }
                try
                {

                    gramatica = new AnalisisSintatico(Entrada);
                    gramatica.Analizar();
                    SalidaTexto(gramatica.Traducir(Salida));
                }
                catch (Exception ex)
                {
                    SalidaTexto(ex.Message);
                    salidaTextBox.AppendText(Environment.NewLine);
                    salidaTextBox.AppendText(ex.Message);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salidaTextBox.Text = string.Empty;
            entradatextBox.Text = string.Empty;
            IngresoManual.Text = string.Empty;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

 



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
