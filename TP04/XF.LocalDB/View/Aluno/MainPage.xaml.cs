using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.LocalDB.AlunoViewModel;

namespace XF.LocalDB.View.Aluno
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Aluno_ViewModel vmAluno;

        public MainPage()
        {
            vmAluno = new Aluno_ViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            vmAluno = new Aluno_ViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnAlunoTapped(object sender, ItemTappedEventArgs args)
        {
            var selecionado = args.Item as XF.LocalDB.Model.Aluno;
            DisplayAlert("Aluno Selecionado", "Aluno" + selecionado.Id, "OK");
        }
    }
}