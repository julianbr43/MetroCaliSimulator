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
                    loadStopsStations();
                }
                else if (comboFiltrar.Text.Equals("Troncales"))
                {
                    int n = laVentana.theMio.stopStreets.Count;
                    for (int i = 0; i < n; i++)
                    {
                        Stop theStop = laVentana.theMio.stopStreets[i];
                        streetsMarket(theStop);
                    }
                }
                else if (comboFiltrar.Text.Equals("Todas"))
                {
                    loadStopsStations();
                    int n2 = laVentana.theMio.stopStreets.Count;
                    for (int i = 0; i < n2; i++)
                    {
                        Stop theStop = laVentana.theMio.stopStreets[i];
                        streetsMarket(theStop);
                    }
                }
            }
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
                Stop searched = laVentana.theMio.stopStationsZone0.FirstOrDefault(x => x.shortName.Equals(id) || x.longName.Equals(id));
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

        public void loadStopsStations() {
            if (checkBox1.Checked==true) {
                int n = laVentana.theMio.stopStationsZone0.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone0[i];
                    stationsMarket(theStop);
                }
            }
            if (checkBox2.Checked == true)
            {
                int n = laVentana.theMio.stopStationsZone1.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone1[i];
                    stationsMarket(theStop);
                }
            }
            if (checkBox3.Checked == true)
            {
                int n = laVentana.theMio.stopStationsZone2.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone2[i];
                    stationsMarket(theStop);
                }
            }
            if (checkBox4.Checked == true)
            {
                int n = laVentana.theMio.stopStationsZone3.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone3[i];
                    stationsMarket(theStop);
                }
            }
            if (checkBox5.Checked == true)
            {
                int n = laVentana.theMio.stopStationsZone4.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone4[i];
                    stationsMarket(theStop);
                }
            }
            if (checkBox6.Checked == true)
            {
                int n = laVentana.theMio.stopStationsZone5.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone5[i];
                    stationsMarket(theStop);
                }
            }
            if (checkBox7.Checked == true)
            {
                int n = laVentana.theMio.stopStationsZone7.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStationsZone7[i];
                    stationsMarket(theStop);
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
