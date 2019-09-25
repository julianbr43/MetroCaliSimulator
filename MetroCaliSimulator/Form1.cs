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
        public void dataRead() {
            StreamReader read;
            read = new StreamReader(@"C:\Users\ANDREA CAICEDO\Desktop\stops.csv");
            String line = "";
            while (!read.EndOfStream)
            {
                line = read.ReadLine();
                String[] infoStop = line.Split(';');
                Stop newStop = new Stop(infoStop[0], int.Parse(infoStop[1]), infoStop[2], infoStop[3], int.Parse(infoStop[4]), int.Parse(infoStop[5]), double.Parse(infoStop[6]), double.Parse(infoStop[7]));
                theMio.stopStreets.Add(newStop);
                theMio.theStop.Add(newStop.stopid, newStop);
                Console.WriteLine("{0}", newStop.stopid);
            }

            read = new StreamReader(@"C:\Users\ANDREA CAICEDO\Desktop\stopsStations.csv");
            line = "";
            while (!read.EndOfStream)
            {
                line = read.ReadLine();
                String[] infoStop = line.Split(';');
                Stop newStop = new Stop(infoStop[0], int.Parse(infoStop[1]), infoStop[2], infoStop[3], int.Parse(infoStop[4]), int.Parse(infoStop[5]), double.Parse(infoStop[6]), double.Parse(infoStop[7]));
                theMio.stopStations.Add(newStop);
                theMio.theStop.Add(newStop.stopid, newStop);
                Console.WriteLine("{0}", newStop.stopid);
            }
            serializar();
        }
    }
}
