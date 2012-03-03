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
using MotorozoidDB;

namespace IntensityChart
{
    /// <summary>
    /// Interaction logic for Grafiek.xaml
    /// </summary>
    public partial class Grafiek : UserControl
    {

        private double[,] data;
        private double besteRendament;
        private Points besteNominaleWaarden;
        private Machine machine;
        bool totaleGrafiek = false;
    

        public Grafiek(string pad, Machine machine)
        {
            InitializeComponent();
            this.machine = machine;
            this.data = TekenDB.getData(pad, machine.MachineId);
            this.besteRendament = TekenDB.geefBesteRendament(machine);
            this.besteNominaleWaarden = TekenDB.geefBesteNominaleWaarden(machine.BesteNominaalID);
            drawImage();
        }

        public Grafiek(Machine machine)
        {
            InitializeComponent();
            this.machine = machine;
            this.data = TekenDB.getDataPerMachine(machine.MachineId);
            this.besteRendament = TekenDB.geefBesteRendament(machine);
           this.besteNominaleWaarden = TekenDB.geefBesteNominaleWaarden(machine.BesteNominaalID);
            drawImage();
        }

        public Grafiek(Machine motor, Machine overbrenging, Machine belasting)
        {
            InitializeComponent();
            double[,] motordata = TekenDB.getDataPerMachine(motor.MachineId);
            double[,] overbrengingdata = TekenDB.getDataPerMachine(overbrenging.MachineId);
            double[,] belastingdata = TekenDB.getDataPerMachine(belasting.MachineId);
            berekenTotaleGrafiek(motordata, overbrengingdata, belastingdata);
            totaleGrafiek = true;
            drawImage();
        }

        private void berekenTotaleGrafiek(double[,] motordata,double[,] overbrengingdata,double[,] belastingdata)
        {
            this.data = new double[42, 42];
            for (int y = 0; y < 42; y++)
            {
                for (int x = 0; x < 42; x++)
                {
                    this.data[x, y] = (motordata[x, y] / 100) * (overbrengingdata[x, y] / 100) * (belastingdata[x, y] / 100);
                }
            }
        }

        private void drawImage()
        {
            if (!totaleGrafiek)
            {
                if (machine.NominaalToerental != 0 && machine.NominaalKoppel != 0)
                {
                    optimalePunt.Text = "Optimale punt:\nToerental = " + Math.Round(besteNominaleWaarden.getToerental() * machine.NominaalToerental,2) + " toeren/min, koppel = " + Math.Round(besteNominaleWaarden.getKoppel()* machine.NominaalKoppel,2) + " Nm, rendament = " + Math.Round(besteRendament, 2) + "%.";
                }
                else
                {
                    optimalePunt.Text = "Vermogen of toerental van de machine niet ingevuld!\nOptimaal rendament = " + Math.Round(besteRendament, 2) + "%.";
                }
            }
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
