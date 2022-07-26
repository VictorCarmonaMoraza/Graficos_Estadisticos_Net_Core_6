using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace GraficosNetCore.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string graficoInicial()
        {
            //Es necesario para graficos utiluzar un BitmAp
            Bitmap oBitmap = new Bitmap(800,400);
            //Lo usamos para guardar el grafico
            using(MemoryStream ms = new MemoryStream())
            {
                oBitmap.Save(ms, ImageFormat.Png);
                //Obtenemos su array de byte
                byte[] data = ms.ToArray();
                //Lo convertimos a base64 
                return Convert.ToBase64String(data);
            }

        }
    }
}
