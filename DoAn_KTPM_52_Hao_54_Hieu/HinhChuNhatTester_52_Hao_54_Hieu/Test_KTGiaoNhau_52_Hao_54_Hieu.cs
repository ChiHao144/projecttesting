using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
//Import namespace của project DoAn_KTPM_52_Hao_54_Hieu chứa class HinhChuNhat_52_Hao_54_Hieu cần kiểm thử
using DoAn_KTPM_52_Hao_54_Hieu;


namespace HinhChuNhatTester_52_Hao_54_Hieu
{
    [TestClass]
    public class Test_KTGiaoNhau_52_Hao_54_Hieu
    {
        // Khai báo đối tượng hình chữ nhật thứ nhất và thứ 2 để dùng trong các test case
        private HinhChuNhat_52_Hao_54_Hieu hcn1_52_Hao_54_Hieu, hcn2_52_Hao_54_Hieu;
        // Khai báo hai điểm trên trái và dưới phải của 2 hình chữ nhật để dùng trong các test case
        private Diem_52_Hao_54_Hieu DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu, DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu;

        [TestMethod]
        // TC1: Kiểm tra hai hình chữ nhật có giao nhau (Giao nhau 1 phần) => Pass
        public void TC1_GiaoNhau_52_Hao_54_Hieu()
        {
            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 3);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 0);

            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 4);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 1);

            // Khởi tạo đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi phương thức GiaoNhau để kiểm tra xem hai hình chữ nhật có giao nhau không
            // Kết quả trả về (true/false) sẽ được lưu vào biến actual_52_Hao_54_Hieu
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Kiểm tra xem kết quả có đúng là hai hình giao nhau không (kỳ vọng là true)
            // Nếu actual_52_Hao_54_Hieu == false, test sẽ bị fail
            Assert.IsTrue(actual_52_Hao_54_Hieu);
        }

        [TestMethod]
        // TC2: Kiểm tra giao nhau ở góc => Pass
        public void TC2_GiaoNhau_Goc_52_Hao_54_Hieu()
        {
            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 2);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 0);

            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 4);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 2);

            // Khởi tạo đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi phương thức GiaoNhau để kiểm tra xem hai hình chữ nhật có giao nhau không
            // Kết quả trả về (true/false) sẽ được lưu vào biến actual_52_Hao_54_Hieu
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Kiểm tra xem kết quả có đúng là hai hình giao nhau không (kỳ vọng là true)
            // Nếu actual_52_Hao_54_Hieu == false, test sẽ bị fail
            Assert.IsTrue(actual_52_Hao_54_Hieu);

        }

        [TestMethod]
        // TC3: Kiểm tra giao nhau ở cạnh bên => Pass
        public void TC3_GiaoNhau_CanhBen_52_Hao_54_Hieu()
        {
            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 4);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 0);

            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(2, 3);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 0);

            // Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi phương thức GiaoNhau để kiểm tra xem hai hình chữ nhật có giao nhau không
            // Kết quả trả về (true/false) sẽ được lưu vào biến actual_52_Hao_54_Hieu
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Kiểm tra xem kết quả có đúng là hai hình giao nhau không (kỳ vọng là true)
            // Nếu actual_52_Hao_54_Hieu == false, test sẽ bị fail
            Assert.IsTrue(actual_52_Hao_54_Hieu);

        }

        [TestMethod]
        // TC4: Một hình chữ nhật nằm trong hình chữ nhật kia => Pass
        public void TC4_GiaoNhau_NamTrong_52_Hao_54_Hieu()
        {
            //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 4);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 0);

            //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 2);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 1);

            //Khởi đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi phương thức GiaoNhau để kiểm tra xem hai hình chữ nhật có giao nhau không
            // Kết quả trả về (true/false) sẽ được lưu vào biến actual_52_Hao_54_Hieu
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Kiểm tra xem kết quả có đúng là hai hình giao nhau không (kỳ vọng là true)
            // Nếu actual_52_Hao_54_Hieu == false, test sẽ bị fail
            Assert.IsTrue(actual_52_Hao_54_Hieu);

        }

        [TestMethod]
        // TC5: Hai hình chữ nhật trùng nhau => Pass
        public void TC5_GiaoNhau_TrungNhau_52_Hao_54_Hieu()
        {
            //Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 5);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 1);

            // Hình chữ nhật thứ hai có tọa độ giống hệt hình chữ nhật thứ nhất
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(1, 5);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(5, 1);

            //Khởi tạo đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi phương thức GiaoNhau để kiểm tra xem hai hình chữ nhật có giao nhau không
            // Kết quả trả về (true/false) sẽ được lưu vào biến actual_52_Hao_54_Hieu
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Kiểm tra xem kết quả có đúng là hai hình giao nhau không (kỳ vọng là true)
            // Nếu actual_52_Hao_54_Hieu == false, test sẽ bị fail
            Assert.IsTrue(actual_52_Hao_54_Hieu);
        }

        [TestMethod]
        // TC6: Kiểm tra hai hình chữ nhật có giao nhau, cho ra kết quả Fail
        public void TC6_GiaoNhau_Fail_52_Hao_54_Hieu()
        {
            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(0, 3);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(3, 0);

            // Khởi tạo tọa độ điểm trên trái vài điểm dưới phải của hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(4, 3);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(6, 0);

            // Khởi tạo đối tượng hình chữ nhật thứ nhất và thứ hai với các tọa độ đã tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi phương thức GiaoNhau để kiểm tra xem hai hình chữ nhật có giao nhau không
            // Kết quả trả về (true/false) sẽ được lưu vào biến actual_52_Hao_54_Hieu
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Kiểm tra xem kết quả có đúng là hai hình giao nhau không (kỳ vọng là true)
            // Nếu actual_52_Hao_54_Hieu == false, test sẽ bị fail
            Assert.IsTrue(actual_52_Hao_54_Hieu);
        }

        // Thuộc tính TestContext cho phép truy xuất dữ liệu dòng hiện tại từ file kiểm thử (CSV)
        public TestContext TestContext { get; set; }

        [TestMethod]
        // Cấu hình nguồn dữ liệu kiểm thử là file CSV
        // File chứa dữ liệu kiểm tra chức năng giao nhau giữa hai hình chữ nhật
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_52_Hao_54_Hieu\TestData_KTGiaoNhau_52_Hao_54_Hieu.csv",
            "TestData_KTGiaoNhau_52_Hao_54_Hieu#csv",
            DataAccessMethod.Sequential)]
        public void TC7_KTGiaoNhau_csv_3Pass_2Fail_52_Hao_54_Hieu()
        {
            // Đọc tọa độ điểm trái trên và phải dưới của hình chữ nhật 1 từ dòng dữ liệu
            int x1_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[0].ToString());
            int y1_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[1].ToString());
            int x2_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[2].ToString());
            int y2_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[3].ToString());

            // Đọc tọa độ điểm trái trên và phải dưới của hình chữ nhật 2 từ dòng dữ liệu
            int x3_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[4].ToString());
            int y3_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[5].ToString());
            int x4_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[6].ToString());
            int y4_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[7].ToString());

            // Đọc kết quả mong đợi (có giao nhau hay không)
            bool expected_52_Hao_54_Hieu = bool.Parse(TestContext.DataRow[8].ToString());

            // Tạo điểm trái trên và phải dưới cho hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu);

            // Tạo điểm trái trên và phải dưới cho hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu);

            // Tạo hai đối tượng hình chữ nhật từ các điểm vừa tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi hàm kiểm tra hai hình chữ nhật có giao nhau hay không
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Ghi log các giá trị để tiện theo dõi
            TestContext.WriteLine("Chạy test với dữ liệu đầu vào:");
            TestContext.WriteLine($"HCN1: ({x1_52_Hao_54_Hieu}, {y1_52_Hao_54_Hieu}) -> ({x2_52_Hao_54_Hieu}, {y2_52_Hao_54_Hieu})");
            TestContext.WriteLine($"HCN2: ({x3_52_Hao_54_Hieu}, {y3_52_Hao_54_Hieu}) -> ({x4_52_Hao_54_Hieu}, {y4_52_Hao_54_Hieu})");
            TestContext.WriteLine($"Expected: {expected_52_Hao_54_Hieu}");
            TestContext.WriteLine($"Actual: {actual_52_Hao_54_Hieu}");
            TestContext.WriteLine(expected_52_Hao_54_Hieu == actual_52_Hao_54_Hieu ? "=> Pass" : "=> Fail");

            // So sánh kết quả thực tế với kết quả mong đợi
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }

        // Phương thức kiểm thử sử dụng dữ liệu từ file Excel
        [TestMethod]
        // Cấu hình nguồn dữ liệu kiểm thử là file Excel thông qua OleDb
        // File Excel có đường dẫn tương đối: .\Data_52_Hao_54_Hieu\TestData_HCN_52_Hao_54_Hieu.xlsX
        // Sử dụng bảng (sheet) có tên: KTGiaoNhau_52_Hao_54_Hieu$
        // Phương thức đọc dữ liệu là tuần tự (Sequential)
        [DataSource("System.Data.OleDb",
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=.\\Data_52_Hao_54_Hieu\\TestData_HCN_52_Hao_54_Hieu.xls;" +
                    "Extended Properties='Excel 8.0;HDR=YES';",
                    "KTGiaoNhau_52_Hao_54_Hieu$", DataAccessMethod.Sequential)]
        public void TC8_KTGiaoNhau_Excel_3Pass_2Fail_52_Hao_54_Hieu()
        {
            // Tăng số thứ tự testcase bằng index dòng dữ liệu
            int testCaseNumber_52_Hao_54_Hieu = TestContext.DataRow.Table.Rows.IndexOf(TestContext.DataRow) + 1;

            // Đọc tọa độ các điểm của hai hình chữ nhật từ dòng dữ liệu trong file Excel
            int x1_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[0]);
            int y1_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[1]);
            int x2_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[2]);
            int y2_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[3]);

            int x3_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[4]);
            int y3_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[5]);
            int x4_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[6]);
            int y4_52_Hao_54_Hieu = Convert.ToInt32(TestContext.DataRow[7]);

            // Đọc kết quả mong đợi từ dòng dữ liệu (true nếu hai hình giao nhau, false nếu không)
            bool expected_52_Hao_54_Hieu = Convert.ToBoolean(TestContext.DataRow[8]);

            // Tạo các điểm trái trên và phải dưới cho hình chữ nhật thứ nhất
            DiemTrenTrai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x1_52_Hao_54_Hieu, y1_52_Hao_54_Hieu);
            DiemDuoiPhai_HCN1_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x2_52_Hao_54_Hieu, y2_52_Hao_54_Hieu);

            // Tạo các điểm trái trên và phải dưới cho hình chữ nhật thứ hai
            DiemTrenTrai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x3_52_Hao_54_Hieu, y3_52_Hao_54_Hieu);
            DiemDuoiPhai_HCN2_52_Hao_54_Hieu = new Diem_52_Hao_54_Hieu(x4_52_Hao_54_Hieu, y4_52_Hao_54_Hieu);

            // Tạo hai đối tượng hình chữ nhật từ các điểm vừa khởi tạo
            hcn1_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN1_52_Hao_54_Hieu, DiemDuoiPhai_HCN1_52_Hao_54_Hieu);
            hcn2_52_Hao_54_Hieu = new HinhChuNhat_52_Hao_54_Hieu(DiemTrenTrai_HCN2_52_Hao_54_Hieu, DiemDuoiPhai_HCN2_52_Hao_54_Hieu);

            // Gọi hàm kiểm tra giao nhau giữa hai hình chữ nhật
            bool actual_52_Hao_54_Hieu = hcn1_52_Hao_54_Hieu.GiaoNhau_52_Hao_54_Hieu(hcn2_52_Hao_54_Hieu).Item1;

            // Ghi log các giá trị để tiện theo dõi
            TestContext.WriteLine("Chạy test với dữ liệu đầu vào:");
            TestContext.WriteLine($"HCN1: ({x1_52_Hao_54_Hieu}, {y1_52_Hao_54_Hieu}) -> ({x2_52_Hao_54_Hieu}, {y2_52_Hao_54_Hieu})");
            TestContext.WriteLine($"HCN2: ({x3_52_Hao_54_Hieu}, {y3_52_Hao_54_Hieu}) -> ({x4_52_Hao_54_Hieu}, {y4_52_Hao_54_Hieu})");
            TestContext.WriteLine($"Expected: {expected_52_Hao_54_Hieu}");
            TestContext.WriteLine($"Actual: {actual_52_Hao_54_Hieu}");
            TestContext.WriteLine(expected_52_Hao_54_Hieu == actual_52_Hao_54_Hieu ? "=> Pass" : "=> Fail");

            // So sánh kết quả thực tế với mong đợi
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }
    }
}
