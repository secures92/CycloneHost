using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Collections;


namespace CycloneHost
{
    /// <summary>
    /// Interaktionslogik für GCodeView.xaml
    /// </summary>
    public partial class GCodeView : UserControl
    {
        public GCodeView()
        {
            InitializeComponent();
        }

        Point origin;

        GCode gc = null;
        bool absolutepositioning = true;
        Point lastPos = new Point(0, 0);
        public double scale = 1;

        public void attachGcode(string filename)
        {
            gc = new GCode(filename);
        }

        private void Canvas_Loaded_1(object sender, RoutedEventArgs e)
        {
            origin = new Point(this.Canvas.ActualWidth / 2, this.Canvas.ActualHeight / 2);
            drawFrame();
        }

        private void drawFrame()
        {
            this.Canvas.Children.Clear();
            int width = (int)this.Canvas.ActualHeight;
            int height = (int)this.Canvas.ActualWidth;
            int thickness = 4;
            Brush bru = Brushes.Black;

            drawLine(0, origin.Y, height, origin.Y, 1, Brushes.Red);
            drawLine(origin.X, 0,origin.X, width, 1, Brushes.Red);


            drawLine(0, 0, height, 0, thickness, bru);
            drawLine(0, 0, 0, width, thickness, bru);
            drawLine(height, width, height, 0, thickness, bru);
            drawLine(height, width, 0, width, thickness, bru);

        }

        private void drawLine(Double x1, Double y1, Double x2, Double y2, int thickness, Brush brush)
        {
            Line line = new Line();

            line.Stroke = brush;
            line.StrokeThickness = thickness;

            double width = this.Canvas.ActualHeight / 2;
            double height = this.Canvas.ActualWidth / 2;


            line.X1 = x1;
            line.Y1 = y1;

            line.X2 = x2;
            line.Y2 = y2;
            this.Canvas.Children.Add(line);
        }

        private void drawLineFromZero(Double x1, Double y1, Double x2, Double y2, int thickness, Brush brush)
        {
            Line line = new Line();

            line.Stroke = brush;
            line.StrokeThickness = thickness;

            line.X1 = scale * x1 + origin.X;
            line.Y1 = -scale * y1 + origin.Y;

            line.X2 = scale * x2 + origin.X;
            line.Y2 = -scale * y2 + origin.Y;
            this.Canvas.Children.Add(line);
        }

        private void drawArc(Double x, Double y, Double i, Double j)
        {

        }

        private void drawArcFromZero(Double x, Double y, Double i, Double j)
        {

        }

        private void drawGCode()
        {
            calcZoom();
            lastPos = new Point(0, 0);
            for (int i = 0; i < gc.gCodeList.Count; i++)
            {
                switch (gc.gCodeList[i].code)
                {
                    #region Code: G0/G1
                    case "G0":
                    case "G00":
                    case "G1":
                    case "G01":
                        #region AbsollutePositioning
                        if (absolutepositioning)
                        {
                            double xNew = 0, yNew = 0;
                            if (Double.IsNaN(gc.gCodeList[i].x))
                            {
                                xNew = lastPos.X;
                            }
                            else
                            {
                                xNew = gc.gCodeList[i].x;
                            }
                            if (Double.IsNaN(gc.gCodeList[i].y))
                            {
                                yNew = lastPos.Y;
                            }
                            else
                            {
                                yNew = gc.gCodeList[i].y;
                            }
                            Point newPos = new Point(xNew, yNew);

                            drawLineFromZero(lastPos.X, lastPos.Y, newPos.X, newPos.Y, 1, Brushes.Blue);
                            lastPos = newPos;
                        }
                            #endregion

                        #region RelativePositioning
                        else//relativepositioning
                        {

                            if (Double.IsNaN(gc.gCodeList[i].x))
                            {
                                gc.gCodeList[i].x = 0;
                            }
                            if (Double.IsNaN(gc.gCodeList[i].y))
                            {
                                gc.gCodeList[i].y = 0;
                            }
                            Point newPos = new Point(lastPos.X + gc.gCodeList[i].x, lastPos.Y + gc.gCodeList[i].y);
                            drawLineFromZero(lastPos.X, lastPos.Y, newPos.X, newPos.Y, 1, Brushes.Blue);
                            lastPos = newPos;
                        }
                        break;
                        #endregion
                   
                    #endregion

                    #region Code: G2/G3
                    case "G02":
                    case "G2":
                        // do G2 Arc draw here
                        break;
                    case "G03":
                    case "G3":
                        //do G3 Arc draw here
                        break;
                    #endregion

                    #region Code: G90/G91
                    case "G90":
                        absolutepositioning = true;
                        break;
                    case "G91":
                        absolutepositioning = false;
                        break;
                    #endregion
                }


            }
        }

        public void clear()
        {
            drawFrame();
        }

        public void updateView()
        {
            drawFrame();
            if (gc != null)
            {
                drawGCode();
            }
        }

        private void calcZoom()
        {
            double xMin = Double.MaxValue;
            double yMin = Double.MaxValue;
            double xMax = 0;
            double yMax = 0;

            for (int i = 0; i < gc.gCodeList.Count; i++)
            {
                if (gc.gCodeList[i].x < xMin) xMin = gc.gCodeList[i].x;
                if (gc.gCodeList[i].y < yMin) yMin = gc.gCodeList[i].y;
                if (gc.gCodeList[i].x > xMax) xMax = gc.gCodeList[i].x;
                if (gc.gCodeList[i].y > yMax) yMax = gc.gCodeList[i].y;
            }

            origin.X = (xMin + xMax) / 2 + 50;
            origin.Y = this.ActualHeight - 50 - ((yMin + yMax) / 2);

        }

    }
}

public class GCode
{
    public List<GCodeLine> gCodeList = new List<GCodeLine>();
    public GCode(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        parse(lines);
    }

    bool shortLineCheck(string line)
    {
        return (line.ToLower().StartsWith("m") || line.ToLower().StartsWith("g")) ? true : false;
    }

    void parse(string[] lines)
    {
        foreach (string line in lines)
        {
            if (shortLineCheck(line))
            {
                gCodeList.Add(new GCodeLine(line));
            }
        }
    }
}

public class GCodeLine
{
    public Double x = Double.NaN;
    public double y = Double.NaN;
    public double z = Double.NaN;
    public double i = Double.NaN;
    public double j = Double.NaN;
    public double r = Double.NaN;
    public double f = Double.NaN;
    public string code = null;

    public GCodeLine(string codeline)
    {
        Regex Gcode = new Regex("[ngxyzf][+-]?[0-9]*\\.?[0-9]­*", RegexOptions.IgnoreCase);
        MatchCollection m = Gcode.Matches(codeline);
        foreach (Match n in m)
        {

            if (n.Value.ToUpper().StartsWith("G")) { code = n.Value.ToUpper(); }
            if (n.Value.ToUpper().StartsWith("M")) { code = n.Value.ToUpper(); }
            if (n.Value.ToUpper().StartsWith("X")) { x = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }
            if (n.Value.ToUpper().StartsWith("Y")) { y = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }
            if (n.Value.ToUpper().StartsWith("Z")) { z = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }
            if (n.Value.ToUpper().StartsWith("I")) { i = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }
            if (n.Value.ToUpper().StartsWith("J")) { j = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }
            if (n.Value.ToUpper().StartsWith("R")) { r = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }
            if (n.Value.ToUpper().StartsWith("F")) { f = Convert.ToDouble(n.Value.Remove(0, 1).Replace(".", ",")); }


        }
    }
}
