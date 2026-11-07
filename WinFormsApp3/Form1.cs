
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _Client = new HttpClient();
        private readonly string url_base = "https://fakestoreapi.com/products";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTodos_Click(object sender, EventArgs e)
        {
            List<Productos> productos = await obtenProductos();
        }

        private async Task<List<Productos>> obtenProductos()
        {
            string json =
            await _Client
            .GetStringAsync(url_base);

            return JsonSerializer.Deserialize<List<Productos>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<Productos>();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await obtenProductoPorId(1);
        }

        private async Task<Productos> obtenProductoPorId(int id)
        {
            string json =
            await _Client
            .GetStringAsync($"{url_base}/{id}");
            return JsonSerializer.Deserialize<Productos>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? new Productos();
        }
        private async Task escribeProducto(Productos objProducto)
        {
            string json =
          JsonSerializer.Serialize(
              objProducto
          );

            StringContent contenido =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

            HttpResponseMessage respuesta =
                await _Client.PostAsync(
                    url_base,
                    contenido
                );

            string resultado =
                await respuesta.Content
                    .ReadAsStringAsync();

            MessageBox.Show(resultado);
        }   
        private async Task button2_Click(object sender, EventArgs e)
        {
            Productos nuevoProducto = new Productos
            {
                Id = 0,
                Title = "Producto Nuevo",
                Price = 10.5F,
                Description = "Descripcion producto nuevo",
                Category = "Categoria 1"
            };

            await escribeProducto(nuevoProducto);
        }
    }
}
