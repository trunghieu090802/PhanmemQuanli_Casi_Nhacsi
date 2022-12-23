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
    public partial class frmBH : DevExpress.XtraEditors.XtraForm
    {
        PHANMEMTRACUUNHACSY_CASYEntities data = new PHANMEMTRACUUNHACSY_CASYEntities();

        public frmBH()
        {
            InitializeComponent();
            LoadData();

        }
        void LoadData()
        {
            int i = 0;
            List<BAIHAT> bAIHATs = data.BAIHATs.ToList();
            var columns = from t in bAIHATs
                          select new
                          {
                              no = ++i,
                              MÃ_BÀI_HÁT = t.MABAIHAT,
                              TENBAIHAT = t.TENBAIHAT,
                              MATHELOAI = t.MATHELOAI,
                              MANHACSY = t.MANHACSY,
                              GIAIDIEU = t.GIAIDIEU,
                              GHICHU = t.GHICHU,
                          };
            gw_Baihat.DataSource = columns.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // var cs = data.CASies
                //    .Where(x => x.MACASY == txMaCS.Text.Trim())
                //    .FirstOrDefault();
                //      
                var cs = data.THUCHIENs.FirstOrDefault(x => x.MACASY.Contains(txt_mabaihat.Text.Trim()));
                if (cs != null)
                {
                    MessageBox.Show("Ca Sĩ này đã có dữ liệu");
                }
                else
                {
                    var s = data.BAIHATs.FirstOrDefault(x => x.MABAIHAT.Contains(txt_mabaihat.Text.Trim()));
                    data.BAIHATs.Remove(s);
                    data.SaveChanges();
                    LoadData();
                }
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            {
                var k = new BAIHAT
                {
                    MABAIHAT = txt_mabaihat.Text.Trim(),
                    TENBAIHAT = txt_tenbaihat.Text.Trim(),
                    GHICHU = txt_ghichu.Text.Trim(),
                    GIAIDIEU = txt_giaidieu.Text.Trim(),
                    MATHELOAI = txt_matheloai.Text.Trim(),
                    MANHACSY = txt_manhacsi.Text.Trim(),

                };
                data.BAIHATs.Add(k);
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
    }
}