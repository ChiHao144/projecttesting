using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Import namespace chứa class TinhDienTich_52_Hao_54_Hieu
using DoAn_KTPM_52_Hao_54_Hieu;

namespace TinhDienTich_UnitTest_52_Hao_54_Hieu
{
    [TestClass]
    public class UnitTest1
    {
        //TEST CASE HỢP LỆ 
        //Test case 1: Test với kết quả hợp lệ
        [TestMethod]
        public void TC1_52_Hao_54_Hieu_Test_HopLe()
        {
            Assert.AreEqual(50, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(5, 10));
        }
        //Test case 2: Test với chiều dài bằng 0
        [TestMethod]
        public void TC2_52_Hao_54_Hieu_Test_WidthZero()
        {
            Assert.AreEqual(0, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(0, 10));
        }
        //Test case 3: Test với chiều rộng bằng 0
        [TestMethod]
        public void TC3_52_Hao_54_Hieu_Test_HeightZero()
        {
            Assert.AreEqual(0, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(10, 0));
        }
        //Test case 4: Test với số dương bé nhất
        [TestMethod]
        public void TC4_52_Hao_54_Hieu_Test_MinimumPositiveValues()
        {
            Assert.AreEqual(1, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(1, 1));
        }
        //Test case 5: Test với số dương lớn 
        [TestMethod]
        public void TC5_52_Hao_54_Hieu_Test_LargeNumbers()
        {
            Assert.AreEqual(2000000, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(1000, 2000));
        }


        //TEST CASE KHÔNG HỢP LỆ
        //Test case 6: Test với chiều dài âm
        [TestMethod]
        public void TC6_52_Hao_54_Hieu_Test_NegativeWidth()
        {
            Assert.AreEqual(-50, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(-5, 10)); 
        }
        //Test case 7: Test với chiều rộng âm
        [TestMethod]
        public void TC7_52_Hao_54_Hieu_Test_NegativeHeight()
        {
            Assert.AreEqual(-50, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(5, -10));
        }
        //Test case 8: Test với chiều dài và rộng âm
        [TestMethod]
        public void TC8_52_Hao_54_Hieu_Test_NegativeWidthAndHeight()
        {
            Assert.AreEqual(50, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(-5, -10));
        }

        //Test case 9: Test với dữ liệu chiều dài sai
        [TestMethod]
        public void TC9_52_Hao_54_Hieu_Test_NonNumericWidth()
        {
            // Lỗi khi chuyển đổi
            int width_52_Hao_54_Hieu = int.Parse("abc");
            int height_52_Hao_54_Hieu = 10;
            Assert.AreEqual(50, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(width_52_Hao_54_Hieu, height_52_Hao_54_Hieu));
        }
        //Test case 10: Test với dữ liệu dài rộng sai
        [TestMethod]
        public void TC10_52_Hao_54_Hieu_Test_NonNumericHeight()
        {
            // Lỗi khi chuyển đổi
            int width_52_Hao_54_Hieu = 10;
            int height_52_Hao_54_Hieu = int.Parse("xyz");
            Assert.AreEqual(50, TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(width_52_Hao_54_Hieu, height_52_Hao_54_Hieu));
        }



        //ĐỌC FILE CSV 3 CỘT
        //Khai báo TestContext để đọc dữ liệu từ file CSV
        public TestContext TestContext { get; set; }
        //Đọc dữ liệu từ file CSV với 3 cột: Width, Height, ExpectedResult
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @".\Data_52_Hao_54_Hieu\TestData_3col_52_Hao_54_Hieu.csv",
            "TestData_3col_52_Hao_54_Hieu#csv",DataAccessMethod.Sequential)]

        //VỚI 5 PASS, 5 FAIL
        [TestMethod]
        public void TC11_52_Hao_54_Hieu_TestWithDataSource_3Col_5Pass_5Fail()
        {
            //Đọc dữ liệu từ TestContext (theo thứ tự cột)
            //Cột chiều dài
            int width_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[0].ToString());
            //Cột chiều rộng
            int height_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[1].ToString());
            //Cột kết quả mong đợi
            int expected_52_Hao_54_Hieu = int.Parse(TestContext.DataRow[2].ToString());

            //Gọi phương thức tính diện tích hình chữ nhật với dữ liệu từ file CSV
            int actual_52_Hao_54_Hieu = TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(width_52_Hao_54_Hieu, height_52_Hao_54_Hieu);

            //So sánh kết quả thực thế với kết quả mong đợi 
            Assert.AreEqual(expected_52_Hao_54_Hieu, actual_52_Hao_54_Hieu);
        }
    }
}
