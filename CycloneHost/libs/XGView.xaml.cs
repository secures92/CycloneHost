using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CycloneHost.libs
{
    /// <summary>
    /// Interaktionslogik für XGView.xaml
    /// </summary>
    public partial class XGView : UserControl
    {
        public XGView()
        {
            InitializeComponent();
        }
        bool inch = false;

        class gcodeMaxMinData
        {
            public double x_max { get; set; }
            public double x_min { get; set; }
            public double y_max { get; set; }
            public double y_min { get; set; }
            public double z_max { get; set; }
            public double z_min { get; set; }
        }

        // List defnition for gcode commands and there values
        List<gcodeSource> gcodeListCommands = new List<gcodeSource>();
        class gcodeSource
        {
            public int linenumber { get; set; }
            public string command { get; set; }
            public string line { get; set; }
            public List<string> axiscmds { get; set; }
            public double? x_pos { get; set; }
            public double? y_pos { get; set; }
            public double? z_pos { get; set; }
            public double? i_pos { get; set; }
            public double? j_pos { get; set; }
            public double? speed { get; set; }

            public gcodeSource(int lnr, string cmd, string old_command)
            {
                linenumber = lnr;
                line = cmd.Trim();
                axiscmds = new List<string>();

                if (cmd.Length > 0)
                {
                    string[] tokens = line.Split(new char[] { ' ' });
                    int i = 0;
                    foreach (string token in tokens)
                    {
                        if (i == 0 && token.StartsWith("G"))
                        {
                            command = token;
                        }
                        else
                        {
                            if (command == null)
                                command = old_command;
                            axiscmds.Add(token);
                            string[] cmdtokens = token.Split(new char[] { ' ' });

                            foreach (string cmdtoken in cmdtokens)
                            {
                                if (cmdtoken.StartsWith("X"))
                                {
                                    x_pos = Convert.ToDouble(cmdtoken.Substring(1).Replace(".", ","));
                                }
                                if (cmdtoken.StartsWith("Y"))
                                {
                                    y_pos = Convert.ToDouble(cmdtoken.Substring(1).Replace(".", ","));
                                }
                                if (cmdtoken.StartsWith("Z"))
                                {
                                    z_pos = Convert.ToDouble(cmdtoken.Substring(1).Replace(".", ","));
                                }
                                if (cmdtoken.StartsWith("I"))
                                {
                                    i_pos = Convert.ToDouble(cmdtoken.Substring(1).Replace(".", ","));
                                }
                                if (cmdtoken.StartsWith("J"))
                                {
                                    j_pos = Convert.ToDouble(cmdtoken.Substring(1).Replace(".", ","));
                                }
                                if (cmdtoken.StartsWith("F"))
                                {
                                    speed = Convert.ToDouble(cmdtoken.Substring(1).Replace(".", ","));
                                }
                            }
                        }
                        i++;
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string property)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }


        public void loadFile(String Pfad)
        {
            gcodeListCommands.Clear();

            // Read the file as one string.
            System.IO.StreamReader myFile;
            try
            {
                myFile = new System.IO.StreamReader(Pfad);
            }
            catch
            {
                return;
            }
            System.IO.Stream s = File.OpenRead(Pfad);


            string line;
            int i = 1;
            string old_command = "";
            while ((line = myFile.ReadLine()) != null)
            {
                if (!line.StartsWith("(") && !line.StartsWith(";"))
                    old_command = _parseGcodeLine(line, i, old_command);
                i++;
            }
            myFile.Close();


            // build 3d wire modell
            _build_3d_model(i);

            // Switch send button on

        }

        private string _parseGcodeLine(string line, int lnr, string old_command)
        {
            line.Trim();
            Regex rgx = new Regex(";.*$");
            line = rgx.Replace(line, "");

            if (line.IndexOf("G20") >= 0)
                inch = true;
            if (line.IndexOf("G21") >= 0)
                inch = false;

            gcodeSource linedata = new gcodeSource(lnr, line, old_command);
            gcodeListCommands.Add(linedata);

            return linedata.command;
        }

        LinesVisual3D normalmoves = new LinesVisual3D();
        LinesVisual3D rapidmoves = new LinesVisual3D();
        LinesVisual3D wirebox = new LinesVisual3D();

        private void _build_3d_model(double bis)
        {
            if (gcodeListCommands.Count <= 0)
                return;

            // init 3d system
            viewport.Children.Remove(normalmoves);
            viewport.Children.Remove(rapidmoves);
            viewport.Children.Remove(wirebox);

            rapidmoves.Points.Clear();
            normalmoves.Points.Clear();
            wirebox.Points.Clear();

            // translate gcode to 3d
            gcodeMaxMinData maxdata = new gcodeMaxMinData();
            gcodeSource old_positions = new gcodeSource(0, "G0 X0 Y0 Z0 F0 J0 I0", "");
            foreach (gcodeSource positions in gcodeListCommands)
            {
                // Slider value ...
                if (bis >= 0 && positions.linenumber > bis)
                {


                    break;
                }

                if (positions.command != "G0" && positions.command != "G1" && positions.command != "G2" && positions.command != "G3")
                    continue;

                double factor = (inch ? 25.4 : 1); // mm or inch

                double x_pos_old = Convert.ToDouble(old_positions.x_pos);
                double y_pos_old = Convert.ToDouble(old_positions.y_pos);
                double z_pos_old = Convert.ToDouble(old_positions.z_pos);
                double x_pos = Convert.ToDouble((positions.x_pos.HasValue ? positions.x_pos * factor : old_positions.x_pos));
                double y_pos = Convert.ToDouble((positions.y_pos.HasValue ? positions.y_pos * factor : old_positions.y_pos));
                double z_pos = Convert.ToDouble((positions.z_pos.HasValue ? positions.z_pos * factor : old_positions.z_pos));
                double i_pos = Convert.ToDouble((positions.i_pos.HasValue ? positions.i_pos * factor : Double.NaN));
                double j_pos = Convert.ToDouble((positions.j_pos.HasValue ? positions.j_pos * factor : Double.NaN));

                // Save in maxmin data
                if (x_pos > maxdata.x_max)
                    maxdata.x_max = x_pos;
                if (x_pos < maxdata.x_min)
                    maxdata.x_min = x_pos;
                if (y_pos > maxdata.y_max)
                    maxdata.y_max = y_pos;
                if (y_pos < maxdata.y_min)
                    maxdata.y_min = y_pos;
                if (z_pos > maxdata.z_max)
                    maxdata.z_max = z_pos;
                if (z_pos < maxdata.z_min)
                    maxdata.z_min = z_pos;


                if (positions.command == "G0")
                {
                    // Draw rapidmove as blue line
                    DrawLine(rapidmoves, x_pos_old, y_pos_old, z_pos_old, x_pos, y_pos, z_pos);
                }
                if (positions.command == "G1")
                {
                    DrawLine(normalmoves, x_pos_old, y_pos_old, z_pos_old, x_pos, y_pos, z_pos);
                }
                if (positions.command == "G2" || positions.command == "G3") // G2 or G3 > draw an arc
                {
                    bool clockwise = false;
                    if (positions.command == "G2")
                        clockwise = true;

                    DrawArc(x_pos_old, y_pos_old, z_pos_old, x_pos, y_pos, z_pos, j_pos, i_pos, false, clockwise);
                }

                if (positions.x_pos.HasValue == true)
                    old_positions.x_pos = x_pos;
                if (positions.y_pos.HasValue == true)
                    old_positions.y_pos = y_pos;
                if (positions.z_pos.HasValue == true)
                    old_positions.z_pos = z_pos;
            }
            rapidmoves.Thickness = 1;
            rapidmoves.Color = Colors.Blue;
            viewport.Children.Add(rapidmoves);
            normalmoves.Thickness = 1;
            normalmoves.Color = Colors.Black;
            viewport.Children.Add(normalmoves);

            // Rectancle bottom
            DrawLine(wirebox, maxdata.x_min, maxdata.y_min, maxdata.z_min, maxdata.x_max, maxdata.y_min, maxdata.z_min);
            DrawLine(wirebox, maxdata.x_min, maxdata.y_min, maxdata.z_min, maxdata.x_min, maxdata.y_max, maxdata.z_min);
            DrawLine(wirebox, maxdata.x_max, maxdata.y_min, maxdata.z_min, maxdata.x_max, maxdata.y_max, maxdata.z_min);
            DrawLine(wirebox, maxdata.x_min, maxdata.y_max, maxdata.z_min, maxdata.x_max, maxdata.y_max, maxdata.z_min);

            // Rectancle top
            DrawLine(wirebox, maxdata.x_min, maxdata.y_min, maxdata.z_max, maxdata.x_max, maxdata.y_min, maxdata.z_max);
            DrawLine(wirebox, maxdata.x_min, maxdata.y_min, maxdata.z_max, maxdata.x_min, maxdata.y_max, maxdata.z_max);
            DrawLine(wirebox, maxdata.x_max, maxdata.y_min, maxdata.z_max, maxdata.x_max, maxdata.y_max, maxdata.z_max);
            DrawLine(wirebox, maxdata.x_min, maxdata.y_max, maxdata.z_max, maxdata.x_max, maxdata.y_max, maxdata.z_max);

            // Rectancle stege
            DrawLine(wirebox, maxdata.x_min, maxdata.y_min, maxdata.z_min, maxdata.x_min, maxdata.y_min, maxdata.z_max);
            DrawLine(wirebox, maxdata.x_max, maxdata.y_min, maxdata.z_min, maxdata.x_max, maxdata.y_min, maxdata.z_max);
            DrawLine(wirebox, maxdata.x_max, maxdata.y_max, maxdata.z_min, maxdata.x_max, maxdata.y_max, maxdata.z_max);
            DrawLine(wirebox, maxdata.x_min, maxdata.y_max, maxdata.z_min, maxdata.x_min, maxdata.y_max, maxdata.z_max);

            wirebox.Thickness = 1;
            wirebox.Color = Colors.LightGray;
            viewport.Children.Add(wirebox);

            refreshCamera();
        }

        private void DrawLine(LinesVisual3D lines, double x_start, double y_start, double z_start, double x_stop, double y_stop, double z_stop)
        {
            lines.Points.Add(new Point3D(x_start, y_start, z_start));
            lines.Points.Add(new Point3D(x_stop, y_stop, z_stop));
        }
        private void DrawLine(LinesVisual3D lines, Point3D start, Point3D end)
        {
            lines.Points.Add(start);
            lines.Points.Add(end);
        }

        private void DrawArc(double x_start, double y_start, double z_start,
                             double x_stop, double y_stop, double z_stop,
                             double j_pos, double i_pos,
                             bool absoluteIJKMode, bool clockwise)
        {
            Point3D initial = new Point3D(x_start, y_start, z_start);
            Point3D nextpoint = new Point3D(x_stop, y_stop, z_stop);
            double k = Double.NaN;
            double radius = Double.NaN;

            Point3D center = updateCenterWithCommand(initial, nextpoint, j_pos, i_pos, k, radius, absoluteIJKMode, clockwise);
            List<Point3D> kreispunkte = generatePointsAlongArcBDring(initial, nextpoint, center, clockwise, 0, 10); // Dynamic resolution

            Point3D old_point = new Point3D();
            foreach (Point3D point in kreispunkte)
            {
                if (old_point.X != 0)
                {
                    DrawLine(normalmoves, old_point, point);
                }
                old_point = point;
            }
        }

        /**
        * Generates the points along an arc including the start and end points.
        */
        public static List<Point3D> generatePointsAlongArcBDring(Point3D p1, Point3D p2, Point3D center, bool isCw, double R, int arcResolution)
        {
            double radius = R;
            double sweep;

            // Calculate radius if necessary.
            if (radius == 0)
            {
                radius = Math.Sqrt(Math.Pow(p1.X - center.X, 2.0) + Math.Pow(p1.Y - center.Y, 2.0));
            }

            // Calculate angles from center.
            double startAngle = getAngle(center, p1);
            double endAngle = getAngle(center, p2);

            // Fix semantics, if the angle ends at 0 it really should end at 360.
            if (endAngle == 0)
            {
                endAngle = Math.PI * 2;
            }

            // Calculate distance along arc.
            if (!isCw && endAngle < startAngle)
            {
                sweep = ((Math.PI * 2 - startAngle) + endAngle);
            }
            else if (isCw && endAngle > startAngle)
            {
                sweep = ((Math.PI * 2 - endAngle) + startAngle);
            }
            else
            {
                sweep = Math.Abs(endAngle - startAngle);
            }

            return generatePointsAlongArcBDring(p1, p2, center, isCw, radius, startAngle, endAngle, sweep, arcResolution);
        }

        /**
         * Generates the points along an arc including the start and end points.
         */
        public static List<Point3D> generatePointsAlongArcBDring(Point3D p1,
                Point3D p2, Point3D center, bool isCw, double radius,
                double startAngle, double endAngle, double sweep, int numPoints)
        {

            Point3D lineEnd = p2;
            List<Point3D> segments = new List<Point3D>();
            double angle;

            double zIncrement = (p2.Z - p1.Z) / numPoints;
            for (int i = 0; i < numPoints; i++)
            {
                if (isCw)
                {
                    angle = (startAngle - i * sweep / numPoints);
                }
                else
                {
                    angle = (startAngle + i * sweep / numPoints);
                }

                if (angle >= Math.PI * 2)
                {
                    angle = angle - Math.PI * 2;
                }

                lineEnd.X = Math.Cos(angle) * radius + center.X;
                lineEnd.Y = Math.Sin(angle) * radius + center.Y;
                lineEnd.Z += zIncrement;

                segments.Add(lineEnd);
            }

            segments.Add(p2);

            return segments;
        }

        /** 
         * Return the angle in radians when going from start to end.
         */
        public static double getAngle(Point3D start, Point3D end)
        {
            double deltaX = end.X - start.X;
            double deltaY = end.Y - start.Y;

            double angle = 0.0;

            if (deltaX != 0)
            { // prevent div by 0
                // it helps to know what quadrant you are in
                if (deltaX > 0 && deltaY >= 0)
                {  // 0 - 90
                    angle = Math.Atan(deltaY / deltaX);
                }
                else if (deltaX < 0 && deltaY >= 0)
                { // 90 to 180
                    angle = Math.PI - Math.Abs(Math.Atan(deltaY / deltaX));
                }
                else if (deltaX < 0 && deltaY < 0)
                { // 180 - 270
                    angle = Math.PI + Math.Abs(Math.Atan(deltaY / deltaX));
                }
                else if (deltaX > 0 && deltaY < 0)
                { // 270 - 360
                    angle = Math.PI * 2 - Math.Abs(Math.Atan(deltaY / deltaX));
                }
            }
            else
            {
                // 90 deg
                if (deltaY > 0)
                {
                    angle = Math.PI / 2.0;
                }
                // 270 deg
                else
                {
                    angle = Math.PI * 3.0 / 2.0;
                }
            }

            return angle;
        }


        static public Point3D updateCenterWithCommand(Point3D initial, Point3D nextPoint,
                        double j, double i, double k, double radius,
                        bool absoluteIJKMode, bool clockwise)
        {
            if (Double.IsNaN(i) && Double.IsNaN(j) && Double.IsNaN(k))
            {
                return convertRToCenter(initial, nextPoint, radius, absoluteIJKMode, clockwise);
            }

            Point3D newPoint = new Point3D();

            if (absoluteIJKMode)
            {
                if (!Double.IsNaN(i))
                {
                    newPoint.X = i;
                }
                if (!Double.IsNaN(j))
                {
                    newPoint.Y = j;
                }
                if (!Double.IsNaN(k))
                {
                    newPoint.Z = k;
                }
            }
            else
            {
                if (!Double.IsNaN(i))
                {
                    newPoint.X = initial.X + i;
                }
                if (!Double.IsNaN(j))
                {
                    newPoint.Y = initial.Y + j;
                }
                if (!Double.IsNaN(k))
                {
                    newPoint.Z = initial.Z + k;
                }
            }

            return newPoint;
        }

        public static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        // Try to create an arc :)
        public static Point3D convertRToCenter(Point3D start, Point3D end, double radius, bool absoluteIJK, bool clockwise)
        {
            double R = radius;
            Point3D center = new Point3D();

            // This math is copied from GRBL in gcode.c
            double x = end.X - start.X;
            double y = end.Y - start.Y;

            double h_x2_div_d = 4 * R * R - x * x - y * y;
            if (h_x2_div_d < 0) { Console.Write("Error computing arc radius."); }
            h_x2_div_d = (-Math.Sqrt(h_x2_div_d)) / Hypotenuse(x, y);

            if (clockwise == false)
            {
                h_x2_div_d = -h_x2_div_d;
            }

            // Special message from gcoder to software for which radius
            // should be used.
            if (R < 0)
            {
                h_x2_div_d = -h_x2_div_d;
                // TODO: Places that use this need to run ABS on radius.
                radius = -radius;
            }

            double offsetX = 0.5 * (x - (y * h_x2_div_d));
            double offsetY = 0.5 * (y + (x * h_x2_div_d));

            if (!absoluteIJK)
            {
                center.X = start.X + offsetX;
                center.Y = start.Y + offsetY;
            }
            else
            {
                center.X = offsetX;
                center.Y = offsetY;
            }

            return center;
        }

        private void Menu_Quit_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Current.Shutdown();
        }

        // Set Tool to a new position and change diameter (changed in gcode)
        public void MoveTool(Point3D position, double diameter)
        {
            Tool3D.Visible = true;
            Tool3D.Diameter = diameter;
            Tool3D.Point1 = position;
            position.Z = position.Z + 5;
            Tool3D.Point2 = position;
        }

        public void refreshCamera()
        {
            viewport.CameraController.AddRotateForce(0.001, 0.001); // emulate move camera 
        }

        private void ThreeDfront_Click(object sender, RoutedEventArgs e)
        {
            camera.UpDirection = new Vector3D(0, -0.5, 1);
            camera.LookDirection = new Vector3D(0, 100, -0.5);
            camera.Position = new Point3D(0, 105, 0);
            camera.LookAt(new Point3D(0, 0, 0), 1);
            viewport.ResetCamera();

        }

        private void ThreeDtop_Click(object sender, RoutedEventArgs e)
        {
            camera.UpDirection = new Vector3D(0, 1, 0.5);
            camera.LookDirection = new Vector3D(0, 0, -100);
            camera.Position = new Point3D(0, 0, 100);
            camera.LookAt(new Point3D(0, 0, 0), 1);
            viewport.ResetCamera();
        }

        private void ThreeDside_Click(object sender, RoutedEventArgs e)
        {
            camera.UpDirection = new Vector3D(-0.5, 0, 1);
            camera.LookDirection = new Vector3D(100, 0, -0.5);
            camera.Position = new Point3D(100, 0, 0);
            camera.LookAt(new Point3D(0, 0, 0), 1);
            viewport.ResetCamera();
        }

        private void ThreeDBindToCamera_Click(object sender, RoutedEventArgs e)
        {
            // follow object
            camera.LookAt(Tool3D.Point1, 1);
            viewport.ResetCamera();
        }
    }
}