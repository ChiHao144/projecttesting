using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;


namespace DoAn_KTPM_52_Hao_54_Hieu
{
    public partial class Form1 : Form
    {
        //Hàm khởi tạo Form 1
        public Form1()
        {
            //Khởi tạo các thành phần giao diện
            InitializeComponent();
        }

        //Sự kiện khi nhấn nút "Tính diện tích"
        private void btn_TinhDT_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy dữ liệu từ textbox và chuyển sang kiểu số nguyên
                int dai_52_Hao_54_Hieu = int.Parse(txt_ChieuDai_52_Hao_54_Hieu.Text);
                int rong_52_Hao_54_Hieu = int.Parse(txt_ChieuRong_52_Hao_54_Hieu.Text);
                //Gọi phương thức TinhDienTichHCN_52_Hao_54_Hieu từ class TinhDienTich_52_Hao_54_Hieu 
                int dientich_52_Hao_54_Hieu = TinhDienTich_52_Hao_54_Hieu.TinhDienTichHCN_52_Hao_54_Hieu(dai_52_Hao_54_Hieu, rong_52_Hao_54_Hieu);
                //Hiển thị kết quả trong textbox txt_KetQua_52_Hao_54_Hieu
                txt_KetQua_52_Hao_54_Hieu.Text = dientich_52_Hao_54_Hieu.ToString();
            }
            catch (FormatException)
            {
                //Hiển thị thông báo lỗi nếu nhập sai định dạng
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                //Hiển thị thông báo lỗi nếu nhập số âm
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_UpLoadFile_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Ẩn màn hình terminal của ChromeDriver
            ChromeDriverService chrome_52_Hao_54_Hieu = ChromeDriverService.CreateDefaultService();
            chrome_52_Hao_54_Hieu.HideCommandPromptWindow = true;

            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver(chrome_52_Hao_54_Hieu);
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://demos.telerik.com/aspnet-ajax/asyncupload/examples/draganddrop/defaultcs.aspx");
            driver_52_Hao_54_Hieu.Manage().Window.Maximize();

            // Chờ trang tải xong
            Thread.Sleep(3000);

            // Đường dẫn tới file muốn tải lên (Cần thay bằng file có sẵn trong máy)
            string filePath_52_Hao_54_Hieu = @"C:\Users\PHAM CHI HAO\Pictures\python.png";

            // Gửi file trực tiếp vào input hidden của Telerik Upload
            IWebElement fileInput_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.XPath("//input[@type='file']"));
            fileInput_52_Hao_54_Hieu.SendKeys(filePath_52_Hao_54_Hieu);

            // Chờ upload hoàn tất
            Thread.Sleep(5000);

            driver_52_Hao_54_Hieu.Quit();
        }

        private void btn_Drag_Drop_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Ẩn màn hình terminal của ChromeDriver
            ChromeDriverService chrome_52_Hao_54_Hieu = ChromeDriverService.CreateDefaultService();
            chrome_52_Hao_54_Hieu.HideCommandPromptWindow = true;


            // Khởi tạo trình duyệt
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver(chrome_52_Hao_54_Hieu);
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            driver_52_Hao_54_Hieu.Manage().Window.Maximize();

            // Chờ trang tải xong
            Thread.Sleep(2000);

            // Chuyển vào iframe chứa Drag & Drop
            driver_52_Hao_54_Hieu.SwitchTo().Frame(driver_52_Hao_54_Hieu.FindElement(By.ClassName("demo-frame")));

            // Tìm phần tử kéo và thả
            // Hộp kéo
            IWebElement sourceElement = driver_52_Hao_54_Hieu.FindElement(By.Id("draggable"));
            // Khu vực thả
            IWebElement targetElement = driver_52_Hao_54_Hieu.FindElement(By.Id("droppable")); 

            // Thực hiện kéo và thả
            Actions actions_52_Hao_54_Hieu = new Actions(driver_52_Hao_54_Hieu);
            actions_52_Hao_54_Hieu.DragAndDrop(sourceElement, targetElement).Perform();

            // Chờ 3s để kiểm tra kết quả
            Thread.Sleep(3000);

            driver_52_Hao_54_Hieu.Quit();
        }

        private void btn_KetHop_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Ẩn màn hình terminal của ChromeDriver
            ChromeDriverService chrome_52_Hao_54_Hieu = ChromeDriverService.CreateDefaultService();
            chrome_52_Hao_54_Hieu.HideCommandPromptWindow = true;


            // Khởi tạo trình duyệt
            IWebDriver driver_52_Hao_54_Hieu = new ChromeDriver(chrome_52_Hao_54_Hieu);
            driver_52_Hao_54_Hieu.Manage().Window.Maximize();

            // 1. MỞ TRANG WINDOW HANDLING DEMO
            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            Thread.Sleep(2000);

            // Lưu ID cửa sổ gốc
            string originalWindow_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.CurrentWindowHandle;

            // Nhấp vào liên kết mở tab mới
            IWebElement newWindowLink_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.LinkText("Click Here"));
            newWindowLink_52_Hao_54_Hieu.Click();
            Thread.Sleep(2000);

            // 2. CHUYỂN SANG TAB MỚI - THỰC HIỆN DRAG & DROP
            foreach (string window in driver_52_Hao_54_Hieu.WindowHandles)
            {
                if (window != originalWindow_52_Hao_54_Hieu)
                {
                    driver_52_Hao_54_Hieu.SwitchTo().Window(window);
                    break;
                }
            }

            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            Thread.Sleep(2000);

            // Chuyển vào iframe chứa Drag & Drop
            driver_52_Hao_54_Hieu.SwitchTo().Frame(driver_52_Hao_54_Hieu.FindElement(By.ClassName("demo-frame")));

            // Tìm phần tử kéo và thả
            IWebElement sourceElement_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.Id("draggable"));
            IWebElement targetElement_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.Id("droppable"));

            // Thực hiện kéo và thả
            Actions actions_52_Hao_54_Hieu = new Actions(driver_52_Hao_54_Hieu);
            actions_52_Hao_54_Hieu.DragAndDrop(sourceElement_52_Hao_54_Hieu, targetElement_52_Hao_54_Hieu).Perform();
            Thread.Sleep(2000);

            

            // 3. MỞ TAB MỚI - THỰC HIỆN UPLOAD FILE
            ((IJavaScriptExecutor)driver_52_Hao_54_Hieu).ExecuteScript("window.open();");
            Thread.Sleep(2000);

            List<string> tabs = new List<string>(driver_52_Hao_54_Hieu.WindowHandles);
            // Chuyển sang tab thứ 3
            driver_52_Hao_54_Hieu.SwitchTo().Window(tabs[2]);

            driver_52_Hao_54_Hieu.Navigate().GoToUrl("https://demos.telerik.com/aspnet-ajax/asyncupload/examples/draganddrop/defaultcs.aspx");
            Thread.Sleep(3000);

            // Đường dẫn file cần tải lên (thay đường dẫn thực tế)
            string filePath_52_Hao_54_Hieu = @"C:\Users\PHAM CHI HAO\Pictures\python.png";

            // Tìm input file và tải lên
            IWebElement fileInput_52_Hao_54_Hieu = driver_52_Hao_54_Hieu.FindElement(By.XPath("//input[@type='file']"));
            fileInput_52_Hao_54_Hieu.SendKeys(filePath_52_Hao_54_Hieu);
            Thread.Sleep(5000);


            // Đóng trình duyệt
            driver_52_Hao_54_Hieu.Quit();
        }

        private void btn_DatHang_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Ẩn màn hình terminal của ChromeDriver
            ChromeDriverService chrome_52_Hao_54_Hieu = ChromeDriverService.CreateDefaultService();
            chrome_52_Hao_54_Hieu.HideCommandPromptWindow = true;


            // 1️⃣ Khởi tạo trình duyệt
            IWebDriver driver = new ChromeDriver(chrome_52_Hao_54_Hieu);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(2000);

            // 2️⃣ Đăng nhập vào SauceDemo
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);

            // 3️⃣ Thêm sản phẩm vào giỏ hàng
            driver.FindElement(By.XPath("//button[text()='Add to cart']")).Click();
            Thread.Sleep(1000);

            // 4️⃣ Mở giỏ hàng
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(2000);

          

            // 5️⃣ Bắt đầu thanh toán (Checkout)
            driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(2000);

            // 6️⃣ Nhập thông tin thanh toán
            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("Doe");
            driver.FindElement(By.Id("postal-code")).SendKeys("12345");
            driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(2000);

            // 7️⃣ Xác nhận và hoàn tất đặt hàng
            driver.FindElement(By.Id("finish")).Click();
            Thread.Sleep(2000);

            driver.Quit();
        }

        private void btn_TimKiem_52_Hao_54_Hieu_Click(object sender, EventArgs e)
        {
            // Ẩn màn hình terminal của ChromeDriver
            ChromeDriverService chrome_52_Hao_54_Hieu = ChromeDriverService.CreateDefaultService();
            chrome_52_Hao_54_Hieu.HideCommandPromptWindow = true;
            //Điều hướng đến trang web
            IWebDriver driver = new ChromeDriver(chrome_52_Hao_54_Hieu);
            driver.Navigate().GoToUrl("https://hoayeuthuong.com/");
            Thread.Sleep(2000);
            //Dùng thành phần của HTML 
            IWebElement element_52_Hao_54_Hieu = driver.FindElement(By.Id("txtSearch"));
            element_52_Hao_54_Hieu.SendKeys("hoa hồng");
            driver.FindElement(By.LinkText("Tìm kiếm")).Click();
        }
    }
}
