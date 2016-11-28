using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace MbDataManagement
{
    public class MbXmlDataGridView : System.Windows.Forms.DataGridView
    {
        static String xml_Element_Grid = "GRID";
        static String xml_Element_Row = "ROW";
        
        //****************************************
        // Saves the Info of the Grid to a File
        //*****************************************
        public void SaveToXml(String xmlFile)
        {

            if (!Directory.Exists(Path.GetDirectoryName(xmlFile)))
                Directory.CreateDirectory(Path.GetDirectoryName(xmlFile));

            using (XmlWriter writer = XmlWriter.Create(xmlFile))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement(xml_Element_Grid);
                for (int i = 0; i < this.Rows.Count - 1; i++)
                {
                    writer.WriteStartElement(xml_Element_Row);
                    for (int j = 0; j < this.Columns.Count; j++)
                    {
                        String columnValue = (this.Rows[i].Cells[j].Value == null) ? "" : this.Rows[i].Cells[j].Value.ToString();
                        writer.WriteElementString(this.Columns[j].Name, columnValue);
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            return;
        }

        //****************************************
        // Loads the Info of the Grid from a File
        //****************************************
        public void LoadFromXml(String xmlFile)
        {
            if (!File.Exists(xmlFile))
                return;

            using (XmlReader reader = XmlReader.Create(xmlFile))
            {
                int index = -1;
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == xml_Element_Grid)
                        {
                            continue;
                        }
                        else if (reader.Name == xml_Element_Row)
                        {
                            index = this.Rows.Add();
                        }
                        else
                        {
                            while (reader.Name != xml_Element_Row)
                            {
                                String columnName = reader.Name;
                                if (this.Columns[columnName] == null)
                                {
                                    int column = this.Columns.Add(columnName, columnName);
                                    this.Columns[column].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                                }

                                this.Rows[index].Cells[reader.Name].Value = reader.ReadInnerXml();
                            }

                        }
                    }
                }
            }
        }

    }
}
