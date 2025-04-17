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
    public partial class HinhChuNhatApp_52_Hao_54_Hieu : Form
    {
        public HinhChuNhatApp_52_Hao_54_Hieu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Xử lý sự kiện khi nhấn nút tính diện tích
        private void btn_TinhDT_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập đầy đủ tọa độ cho HCN1 hay chưa
            bool hcn1DayDu_52_Hao_54_Hieu = !string.IsNullOrWhiteSpace(txt_X1_52_Hao_54_Hieu.Text) &&
                                            !string.IsNullOrWhiteSpace(txt_Y1_52_Hao_54_Hieu.Text) &&
                                            !string.IsNullOrWhiteSpace(txt_X2_52_Hao_54_Hieu.Text) &&
                                            !string.IsNullOrWhiteSpace(txt_Y2_52_Hao_54_Hieu.Text);

            // Kiểm tra người dùng đã nhập đầy đủ tọa độ cho HCN2 hay chưa
            bool hcn2DayDu_52_Hao_54_Hieu = !string.IsNullOrWhiteSpace(txt_X3_52_Hao_54_Hieu.Text) &&
                                            !string.IsNullOrWhiteSpace(txt_Y3_52_Hao_54_Hieu.Text) &&
                                            !string.IsNullOrWhiteSpace(txt_X4_52_Hao_54_Hieu.Text) &&
                                            !string.IsNullOrWhiteSpace(txt_Y4_52_Hao_54_Hieu.Text);

            // Chuỗi lưu kết quả tính diện tích
            string ketQua_52_Hao_54_Hieu = "";

            // Nếu đã nhập đủ tọa độ cho HCN1
            if (hcn1DayDu_52_Hao_54_Hieu)
            {
                // Lấy giá trị tọa độ từ ô nhập
                int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
                int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
                int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
                int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

                // Tạo đối tượng điểm
                Diem_52_Hao_54_Hieu diemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu);
                Diem_52_Hao_54_Hieu diemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu);

                // Tạo đối tượng hình chữ nhật
                HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(diemTrenTrai_HCN1_52_Hao_54_Hieu, diemDuoiPhai_HCN1_52_Hao_54_Hieu);

                // Tính diện tích HCN1
                int dt1_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

                // Nếu diện tích bằng 0 thì báo lỗi
                if (dt1_52_Hao_54_Hieu == 0)
                {
                    txt_Kq_52_Hao_54_Hieu.Text = "Tọa độ HCN1 không hợp lệ";
                    return;
                }

                // Thêm kết quả vào chuỗi hiển thị
                ketQua_52_Hao_54_Hieu += $"Diện tích HCN1: {dt1_52_Hao_54_Hieu}";
            }

            // Nếu đã nhập đủ tọa độ cho HCN2
            if (hcn2DayDu_52_Hao_54_Hieu)
            {
                // Lấy giá trị tọa độ từ ô nhập
                int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
                int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
                int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
                int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

                // Tạo đối tượng điểm
                Diem_52_Hao_54_Hieu diemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu);
                Diem_52_Hao_54_Hieu diemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu);

                // Tạo đối tượng hình chữ nhật
                HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(diemTrenTrai_HCN2_52_Hao_54_Hieu, diemDuoiPhai_HCN2_52_Hao_54_Hieu);

                // Tính diện tích HCN2
                int dt2_52_Hao_54_Hieu = hcn2_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

                // Nếu diện tích bằng 0 thì báo lỗi
                if (dt2_52_Hao_54_Hieu == 0)
                {
                    txt_Kq_52_Hao_54_Hieu.Text = "Tọa độ HCN2 không hợp lệ";
                    return;
                }

                // Nếu trước đó có kết quả HCN1 → thêm dấu phẩy ngăn cách
                if (!string.IsNullOrEmpty(ketQua_52_Hao_54_Hieu))
                    ketQua_52_Hao_54_Hieu += ", ";

                // Thêm kết quả vào chuỗi hiển thị
                ketQua_52_Hao_54_Hieu += $"Diện tích HCN2: {dt2_52_Hao_54_Hieu}";
            }

            // Hiển thị kết quả cuối cùng hoặc thông báo nếu không nhập gì hợp lệ
            txt_Kq_52_Hao_54_Hieu.Text = string.IsNullOrEmpty(ketQua_52_Hao_54_Hieu)
                ? "Vui lòng nhập tọa độ hợp lệ cho ít nhất một hình chữ nhật"
                : ketQua_52_Hao_54_Hieu;
        }

        // Xử lý sự kiện khi nhấn nút kiểm tra giao nhau
        private void btn_GiaoNhau_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ hai hình chữ nhật từ ô nhập liệu
            int x1_52_Hao_54_Hieu = int.Parse(txt_X1_52_Hao_54_Hieu.Text);
            int y1_52_Hao_54_Hieu = int.Parse(txt_Y1_52_Hao_54_Hieu.Text);
            int x2_52_Hao_54_Hieu = int.Parse(txt_X2_52_Hao_54_Hieu.Text);
            int y2_52_Hao_54_Hieu = int.Parse(txt_Y2_52_Hao_54_Hieu.Text);

            int x3_52_Hao_54_Hieu = int.Parse(txt_X3_52_Hao_54_Hieu.Text);
            int y3_52_Hao_54_Hieu = int.Parse(txt_Y3_52_Hao_54_Hieu.Text);
            int x4_52_Hao_54_Hieu = int.Parse(txt_X4_52_Hao_54_Hieu.Text);
            int y4_52_Hao_54_Hieu = int.Parse(txt_Y4_52_Hao_54_Hieu.Text);

            //Tạo tọa độ hai điểm trên trái và dưới phải cho hình chữ nhật thứ nhất
            Diem_52_Hao_54_Hieu DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu);
            Diem_52_Hao_54_Hieu DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu);

            // Tạo đối tượng HCN1
            HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);

            //Tạo tọa độ hai điểm trên trái và dưới phải cho hình chữ nhật thứ hai
            Diem_52_Hao_54_Hieu DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu);
            Diem_52_Hao_54_Hieu DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu);

            // Tạo đối tượng HCN2
            HinhChuNhat_52_Hao_54_Hieu hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi hàm kiểm tra giao nhau và nhận kết quả gồm: bool (giao nhau) và string (thông báo lỗi nếu có)
            (bool ketQuaGiaoNhau_52_Hao_54_Hieu, string thongBaoLoi_52_Hao_54_Hieu) = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu);

            // Nếu có lỗi (ví dụ: 1 hình không hợp lệ), hiển thị lỗi
            if (!string.IsNullOrEmpty(thongBaoLoi_52_Hao_54_Hieu))
            {
                txt_Kq_52_Hao_54_Hieu.Text = thongBaoLoi_52_Hao_54_Hieu;
            }
            else
            {
                // Nếu không có lỗi, hiển thị kết quả giao nhau
                if (ketQuaGiaoNhau_52_Hao_54_Hieu)
                    txt_Kq_52_Hao_54_Hieu.Text = "Hai hình chữ nhật giao nhau";
                else
                    txt_Kq_52_Hao_54_Hieu.Text = "Hai hình chữ nhật không giao nhau";
            }
        }
    }
}
