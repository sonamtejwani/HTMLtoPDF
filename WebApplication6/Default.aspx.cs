using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using PuppeteerSharp;
using System.Threading.Tasks;
using PuppeteerSharp.Media;
using IronPdf;

namespace WebApplication6
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void btnPupet_Click(object sender, EventArgs e)
        {
            var fileName = Server.MapPath("~/PDF/table.pdf");
            var output = "" + fileName;
            ViewPortOptions vp = new ViewPortOptions();
            vp.Width = 1700;
            vp.Height = 4100;
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var margin = new MarginOptions();
            margin.Top = "10";
            var pdfOptions = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page = await browser.NewPageAsync().ConfigureAwait(false);
            await page.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/table.html").ConfigureAwait(false);
            await page.WaitForTimeoutAsync(2000);
            await page.PdfAsync(output, pdfOptions).ConfigureAwait(false);




            var fileName2 = Server.MapPath("~/PDF/table-datatable.pdf");
            var output2 = "" + fileName2;
            var browser2 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
           
            var pdfOptions2 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page2 = await browser.NewPageAsync().ConfigureAwait(false);
            await page2.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/table-datatable.html").ConfigureAwait(false);
            await page2.WaitForTimeoutAsync(2000);
            await page2.PdfAsync(output2, pdfOptions).ConfigureAwait(false);




            var fileName3 = Server.MapPath("~/PDF/ui-chart-apexcharts.pdf");
            var output3 = "" + fileName3;
            var browser3 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var pdfOptions3 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter=true,
                MarginOptions=margin
            };
            var page3 = await browser.NewPageAsync().ConfigureAwait(false);
            await page3.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/ui-chart-apexcharts.html").ConfigureAwait(false);
            //await page3.WaitForFunctionAsync("windows.innerWidth<1600");
            await page3.WaitForTimeoutAsync(2000);
            await page3.PdfAsync(output3, pdfOptions).ConfigureAwait(false);



            var fileName4 = Server.MapPath("~/PDF/component-card.pdf");
            var output4 = "" + fileName4;
            var browser4 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var pdfOptions4 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page4 = await browser.NewPageAsync().ConfigureAwait(false);
            await page4.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/component-card.html").ConfigureAwait(false);
            await page4.WaitForTimeoutAsync(2000);
            await page4.PdfAsync(output4, pdfOptions).ConfigureAwait(false);




            var fileName5 = Server.MapPath("~/PDF/component-pagination.pdf");
            var output5 = "" + fileName5;
            var browser5 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var pdfOptions5 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page5 = await browser.NewPageAsync().ConfigureAwait(false);
            await page5.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/component-pagination.html").ConfigureAwait(false);
            await page5.WaitForTimeoutAsync(2000);
            await page5.PdfAsync(output5, pdfOptions).ConfigureAwait(false);



            var fileName6 = Server.MapPath("~/PDF/component-progress.pdf");
            var output6 = "" + fileName6;
            var browser6 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var pdfOptions6 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page6 = await browser.NewPageAsync().ConfigureAwait(false);
            await page6.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/component-progress.html").ConfigureAwait(false);
            await page6.WaitForTimeoutAsync(2000);
            await page6.PdfAsync(output6, pdfOptions).ConfigureAwait(false);



            var fileName7 = Server.MapPath("~/PDF/form-element-checkbox.pdf");
            var output7 = "" + fileName7;
            var browser7 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var pdfOptions7 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page7 = await browser.NewPageAsync().ConfigureAwait(false);
            await page7.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/form-element-checkbox.html").ConfigureAwait(false);
            await page7.WaitForTimeoutAsync(2000);
            await page7.PdfAsync(output7, pdfOptions).ConfigureAwait(false);




            var fileName8 = Server.MapPath("~/PDF/ui-widgets-pricing.pdf");
            var output8 = "" + fileName8;
            var browser8 = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
                DefaultViewport = vp
            }).ConfigureAwait(false);
            var pdfOptions8 = new PdfOptions
            {
                Format = PaperFormat.A2,
                Landscape = true,
                PrintBackground = true,
                DisplayHeaderFooter = true,
                MarginOptions = margin
            };
            var page8 = await browser.NewPageAsync().ConfigureAwait(false);
            await page8.GoToAsync("C:/Users/sonam/source/repos/WebApplication6/mazer-main/dist/ui-widgets-pricing.html").ConfigureAwait(false);
            await page8.WaitForTimeoutAsync(2000);
            await page8.PdfAsync(output8, pdfOptions).ConfigureAwait(false);



            var pdfs = new List<PdfDocument>();
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/table.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/table-datatable.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/ui-chart-apexcharts.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/component-card.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/component-pagination.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/component-progress.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/form-element-checkbox.pdf"));
            pdfs.Add(PdfDocument.FromFile("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/ui-widgets-pricing.pdf"));

            PdfDocument pdf = PdfDocument.Merge(pdfs);
            pdf.SaveAs("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/merged.pdf");
            System.Diagnostics.Process.Start("C:/Users/sonam/source/repos/WebApplication6/WebApplication6/PDF/merged.pdf");
        }
    }
}