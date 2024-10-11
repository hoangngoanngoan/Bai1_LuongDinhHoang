namespace Bai1_LuongDinhHoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Xe> dsx = new List<Xe>();
        List<XeDien> dsxd = new List<XeDien>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            var tenx = txttenx.Text;
            var namsx = int.Parse(txtnamsxx.Text);
            var gban = double.Parse(txtgbanx.Text);
            var newXe = new Xe(null, tenx, namsx, gban);

            dsx.Add(newXe);
            dt1.DataSource = null;
            dt1.DataSource = dsx;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var bso = txtbsx.Text;
            foreach (var item in dsx)
            {
                if (item.BienSoXe == bso)
                {
                    dsx.Remove(item);
                    break;
                }
            }
            dt1.DataSource = null;
            dt1.DataSource = dsx;
        }

        private void btnthemxd_Click(object sender, EventArgs e)
        {
            var tenx = txttenxd.Text;
            var namsx = int.Parse(txtnamxd.Text);
            var gban = double.Parse(txtgbanxd.Text);
            var pin = int.Parse(txtpin.Text);
            var newXe = new XeDien(null, tenx, namsx, gban, pin);

            dsxd.Add(newXe);
            dt2.DataSource = null;
            dt2.DataSource = dsxd;
        }

        private void btnxoaxd_Click(object sender, EventArgs e)
        {
            var bso = txtbsoxd.Text;
            foreach (var item in dsxd)
            {
                if (item.BienSoXe == bso)
                {
                    dsxd.Remove(item);
                    break;
                }
            }
            dt2.DataSource = null;
            dt2.DataSource = dsxd;
        }
    }
}
