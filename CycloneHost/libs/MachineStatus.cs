using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CycloneHost.libs
{
    public class MachineStatus
    {

        public String regexPattern = @"<(.*),MPos:(.*),(.*),(.*),WPos:(.*),(.*),(.*)>";
        public int indexMx = 2;
        public int indexMy = 3;
        public int indexMz = 4;
        public int indexWx = 5;
        public int indexWy = 6;
        public int indexWz = 7;

        public int indexStatus = 1;
        public String Status;
        public Vector3 WorkCoordinates;
        public Vector3 MachineCoordinates;
        private String xmlFilePath = "";

        public MachineStatus(String fileName)
        {
            if (!fileName.Trim().Equals(""))
            {
                xmlFilePath = fileName;
                loadFromXML();
            }
            
            Status = "idle";
            WorkCoordinates = new Vector3(0, 0, 0);
            MachineCoordinates = new Vector3(0, 0, 0);
        }

        private int parseIntFromXElement(XElement xelem)
        {
            return (int)parseDoubleFromXElement(xelem);
        }

        private double parseDoubleFromXElement(XElement xelem)
        {
            try
            {
                return double.Parse(xelem.Value, System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while loading settings\nplease correct the value in " + xelem.ToString(), "Error while loading settings");
                Application.Exit();
                return 0;
            }
        }

        private bool parseBoolFromXElement(XElement xelem)
        {

            if (parseIntFromXElement(xelem) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void loadFromXML()
        {

            XDocument xmlDoc = XDocument.Load(xmlFilePath);
            XElement xmlReg = xmlDoc.Descendants("Regex").First<XElement>();

            regexPattern = xmlReg.Descendants("RegexPattern").First<XElement>().Value;
            indexStatus = parseIntFromXElement(xmlReg.Descendants("Status").First<XElement>());
            indexMx = parseIntFromXElement(xmlReg.Descendants("MX").First<XElement>());
            indexMy = parseIntFromXElement(xmlReg.Descendants("MY").First<XElement>());
            indexMz = parseIntFromXElement(xmlReg.Descendants("MZ").First<XElement>());
            indexWx = parseIntFromXElement(xmlReg.Descendants("WX").First<XElement>());
            indexWy = parseIntFromXElement(xmlReg.Descendants("WY").First<XElement>());
            indexWz = parseIntFromXElement(xmlReg.Descendants("WZ").First<XElement>());
        }

    }
    
}
