using MauiListaCompras.Models;

namespace MauiListaCompras.View;

public partial class NovoProduto2 : ContentPage
{
	public NovoProduto2()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text),
            };

            await App.Db.Insert(p);
            await DisplayAlert("Sucesso!", "Produto inserido", "OK");
            await Navigation.PushAsync(new MainPage());

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}