using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CycloneHost.libs
{
    public class Settings
    {
        #region Structs
        public struct ManualControl
        {
            public int XYMovementFeed;
            public int ZMovementFeed;
            public bool InvertXAxis;
            public bool InvertYAxis;
            public bool InvertZAxis;
        };
        public struct GcodeStreaming
        {
            public int XYMaximumFeed;
            public int ZMaximumFeed;
            public int BufferSize;
            public bool PingPongProtocol;
        };
        public struct Probing
        {
            public int ZProbeFeed;
            public int XYProbeFeed;
            public double SafetyHeight;
            public double MaxDepth;
            public double PulloffHeight;
        };
        public struct CamVision
        {
            public double OffsetX;
            public double OffsetY;
        };
        public struct Misc
        {
            public int StatusUpdateInterval;
            public bool ShowStatusMessages;
            public bool ShowGRBLResponses;
        };

        public ManualControl ManualControlSettings;
        public GcodeStreaming GcodeStreamingSettings;
        public Probing ProbeSettings;
        public CamVision CamVisionSettings;
        public Misc MiscSettings;

        #endregion

        private String xmlFilePath = "";

        public Settings(String path)
        {
            this.xmlFilePath = path;

            if (File.Exists(xmlFilePath) && !xmlFilePath.Equals(""))
            {
                loadFromXML();
            }
            else
            {
                initStdSettings();
            }
        }

        private void initStdSettings()
        {
            #region ManualControlSettings
            ManualControlSettings.InvertXAxis = false;
            ManualControlSettings.InvertYAxis = false;
            ManualControlSettings.InvertZAxis = false;
            ManualControlSettings.XYMovementFeed = 1000;
            ManualControlSettings.ZMovementFeed = 300;
            #endregion
            #region GcodeStreamingSettings
            GcodeStreamingSettings.BufferSize = 1;
            GcodeStreamingSettings.XYMaximumFeed = 1000;
            GcodeStreamingSettings.ZMaximumFeed = 300;
            GcodeStreamingSettings.PingPongProtocol = true;
            #endregion
            #region ProbeSettings
            ProbeSettings.MaxDepth = 1;
            ProbeSettings.PulloffHeight = 1;
            ProbeSettings.XYProbeFeed = 50;
            ProbeSettings.ZProbeFeed = 50;
            ProbeSettings.SafetyHeight = 3;
            #endregion
            #region CamVision
            CamVisionSettings.OffsetX = 0;
            CamVisionSettings.OffsetY = 0;
            #endregion
            #region Misc
            MiscSettings.ShowStatusMessages = false;
            MiscSettings.ShowGRBLResponses = false;
            MiscSettings.StatusUpdateInterval = 1000;
            #endregion
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
                MessageBox.Show("An error occured while loading settings\nplease correct the value in " + xelem.ToString(),"Error while loading settings");
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

        public void saveToXML()
        {

        }

        public void loadFromXML(String path)
        {
            this.xmlFilePath = path;
            loadFromXML();
        }

        public void loadFromXML()
        {

            XDocument xmlDoc = XDocument.Load(xmlFilePath);
            XElement xmlSettings = xmlDoc.Descendants("Settings").First<XElement>();
            
            #region ManualControlSettings
            XElement xmlManualControlSettings = xmlSettings.Descendants("ManualControl").First<XElement>();
            ManualControlSettings.InvertXAxis = parseBoolFromXElement(xmlManualControlSettings.Descendants("InvertXAxis").First<XElement>());
            ManualControlSettings.InvertYAxis = parseBoolFromXElement(xmlManualControlSettings.Descendants("InvertYAxis").First<XElement>());
            ManualControlSettings.InvertZAxis = parseBoolFromXElement(xmlManualControlSettings.Descendants("InvertZAxis").First<XElement>());
            ManualControlSettings.XYMovementFeed = parseIntFromXElement(xmlManualControlSettings.Descendants("XYMovementFeed").First<XElement>());
            ManualControlSettings.ZMovementFeed = parseIntFromXElement(xmlManualControlSettings.Descendants("ZMovementFeed").First<XElement>());
            #endregion


            //fehler irgendwo hier
            #region GcodeStreamingSettings
            XElement xmlGcodeStreamingSettings = xmlSettings.Descendants("GcodeStreaming").First<XElement>();
            GcodeStreamingSettings.BufferSize = parseIntFromXElement(xmlGcodeStreamingSettings.Descendants("BufferSize").First<XElement>());
            GcodeStreamingSettings.XYMaximumFeed = parseIntFromXElement(xmlGcodeStreamingSettings.Descendants("XYMaximumFeed").First<XElement>());
            GcodeStreamingSettings.ZMaximumFeed = parseIntFromXElement(xmlGcodeStreamingSettings.Descendants("ZMaximumFeed").First<XElement>());
            GcodeStreamingSettings.PingPongProtocol = parseBoolFromXElement(xmlGcodeStreamingSettings.Descendants("PingPongProtocol").First<XElement>());
            #endregion

            #region ProbeSettings
            XElement xmlProbeSettings = xmlSettings.Descendants("Probing").First<XElement>();
            ProbeSettings.MaxDepth = parseDoubleFromXElement(xmlProbeSettings.Descendants("MaxDepth").First<XElement>());
            ProbeSettings.PulloffHeight = parseDoubleFromXElement(xmlProbeSettings.Descendants("PulloffHeight").First<XElement>()); ;
            ProbeSettings.XYProbeFeed = parseIntFromXElement(xmlProbeSettings.Descendants("XYProbeFeed").First<XElement>());
            ProbeSettings.ZProbeFeed = parseIntFromXElement(xmlProbeSettings.Descendants("ZProbeFeed").First<XElement>());
            ProbeSettings.SafetyHeight = parseDoubleFromXElement(xmlProbeSettings.Descendants("SafetyHeight").First<XElement>());
            #endregion

            #region CamVision
            XElement xmlCamVisionSettings = xmlSettings.Descendants("CamVision").First<XElement>();
            CamVisionSettings.OffsetX = parseDoubleFromXElement(xmlCamVisionSettings.Descendants("OffsetX").First<XElement>());
            CamVisionSettings.OffsetY = parseDoubleFromXElement(xmlCamVisionSettings.Descendants("OffsetY").First<XElement>());
            #endregion

            #region Misc
            XElement xmlMiscSettings = xmlSettings.Descendants("Misc").First<XElement>();
            MiscSettings.ShowStatusMessages = parseBoolFromXElement(xmlMiscSettings.Descendants("ShowStatusMessages").First<XElement>());
            MiscSettings.ShowGRBLResponses = parseBoolFromXElement(xmlMiscSettings.Descendants("ShowGRBLResponses").First<XElement>());
            MiscSettings.StatusUpdateInterval = parseIntFromXElement(xmlMiscSettings.Descendants("StatusUpdateInterval").First<XElement>());
            #endregion
        }
    }
}
