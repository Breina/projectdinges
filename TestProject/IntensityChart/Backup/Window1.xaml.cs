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

			NaiveColorMap map = new NaiveColorMap { Data = data, Palette = LinearPalettes.BlackAndWhitePalette };
			var bmp = map.BuildImage();
			image.Source = bmp;
		}

		private double[,] BuildSampleData(int size)
		{
			double[,] data = new double[size, size];

			for (int ix = 0; ix < size; ix++)
			{
				double coeff = 0.0005 * ix;
				for (int iy = 0; iy < size; iy++)
				{
					double value = Math.Sin(coeff * iy);
					data[ix, iy] = value;
				}
			}

			return data;
		}

		EnumerableDataSource<double> dimensionDataSource = Enumerable.Range(0, imageSize).Select(i => (double)i).AsXDataSource();
		private void point_PositionChanged(object sender, PositionChangedEventArgs e)
		{
			if (data == null) return;

			var sectionDS = CreateSection(e.Position.X).AsYDataSource();
			var ds = new CompositeDataSource(dimensionDataSource, sectionDS);
			sectionChart.DataSource = ds;
		}

		private IEnumerable<double> CreateSection(double ratio)
		{
			double xIndex = ratio * imageSize;
			if (xIndex < 0) xIndex = 0;
			if (xIndex >= imageSize - 1) xIndex = imageSize - 2;

			int ix = (int)xIndex;

			double alpha = xIndex - Math.Floor(xIndex);

			double[] section = new double[imageSize];
			for (int iy = 0; iy < imageSize; iy++)
			{
				double interpolatedValue = (1 - alpha) * data[ix, iy] + alpha * data[ix + 1, iy];
				section[iy] = interpolatedValue;
			}

			return section;
		}
	}
}
