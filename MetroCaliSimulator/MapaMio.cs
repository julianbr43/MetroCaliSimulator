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
            if (comboFiltrar.Text.Equals("Estaciones"))
            {
                int n = laVentana.theMio.stopStations.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStations[i];
                    stationsMarket(theStop.decLat, theStop.decLong);
                }
            }
            else if (comboFiltrar.Text.Equals("Troncales"))
            {
                int n = laVentana.theMio.stopStreets.Count;
                for (int i = 0; i < n; i++)
                {
                    Stop theStop = laVentana.theMio.stopStreets[i];
                    streetsMarket(theStop.decLat, theStop.decLong);
                }
            }
            else if(comboFiltrar.Text.Equals("Todas"))
            {
                int n1 = laVentana.theMio.stopStations.Count;
                for (int i = 0; i < n1; i++)
                {
                    Stop theStop = laVentana.theMio.stopStations[i];
                    stationsMarket(theStop.decLat, theStop.decLong);
                }
                int n2 = laVentana.theMio.stopStreets.Count;
                for (int i = 0; i < n2; i++)
                {
                    Stop theStop = laVentana.theMio.stopStreets[i];
                    streetsMarket(theStop.decLat, theStop.decLong);
                }
            }
            comboFiltrar.Text = "";
            if (!textBoxBuscar.Text.Equals("")) {
                search(textBoxBuscar.Text);
            }
            textBoxBuscar.Text = "";
        }

        private void stationsMarket(double lat, double lng) {
            //removeMarkers();
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            GMapOverlay markers = new GMapOverlay("markers");
            //gMapMapaMio.Overlays.Remove(markers);
            //gMapMapaMio.Refresh();
            markers.Markers.Add(theMarker);
            gMapMapaMio.Overlays.Add(markers);
            //gMapMapaMio.Refresh();
        }

        private void streetsMarket(double lat, double lng) {
            //removeMarkers();
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            GMapOverlay markers = new GMapOverlay("markers");
            //gMapMapaMio.Overlays.Remove(markers);
            //gMapMapaMio.Refresh();
            markers.Markers.Add(theMarker);
            gMapMapaMio.Overlays.Add(markers);
            //gMapMapaMio.Refresh();
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

        public void search(String id) {
            Stop theStop = (Stop)(laVentana.theMio.theStop[id]);
            PointLatLng point = new PointLatLng(theStop.decLat, theStop.decLong);
            GMapMarker theMarker = new GMarkerGoogle(point, GMarkerGoogleType.green_dot);

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(theMarker);
            gMapMapaMio.Overlays.Add(markers);
            //gMapMapaMio.Refresh();
        }

    }
}
