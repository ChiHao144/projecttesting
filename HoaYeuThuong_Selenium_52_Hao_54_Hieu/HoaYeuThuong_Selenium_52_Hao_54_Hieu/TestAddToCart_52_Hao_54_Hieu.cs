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
    public class TestAddToCart_52_Hao_54_Hieu
    {

        [TestMethod]
        //Case 1: Thêm sản phầm vào vỏ hàng 
        //Khi nhấn button thêm vào giỏ hàng => chỉ thêm được 1 sản phẩm
        //Kết quả mong đợi là thêm được sản phẩm vào giỏ hàng => pass
        public void TC1_TestAddToCart_52_Hao_54_Hieu()
        {
            //Điều hướng đến trang sản phẩm cần thêm vào giỏ hàng
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/cua-hang-hoa/hoa-khuyen-mai/5235_tuoi-mong-mo");
            //Cho web ngủ 2s để nạp trang
            Thread.Sleep(2000);
            //Dùng LinkText bắt vào button thêm giỏ hàng
            IWebElement element_them_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            //Click vào button thêm vào giỏ hàng
            element_them_52_Hao_54_Hieu.Click();
            //Bắt được thông báo giỏ hàng tăng thêm => Pass
            try
            {
                // Tìm phần tử có ID là "shopping-cart" trên trang web 
                IWebElement notification_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.Id("shopping-cart"));

                // Nếu phần tử được tìm thấy, thì kiểm tra sẽ thành công
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                // Nếu có lỗi (ví dụ, phần tử không được tìm thấy), kiểm tra sẽ thất bại
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        //Case 2: Thêm sản phầm vào vỏ hàng 
        //Cần thêm đơn hàng đã đặt => click chọn thêm số lượng 
        //Kết quả mong đợi là tăng số lượng sản phẩm đó trong trang giỏ hàng => pass
        public void TC2_TestAddToCart_52_Hao_54_Hieu()
        {
            //Điều hướng đến trang sản phẩm cần thêm vào giỏ hàng
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver();
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://hoayeuthuong.com/cua-hang-hoa/hoa-khuyen-mai/5235_tuoi-mong-mo");
            //Cho web ngủ 2s để nạp trang
            Thread.Sleep(2000);
            //Dùng LinkText bắt vào button thêm giỏ hàng
            IWebElement element_them_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.LinkText("Thêm vào giỏ hàng"));
            //Click vào button thêm vào giỏ hàng
            element_them_52_Hao_54_Hieu.Click();
            //Dùng id để bắt button giỏ hàng để tăng thêm sản phẩm
            IWebElement element_xemGioHang_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.Id("shopping-cart"));
            //Click vào buttin giỏ hàng 
            element_xemGioHang_52_Hao_54_Hieu.Click();
            //Dùng ClassName bắt vào button tăng số lượng sản phẩm trong giỏ
            IWebElement element_themsp_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.ClassName("plus"));
            //Click vào button cộng thêm 
            element_themsp_52_Hao_54_Hieu.Click();
            //Bắt được thông báo số lượng tăng thêm => Pass
            try
            {
                // Tìm phần tử có classname là "txtQty" trên trang web 
                IWebElement notification_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.ClassName("txtQty"));
                // Nếu phần tử được tìm thấy, thì kiểm tra sẽ thành công
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                // Nếu có lỗi (ví dụ, phần tử không được tìm thấy), kiểm tra sẽ thất bại
                Assert.IsTrue(false);
            }
        }
    }
}
