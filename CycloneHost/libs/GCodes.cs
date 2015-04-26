using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CycloneHost.libs
{
    public class GCodes
    {
        #region Structs
        public struct GCodeSet
        {
            public String G00;
            public String G01;
            public String G02;
            public String G03;
            public String G90;
            public String G91;
            public String G92;
        };

        public struct MCodeSet
        {
            public String M03;
            public String M04;
            public String M05;
            public String M08;
            public String M09;
            public String M10;
            public String M11;
            public String M114;
        };

        public struct CodeSet
        {
            public String X;
            public String Y;
            public String Z;
            public String F;
            public String I;
            public String J;
        };

        public struct SCodeSet
        {
            public String Probe;
            public String Info;
            public String Reset;
        };

        public GCodeSet gCodeSet;
        public MCodeSet mCodeSet;
        public CodeSet codeSet;
        public SCodeSet sCodeSet;

        #endregion

        private String xmlFilePath = "";

        public GCodes(String path)
        {
            this.xmlFilePath = path;

            if (path.Equals(""))
            {
                initStdSet();
            }
            else
            {
                loadFromXML();
            }
        }

        private void initStdSet()
        {
            #region GCodes
            gCodeSet.G00 = "G00";
            gCodeSet.G01 = "G01";
            gCodeSet.G02 = "G02";
            gCodeSet.G03 = "G03";
            gCodeSet.G90 = "G90";
            gCodeSet.G91 = "G91";
            gCodeSet.G92 = "G92";
            #endregion
            #region MCodes
            mCodeSet.M03 = "M03";
            mCodeSet.M04 = "M04";
            mCodeSet.M05 = "M05";
            mCodeSet.M08 = "M08";
            mCodeSet.M09 = "M09";
            mCodeSet.M10 = "M10";
            mCodeSet.M11 = "M11";
            mCodeSet.M114 = "?";
            #endregion
            #region Codes
            codeSet.X = "X";
            codeSet.Y = "Y";
            codeSet.Z = "Z";
            codeSet.I = "I";
            codeSet.J = "J";
            codeSet.F = "F";
            #endregion
            #region SpecialCommands
            sCodeSet.Info = "$I";
            sCodeSet.Probe = "G38.2";
            sCodeSet.Reset = "(ctrl-x)";
            #endregion
        }

        public void loadFromXML(String path)
        {
            this.xmlFilePath = path;
            loadFromXML();
        }
        public void loadFromXML()
        {
            XDocument xmlDoc = XDocument.Load(xmlFilePath);
            XElement xmlCom = xmlDoc.Descendants("Commands").First<XElement>();

            #region GCodes
            XElement xmlGcodes = xmlCom.Descendants("GCodes").First<XElement>();
            gCodeSet.G00 = xmlGcodes.Descendants("G00").First<XElement>().Value;
            gCodeSet.G01 = xmlGcodes.Descendants("G01").First<XElement>().Value;
            gCodeSet.G02 = xmlGcodes.Descendants("G02").First<XElement>().Value;
            gCodeSet.G03 = xmlGcodes.Descendants("G03").First<XElement>().Value;
            gCodeSet.G90 = xmlGcodes.Descendants("G90").First<XElement>().Value;
            gCodeSet.G91 = xmlGcodes.Descendants("G91").First<XElement>().Value;
            gCodeSet.G92 = xmlGcodes.Descendants("G92").First<XElement>().Value;
            #endregion

            #region MCodes
            XElement xmlMcodes = xmlCom.Descendants("MCodes").First<XElement>();
            mCodeSet.M03 = xmlMcodes.Descendants("M03").First<XElement>().Value;
            mCodeSet.M04 = xmlMcodes.Descendants("M04").First<XElement>().Value;
            mCodeSet.M05 = xmlMcodes.Descendants("M05").First<XElement>().Value;
            mCodeSet.M08 = xmlMcodes.Descendants("M08").First<XElement>().Value;
            mCodeSet.M09 = xmlMcodes.Descendants("M09").First<XElement>().Value;
            mCodeSet.M10 = xmlMcodes.Descendants("M10").First<XElement>().Value;
            mCodeSet.M11 = xmlMcodes.Descendants("M11").First<XElement>().Value;
            mCodeSet.M114 = xmlMcodes.Descendants("M114").First<XElement>().Value;
            #endregion

            #region Codes
            XElement xmlGencodes = xmlCom.Descendants("GenericCodes").First<XElement>();
            codeSet.X = xmlGencodes.Descendants("X").First<XElement>().Value;
            codeSet.Y = xmlGencodes.Descendants("Y").First<XElement>().Value;
            codeSet.Z = xmlGencodes.Descendants("Z").First<XElement>().Value;
            codeSet.I = xmlGencodes.Descendants("I").First<XElement>().Value;
            codeSet.J = xmlGencodes.Descendants("J").First<XElement>().Value;
            codeSet.F = xmlGencodes.Descendants("F").First<XElement>().Value;
            #endregion

            #region SpecialCommands
            XElement xmlScodes = xmlCom.Descendants("SpecificCodes").First<XElement>();
            sCodeSet.Probe = xmlScodes.Descendants("Probe").First<XElement>().Value;
            sCodeSet.Info = xmlScodes.Descendants("Info").First<XElement>().Value;
            sCodeSet.Reset = xmlScodes.Descendants("Reset").First<XElement>().Value;
            #endregion
        }
    }

}
