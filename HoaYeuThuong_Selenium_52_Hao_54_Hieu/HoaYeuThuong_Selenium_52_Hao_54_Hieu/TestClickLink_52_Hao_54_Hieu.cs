using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;

namespace HoaYeuThuong_Selenium_52_Hao_54_Hieu
{
    [TestClass]
    public class TestClickLink_52_Hao_54_Hieu
    {
        [TestMethod]
        //Case 5: ClickLink facebook 
        //Kết quả là bắt được tên miền chứa facebook => pass
        public void TC5_TestClickLink_Facebook_52_Hao_54_Hieu()
        {
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            // Điều hướng đến trang web Hoa Yêu Thương
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            // Tạm dừng chương trình trong 2 giây để trang web có thời gian load
            Thread.Sleep(2000);
            // Tìm phần tử liên kết Facebook ở footer bằng XPath
            IWebElement element_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.XPath("//*[@id=\"footer\"]/div[3]/div[2]/div/a[1]"));
            // Click vào liên kết Facebook
            element_52_Hao_54_Hieu.Click();
            // Lấy danh sách các tab hiện đang mở và lưu vào biến `tabs`
            //ToList là chuyển danh sách trả về thành dạng list để dễ thao tác
            var tabs_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.WindowHandles.ToList();
            // Chuyển trình điều khiển selenium sang tab mới vừa được mở (tab thứ 2)
            //tabs[0]: trang chủ Hoa Yêu Thương
            //tabs[1]: tab mới Facebook
            driver_52_Hao_54_Hieu.SwitchTo().Window(tabs_52_Hao_54_Hieu[1]);
            // Kiểm tra xem URL của tab mới có chứa "facebook" không
            if (driver_52_Hao_54_Hieu.Url.Contains("facebook"))
            {
                // Nếu có chứa "facebook" thì assert thành công
                Assert.IsTrue(true);
            }
            else
            {
                // Nếu không chứa thì assert thất bại
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        //Case 6: ClickLink youtube
        //Kết quả là bắt được tên miền chứa youtube => pass
        public void TC6_TestClickLink_Youtube_52_Hao_54_Hieu()
        {
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            // Điều hướng đến trang web Hoa Yêu Thương
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            // Tạm dừng chương trình trong 2 giây để trang web có thời gian load
            Thread.Sleep(2000);
            // Tìm phần tử liên kết Youtube ở footer bằng XPath
            IWebElement element_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.XPath("//*[@id=\"footer\"]/div[3]/div[2]/div/a[3]"));
            // Click vào liên kết Youtube
            element_52_Hao_54_Hieu.Click();
            // Lấy danh sách các tab hiện đang mở và lưu vào biến `tabs`
            //ToList là chuyển danh sách trả về thành dạng list để dễ thao tác
            var tabs_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.WindowHandles.ToList();
            // Chuyển trình điều khiển selenium sang tab mới vừa được mở (tab thứ 2)
            //tabs[0]: trang chủ Hoa Yêu Thương
            //tabs[1]: tab mới Youtube
            driver_52_Hao_54_Hieu.SwitchTo().Window(tabs_52_Hao_54_Hieu[1]);
            // Kiểm tra xem URL của tab mới có chứa "youtube" không
            if (driver_52_Hao_54_Hieu.Url.Contains("youtube"))
            {
                // Nếu có chứa "youtube" thì assert thành công
                Assert.IsTrue(true);
            }
            else
            {
                // Nếu không chứa thì assert thất bại
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        //Case 7: Click vào button chuyển ngôn ngữ
        //Kết quả mong đợi là chuyển từ tiếng việt sang tiếng anh hoặc ngược lại => pass
        public void TC7_TestLanguageToggle_52_Hao_54_Hieu()
        {
            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            // Điều hướng đến trang chủ hoayeuthuong.com
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/");
            // Chờ 2 giây để trang web load xong
            Thread.Sleep(2000);
            try
            {
                // Tìm phần tử chuyển đổi ngôn ngữ (icon góc trên cùng bên phải)
                IWebElement languageToggle_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.CssSelector("#top-line > div > div.language"));
                // Lấy URL hiện tại để kiểm tra ngôn ngữ hiện tại (mặc định tiếng Việt không có đuôi /en)
                string currentUrl_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.Url;
                // Nếu URL chứa "/en", nghĩa là đang ở giao diện tiếng Anh
                if (currentUrl_52_Hao_54_Hieu.Contains("/en"))
                {
                    // Click để chuyển từ tiếng Anh sang tiếng Việt
                    languageToggle_52_Hao_54_Hieu.Click();
                    // Đợi load lại trang
                    Thread.Sleep(2000);
                    // Kiểm tra URL không còn chứa "/en" nữa => pass
                    Assert.IsFalse(driver_52_Hao_54_Hieu.Url.Contains("/en"));
                }
                else
                {
                    // Click để chuyển từ tiếng Việt sang tiếng Anh
                    languageToggle_52_Hao_54_Hieu.Click();
                    // Đợi load lại trang
                    Thread.Sleep(2000);
                    // Kiểm tra URL đã chứa "/en" => pass
                    Assert.IsTrue(driver_52_Hao_54_Hieu.Url.Contains("/en"));
                }
            }
            catch
            {
                // Nếu xảy ra lỗi ở bất kỳ bước nào thì test sẽ fail
                Assert.Fail();
            }
        }
    }
}
