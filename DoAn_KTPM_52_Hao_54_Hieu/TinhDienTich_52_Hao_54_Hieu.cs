using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_KTPM_52_Hao_54_Hieu
{
    public class TinhDienTich_52_Hao_54_Hieu
    {
        //Tạo phương thức tĩnh có thể gọi từ bên ngoài
        public static int TinhDienTichHCN_52_Hao_54_Hieu(int dai_52_Hao_54_Hieu, int rong_52_Hao_54_Hieu)
        {
            //Đặt điều kiện để kiểm tra dữ liệu hợp lệ
            if (dai_52_Hao_54_Hieu < 0 || rong_52_Hao_54_Hieu < 0)
                throw new ArgumentException("Chiều rộng và chiều cao phải >= 0");
            //Trả về diện tích hình chữ nhật 
            return dai_52_Hao_54_Hieu * rong_52_Hao_54_Hieu;
        }
    }
}
