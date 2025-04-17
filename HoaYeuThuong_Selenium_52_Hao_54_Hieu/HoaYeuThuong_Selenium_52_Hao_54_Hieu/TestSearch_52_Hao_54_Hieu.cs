using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;


namespace HoaYeuThuong_Selenium_52_Hao_54_Hieu
{
    [TestClass]
    public class TestSearch_52_Hao_54_Hieu
    {
        [TestMethod]
        // Case 8: Tìm sản phẩm có chứa từ khoá
        // Kết quả mong đợi tìm được sản phẩm bằng từ khoá nhập vào => pass
        public void TC8_TestSearch_52_Hao_54_Hieu()
        {
            //Điều hướng đến trang web hoa yêu thương
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            //Cho web ngủ 2s để load trang
            Thread.Sleep(2000);
            //Dùng thuộc tính id để truyền từ khoá tìm kiếm  
            IWebElement input_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.Id("txtSearch"));
            input_52_Hao_54_Hieu.SendKeys("hoa hồng");
            //Click button tìm kiếm 
            driver_52_Hao_54_Hieu.FindElement(By.LinkText("Tìm kiếm")).Click();
            try
            {
                //Tìm kiếm phần tử với css selector
                IWebElement notification_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.CssSelector("#ctl00_cphContent_ucSearchItems_ucItems_rptItems_ctl00_hplTitle"));
                //Nếu tìm thấy phần tử Assert.IsTrue(true) sẽ chạy vào báo test là pass 
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                //Nếu không tìm thấy phần tử sẽ báo test là fail
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        // Case 9: Không tìm thấy sản phẩm có chứa từ khoá
        // Kết quả mong đợi là nhập từ khoá không tìm thấy sản phẩm nào => pass
        public void TC9_TestSearch_52_Hao_54_Hieu()
        {
            //Điều hướng đến trang web hoa yêu thương
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            //Cho web ngủ 2s để load trang
            Thread.Sleep(2000);
            //Dùng thuộc tính id để truyền từ khoá tìm kiếm  
            IWebElement input_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.Id("txtSearch"));
            input_52_Hao_54_Hieu.SendKeys("abc");
            //Click button tìm kiếm 
            driver_52_Hao_54_Hieu.FindElement(By.LinkText("Tìm kiếm")).Click();
            //Tìm danh sách các item sản phẩm được hiển thị sau khi tìm kiếm
            //IList<...> đại diện cho 1 danh sách có thể truy cập theo chỉ số 
            //IWebElement đại diện cho 1 phần tử trong danh sách này
            IList<IWebElement> items_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElements(By.CssSelector("#data_items > div:nth-child(1)"));
            //Dùng hàm Count để kiểm tra số lượng trong danh sách
            // Nếu danh sách rỗng, nghĩa là không có sản phẩm phù hợp với từ khoá
            if (items_52_Hao_54_Hieu.Count == 0)
            {
                // Đúng như mong đợi, test pass
                Assert.IsTrue(true);
            }
            else
            {
                // Có sản phẩm xuất hiện, sai yêu cầu
                Assert.IsTrue(false);
            }
        }
    }
}
