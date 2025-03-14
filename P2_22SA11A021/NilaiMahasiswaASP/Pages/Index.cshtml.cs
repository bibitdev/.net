using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace NilaiMahasiswaASP.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? Nim { get; set; }

        [BindProperty]
        public string? Nama { get; set; }

        [BindProperty]
        public int? Nilai { get; set; }

        [BindProperty]
        public string? FileContents { get; set; }

        public void OnGet()
        {
            string path = "nilai_mahasiswa.txt";
            if (System.IO.File.Exists(path))
            {
                FileContents = System.IO.File.ReadAllText(path);
            }
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Nim) && !string.IsNullOrEmpty(Nama) && Nilai.HasValue)
            {
                string path = "nilai_mahasiswa.txt";
                string data = $"NIM: {Nim}, Nama: {Nama}, Nilai: {Nilai}";

                if (!System.IO.File.Exists(path))
                {
                    System.IO.File.WriteAllLines(path, new[] { data });
                }
                else
                {
                    System.IO.File.AppendAllText(path, data + Environment.NewLine);
                }
                FileContents = System.IO.File.ReadAllText(path);
            }
        }
    }
}