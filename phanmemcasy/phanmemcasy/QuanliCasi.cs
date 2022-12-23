using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmemcasy
{
    public partial class frmCS : DevExpress.XtraEditors.XtraForm
    {
        PHANMEMTRACUUNHACSY_CASYEntities data= new PHANMEMTRACUUNHACSY_CASYEntities();
        public frmCS()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            int i = 0;
            List<CASY> lstCaSi = data.CASies.ToList();
            var columns = from t in lstCaSi
                          select new
                          {
                              no = ++i,
                              MaCS = t.MACASY,
                              TENCASY = t.TENCASY,
                              DIACHI = t.DIACHI,
                              SODIENTHOAI = t.SODIENTHOAI,
                          };
            gwCaSi.DataSource = columns.ToList();
        }
        private void gwCaSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = gwCaSi.Rows[e.RowIndex];
                txMaCS.Text = r.Cells[1].Value.ToString();
                txTenCS.Text = r.Cells[2].Value.ToString();
                txDchiCS.Text = r.Cells[3].Value.ToString();
                txSDT_CS.Text = r.Cells[4].Value.ToString();
                txMaCS.ReadOnly = true;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            {
                var k = new CASY
                {
                    MACASY = txMaCS.Text.Trim(),
                    TENCASY = txTenCS.Text.Trim(),
                    DIACHI = txDchiCS.Text.Trim(),
                    SODIENTHOAI = txSDT_CS.Text.Trim(),

                };
                data.CASies.Add(k);
                data.SaveChanges();
                LoadData();

                // }
                //else
                //          {
                //            var cs = data.CASies
                //            .Where(x => x.MACASY == txMaCS.Text.Trim())
                //            .FirstOrDefault();
                //          cs.MACASY = txMaCS.Text.Trim();
                //          cs.TENCASY = txTenCS.Text.Trim();
                //          cs.DIACHI = txDchiCS.Text.Trim();
                //          cs.SODIENTHOAI = txSDT_CS.Text.Trim();
                //          data.SaveChanges();
                //          LoadData();
                //      }


            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // var cs = data.CASies
                //    .Where(x => x.MACASY == txMaCS.Text.Trim())
                //    .FirstOrDefault();
                //      
                var cs = data.THUCHIENs.FirstOrDefault(x => x.MACASY.Contains(txMaCS.Text.Trim()));
                if (cs != null)
                {
                    MessageBox.Show("Ca Sĩ này đã có dữ liệu");
                }
                else
                {
                    var s = data.CASies.FirstOrDefault(x => x.MACASY.Contains(txMaCS.Text.Trim()));
                    data.CASies.Remove(s);
                    data.SaveChanges();
                    LoadData();
                }
            }

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void frmCS_Load(object sender, EventArgs e)
        {

        }
    }
}