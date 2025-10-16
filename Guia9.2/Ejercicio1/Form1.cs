using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Ejercicio1.Models;
using Ejercicio1.Models.Exportadores;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        List<IExportable> exportables = new List<IExportable>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IExportable nuevo = null;

            string patente = tbPatente.Text;
            DateOnly vencimiento = DateOnly.FromDateTime(dtpVencimiento.Value);
            double importe = Convert.ToDouble(tbImporte.Text);

            nuevo = new Multa(patente, vencimiento, importe);

            exportables.Sort();
            int idx = exportables.BinarySearch(nuevo);
            if (idx >= 0)
            {
                Multa multa = exportables[idx] as Multa;
                multa.Importe += importe;
                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                multa.Vencimiento = ((Multa)nuevo).Vencimiento;
            }
            else
                exportables.Add(nuevo);

            btnActualizar.PerformClick();
            tbPatente.Clear();
            dtpVencimiento.Value = DateTime.Now;
            tbImporte.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|(txt)|*.txt|(xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;

                IExportador exportador = (new ExportadorFactory()).GetInstance(tipo);

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    //descarto la cabecera
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        IExportable nuevo = new Multa();

                        if (nuevo.Importar(linea, exportador) == true)
                        {
                            int idx = exportables.BinarySearch(nuevo);
                            if (idx >= 0)
                            {
                                Multa multa = exportables[idx] as Multa;
                                multa.Importe += ((Multa)nuevo).Importe;
                                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                                multa.Vencimiento = ((Multa)nuevo).Vencimiento;
                            }
                            else
                                exportables.Add(nuevo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                    if (fs != null)
                        fs.Close();
                }
            }
            btnActualizar.PerformClick();
        }

        private void lstVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Multa selected = lstVer.SelectedItem as Multa;
            if (selected != null)
            {
                tbPatente.Text = selected.Patente;
                dtpVencimiento.Value = selected.Vencimiento.ToDateTime(new TimeOnly(0, 0));
                tbImporte.Text = selected.Importe.ToString("f2");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lstVer.Items.Clear();
            ;
            foreach (IExportable multa in exportables)
            {
                lstVer.Items.Add(multa);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
        }
    }
}
