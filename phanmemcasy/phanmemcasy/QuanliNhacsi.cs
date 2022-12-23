using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frmNS : DevExpress.XtraEditors.XtraForm
    {
        PHANMEMTRACUUNHACSY_CASYEntities data = new PHANMEMTRACUUNHACSY_CASYEntities();

        public frmNS()
        {
            InitializeComponent();
            LoadData();

        }
        void LoadData()
        {
            int i = 0;
            List<NHACSY> nHACSies = data.NHACSies.ToList();
            var columns = from t in nHACSies
                          select new
                          {
                              no = ++i,
                              MANHACSY = t.MANHACSY,
                              TENCASY = t.TENNHACSY,
                              DIACHI = t.DIACHI,
                              SODIENTHOAI = t.SODIENTHOAI,
                          };
            gwNhacSi.DataSource = columns.ToList();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            {
                var k = new NHACSY
                {
                    MANHACSY = txtUser.Text.Trim(),
                    TENNHACSY = txt_TenNS.Text.Trim(),
                    DIACHI = txt_Diachi.Text.Trim(),
                    SODIENTHOAI = txt_SDT.Text.Trim(),

                };
                data.NHACSies.Add(k);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                var cs = data.THUCHIENs.FirstOrDefault(x => x.MACASY.Contains(txtUser.Text.Trim()));
                if (cs != null)
                {
                    MessageBox.Show("Ca Sĩ này đã có dữ liệu");
                }
                else
                {
                    var s = data.NHACSies.FirstOrDefault(x => x.MANHACSY.Contains(txtUser.Text.Trim()));
                    data.NHACSies.Remove(s);
                    data.SaveChanges();
                    LoadData();
                }
            }

        }
    }
}