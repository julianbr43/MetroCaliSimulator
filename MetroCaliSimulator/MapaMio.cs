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

        private bool isVisible;


        List<Bus> buses;

        GMapOverlay Poligono;
        public MapaMio(Form1 v)
        {
            InitializeComponent();
            laVentana = v;
            Poligono = new GMapOverlay("POligono");
            isVisible = false;
            buses = new List<Bus>();
            //cargarMapa();
          
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

        private void drawStops()
        {
            if (textBoxBuscar.Text.Equals(""))
            {

                if (comboFiltrar.Text.Equals("Estaciones"))
                {
                    loadStops(1);
                }
                else if (comboFiltrar.Text.Equals("Calles"))
                {
                    loadStops(2);
                }
                else if (comboFiltrar.Text.Equals("Todas"))
                {
                    loadStops(3);
                }
            }
                refreshMap();
        }

        private void stationsMarket(Stop theStop) {
            PointLatLng point = new PointLatLng(theStop.decLat, theStop.decLong);
            GMapMarker theMarker = new GMarkerGoogle(point, new Bitmap("Images/TransportIcon.png"));

            addLabelPoint(theMarker, theStop);

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(theMarker);
            gMapMapaMio.Overlays.Add(markers);
        }

        private void streetsMarket(Stop theStop) {
            PointLatLng point = new PointLatLng(theStop.decLat, theStop.decLong);
            GMapMarker theMarker = new GMarkerGoogle(point, new Bitmap("Images/stopBusIcon.png"));

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
            refreshMap();
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
            removeMarkers();
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
            gMapMapaMio.Zoom = gMapMapaMio.Zoom + 0.001;
            gMapMapaMio.Zoom = gMapMapaMio.Zoom - 0.001;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drawStops();
        }

        private void ComboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawStops();
        }

        private void drawBus(string draw)
        {
            removeMarkers();
            List<Bus> theDefinitiveList = buses;
            labelTiempo.Text = theDefinitiveList[0].date + " " + theDefinitiveList[0].hour;
            int n = theDefinitiveList.Count();
            
            if (!draw.Equals("") && !draw.Equals("TODAS")) {
                
                //try
                //{ 
                    for (int i = 0; i < n; i++)
                    {
                        Line theLine = ((Line)(laVentana.theMio.lineInfo[theDefinitiveList[i].lineId]));
                        if (theLine != null) {
                        Console.WriteLine("{0}, {1}", theLine.shortName, draw);
                            if (theLine.shortName.Equals(draw)) {
                                verificarZone(theDefinitiveList[i]);
                            }
                        }
                    }
                refreshMap();
                
                //}
                //catch (Exception e) { }
            }
    
            else {
                for (int i = 0; i < n; i++)
                {
                    verificarZone(theDefinitiveList[i]);
                    
                }
                refreshMap();
            }
            
        }

        private void busShow(int zone,Bus theMioBus)
        {
            if (laVentana.theMio.isZone(theMioBus.latitude, theMioBus.longitude) == zone)
            {
                PointLatLng point = new PointLatLng(theMioBus.latitude, theMioBus.longitude);
                GMapMarker theMarker = new GMarkerGoogle(point, new Bitmap("Images/img4.png"));
                addLabelPointBus(theMarker, theMioBus);

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(theMarker);
                gMapMapaMio.Overlays.Add(markers);

            }
        }

        private void addLabelPointBus(GMapMarker theMarker, Bus theMioBus)
        {
            Line ruta = ((Line)(laVentana.theMio.lineInfo[theMioBus.lineId]));
            if (ruta != null)
            {
                Operational TheOp= ((Operational)(laVentana.theMio.operationalInfo[theMioBus.busId + " " + theMioBus.tripId]));
                if (TheOp != null)
                {
                    int time = TheOp.desviationTime;
                    theMarker.ToolTipText = $"ID: {theMioBus.busId}, \nRuta: {ruta.shortName}, \nDesc: {ruta.description}, \nTiempo de Desviación: {laVentana.theMio.getTimeDeviation(time)}";
                }
                else {
                    var rand = new Random();
                    int num = rand.Next(-20,20);
                    theMarker.ToolTipText = $"ID: {theMioBus.busId}, \nRuta: {ruta.shortName}, \nDesc: {ruta.description}, \nTiempo de Desviación: {laVentana.theMio.getTimeDeviation(num)}";
                }
            }
            else {
                theMarker.ToolTipText = $"ID: {theMioBus.busId}";
            }
            GMapToolTip theTip = new GMapToolTip(theMarker);
            theTip.Fill = new SolidBrush(Color.White);
            theTip.Foreground = new SolidBrush(Color.Blue);

            theMarker.ToolTip = theTip;
        }

        private void ButInicio_Click(object sender, EventArgs e)
        {
            if (tiempo.Text.Equals("")) {
                MessageBox.Show("Por favor seleccione el tiempo de los buses ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                timerBuses.Enabled = true;
                timerBuses.Start();
            }
        }

        private void TimerBuses_Tick(object sender, EventArgs e)
        {
            if(!tiempo.Equals(""))
            {
                
                    if (!buses.Any())
                    {
                        buses = laVentana.showBus(int.Parse(tiempo.Text), null);
                    }
                    else
                    {
                        Bus busLast = buses.Last();

                        buses.Clear();

                        buses = laVentana.showBus(int.Parse(tiempo.Text), busLast);
                    }
               
                if (buses.Count > 0)
                {
                    string draw = comboRutas.Text;
                    drawBus(draw);
                }
                else
                {
                    timerBuses.Stop();
                }
            }
            
        }

        private void ButPausa_Click(object sender, EventArgs e)
        {
            timerBuses.Stop();
        }

        private void verificarZone(Bus theBus)
        {
            if (checkBox1.Checked == true)
            {
               busShow(0, theBus);
            }
            if (checkBox2.Checked == true)
            {
                busShow(1, theBus);
            }
            if (checkBox3.Checked == true)
            {
                busShow(2, theBus);
            }
            if (checkBox4.Checked == true)
            {
                busShow(3, theBus);
            }
            if (checkBox5.Checked == true)
            {
                busShow(4, theBus);

            }
            if (checkBox6.Checked == true)
            {
                busShow(5, theBus);

            }
            if (checkBox7.Checked == true)
            {
                busShow(6, theBus);

            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void LabelTiempo_Click(object sender, EventArgs e)
        {

        }

        private void MapaMio_Load(object sender, EventArgs e)
        {

        }

        public void polygonStation()
        {
            int j;
            for(int i = 0; i < laVentana.theMio.stopStations.Count; i++)
            {
                j = i;
                String name = laVentana.theMio.stopStations[i].longName.Substring(0, laVentana.theMio.stopStations[i].longName.Length - 3);
                String nameCompare = laVentana.theMio.stopStations[j+1].longName.Substring(0, laVentana.theMio.stopStations[j+1].longName.Length - 3);
                List<Stop> theListStopStation = new List<Stop>();
                theListStopStation.Add(laVentana.theMio.stopStations[i]);
                
                while (name.Trim().Equals(nameCompare.Trim()))
                {
                    
                    j++;
                    
                    if (j < laVentana.theMio.stopStations.Count)
                    {

                        if((j+1) < laVentana.theMio.stopStations.Count) 
                        {
                            theListStopStation.Add(laVentana.theMio.stopStations[j]);
                            nameCompare = laVentana.theMio.stopStations[j+1].longName.Substring(0, laVentana.theMio.stopStations[j+1].longName.Length - 3);
                        } else
                        {
                            nameCompare = "";
                        }
                            
                    } else
                    {
                        nameCompare = "";
                    }
                    
                        // Console.WriteLine(name + ";");
                        //Console.WriteLine(nameCompare + "; - " + j + " -- " + i);
                }
                polygonStation(convexHull(theListStopStation, theListStopStation.Count));
                //queue.Enqueue(theListStopStation);
                i = j;
            }

            
        }

        private void polygonStation(List<Stop> list)
        {
           // Poligono = new GMapOverlay();
            List<PointLatLng> puntos = new List<PointLatLng>();
            double lat, longi;
            //String name = "";
            for(int i = 0; i < list.Count; i++)
            {
                lat = list[i].decLat;
                longi = list[i].decLong;
                puntos.Add(new PointLatLng(lat, longi));
            }
            GMapPolygon polygonPoint = new GMapPolygon(puntos, "Poligono");
            Poligono.Polygons.Add(polygonPoint);
            gMapMapaMio.Overlays.Add(Poligono);
            refreshMap();
        }

        public int orientacion(Stop p, Stop q, Stop r)
        {
            double val = (q.decLat - p.decLat) * (r.decLong - q.decLong) - (q.decLong - p.decLong) * (r.decLat- q.decLat);

            if (val == 0)
            {
                return 0;
            }

            return (val > 0) ? 1 : 2;
        }

        public List<Stop> convexHull(List<Stop> lista, int n)
        {
            //if (n < 3) return;

            List<Stop> hull = new List<Stop>();
            int l = 0;

            for (int i = 1; i < n; i++)
            {
                if (lista[i].decLong < lista[l].decLong)
                {
                    l = i;
                }
            }

            int p = l, q;

            do
            {
                hull.Add(lista[p]);

                q = (p + 1) % n;

                for (int i = 0; i < n; i++)
                {

                    if (orientacion(lista[p], lista[i], lista[q]) == 2)
                        q = i;
                }
                p = q;
            } while (p != l);

            //lista = hull;
            return hull;
        }

        private void MouseEventHandler()
        {
            String zoomTo = gMapMapaMio.Zoom.ToString();
            double zoom = double.Parse(zoomTo);
            if(zoom >= 18 && !isVisible)
            {
                polygonStation();
                isVisible = true;
            } else if(zoom < 18)
            {
                Poligono.Clear();
                isVisible = false;
                refreshMap();
            }
        }

        private void ComboRutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Tiempo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text.Equals(""))
            {
                MessageBox.Show("Escribe una parada");
            }
            
            search(textBoxBuscar.Text);
            textBoxBuscar.Text = "";
        }

        private void loadArchive_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                laVentana.openArchive(ofd.FileName);
            }
        }
    }
}
