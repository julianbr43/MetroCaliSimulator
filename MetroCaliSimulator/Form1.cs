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
            FileStream fs = new FileStream("DaticosDesnutricion.txt", FileMode.Open);
            theMio = (MioSystem)formateador.Deserialize(fs);
            fs.Close();
        }
    }
}
