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
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.DataSources.MultiDimensional;
using Microsoft.Research.DynamicDataDisplay.Common.Auxiliary;
using System.IO;
using TestDB;

namespace IntensityChart
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();

			Loaded += new RoutedEventHandler(Window1_Loaded);
		}

		private double[,] data;
		const int imageSize = 400;
		private void Window1_Loaded(object sender, RoutedEventArgs e)
		{
			data = BuildSampleData(imageSize);

			NaiveColorMap map = new NaiveColorMap { Data = data, Palette = LinearPalettes.BlueOrangePalette };
			var bmp = map.BuildImage();
			image.Source = bmp;

            Point[,] gridData = new Point[42, 42];

            TestDB1 test = new TestDB1();

            Points[,] pts = test.getValues();

            for (int y = 0; y < 42; y++)
            {
                for (int x = 0; x < 42; x++)
                {
                    Points p = pts[x, y];
                    gridData[x, y] = new Point(p.getToerental(), p.getKoppel());
                }
            }
                    

            WarpedDataSource2D<double> dataSource = new WarpedDataSource2D<double>(data, gridData);

            isolineGraph.Palette = new LinearPalette(Colors.Black, Colors.Black);
            isolineGraph.DataSource = dataSource;
            
            trackingGraph.Palette = new LinearPalette(Colors.Black, Colors.Black);
            trackingGraph.DataSource = dataSource;

            Rect visible = dataSource.GetGridBounds();
            plotter.Viewport.Visible = visible;
		}

		private double[,] BuildSampleData(int size)
		{
            double[,] d = new double[42, 42];
            TestDB1 test = new TestDB1();
            d = test.getData();           
            return d;
        }

		EnumerableDataSource<double> dimensionDataSource = Enumerable.Range(0, imageSize).Select(i => (double)i).AsXDataSource();
	}
}
