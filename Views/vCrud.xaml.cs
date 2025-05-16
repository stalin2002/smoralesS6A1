using System.Collections.ObjectModel;
using Newtonsoft.Json;
using smoralesS6A1.Models;

namespace smoralesS6A1.Views;

public partial class vCrud : ContentPage
{
	private const string URL = "http://localhost:8081/views";
	private HttpClient client = new HttpClient();
	private ObservableCollection<Usuario> usuarioTem;
	public vCrud()
	{
		InitializeComponent();
		mostrarUsuarios();
	}

	public async void mostrarUsuarios()
	{
		var content = await client.GetStringAsync(URL);
		List<Usuario>lista = JsonConvert.DeserializeObject<List<Usuario>>(content);
		usuarioTem = new ObservableCollection<Usuario>(lista);
		lvUsuarios.ItemsSource = usuarioTem;
	}
}