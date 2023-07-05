using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class DataMahasiswa : Form
    {
        private string stringConnection = "data source= DESKTOP-LAFVQ8T\\MAHFUDZSIDDIQ;" + "database=Kampus;MultipleActiveResultSets=True;User ID = sa; Password = 123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customerBindingSource = new BindingSource();
        public DataMahasiswa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DataMahasiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
