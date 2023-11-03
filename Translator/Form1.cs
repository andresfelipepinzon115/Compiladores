using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CompiladoExtraClase.AnalisisSintactico;
using CompiladoExtraClase.Cache;
using CompiladoExtraClase.ErrorManagement;
using CompiladoExtraClase.LexicalAnalysis;
using CompiladoExtraClase.TablaComponentes;

namespace CompiladoExtraClase
{
    public static class DataStorage
    {
        public static string ManualInputData { get; set; }
    }

    public partial class Form1 : Form
    {
        private TabControl tabControl;
        public TextBox entryTextBox;
        public TextBox resultTextBox;
        public TextBox resultTextBox1;
        public Label resultTes;
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
        public AnalizadorSintatico gramatica;

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



        public Form1()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {

            
            Size = new System.Drawing.Size(1100, 600);
            this.BackColor = System.Drawing.Color.Gray;

            tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(tabControl);

            AddTabWithContentOption("Traducción");


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
                    Padding = new Padding(10),
                    BackColor = System.Drawing.Color.Gray
            };
                
                tabPage.Controls.Add(contentPanel);

                var radioButtonInputPanel = new Panel  
                {
                Location = new System.Drawing.Point(300, 50), // Establece la ubicación del botón
                Width = 200, // Establece el ancho del botón
                    Height = 90,
                    BackColor = System.Drawing.Color.Azure
                  
            };
                var radioButtonOutputPanel = new Panel
                {
                    Location = new System.Drawing.Point(600, 50), // Establece la ubicación del botón
                    Width = 200, // Establece el ancho del botón
                    Height = 90,
                    BackColor = System.Drawing.Color.Azure
                };
                var ButtonPanel = new Panel
                {
                    Location = new System.Drawing.Point(0, 150), // Establece la ubicación del botón
                    Width = 1200, // Establece el ancho del botón
                    Height = 700,
                    
                };

                //Botones entrada manual / archivo
                fileButton = new Button
                {
                    Text = "CARGA DESDE ARCHIVOS",
                    UseVisualStyleBackColor = true,
                    Location = new System.Drawing.Point(730, 11),
                    Size = new System.Drawing.Size(211, 36),
                   
                };
                manualButton = new Button
                {
                    Text = "INGRESO MANUAL",
                    UseVisualStyleBackColor = true,
                Location = new System.Drawing.Point(270, 300),
                    Width = 200,// Establece el ancho a 150 píxeles
                    Height = 30
            };

                fileButton.Click += FileButton_click;
                manualButton.Click += ManualButton_click;
                resultTes = new Label
                {
                    Text = "INICIO",
                    ForeColor = System.Drawing.Color.Black,
                    BackColor = System.Drawing.Color.Transparent,
                    Font = new System.Drawing.Font("Console", 50),
                    BorderStyle = BorderStyle.None,
                    Width = 270,// Establece el ancho a 150 píxeles
                    Height = 90,
                    

                };

                contentPanel.Controls.Add(resultTes);
                //Radiobutton entrada

                textInputRadioButton = new RadioButton
                {
                    Text = "Texto",
                    Location = new System.Drawing.Point(0, 10),
                    Width = 150,// Establece el ancho a 150 píxeles
                    Height = 30
                };
                textInputRadioButton.CheckedChanged += OptionRadioButton_CheckedChanged;

                pointInputRadioButton = new RadioButton
                {
                    Text = "Puntos",
                    Location = new System.Drawing.Point(0, 30),
                    Width = 150,// Establece el ancho a 150 píxeles
                    Height = 30
                };
                pointInputRadioButton.CheckedChanged += OptionRadioButton_CheckedChanged;

                numberInputRadioButton = new RadioButton
                {
                    Text = "Numeros",
                    Location = new System.Drawing.Point(0, 50),
                    Width = 150,// Establece el ancho a 150 píxeles
                    Height = 30
                };
                numberInputRadioButton.CheckedChanged += OptionRadioButton_CheckedChanged;


                //Radiobuton salida -> a futuro
                textOutputRadioButton = new RadioButton
                {
                    Text = "selecione",
                    Location = new System.Drawing.Point(10, 10),
                    Margin = new System.Windows.Forms.Padding(15)
                };
                textOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;
                textOutputRadioButton = new RadioButton
                {
                    Text = "Texto",
                    Location = new System.Drawing.Point(0, 10),
                    Margin = new System.Windows.Forms.Padding(15)
                };
                textOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;

                pointOutputRadioButton = new RadioButton
                {
                    Text = "Puntos",
                    Location = new System.Drawing.Point(0, 30),
                    Margin = new System.Windows.Forms.Padding(15)
                };
                pointOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;

                numberOutputRadioButton = new RadioButton
                {
                    Text = "Numero",
                    Location = new System.Drawing.Point(0, 50),
                    Margin = new System.Windows.Forms.Padding(15)
            };
                numberOutputRadioButton.CheckedChanged += OptionOutputRadioButton_CheckedChanged;


                //Cuadros texto para entrada / salida
                entryTextBox = new TextBox
                {
                    Multiline = true,
                    Location = new System.Drawing.Point(360, 230),
                    Height = 200,
                    Width = 300,
                    ScrollBars = ScrollBars.Vertical,
                    ForeColor = System.Drawing.Color.Black,
                    BackColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Console", 12),
                    BorderStyle = BorderStyle.FixedSingle,
                    ReadOnly = true

                };

                contentPanel.Controls.Add(entryTextBox);

                resultTextBox = new TextBox
                {
                    Multiline = true,
                    Location = new System.Drawing.Point(680, 230),
                    Height = 200,
                    Width = 300,
                    ScrollBars = ScrollBars.Vertical,
                    ForeColor = System.Drawing.Color.Black,
                    BackColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Console", 12),
                    BorderStyle = BorderStyle.FixedSingle,
                    ReadOnly = true

                };

                contentPanel.Controls.Add(resultTextBox);
                resultTextBox1 = new TextBox
                {
                    Multiline = true,
                    Location = new System.Drawing.Point(40, 230),
                    Height = 200,
                    Width = 300,
                    ScrollBars = ScrollBars.Vertical,
                    ForeColor = System.Drawing.Color.Black,
                    BackColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Console", 12),
                    BorderStyle = BorderStyle.FixedSingle,
                    ReadOnly = true

                };

                contentPanel.Controls.Add(resultTextBox1);

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
           
            

        }

        private void ManualButton_click(object sender, EventArgs e)
        {
            ManualInput();
            DataCache.limpiar();
        }
        private void FileButton_click(object sender, EventArgs e)
        {
            LoadFile();
            DataCache.limpiar();
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
        }


        private void ManualInput()
        {
            
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

   
    }


    



}