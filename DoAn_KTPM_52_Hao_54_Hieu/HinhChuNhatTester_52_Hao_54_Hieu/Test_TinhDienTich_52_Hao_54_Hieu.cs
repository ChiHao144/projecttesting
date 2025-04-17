using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Import namespace của project DoAn_KTPM_52_Hao_54_Hieu chứa class HinhChuNhat_52_Hao_54_Hieu cần kiểm thử
using DoAn_KTPM_52_Hao_54_Hieu;

namespace HinhChuNhatTester_52_Hao_54_Hieu
{
    [TestClass]
    public class Test_TinhDienTich_52_Hao_54_Hieu
    {
        // Khai báo đối tượng hình chữ nhật để dùng trong các test case
        private HinhChuNhat_52_Hao_54_Hieu hcn_52_Hao_54_Hieu;
        // Khai báo hai điểm trên trái và dưới phải để dùng trong các test case
        private Diem_52_Hao_54_Hieu DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu;

        [TestMethod]
        //TC1: Tính diện tích hcn với tọa độ điểm trên trái là (2, 5) và tọa độ điểm dưới phải là (6, 2), kết quả mong đợi là 12
        public void TC1_DienTich_52_Hao_54_Hieu()
        {
            //Khởi tạo điểm trên trái (2, 5) và điểm dưới phải (6, 2) của hình chữ nhật
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 5);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 2);

            // Khởi tạo hình chữ nhật từ 2 điểm trên trái và dưới phải đã tạo
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            //Giá trị kỳ vọng của hcn = 12
            int expected_52_Hao_54_Hieu = 12;

            //Giá trị thực tế
            int actual_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }

        [TestMethod]
        // TC2: Tính diện tích hình chữ nhật với tọa độ điểm trên trái và điểm dưới phải trùng nhau với tọa độ (1, 5), kết quả mong đợi là 0
        public void TC2_DienTich_HaiDiemTrungNhau_Hao_54_Hieu()
        {
            //Khởi tạo điểm trên trái (1, 5) và điểm dưới phải (1, 5) của hình chữ nhật
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 6);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 6);

            // Khởi tạo hình chữ nhật từ 2 điểm
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            //Giá trị kỳ vọng của hcn = 0
            int expected_HCN1_52_Hao_54_Hieu = 0;

            //Giá trị thực tế
            int actual_HCN1_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
            Assert.AreEqual(expected_HCN1_52_Hao_54_Hieu, actual_HCN1_52_Hao_54_Hieu);
        }

        [TestMethod]
        // TC3: Tính diện tích hình chữ nhật với tọa độ điểm trên trái (1, 2) và điểm dưới phải (5, 2), hai điểm tạo thành đường thẳng, kết quả ký vọng 0
        public void TC3_DienTich_DuongThang_Hao_54_Hieu()
        {
            //Khởi tạo điểm trên trái (1, 2) và điểm dưới phải (5, 2) của hình chữ nhật
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 2);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 2);

            // Khởi tạo hình chữ nhật từ 2 điểm
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            //Giá trị kỳ vọng của hcn = 0
            int expected_52_Hao_54_Hieu = 0;

            //Giá trị thực tế
            int actual_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }

        [TestMethod]
        // TC4: Tính diện tích với tọa độ sai quy tắc (x1 < x2 hoặc y1 < y2), kết quả ký vọng 0
        public void TC4_DienTich_SaiToaDo_Hao_54_Hieu()
        {
            //Khởi tạo điểm trên trái (3, 2) và điểm dưới phải (5, 4) của hình chữ nhật
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 2);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 4);

            // Khởi tạo hình chữ nhật từ 2 điểm
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            //Giá trị kỳ vọng của hcn = 0
            int expected_52_Hao_54_Hieu = 0;

            //Giá trị thực tế
            int actual_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }

        [TestMethod]
        // TC5: Tính diện tích với tọa độ có giá trị âm, kết quả ký vọng 6
        public void TC5_DienTich_GiaTriAm_Hao_54_Hieu()
        {
            //Khởi tạo điểm trên trái (-3, 4) và điểm dưới phải (2, -1) của hình chữ nhật thứ nhất
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(-5, -4);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(-3, -7);

            // Khởi tạo hình chữ nhật từ 2 điểm
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            //Giá trị kỳ vọng của hcn = 6
            int expected_52_Hao_54_Hieu = 6;

            //Giá trị thực tế
            int actual_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            //Kiểm tra giá trị thực tế có khác giá trị kỳ vọng hay không
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }

        // Khai báo thuộc tính TestContext dùng để truy xuất dữ liệu từ file dữ liệu kiểm thử
        public TestContext TestContext { get; set; }

        [TestMethod]
        // Định nghĩa nguồn dữ liệu kiểm thử là một file CSV, sử dụng phương thức truy cập tuần tự (Sequential)
        // File CSV chứa các bộ dữ liệu cho phương thức kiểm thử TC6_TinhDienTich_csv_4Pass_1Fail_52_Hao_54_Hieu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"..\..\Data_52_Hao_54_Hieu\TestData_TinhDienTich_52_Hao_54_Hieu.csv",
            "TestData_TinhDienTich_52_Hao_54_Hieu#csv",
            DataAccessMethod.Sequential)]
        public void TC6_TinhDienTich_csv_3Pass_2Fail_52_Hao_54_Hieu()
        {
            // Đọc từng dòng dữ liệu từ file CSV
            // Parse dữ liệu điểm trái trên và điểm phải dưới từ các cột trong dòng dữ liệu
            int x1_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[0].ToString());
            int y1_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[1].ToString());
            int x2_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[2].ToString());
            int y2_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[3].ToString());
            int expected_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[4].ToString());

            // Khởi tạo các điểm tọa độ tạo thành hình chữ nhật
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu);

            // Tạo đối tượng hình chữ nhật từ 2 điểm vừa tạo
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            // Gọi phương thức tính diện tích hình chữ nhật
            int actual_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            // Ghi log thông tin đầu vào và kết quả ra TestContext (hiển thị trong log test)
            TestContext.WriteLine($"Chạy test với dữ liệu đầu vào:");
            TestContext.WriteLine($"  x1 = {x1_52_Hao_54_Hieu}");
            TestContext.WriteLine($"  y1 = {y1_52_Hao_54_Hieu}");
            TestContext.WriteLine($"  x2 = {x2_52_Hao_54_Hieu}");
            TestContext.WriteLine($"  y2 = {y2_52_Hao_54_Hieu}");
            TestContext.WriteLine($"Expected: {expected_52_Hao_54_Hieu}");
            TestContext.WriteLine($"Actual: {actual_52_Hao_54_Hieu}");
            if (actual_52_Hao_54_Hieu == expected_52_Hao_54_Hieu)
            {
                TestContext.WriteLine($"Test Passed!");
            }
            else
            {
                TestContext.WriteLine($"Test Failed: Expected =  {expected_52_Hao_54_Hieu}, nhưng actual = {actual_52_Hao_54_Hieu}.");
            }

            // Kiểm tra kết quả tính toán có đúng với giá trị mong đợi không
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }

        [TestMethod]
        // Cấu hình nguồn dữ liệu kiểm thử là file Excel thông qua OleDb
        // File Excel có đường dẫn tương đối: .\Data_52_Hao_54_Hieu\TestData_HCN_52_Hao_54_Hieu.xls
        // Sử dụng bảng (sheet) có tên: TinhDienTich_52_Hao_54_Hieu$
        // Phương thức đọc dữ liệu là tuần tự (Sequential)
        [DataSource("System.Data.OleDb",
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=.\\Data_52_Hao_54_Hieu\\TestData_HCN_52_Hao_54_Hieu.xls;" +
                    "Extended Properties='Excel 8.0;HDR=YES';",
                    "TinhDienTich_52_Hao_54_Hieu$", DataAccessMethod.Sequential)]
        //Kiểm thử phương thức tính diện tính với bộ dữ liệu từ file excel
        public void TC7_TinhDienTich_Excel_5Pass_52_Hao_54_Hieu()
        {
            // Đọc dữ liệu từ dòng hiện tại trong file Excel
            int x1_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[0]);
            int y1_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[1]);
            int x2_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[2]);
            int y2_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[3]);
            int expected_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[4]);

            // Tạo hai điểm để xác định hình chữ nhật
            DiemTrenTrai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu);
            DiemDuoiPhai_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu);

            // Tạo đối tượng hình chữ nhật từ hai điểm
            hcn_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_52_Hao_54_Hieu, DiemDuoiPhai_52_Hao_54_Hieu);

            // Tính diện tích hình chữ nhật thực tế
            int actual_52_Hao_54_Hieu = hcn_52_Hao_54_Hieu.TinhDienTich_52_Hao_54_Hieu();

            // Ghi log thông tin đầu vào và kết quả ra TestContext (hiển thị trong log test)
            TestContext.WriteLine($"Chạy test với dữ liệu đầu vào:");
            TestContext.WriteLine($"  x1 = {x1_52_Hao_54_Hieu}");
            TestContext.WriteLine($"  y1 = {y1_52_Hao_54_Hieu}");
            TestContext.WriteLine($"  x2 = {x2_52_Hao_54_Hieu}");
            TestContext.WriteLine($"  y2 = {y2_52_Hao_54_Hieu}");
            TestContext.WriteLine($"Expected: {expected_52_Hao_54_Hieu}");
            TestContext.WriteLine($"Actual: {actual_52_Hao_54_Hieu}");
            if (actual_52_Hao_54_Hieu == expected_52_Hao_54_Hieu)
            {
                TestContext.WriteLine($"Test Passed!");
            }
            else
            {
                TestContext.WriteLine($"Test Failed: Expected =  {expected_52_Hao_54_Hieu}, nhưng actual = {actual_52_Hao_54_Hieu}.");
            }

            // Kiểm tra kết quả thực tế có khớp với giá trị mong đợi không
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }
    }
}