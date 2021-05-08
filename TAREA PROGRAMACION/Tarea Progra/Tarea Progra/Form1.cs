using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Progra
{
    public partial class Form1 : Form
    {
        private string[] Arreglos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Archivo archivos = new Archivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Porfa Selecciona tu Archivo Plano";
            ofd.InitialDirectory = @"C: \Users\alumno\Desktop\datos Texto.csv";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = archivos.LeerTodoArchivo(archivo);
                Arreglos = archivos.LeerArchivo(archivo);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseMySql cn = new ClaseMySql();
            foreach (string linea in Arreglos)

            {
                string[] colum = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string result = $"insert into tb_tarea values('{colum[0]}','{colum[1]}','{colum[2]}','{colum[3]}','{colum[4]}')";
                cn.consultaTablaDirecta(result);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseSqlServer cn = new ClaseSqlServer();
            foreach (string linea in Arreglos)

            {
                string[] colum = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string result = $"insert into tb_tarea values('{colum[0]}','{colum[1]}','{colum[2]}','{colum[3]}','{colum[4]}')";
                cn.consultaTablaDirecta(result);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClaseOracle cn = new ClaseOracle();
            foreach (string linea in Arreglos)

            {
                string[] colum = linea.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                string result = $"insert into TB_TAREA values('{colum[0]}','{colum[1]}','{colum[2]}','{colum[3]}','{colum[4]}')";
                cn.consultaTablaDirecta(result);
            }

        }
    }
}
