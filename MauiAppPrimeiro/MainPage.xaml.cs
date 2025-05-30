namespace MauiAppPrimeiro
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_Etanol.Text);
                double gasolina = Convert.ToDouble(txt_Gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {

                    msg = "O etanol esá compenansando.";
                } else
                {
                    msg = "A gasolina está compensando.";
                }

                DisplayAlert("Calculado", msg, "OK");

            } catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "fechar");
            }

        } //FECHA MÉTODO
    } //FECHA CLASS
} //FECHA NAMESPACE
