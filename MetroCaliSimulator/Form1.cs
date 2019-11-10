using MetroCaliSimulator.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroCaliSimulator
{
    public partial class Form1 : Form
    {
        public MioSystem theMio { get; set; }
        public MapaMio elMapaMio { get; set; }
        public Form1()
        {
            InitializeComponent();
            elMapaMio = new MapaMio(this);
            theMio = new MioSystem();
            //dataRead();
            deserializar();
        }

        
        private void ButVerMapa_Click(object sender, EventArgs e)
        {
            elMapaMio.Show();
            elMapaMio.cargarMapa();
            this.Visible = false;
        }
        public void serializar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            FileStream miStream = new FileStream("DataMio.txt", FileMode.Create);
            formateador.Serialize(miStream, theMio);
            miStream.Close();
        }

        public void deserializar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            FileStream fs = new FileStream("DataMio.txt", FileMode.Open);
            theMio = (MioSystem)formateador.Deserialize(fs);
            fs.Close();
        }
        public void dataRead()
        {
            StreamReader read;
            read = new StreamReader("archivos/stops.csv");
            String line = "";
            while (!read.EndOfStream)
            {
                line = read.ReadLine();
                String[] infoStop = line.Split(';');
                Stop newStop = new Stop(infoStop[0], int.Parse(infoStop[1]), infoStop[2], infoStop[3], double.Parse(infoStop[6]), double.Parse(infoStop[7]));
                theMio.stopStreets.Add(newStop);
                theMio.theStop.Add(newStop.stopid, newStop);
                //Console.WriteLine("{0}", newStop.stopid);
            }

            read = new StreamReader(@"archivos/stops Stations.csv");
            line = "";
            while (!read.EndOfStream)
            {
                line = read.ReadLine();
                String[] infoStop = line.Split(';');
                Stop newStop = new Stop(infoStop[0], int.Parse(infoStop[1]), infoStop[2], infoStop[3], double.Parse(infoStop[6]), double.Parse(infoStop[7]));
                theMio.stopStations.Add(newStop);
                theMio.theStop.Add(newStop.stopid, newStop);
                //Console.WriteLine("{0}", newStop.stopid);
            }

            read = new StreamReader(@"archivos/linesDef.csv");
            line = "";
            while (!read.EndOfStream)
            {
                line = read.ReadLine();
                String[] infoLine = line.Split(';');
                Line theLine = new Line(int.Parse(infoLine[0]), int.Parse(infoLine[1]), infoLine[2], infoLine[3]);
                theMio.lineInfo.Add(theLine.lineId, theLine);
            }

            serializar();
        }

        public List<Bus> showBus(int time, Bus last)
        {
            List<Bus> listTheBus = new List<Bus>();
            StreamReader read = new StreamReader(@"archivos/DATAGRAMS.csv");
            String line = "";
            Bus principal = null;
            String[] infoBus;
            Bus theBus;
            List<int> idBus = new List<int>();
            bool encontrado = false;
            if (last == null)
            {
                line = read.ReadLine();
                infoBus = line.Split(';');
                theBus = new Bus(infoBus[0], infoBus[1], int.Parse(infoBus[2]), int.Parse(infoBus[3]), double.Parse(infoBus[4]), double.Parse(infoBus[5]), int.Parse(infoBus[6]), int.Parse(infoBus[7]), int.Parse(infoBus[8]), long.Parse(infoBus[9]), int.Parse(infoBus[10])); ;
                principal = theBus;
            } else
            {

                line = read.ReadLine();
                while (!encontrado && !read.EndOfStream)
                {
                    infoBus = line.Split(';');
                    theBus = new Bus(infoBus[0], infoBus[1], int.Parse(infoBus[2]), int.Parse(infoBus[3]), double.Parse(infoBus[4]), double.Parse(infoBus[5]), int.Parse(infoBus[6]), int.Parse(infoBus[7]), int.Parse(infoBus[8]), long.Parse(infoBus[9]), int.Parse(infoBus[10]));
                    if (last.dataGramId == theBus.dataGramId)
                    {
                        encontrado = true;
                        if((line = read.ReadLine()) != null)
                        {
                            infoBus = line.Split(';');
                            theBus = new Bus(infoBus[0], infoBus[1], int.Parse(infoBus[2]), int.Parse(infoBus[3]), double.Parse(infoBus[4]), double.Parse(infoBus[5]), int.Parse(infoBus[6]), int.Parse(infoBus[7]), int.Parse(infoBus[8]), long.Parse(infoBus[9]), int.Parse(infoBus[10]));
                           
                        }
                        principal = theBus;
                    } else
                    {
                        line = read.ReadLine();
                        if (read.EndOfStream)
                        {
                            return null;
                        }
                    }
                }
            }

            String[] hourPrincipal = principal.hour.Split('.');
            encontrado = false;
            while(!encontrado && !read.EndOfStream)
            {
                if(horario(hourPrincipal))
                {
                    encontrado = true;
                } else
                {
                    line = read.ReadLine();
                    infoBus = line.Split(';');
                    principal = new Bus(infoBus[0], infoBus[1], int.Parse(infoBus[2]), int.Parse(infoBus[3]), double.Parse(infoBus[4]), double.Parse(infoBus[5]), int.Parse(infoBus[6]), int.Parse(infoBus[7]), int.Parse(infoBus[8]), long.Parse(infoBus[9]), int.Parse(infoBus[10]));
                    hourPrincipal = principal.hour.Split('.');
                }
            }
            encontrado = false;
            
            while (!read.EndOfStream && !encontrado && ((line = read.ReadLine()) != null) )
            {
                
                infoBus = line.Split(';');
                theBus = new Bus(infoBus[0], infoBus[1], int.Parse(infoBus[2]), int.Parse(infoBus[3]), double.Parse(infoBus[4]), double.Parse(infoBus[5]), int.Parse(infoBus[6]), int.Parse(infoBus[7]), int.Parse(infoBus[8]), long.Parse(infoBus[9]), int.Parse(infoBus[10]));

                if ( (theBus.latitude != -1 && theBus.longitude != -1))
                {
                    String[] hourCompare = theBus.hour.Split('.');
                    bool isContain = timeCompare(hourPrincipal, hourCompare, time);
                    if (isContain)
                    {
                        if (!idBus.Contains(theBus.busId))
                        {
                            idBus.Add(theBus.busId);
                            listTheBus.Add(theBus);
                        }
                    }
                    else
                    {
                        encontrado = true;
                    }
                }
            }



            return listTheBus;
        }

        private bool horario(String[] hour)
        {
            bool ok;
            int h = int.Parse(hour[0]);
            String t = hour[2].Substring(3, hour.Length-1);
            if (t == "AM" && (h == 12 || h <= 5) )
            {
                ok = false;
            } else
            {
                ok = true;
            }
            return ok;
        }

        private bool timeCompare(String[]hourPrincipal, String[] hourBuscado, int time)
        {
            bool mayor = false;
            int secondP = int.Parse(hourPrincipal[2].Substring(0,2));
            int secondB = int.Parse(hourBuscado[2].Substring(0, 2));
            int mP = int.Parse(hourPrincipal[1]);
            int mB = int.Parse(hourBuscado[1]);

            int limited = time + secondP;

            if(time != 60)
            {
                if (limited > 60)
                {
                    limited -= 60;
                    if (secondB <= Math.Abs(limited) || secondB >= secondP)
                    {
                        mayor = true;
                    }
                }
                else
                {
                    if (secondB >= secondP && secondB <= limited)
                    {
                        mayor = true;
                    }
                }
            } else
            {
                if((secondB >= secondP && mB == mP) || (secondB <= secondP && mB == (mP+1)))
                {
                    mayor = true;
                }
            }

            

            return mayor;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
