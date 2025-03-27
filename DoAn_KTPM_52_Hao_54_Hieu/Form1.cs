using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn_KTPM_52_Hao_54_Hieu
{
    public partial class Form1 : Form
    {
        //Hàm khởi tạo Form 1
        public Form1()
        {
            //Khởi tạo các thành phần giao diện
            InitializeComponent();
        }

        //Sự kiện khi nhấn nút "Tính diện tích"
        private void btn_TinhDT_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy dữ liệu từ textbox và chuyển sang kiểu số nguyên
                int dai_52_Hao_54_Hieu = int.Parse(txt_ChieuDai_52_Hao_54_Hieu.Text);
                int rong_52_Hao_54_Hieu = int.Parse(txt_ChieuRong_52_Hao_54_Hieu.Text);
                //Gọi phương thức TinhDienTichHCN_52_Hao_54_Hieu từ class TinhDienTich_52_Hao_54_Hieu 
                int dientich_52_Hao_54_Hieu = TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(dai_52_Hao_54_Hieu, rong_52_Hao_54_Hieu);
                //Hiển thị kết quả trong textbox txt_KetQua_52_Hao_54_Hieu
                txt_KetQua_52_Hao_54_Hieu.Text = dientich_52_Hao_54_Hieu.ToString();
            }
            catch (FormatException)
            {
                //Hiển thị thông báo lỗi nếu nhập sai định dạng
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                //Hiển thị thông báo lỗi nếu nhập số âm
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
