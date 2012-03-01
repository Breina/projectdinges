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
using System.Drawing;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.DataSources.MultiDimensional;
using Microsoft.Research.DynamicDataDisplay.Common.Auxiliary;
using System.IO;
using MotoroziodDB;

namespace IntensityChart
{
    /// <summary>
    /// Interaction logic for Grafiek.xaml
    /// </summary>
    public partial class Grafiek : UserControl
    {

        private double[,] data;
       

        public Grafiek(string pad, int machine)
        {
            InitializeComponent();
            this.data = TekenDB.getData(pad, machine);
            drawImage();
        }

        private void drawImage()
        {
            

            System.Windows.Point[,] gridData = new System.Windows.Point[42, 42];

            Bitmap Bmp = new Bitmap(400, 300);

            Points[,] pts = TekenDB.getValues();
            int i = 0;
            for (int y = 0; y < 42; y++)
            {
                for (int x = 0; x < 42; x++)
                {
                    Points p = pts[x, y];
                    gridData[x, y] = new System.Windows.Point(p.getToerental(), p.getKoppel());
                    Bmp.SetPixel(1, 2,System.Drawing.Color.Red);
                    i++;
                }
            }
        
            WarpedDataSource2D<double> dataSource = new WarpedDataSource2D<double>(data, gridData);
            NaiveColorMap map = new NaiveColorMap { Data = data, Palette = LinearPalettes.RedGreenBluePalette };



            var bmp = map.BuildImage();
            //image.Source = bmp;

            
            isolineGraph.Palette = new LinearPalette(Colors.Blue, Colors.Red,Colors.Green);
            isolineGraph.DataSource = dataSource;

            trackingGraph.Palette = new LinearPalette(Colors.Black,Colors.Black);
            trackingGraph.DataSource = dataSource;
           
            Rect visible = dataSource.GetGridBounds();
            plotter.Viewport.Visible = visible;            
        }

        
    }
}
