using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFinanceiro.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonView : ContentView
    {
        public static readonly BindableProperty ClickProperty = BindableProperty.Create(nameof(Click), typeof(ICommand), typeof(ButtonView), null);
        public static readonly BindableProperty TextoProperty = BindableProperty.Create(nameof(Texto), typeof(string), typeof(ButtonView), null);
        public static readonly BindableProperty FontAwesomeProperty = BindableProperty.Create(nameof(FontAwesome), typeof(string), typeof(ButtonView), null);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize), typeof(double), typeof(ButtonView), null);
        public ICommand Click
        {
            get { return (ICommand)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }
        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }
        public string FontAwesome
        {
            get { return (string)GetValue(FontAwesomeProperty); }
            set { SetValue(FontAwesomeProperty, value); }
        }
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == nameof(Texto))
            {
                LabelText.IsVisible = true;
                LabelText.Text = Texto;
                LabelAwesome.IsVisible = false;
            }
            if(propertyName == nameof(FontAwesome))
            {
                LabelAwesome.IsVisible = true;
                LabelAwesome.Text = FontAwesome;
                LabelText.IsVisible = false;
            }
            if(propertyName == nameof(FontSize))
            {
                LabelText.FontSize = FontSize;
                LabelAwesome.FontSize = FontSize;
            }
        }


        public ButtonView()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if(Click?.CanExecute(null) ?? false)
            {
                Click.Execute(null);
            }
        }
    }
}