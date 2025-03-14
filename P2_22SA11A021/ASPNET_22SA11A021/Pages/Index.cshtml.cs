using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;

namespace ASPNET_22SA11A021.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string? FilePath { get; set; }

        [BindProperty]
        public IFormFile? UploadedFile { get; set; }

        [BindProperty]
        public string? FileContents { get; set; }

        [BindProperty]
        public string? Message { get; set; }

        public void OnPostCreate()
        {
            if (!string.IsNullOrEmpty(FilePath)) // Pastikan FilePath tidak null atau kosong
            {
                if (!System.IO.File.Exists(FilePath))
                {
                    string[] buatText = { "Hello", "Selamat Datang di Praktikum Sister", "ok" };
                    System.IO.File.WriteAllLines(FilePath, buatText);

                    string appendText = "Ini adalah text" + Environment.NewLine;
                    System.IO.File.AppendAllText(FilePath, appendText);

                    Message = "File Berhasil Dibuat!";
                }
                else
                {
                    Message = "File sudah ada!";
                }
            }
            else
            {
                Message = "Path file tidak boleh kosong!";
            }
        }

        public void OnPostRead()
        {
            if (UploadedFile != null)
            {
                using (var reader = new StreamReader(UploadedFile.OpenReadStream()))
                {
                    FileContents = reader.ReadToEnd();
                }
            }
            else
            {
                FileContents = "Silahkan pilih/unggah file terlebih dahulu!";
            }
        }
    }
}