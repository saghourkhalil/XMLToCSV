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
using System.Xml.Linq;

namespace XMLtooCSV
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open File from the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenXmlFile();
            DisplayFileXMLInDataGridView();
        }

        /// <summary>
        /// Save File from the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrezFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertTooCsv(dataTable);
        }

        /// <summary>
        /// leave appli from the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Open File From the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOuvrirFichier_Click(object sender, EventArgs e)
        {
            OpenXmlFile();
            DisplayFileXMLInDataGridView();
        }

        /// <summary>
        /// Save File from the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnregistrezFichier_Click(object sender, EventArgs e)
        {
            ConvertTooCsv(dataTable);
        }

        /// <summary>
        /// Open File Dialog
        /// </summary>
        private void OpenXmlFile()
        {
            // open file dialog   
            using(OpenFileDialog open = new OpenFileDialog())
            {
                // filters  
                open.Title = "selectionner un fichier";
                open.Filter = "Tout Les Fichiers (*.*)|*.*|Fichier XML(*.xml)|*.xml|Fichier KML(*.kml)|*.kml";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // xml file path  
                    textBoxCheminFichierXml.Text = open.FileName;
                }
            }
        }

        /// <summary>
        /// Display file XML in DataGridView
        /// </summary>
        private void DisplayFileXMLInDataGridView()
        {
            var fileOpen = textBoxCheminFichierXml.Text.Trim();
            if (fileOpen != "")
            {
                XNamespace ns = "http://www.opengis.net/kml/2.2";
                var lDocument = XDocument.Load(@fileOpen);
                var placemarks = lDocument.Descendants(ns + "Placemark").ToList();
                
                foreach (var placemark in placemarks)
                {
                    var masterName = placemark.Element(ns + "name").Value;
                    var adress = placemark.Element(ns + "address").Value;
                    var newRow = AddDataTableRow(dataTable, masterName, adress);

                    var extendedDatas = placemark.Descendants(ns + "ExtendedData");
                    foreach (var extendedData in extendedDatas)
                    {
                        var datas = extendedData.Descendants(ns + "Data");
                        foreach (var data in datas)
                        {
                            var dataName = data.Attribute("name").Value;
                            var dataValue = data.Value;
                            FillDataTableRow(dataTable, newRow, dataName, dataValue);
                        }
                    }
                }
             dataGridView1.DataSource = dataTable;
            }
        }

        /// <summary>
        /// add row entreprise and adress in datatable
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="masterName"></param>
        /// <param name="adress"></param>
        private DataRow AddDataTableRow(DataTable dataTable, string masterName, string adress)
        {
            DataRow row = dataTable.NewRow(); 
            if (!dataTable.Columns.Contains("Nom Entreprise") ||
               !dataTable.Columns.Contains("Adresse"))
            {
                dataTable.Columns.Add("Nom Entreprise");
                dataTable.Columns.Add("Adresse");
            }
            row[0] = masterName;
            row[1] = adress;
            dataTable.Rows.Add(row);
            return row;
        }

        /// <summary>
        /// Add row in datatable
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="masterName"></param>
        /// <param name="adress"></param>
        /// <param name="dataName"></param>
        /// <param name="dataValue"></param>
        private void FillDataTableRow(DataTable dataTable, DataRow datarow, string dataName, string dataValue)
        {
            if (!dataTable.Columns.Contains(dataName))
            {
                dataTable.Columns.Add(dataName);
            }
            datarow[dataName] = dataValue.Replace("\n", " ");
        }

        /// <summary>
        /// Convert dataTable to Csv
        /// Save File Csv
        /// </summary>
        private void ConvertTooCsv(DataTable dataTable)
        {
            OpenLocationCsvFile();
            var saveFile = textBoxCheminFichierXml.Text.Trim();
            
            if (!String.IsNullOrWhiteSpace(saveFile))
            {
                var result = new StringBuilder();
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    result.Append(dataTable.Columns[i].ColumnName);
                    result.Append(i == dataTable.Columns.Count - 1 ? "\n" : ";");
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        result.Append(row[i].ToString());
                        result.Append(i == dataTable.Columns.Count - 1 ? "\n" : "; ");
                    }
                }
                File.WriteAllText(@saveFile, result.ToString(),Encoding.GetEncoding(1252));
            }
        }

        /// <summary>
        /// Openl Location File for Csv
        /// </summary>
        private void OpenLocationCsvFile()
        {
            // save file dialog   
            SaveFileDialog save = new SaveFileDialog();

            // filters  
            save.Title = "selectionner un emplacement d'enregistrement";
            save.Filter = "Fichier CSV(*.csv)|*.csv";
            if (save.ShowDialog() == DialogResult.OK)
            {
                // csv file path  
                textBoxCheminFichierXml.Text = save.FileName;
            }
        }
    }
}