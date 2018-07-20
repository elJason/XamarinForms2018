﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.SqlServer.Model;
using Pedidos.SqlServer.Service;

namespace Pedidos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{

        //0 adm 1 promotor
        public static int IdLogado { get; set; }
        private Pessoa usuario { get; set; }

		public Master (Pessoa usuarioLogado)
		{
			InitializeComponent ();
            Detail = new NavigationPage(new Home()) { BarBackgroundColor=Color.Black };
            usuario = usuarioLogado;
            IdLogado = usuarioLogado.idPessoa;

            Nome.Text = usuarioLogado.nome;

            if (usuario.rg.ToString().Contains("1"))
            {
                Tipo.Text = "- Promotor";
                SlAdm.IsVisible = false;
            }
            else
            {
                Tipo.Text = "- Administrador";
            }
        }

        //LISTA PESSOAS
        private void GoListaPessoas(object sender, EventArgs args)
        {
            if (VerificarConexao.TemInternet())
            {
                Detail = new NavigationPage(new SqlServer.View.ListaPessoas()) { BarBackgroundColor = Color.Black };
                IsPresented = false;
            }
            else
            {
                SemConexao();
            }
        }

        //LISTA MARCAS
        private void GoListaMarcas(object sender, EventArgs args)
        {
            if (VerificarConexao.TemInternet())
            {
                Detail = new NavigationPage(new SqlServer.View.ListaMarcas(1)) { BarBackgroundColor = Color.Black };
                IsPresented = false;
            }
            else
            {
                SemConexao();
            }
        }

        //LISTA PRODUTOS
        private void GoListaProdutos(object sender, EventArgs args)
        {
            if (VerificarConexao.TemInternet())
            {
                Detail = new NavigationPage(new SqlServer.View.ListaMarcas(2)) { BarBackgroundColor = Color.Black };
                IsPresented = false;
            }
            else
            {
                SemConexao();
            }
        }

        //LISTA PEDIDOS
        private void GoListaPedidos(object sender, EventArgs args)
        {
            if (VerificarConexao.TemInternet())
            {
                Detail = new NavigationPage(new SqlServer.View.ListaPedidos()) { BarBackgroundColor = Color.Black };
                IsPresented = false;
            }
            else
            {
                SemConexao();
            }
        }

        //NOVO PEDIDO
        private void GoNovoPedido(object sender, EventArgs args)
        {
            if (VerificarConexao.TemInternet())
            {
                Detail = new NavigationPage(new SqlServer.View.ListaMarcas(3)) { BarBackgroundColor = Color.Black };
                IsPresented = false;
            }
            else
            {
                SemConexao();
            }
        }

        //VER PERFIL
        private void GoPerfil(object sender, EventArgs args)
        {
            if (VerificarConexao.TemInternet())
            {
                Detail = new NavigationPage(new SqlServer.View.DetalhePessoa(usuario)) { BarBackgroundColor = Color.Black };
                IsPresented = false;
            }
            else
            {
                SemConexao();
            }
        }

        private void Sair(object sender, EventArgs args)
        {
            App.Current.MainPage = new LoginPage();
        }

        private void SemConexao()
        {
            DisplayAlert("Error", "Não há conexão com a Internet", "Ok");
        }
    }
}