using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_KTPM_52_Hao_54_Hieu
{
    // Lớp HinhChuNhat_52_Hao_54_Hieu đại diện cho hình chữ nhật trong hệ tọa độ 2D
    public class HinhChuNhat_52_Hao_54_Hieu
    {
        // Hai điểm định nghĩa hình chữ nhật: điểm trên trái và điểm dưới phải
        public Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu;
        public Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu;

        // Constructor: Khởi tạo đối tượng Hình chữ nhật với hai điểm được truyền vào
        public HinhChuNhat_52_Hao_54_Hieu(Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, Diem_52_Hao_54_Hieu DiemDuoiPhai_52_Hao_54_Hieu)
        {     
            // Gán giá trị cho các thuộc tính
            this.DiemTrenTrai_52_Hao_54_Hieu = DiemTrenTrai_52_Hao_54_Hieu;
            this.DiemDuoiPhai_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu;
        }

        public int TinhDienTich_52_Hao_54_Hieu()
        {
            // Khởi tạo biến diện tích ban đầu bằng 0
            int DienTich_52_Hao_54_Hieu = 0;

            // Kiểm tra nếu tọa độ không hợp lệ thì trả về diện tích = 0
            if (ToaDoKhongHopLe(this))
                return DienTich_52_Hao_54_Hieu;
            else
            {
                // Tính chiều dài hình chữ nhật bằng X2 - X1
                int ChieuDai_52_Hao_54_Hieu = DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu - DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu;

                // Tính chiều rộng hình chữ nhật bằng Y1 - Y2
                int ChieuRong_52_Hao_54_Hieu = DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu - DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu;

                // Tính và trả về diện tích bằng chiều dài nhân chiều rộng
                return DienTich_52_Hao_54_Hieu = ChieuDai_52_Hao_54_Hieu * ChieuRong_52_Hao_54_Hieu;
            }
        }

        // Kiểm tra tọa độ không hợp lệ
        public bool ToaDoKhongHopLe(HinhChuNhat_52_Hao_54_Hieu hcn_52_Hao_54_Hieu)
        {
            return (hcn_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu >= hcn_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu
                    || hcn_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu <= hcn_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu);
        }

        public (bool, string) GiaoNhau_52_Hao_54_Hieu(HinhChuNhat_52_Hao_54_Hieu hcnKhac_52_Hao_54_Hieu)
        {

            if(ToaDoKhongHopLe(this) || ToaDoKhongHopLe(hcnKhac_52_Hao_54_Hieu))
                return (false, "Tọa độ không hợp lệ");

            // Kiểm tra điều kiện không giao nhau:
            // 1. Một hình nằm hoàn toàn bên trái hình kia
            // 2. Một hình nằm hoàn toàn bên phải hình kia
            // 3. Một hình nằm hoàn toàn phía trên hình kia
            // 4. Một hình nằm hoàn toàn phía dưới hình kia
            if (this.DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < hcnKhac_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu ||
                hcnKhac_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.X_52_Hao_54_Hieu < this.DiemTrenTrai_52_Hao_54_Hieu.X_52_Hao_54_Hieu ||
                this.DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < hcnKhac_52_Hao_54_Hieu.DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu ||
                hcnKhac_52_Hao_54_Hieu.DiemTrenTrai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu < this.DiemDuoiPhai_52_Hao_54_Hieu.Y_52_Hao_54_Hieu)
            {
                return (false, "");
            }
            
            // Nếu không rơi vào các trường hợp loại trừ thì hai hình có giao nhau
            return (true, "");
        }
    }
}
