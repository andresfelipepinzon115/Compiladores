using Compilador.AnalisisLexico;
using Compilador.Cache;
using Compilador.GestorErrores;
using Compilador.TablaComponentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Compilador.AnalisisSintactico;

namespace Compilador
{
    public static class DataStorage
    {
        public static string ManualInputData { get; set; }
    }
    public partial class form1 : Form
    {
        private TabControl tabControl;
        public TextBox entryTextBox;
        public TextBox resultTextBox;
        private Button fileButton;
        private Button manualButton;
        private DataTable tabla = new DataTable();//Tabla
        private DataTable errores = new DataTable();//Errores

        private RadioButton textInputRadioButton;
        private RadioButton pointInputRadioButton;
        private RadioButton numberInputRadioButton;
        private RadioButton textOutputRadioButton;
        private RadioButton pointOutputRadioButton;
        private RadioButton numberOutputRadioButton;
        private  AnalisisSintactico  ;

        public int inputControl = 0;
        public int outputControl = 0;
        public TablaMaestra tablaMaestra;
        public ManejadorErrores manejadorErrores;
        public List<ComponenteLexico> listaRetorno;
        public List<Error> listaErrores;

        public DataGridView dataGridView1 = new DataGridView //Tablas
        {
            Dock = DockStyle.Fill

        };
        public DataGridView dataGridView2 = new DataGridView //Errores
        {
            Dock = DockStyle.Fill

        };


        private VScrollBar vScrollBar;



        public form1()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            Text = "Compiladores";
            Size = new System.Drawing.Size(1500, 700);

            tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(tabControl);

            AddTabWithContentOption("Traducción");
            AddTabWithContentOption("Tablas");
            AddTabWithContentOption("Errores");

        }

        private void AddTabWithContentOption(string tabName)
        {
            if (tabName.Equals("Traducción"))
            {
                var tabPage = new TabPage(tabName);
                tabControl.TabPages.Add(tabPage);

                var contentPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10)
                };

                tabPage.Controls.Add(contentPanel);

                var radioButtonInputPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 40
                };
                var radioButtonOutputPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 40
                };
                var ButtonPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 40
                };

                //Botones entrada manual / archivo
                fileButton = new Button
                {
                    Text = "Load File",
                    Location = new System.Drawing.Point(10, 10)
                };
                manualButton = new Button
                {
                    Text = "Manual Input",
                    Location = new System.Drawing.Point(fileButton.Right + 10, 10)
                };

                fileButton.Click += FileButton_click;
                manualButton.Click += ManualButton_click;

                //Radiobutton entrada

                textInputRadioButton = new RadioButton
                {
                    Text = "Text Input",
                    Location = new System.Drawing.Point(10, 10)
                };
                textInputRadioButton.CheckedChanged += OptionRadioButton_CheckedChanged;

                pointInputRadioButton = new RadioButton
                {
                    Text = "Point Input",
                    Location = new System.Drawing.Point(textInputRadioButton.Right + 10, 10)
                };
                pointInputRadioButton.CheckedChanged += OptionRadioButton_CheckedChanged;

                numberInputRadioButton = new RadioButton
                {
                    Text = "Number Input",
                    Location = new System.Drawing.Point(pointInputRadioButton.Right + 10, 10)
                };
                numberInputRadioButton.CheckedChanged += OptionRadioButton_CheckedChanged;


                //Radiobuton salida -> a futuro

                textOutputRadioButton = new RadioButton
                {
                    Text = "Text Output",
                    Location = new System.Drawing.Point(10, 10)
                };
                textOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;

                pointOutputRadioButton = new RadioButton
                {
                    Text = "Point Output",
                    Location = new System.Drawing.Point(textOutputRadioButton.Right + 10, 10)
                };
                pointOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;

                numberOutputRadioButton = new RadioButton
                {
                    Text = "Number Output",
                    Location = new System.Drawing.Point(pointOutputRadioButton.Right + 10, 10)
                };
                numberOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;


                //Cuadros texto para entrada / salida
                entryTextBox = new TextBox
                {
                    Multiline = true,
                    Location = new System.Drawing.Point(10, 130),
                    Height = 500,
                    Width = 700,
                    ScrollBars = ScrollBars.Vertical,
                    ForeColor = System.Drawing.Color.White,
                    BackColor = System.Drawing.Color.Black,
                    Font = new System.Drawing.Font("Console", 12),
                    BorderStyle = BorderStyle.FixedSingle,
                    ReadOnly = true

                };

                contentPanel.Controls.Add(entryTextBox);

                resultTextBox = new TextBox
                {
                    Multiline = true,
                    Location = new System.Drawing.Point(720, 130),
                    Height = 500,
                    Width = 700,
                    ScrollBars = ScrollBars.Vertical,
                    ForeColor = System.Drawing.Color.White,
                    BackColor = System.Drawing.Color.Black,
                    Font = new System.Drawing.Font("Console", 12),
                    BorderStyle = BorderStyle.FixedSingle,
                    ReadOnly = true

                };

                contentPanel.Controls.Add(resultTextBox);


                ButtonPanel.Controls.Add(fileButton);
                ButtonPanel.Controls.Add(manualButton);

                //A futuro
                radioButtonInputPanel.Controls.Add(textInputRadioButton);
                radioButtonInputPanel.Controls.Add(pointInputRadioButton);
                radioButtonInputPanel.Controls.Add(numberInputRadioButton);

                radioButtonOutputPanel.Controls.Add(textOutputRadioButton);
                radioButtonOutputPanel.Controls.Add(pointOutputRadioButton);
                radioButtonOutputPanel.Controls.Add(numberOutputRadioButton);

                contentPanel.Controls.Add(ButtonPanel);
                contentPanel.Controls.Add(radioButtonOutputPanel);
                contentPanel.Controls.Add(radioButtonInputPanel);
            }
            else if (tabName.Equals("Tablas"))
            {
                var tabPage = new TabPage(tabName);


                tabControl.TabPages.Add(tabPage);
                tabPage.Controls.Add(dataGridView1);

                var contentPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10)
                };

                tabPage.Controls.Add(contentPanel);

                tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
                tabla.Columns.Add("Identificador");
                tabla.Columns.Add("Categoria");
                tabla.Columns.Add("Lexema");
                tabla.Columns.Add("Numero Linea");
                tabla.Columns.Add("Posicion Inicial");
                tabla.Columns.Add("Posicion Final");

                dataGridView1.DataSource = tabla;

            }
            else if (tabName.Equals("Errores"))
            {
                var tabPage = new TabPage(tabName);


                tabControl.TabPages.Add(tabPage);
                tabPage.Controls.Add(dataGridView2);

                var contentPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10)
                };

                tabPage.Controls.Add(contentPanel);

                tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
                errores.Columns.Add("Identificador");
                errores.Columns.Add("Numero Linea");
                errores.Columns.Add("Posicion Inicial");
                errores.Columns.Add("Posicion Final");
                errores.Columns.Add("Lexema");
                errores.Columns.Add("Falla");
                errores.Columns.Add("Causa");
                errores.Columns.Add("Solucion");
                errores.Columns.Add("Tipo");
                errores.Columns.Add("Categoria");



                dataGridView2.DataSource = errores;

            }

        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén la pestaña seleccionada
            TabPage selectedTab = tabControl.SelectedTab;


            // Verifica si la pestaña seleccionada es la de "Tablas"
            if (selectedTab.Text == "Tablas")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    tabla.Rows.Clear();
                    dataGridView1.DataSource = tabla;
                }


                tablaMaestra = TablaMaestra.ObtenerTablaMaestra();
                listaRetorno = tablaMaestra.ObtenerTodosSimbolos(TipoComponente.LITERAL);

                var i = 0;

                foreach (var item in listaRetorno)
                {
                    tabla.Rows.Add(i, item.Categoria, item.Lexema, item.NumeroLinea, item.PosicionInicial, item.PosicionFinal);
                    i++;
                }


            }
            else if (selectedTab.Text == "Errores")
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    errores.Rows.Clear();
                    dataGridView2.DataSource = errores;
                }
                var i = 0;

                manejadorErrores = ManejadorErrores.ObtenerManejadorErrores();
                listaErrores = manejadorErrores.ObtenerErrores(TipoError.LEXICO);


                foreach (var item in listaErrores)
                {
                    errores.Rows.Add(i, item.NumeroLinea, item.PosicionInicial, item.PosicionFinal, item.Lexema, item.Falla, item.Causa, item.Solucion, item.Tipo, item.Categoria);
                    i++;
                }
                i = 0;

                listaErrores = manejadorErrores.ObtenerErrores(TipoError.SINTACTICO);


                foreach (var item in listaErrores)
                {
                    errores.Rows.Add(i, item.NumeroLinea, item.PosicionInicial, item.PosicionFinal, item.Lexema, item.Falla, item.Causa, item.Solucion, item.Tipo, item.Categoria);
                    i++;
                }
                i = 0;
                listaErrores = manejadorErrores.ObtenerErrores(TipoError.SEMANTICO);


                foreach (var item in listaErrores)
                {
                    errores.Rows.Add(i, item.NumeroLinea, item.PosicionInicial, item.PosicionFinal, item.Lexema, item.Falla, item.Causa, item.Solucion, item.Tipo, item.Categoria);
                    i++;
                }
            }
        }

        private void ManualButton_click(object sender, EventArgs e)
        {
            ManualInput();
            DataCache.Limpiar();
        }
        private void FileButton_click(object sender, EventArgs e)
        {
            LoadFile();
            DataCache.Limpiar();
        }

        private void mostrarEntrada(List<string> fileLines)
        {
            entryTextBox.Clear();
            for (int lineNumber = 1; lineNumber <= fileLines.Count; lineNumber++)
            {
                entryTextBox.AppendText($"{lineNumber}: {fileLines[lineNumber - 1]}{Environment.NewLine}");
            }

        }
        private void mostrarSalida(string result)
        {
            resultTextBox.Clear();
            /*
            List<string> texto = result.Split('\r').ToList();
            for (int lineNumber = 1; lineNumber < texto.Count; lineNumber++)
            {
                resultTextBox.AppendText($"{lineNumber}: {texto[lineNumber - 1].Trim()}{Environment.NewLine}");
            }
            */
            resultTextBox.AppendText(result);
        }

        private void OptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            if (sender is RadioButton radioButton && radioButton.Checked)
            {


                if (radioButton == textInputRadioButton)
                {
                    inputControl = 0;
                }

                if (radioButton == pointInputRadioButton)
                {
                    inputControl = 1;
                }

                if (radioButton == numberInputRadioButton)
                {
                    inputControl = 2;
                }


            }

        }
        private void OptionOutputRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            if (sender is RadioButton radioButton && radioButton.Checked)
            {



                if (radioButton == textOutputRadioButton)
                {
                    outputControl = 0;
                }

                if (radioButton == pointOutputRadioButton)
                {
                    outputControl = 1;
                }

                if (radioButton == numberOutputRadioButton)
                {
                    outputControl = 2;
                }

            }

        }

        private void LoadFile()
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

                    gramatica = new AnalisisSintactico(inputControl);
                    gramatica.Analizar();
                    mostrarSalida(gramatica.Traducir(outputControl));
                }
                catch (Exception ex)
                {
                    mostrarSalida(ex.Message);
                    resultTextBox.AppendText(Environment.NewLine);
                    resultTextBox.AppendText(ex.Message);

                }


            }
        }


        private void ManualInput()
        {
            var inputForm = new ManualInputForm();
            inputForm.ShowDialog();
            TablaMaestra.ObtenerTablaMaestra().Limpiar();

            if (!string.IsNullOrWhiteSpace(DataStorage.ManualInputData))
            {

                List<string> lineasAnalex = DataStorage.ManualInputData.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

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

                    gramatica = new AnalizadorSintatico(inputControl);
                    gramatica.Analizar();
                    mostrarSalida(gramatica.Traducir(outputControl));
                }
                catch (Exception ex)
                {
                    mostrarSalida(ex.Message);
                    resultTextBox.AppendText(Environment.NewLine);
                    resultTextBox.AppendText(ex.Message);

                }
            }

            DataStorage.ManualInputData = null;
        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            entryTextBox.ScrollToCaret();
        }
    }


    public class ManualInputForm : Form
    {
        private TextBox inputTextBox;
        private Button loadButton;

        public ManualInputForm()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            int ancho = 800;
            int alto = 500;
            Text = "Manual Input";
            Size = new System.Drawing.Size(ancho, alto);

            inputTextBox = new TextBox
            {
                Multiline = true,
                Location = new System.Drawing.Point(10, 10),
                Height = 410,
                Width = 740,
            };

            loadButton = new System.Windows.Forms.Button
            {
                Text = "load",
                Dock = DockStyle.Bottom,

            };

            loadButton.Click += LoadButton_Click;
            Controls.Add(inputTextBox);
            Controls.Add(loadButton);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DataStorage.ManualInputData = inputTextBox.Text;
            Close();
        }
    }
}
