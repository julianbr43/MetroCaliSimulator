using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MetroCaliSimulator.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroCaliSimulator
{
    public partial class MapaMio : Form
    {
        public Form1 laVentana { get; set; }
        public MapaMio(Form1 v)
        {
            InitializeComponent();
            laVentana = v;
        }
        private void ButRegresar_Click(object sender, EventArgs e)
        {
            laVentana.Visible = true;
            this.Visible = false;
        }
        public void cargarMapa()
        {
            gMapMapaMio.DragButton = MouseButtons.Left;
            gMapMapaMio.MapProvider = GMapProviders.GoogleMap;
            double latitud = 3.4372201;
            double longitud = -76.5224991;
            gMapMapaMio.Position = new PointLatLng(latitud, longitud);
            gMapMapaMio.MinZoom = 1;
            gMapMapaMio.MaxZoom = 100;
            gMapMapaMio.Zoom = 13;
        }

        private void ButGraficar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text.Equals(""))
            {

                if (comboFiltrar.Text.Equals("Estaciones"))
                {
                    loadStops(1);
                }
                else if (comboFiltrar.Text.Equals("Troncales"))
                {
                    loadStops(2);
                }
                else if (comboFiltrar.Text.Equals("Todas"))
                {
                    loadStops(3);
                }
            }
            refreshMap();
            comboFiltrar.Text = "";
            search(textBoxBuscar.Text);
            textBoxBuscar.Text = "";
        }

        private void stationsMarket(Stop theStop) {
            PointLatLng point = new PointLatLng(theStop.decLat, theStop.decLong);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            addLabelPoint(theMarker, theStop);

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(theMarker);
            gMapMapaMio.Overlays.Add(markers);
        }

        private void streetsMarket(Stop theStop) {
            PointLatLng point = new PointLatLng(theStop.decLat, theStop.decLong);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            addLabelPoint(theMarker, theStop);

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(theMarker);
            gMapMapaMio.Overlays.Add(markers);
        }

        private void ButEliminar_Click(object sender, EventArgs e)
        {
            removeMarkers();
        }

        private void removeMarkers() {
            if (gMapMapaMio.Overlays.Count > 0)
            {
                gMapMapaMio.Overlays.Clear();
                gMapMapaMio.Refresh();
            }
        }

        private void search(String id)
        {
            if (id.StartsWith("5") || id.StartsWith("6")) {
                Stop searched = (Stop)(laVentana.theMio.theStop[id]);
                PointLatLng point = new PointLatLng(searched.decLat, searched.decLong);
                GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.green_dot);

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(theMarker);
                gMapMapaMio.Overlays.Add(markers);
            }
            else if (comboFiltrar.Text.Equals("Estaciones"))
            {
                Stop searched = laVentana.theMio.stopStations.FirstOrDefault(x => x.shortName.Equals(id) || x.longName.Equals(id));
                if (searched != null)
                {
                    stationsMarket(searched);
                }
            }
            else {
                Stop searched = laVentana.theMio.stopStreets.FirstOrDefault(x => x.shortName.Equals(id) || x.longName.Equals(id));
                if (searched != null)
                {
                    streetsMarket(searched);
                }
            }
        }

        private void addLabelPoint(GMapMarker theMarker, Stop theStop) {
            theMarker.ToolTipText = $"Nombre: {theStop.longName}, \nNombre corto: {theStop.shortName}";

            GMapToolTip theTip = new GMapToolTip(theMarker);
            theTip.Fill = new SolidBrush(Color.Gray);
            theTip.Foreground = new SolidBrush(Color.Black);

            theMarker.ToolTip = theTip;
        }

        private void station(int zone)
        {
            int n = laVentana.theMio.stopStations.Count;
            for (int i = 0; i < n; i++)
            {
                Stop theStop = laVentana.theMio.stopStations[i];
                if (laVentana.theMio.isZone(theStop.decLat, theStop.decLong) == zone)
                {
                    stationsMarket(theStop);
                }
            }
        }

        private void street(int zone)
        {
            for (int i = 0; i < laVentana.theMio.stopStreets.Count; i++)
            {
                Stop theStop = laVentana.theMio.stopStreets[i];
                if (laVentana.theMio.isZone(theStop.decLat, theStop.decLong) == zone)
                {
                    streetsMarket(theStop);
                }
            }
        }

        public void loadStops(int option)
        {
            if (checkBox1.Checked == true)
            {
                if (option == 1)
                {
                    station(0);
                }
                else if (option == 2)
                {
                    street(0);
                }
                else
                {
                    station(0);
                    street(0);
                }
            }
            if (checkBox2.Checked == true)
            {
                if (option == 1)
                {
                    station(1);
                }
                else if (option == 2)
                {
                    street(1);
                }
                else
                {
                    station(1);
                    street(1);
                }
            }
            if (checkBox3.Checked == true)
            {
                if (option == 1)
                {
                    station(2);
                }
                else if (option == 2)
                {
                    street(2);
                }
                else
                {
                    station(2);
                    street(2);
                }
            }
            if (checkBox4.Checked == true)
            {
                if (option == 1)
                {
                    station(3);
                }
                else if (option == 2)
                {
                    street(3);
                }
                else
                {
                    station(3);
                    street(3);
                }
            }
            if (checkBox5.Checked == true)
            {
                if (option == 1)
                {
                    station(4);
                }
                else if (option == 2)
                {
                    street(4);
                }
                else
                {
                    station(4);
                    street(4);
                }

            }
            if (checkBox6.Checked == true)
            {
                if (option == 1)
                {
                    station(5);
                }
                else if (option == 2)
                {
                    street(5);
                }
                else
                {
                    station(5);
                    street(5);
                }

            }
            if (checkBox7.Checked == true)
            {
                if (option == 1)
                {
                    station(6);
                }
                else if (option == 2)
                {
                    street(6);
                }
                else
                {
                    station(6);
                    street(6);
                }

            }
        }


        private void refreshMap() {
            gMapMapaMio.Zoom++;
            gMapMapaMio.Zoom--;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
