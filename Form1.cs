using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TravelingSalesman
{
    public partial class Form1 : Form
    {
        //****************************************************************************************
        public const int MAX_CITIES = 100;

        List<Point> cities = new List<Point>();
        List<Label> cityLabels = new List<Label>();
        List<Label> distanceLabels = new List<Label>();
        Bitmap bitmap;
        Random rnd = new Random();
        Point mouseRightClickLocation;
        double[,] cityDistance = new double[MAX_CITIES, MAX_CITIES];
        bool defaultSetup = false;

        //****************************************************************************************
        public Form1()
        {
            InitializeComponent();
        }

        //**************************************************************************************** 
        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(global::TravelingSalesman.Properties.Resources.US_Map, this.ClientRectangle.Width, this.ClientRectangle.Height);
        }

        //**************************************************************************************** 
        private void delCities()
        {
            for (int i = 0; i < cityLabels.Count; i++)
            {
                this.Controls.Remove(cityLabels[i]);
            }

            eraseWindow();

            cities.Clear();
            cityLabels.Clear();
            distanceLabels.Clear();
        }

        //****************************************************************************************  
        private void eraseWindow()
        {
            bitmap.Dispose();
            bitmap = new Bitmap(global::TravelingSalesman.Properties.Resources.US_Map, this.ClientRectangle.Width, this.ClientRectangle.Height);

            for (int i = 0; i < distanceLabels.Count; i++)
                this.Controls.Remove(distanceLabels[i]);

            distanceLabels.Clear();

            bestDistanceLabel.Visible = false;
        }

        //****************************************************************************************  
        public void setArray()
        {//Initializes the default points and labels
            atlantaLabel.Location = new Point(atlantaLabel.Location.X + 20, atlantaLabel.Location.Y + 20);
            austinLabel.Location = new Point(austinLabel.Location.X + 20, austinLabel.Location.Y + 20);
            bostonLabel.Location = new Point(bostonLabel.Location.X + 20, bostonLabel.Location.Y + 20);
            sanFranLabel.Location = new Point(sanFranLabel.Location.X + 20, sanFranLabel.Location.Y + 20);
            chicagoLabel.Location = new Point(chicagoLabel.Location.X + 20, chicagoLabel.Location.Y + 20);
            honoluluLabel.Location = new Point(honoluluLabel.Location.X + 20, honoluluLabel.Location.Y + 20);
            miamiLabel.Location = new Point(miamiLabel.Location.X + 20, miamiLabel.Location.Y + 20);
            newOrleansLabel.Location = new Point(newOrleansLabel.Location.X + 20, newOrleansLabel.Location.Y + 20);
            portlandLabel.Location = new Point(portlandLabel.Location.X + 20, portlandLabel.Location.Y + 20);
            denverLabel.Location = new Point(denverLabel.Location.X + 20, denverLabel.Location.Y + 20);
            bismarkLabel.Location = new Point(bismarkLabel.Location.X + 20, bismarkLabel.Location.Y + 20);
            vegasLabel.Location = new Point(vegasLabel.Location.X + 20, vegasLabel.Location.Y + 20);
            newyorkLabel.Location = new Point(newyorkLabel.Location.X + 20, newyorkLabel.Location.Y + 20);
            stlouisLabel.Location = new Point(stlouisLabel.Location.X + 20, stlouisLabel.Location.Y + 20);
            columbusLabel.Location = new Point(columbusLabel.Location.X + 20, columbusLabel.Location.Y + 20);
            santefeLabel.Location = new Point(santefeLabel.Location.X + 20, santefeLabel.Location.Y + 20);
            boiseLabel.Location = new Point(boiseLabel.Location.X + 20, boiseLabel.Location.Y + 20);
            oklahomaLabel.Location = new Point(oklahomaLabel.Location.X + 20, oklahomaLabel.Location.Y + 20);
            dcLabel.Location = new Point(dcLabel.Location.X + 20, dcLabel.Location.Y + 20);
            helenaLabel.Location = new Point(helenaLabel.Location.X + 20, helenaLabel.Location.Y + 20);
            tallahasseeLabel.Location = new Point(tallahasseeLabel.Location.X + 20, tallahasseeLabel.Location.Y + 20);
            olympiaLabel.Location = new Point(olympiaLabel.Location.X + 20, olympiaLabel.Location.Y + 20);
            phoenixLabel.Location = new Point(phoenixLabel.Location.X + 20, phoenixLabel.Location.Y + 20);
            stpaulLabel.Location = new Point(stpaulLabel.Location.X + 20, stpaulLabel.Location.Y + 20);
            lincolnLabel.Location = new Point(lincolnLabel.Location.X + 20, lincolnLabel.Location.Y + 20);
            topekaLabel.Location = new Point(topekaLabel.Location.X + 20, topekaLabel.Location.Y + 20);
            cheyenneLabel.Location = new Point(cheyenneLabel.Location.X + 20, cheyenneLabel.Location.Y + 20);
            nashvilleLabel.Location = new Point(nashvilleLabel.Location.X + 20, nashvilleLabel.Location.Y + 20);
            raleighLabel.Location = new Point(raleighLabel.Location.X + 20, raleighLabel.Location.Y + 20);


            addCity(atlantaLabel);
            addCity(austinLabel);
            addCity(bostonLabel);
            addCity(sanFranLabel);
            addCity(chicagoLabel);
            addCity(honoluluLabel);
            addCity(miamiLabel);
            addCity(newOrleansLabel);
            addCity(portlandLabel);
            addCity(denverLabel);
            addCity(bismarkLabel);
            addCity(vegasLabel);
            addCity(newyorkLabel);
            addCity(stlouisLabel);
            addCity(columbusLabel);
            addCity(santefeLabel);
            addCity(boiseLabel);
            addCity(oklahomaLabel);
            addCity(dcLabel);
            addCity(tallahasseeLabel);
            addCity(olympiaLabel);
            addCity(phoenixLabel);
            addCity(stpaulLabel);
            addCity(lincolnLabel);
            addCity(topekaLabel);
            addCity(cheyenneLabel);
            addCity(nashvilleLabel);
            addCity(raleighLabel);
            addCity(helenaLabel);

            // All paths.
            for (int i = 0; i < cities.Count; i++)
                for (int j = 0; j < cities.Count; j++)
                    if (i != j)
                        connectCity(i, j);

            this.Refresh();
        }

        //****************************************************************************************
        private void addCity(Label label)
        {//Add a city to the list of cities
            if (cities.Count == MAX_CITIES)
            {
                MessageBox.Show("Cannot add anymore cities.");
                return;
            }

            label.Location = new Point(label.Location.X - 20, label.Location.Y - 20);
            label.Visible = true;
            cityLabels.Add(label);
            this.Controls.Add(label);
            cities.Add(new Point(label.Location.X + 15, label.Location.Y + 15));

            drawCity(cities.Count - 1);
        }

        //****************************************************************************************
        private void drawCity(int cityIndex)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.FillEllipse(new SolidBrush(Color.Black), cities[cityIndex].X, cities[cityIndex].Y, 10, 10);
            g.Flush();
            g.Dispose();
        }

        //****************************************************************************************
        private void connectCity(int a, int b, bool showPath)
        {//Used to connect city a to city b
            //Makes the line connect to the center of the point
            Point city1 = new Point(cities[a].X + 5, cities[a].Y + 5);
            Point city2 = new Point(cities[b].X + 5, cities[b].Y + 5);

            Graphics g = Graphics.FromImage(bitmap);

            cityDistance[a, b] = Math.Sqrt((city2.X - city1.X) * (city2.X - city1.X) + (city2.Y - city1.Y) * (city2.Y - city1.Y));
            cityDistance[b, a] = cityDistance[a, b];

            if (showPath)
            {
                Pen pen = new Pen(new SolidBrush(Color.Red), 2);
                g.DrawLine(pen, city1, city2);
                g.Flush();
                g.Dispose();
                Label distLabel = new Label();
                distLabel.Text = String.Format("{0:0.0}", cityDistance[a, b]);
                distLabel.Location = new Point((city1.X + city2.X) / 2 - 5, (city1.Y + city2.Y) / 2 - 5);
                distLabel.AutoSize = true;
                distanceLabels.Add(distLabel);
                this.Controls.Add(distLabel);
            }
        }

        //****************************************************************************************
        private void connectCity(int a, int b)
        {
            connectCity(a, b, false);
        }

        //****************************************************************************************
        private void defaultSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!defaultSetup)
            {
                defaultSetup = true;
                setArray();
            }
        }

        //****************************************************************************************
        private void addCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityDialog dialog = new CityDialog("Add City", "City Name", "Add City");
            Label newCity = new Label();

            newCity.Text = dialog.result;
            newCity.Location = new Point(mouseRightClickLocation.X, mouseRightClickLocation.Y);
            newCity.AutoSize = true;
            newCity.Visible = true;
            addCity(newCity);

            for (int i = 0; i < cities.Count - 1; i++)
                connectCity(cities.Count - 1, i);

            this.Refresh();
        }

        //****************************************************************************************
        // gets mouse position when the right clicking
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            mouseRightClickLocation = Cursor.Position;

            mouseRightClickLocation = contextMenuStrip1.SourceControl.PointToClient(mouseRightClickLocation);
        }

        //****************************************************************************************
        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delCities();
            this.Refresh();

            if (defaultSetup)
                defaultSetup = false;
        }

        //****************************************************************************************
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
        }

        //****************************************************************************************
        // Simulated Annealing stuff.
        private void StartAnnealing(int[] current)
        {
            //the next configuration of cities to be tested
            int[] next = new int[current.Length];
            int iteration = -1;

            //the probability
            double proba;
            double alpha = 0.9999;
            double temperature = 400.0;
            double epsilon = 0.0000000001;
            double delta;
            double distance = computeDistance(current);

            //while the temperature did not reach epsilon
            while (temperature > epsilon)
            {
                iteration++;

                //get the next random permutation of distances 
                computeNext(current, next);
                //compute the distance of the new permuted configuration
                delta = computeDistance(next) - distance;
                //if the new distance is better accept it and assign it
                if (delta < 0)
                {
                    current = (int[])next.Clone();
                    distance = delta + distance;
                }
                else
                {
                    proba = rnd.Next();
                    //if the new distance is worse accept 
                    //it but with a probability level
                    //if the probability is less than 
                    //E to the power -delta/temperature.
                    //otherwise the old value is kept
                    if (proba < Math.Exp(-delta / temperature))
                    {
                        current = (int[])next.Clone();
                        distance = delta + distance;
                    }
                }
                //cooling process on every iteration
                temperature *= alpha;
            }

            distance = computeDistance(current);

            bestDistanceLabel.Text = String.Format("Best distance: {0:0.0}", distance);
            bestDistanceLabel.Location = new Point(bitmap.Width - bestDistanceLabel.Size.Width - 5, bitmap.Height - bestDistanceLabel.Size.Height - 5);
            bestDistanceLabel.Visible = true;

            drawPath(current);
        }

        //****************************************************************************************
        private void computeNext(int[] current, int[] next)
        {
            int i1 = 0;
            int i2 = 0;

            for (int i = 0; i < next.Length; i++)
                next[i] = current[i];

            do
            {
                i1 = (int)(rnd.Next(next.Length - 1));
                i2 = (int)(rnd.Next(next.Length - 1));
            } while (i1 == 0 || i1 == next.Length - 1 || i2 == 0 || i2 == next.Length - 1);

            int aux = next[i1];
            next[i1] = next[i2];
            next[i2] = aux;
        }

        //****************************************************************************************
        private double computeDistance(int[] city)
        {
            double dist = 0;
            for (int i = 0; i < city.Length - 1; i++)
            {
                dist += cityDistance[city[i], city[i + 1]];
            }

            //MessageBox.Show(Convert.ToString(dist));
            return dist;
        }

        //****************************************************************************************
        private void drawPath(int[] city)
        {
            for (int i = 0; i < city.Length - 1; i++)
                connectCity(city[i], city[i + 1], true);

            this.Refresh();
        }

        //****************************************************************************************
        private void runAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cities.Count == 0)
                return;

            eraseWindow();

            for (int i = 0; i < cities.Count; i++)
                drawCity(i);

            int[] cityArray = new int[cities.Count + 1];

            for (int i = 0; i < cityArray.Length; i++)
                cityArray[i] = i;

            cityArray[cities.Count] = 0;

            StartAnnealing(cityArray);
        }

    }
}
