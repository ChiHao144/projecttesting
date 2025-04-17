using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Interactions;


namespace HoaYeuThuong_Selenium_52_Hao_54_Hieu
{
    [TestClass]
    public class TestChangeAddress_52_Hao_54_Hieu
    {
        [TestMethod]
        //Case 3: Đổi nơi giao hàng
        //Kết quả mong đợi chuyển nơi giao hàng ở An Giang => pass
        public void TC3_TestChangeAddress_52_Hao_54_Hieu()
        {
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            // Điều hướng đến trang chủ hoayeuthuong.com
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            // Chờ 2 giây để trang web load xong
            Thread.Sleep(2000);
            try
            {
                // Tìm phần tử hiển thị vị trí hiện tại (thành phố/tỉnh đang chọn)
                IWebElement element_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.CssSelector("#top-line > div > div.location > div.dropdown_content > span"));
                // mô phỏng hành vi chuột thật, di chuyển con trỏ đến phần tử trước, rồi click
                // do button yêu cầu phải hover hoặc đã được phủ lớp nào trước đó
                Actions action_52_Hao_54_Hieu = new Actions(driver_52_Hao_54_Hieu);
                // Di chuột đến phần tử hiển thị vị trí để hiển thị dropdown các lựa chọn tỉnh/thành phố
                //MoveToElement phương thức trong đối tượng Actions dùng để rê chuột (hover)
                //Perform là kết thúc chuỗi hoạt động và thực thi nó
                action_52_Hao_54_Hieu.MoveToElement(element_52_Hao_54_Hieu).Perform();
                // Chờ 2 giây để dropdown hiển thị
                Thread.Sleep(2000);
                // Tìm và click vào lựa chọn "An Giang" trong danh sách dropdown
                IWebElement AnGiangOption = driver_52_Hao_54_Hieu.FindElement(By.LinkText("An Giang"));
                AnGiangOption.Click();
                // Chờ 2 giây để nội dung trang cập nhật theo địa chỉ mới
                Thread.Sleep(2000);
                // Tìm một phần tử sản phẩm (ở đây là phần tử thứ 2 trong danh sách sản phẩm) để xác nhận địa chỉ đã thay đổi thành công
                IWebElement select_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.CssSelector("#content > div > ul > li:nth-child(2) > h1 > a"));
                // Kiểm tra thành công nếu không có lỗi xảy ra
                Assert.IsTrue(true);
            }
            catch
            {
                // Nếu có bất kỳ lỗi nào trong khối try, test sẽ thất bại
                Assert.Fail();
            }
        }

        [TestMethod]
        // Case 4: Chọn tỉnh không tồn tại
        // Kết quả mong đợi: Không thay đổi vị trí, không phát sinh lỗi
        public void TC4_TestChangeAddress_52_Hao_54_Hieu()
        {
            // Khởi tạo trình duyệt
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            //Điều hướng đến trang web hoa yêu thương
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            //Chờ 2s để nạp trang
            Thread.Sleep(2000);
            try
            {
                // Tìm phần tử hiển thị vị trí hiện tại (thành phố/tỉnh đang chọn)
                IWebElement locationElement_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.CssSelector("#top-line > div > div.location > div.dropdown_content > span"));
                // mô phỏng hành vi chuột thật, di chuyển con trỏ đến phần tử trước, rồi click
                // do button yêu cầu phải hover hoặc đã được phủ lớp nào trước đó
                Actions action_52_Hao_54_Hieu = new Actions(driver_52_Hao_54_Hieu);
                // Di chuột đến phần tử hiển thị vị trí để hiển thị dropdown các lựa chọn tỉnh/thành phố
                //MoveToElement phương thức trong đối tượng Actions dùng để rê chuột (hover)
                //Perform là kết thúc chuỗi hoạt động và thực thi nó
                action_52_Hao_54_Hieu.MoveToElement(locationElement_52_Hao_54_Hieu).Perform();
                //Chờ 2s để dropdown hiển thị
                Thread.Sleep(2000);
                // Thử tìm tỉnh không tồn tại (giả định là thao tác thủ công không cho chọn)
                // Do trang web không hiển thị lựa chọn không hợp lệ, ta mô phỏng bằng việc tìm phần tử không có
                var invalidOption_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElements(By.LinkText("Tỉnh Không Tồn Tại"));
                // Kiểm tra không có phần tử nào khớp (tức là trang hoạt động đúng)
                //Dùng Count để so sánh không có phần tử phù hợp thì = 0 ==> Test PASS
                Assert.IsTrue(invalidOption_52_Hao_54_Hieu.Count == 0);
            }
            catch
            {
                //Nếu xảy ra lỗi test sẽ bị fail
                Assert.Fail();
            }
        }
    }
}
