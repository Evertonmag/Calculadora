using NCalc2;
using System;
using Xamarin.Forms;

namespace App.Calculadora
{
    public partial class Calc : ContentPage
    {
        double pre = 0;
        double pos = 0;
        string calculo = "";
        bool parenteses = false;
        double porcentagem = 0;
        bool porcento = false;

        public Calc()
        {
            InitializeComponent();
            historico.Source = ImageSource.FromResource("App.Calculadora.Img.historico.png");
            apagar.Source = ImageSource.FromResource("App.Calculadora.Img.apagar.png");
            Conversor.Source = ImageSource.FromResource("App.Calculadora.Img.conversorUni.png");
        }

        void Calcular()
        {
            try
            {

                if (porcento == true)
                {
                    switch (calculo)
                    {
                        case "+":
                            pre = double.Parse(txt_visor.Text.Split('+')[0]);

                            pos = double.Parse(txt_visor.Text.Split('+')[1]);

                            txt_visor.Text += "%";
                            porcentagem = pre * (1 + (pos / 100));
                            txt_Resultado.Text = porcentagem.ToString();
                            porcento = false;
                            return;
                        case "-":
                            pre = double.Parse(txt_visor.Text.Split('-')[0]);

                            pos = double.Parse(txt_visor.Text.Split('-')[1]);

                            txt_visor.Text += "%";
                            porcentagem = pre * (1 - (pos / 100));
                            txt_Resultado.Text = porcentagem.ToString();
                            porcento = false;
                            return;
                        case "*":
                            pre = double.Parse(txt_visor.Text.Split('*')[0]);

                            pos = double.Parse(txt_visor.Text.Split('*')[1]);

                            txt_visor.Text += "%";
                            porcentagem = pre * (pos / 100);
                            txt_Resultado.Text = porcentagem.ToString();
                            porcento = false;
                            return;
                        case "/":
                            pre = double.Parse(txt_visor.Text.Split('/')[0]);

                            pos = double.Parse(txt_visor.Text.Split('/')[1]);

                            txt_visor.Text += "%";
                            porcentagem = pre / (pos / 100);
                            txt_Resultado.Text = porcentagem.ToString();
                            porcento = false;
                            return;
                    }
                }

                if (parenteses != true)
                {
                    if (txt_visor.Text.Contains("%"))
                    {
                        txt_visor.Text = txt_Resultado.Text;
                    }
                    Expression expressao = new Expression(txt_visor.Text);
                    var result = expressao.Evaluate();
                    if (result != null)
                        txt_Resultado.Text = result.ToString();
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
            }
        }

        //Numeros
        private void Button_Clicked_7(object sender, EventArgs e)
        {
            txt_visor.Text += "7";
            Calcular();
        }
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            txt_visor.Text += "8";
            Calcular();
        }
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            txt_visor.Text += "9";
            Calcular();
        }
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            txt_visor.Text += "4";
            Calcular();
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            txt_visor.Text += "5";
            Calcular();
        }
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            txt_visor.Text += "6";
            Calcular();
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            txt_visor.Text += "1";
            Calcular();
        }
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            txt_visor.Text += "2";
            Calcular();
        }
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            txt_visor.Text += "3";
            Calcular();
        }
        private void Button_Clicked_0(object sender, EventArgs e)
        {
            txt_visor.Text += "0";
            Calcular();
        }

        //Operações
        private void Button_Clicked_Limpar(object sender, EventArgs e)
        {
            try
            {
                txt_visor.Text = "";
                calculo = "";
                txt_Resultado.Text = "";
                parenteses = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Somar(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    if (txt_visor.Text.Contains("%"))
                    {
                        txt_visor.Text = txt_Resultado.Text;
                    }
                    txt_visor.Text += "+";
                    calculo = "+";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Subtrair(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    if (txt_visor.Text.Contains("%"))
                    {
                        txt_visor.Text = txt_Resultado.Text;
                    }
                    txt_visor.Text += "-";
                    calculo = "-";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                 $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Multiplicar(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    if (txt_visor.Text.Contains("%"))
                    {
                        txt_visor.Text = txt_Resultado.Text;
                    }
                    txt_visor.Text += "*";
                    calculo = "*";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Dividir(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    if (txt_visor.Text.Contains("%"))
                    {
                        txt_visor.Text = txt_Resultado.Text;
                    }
                    txt_visor.Text += "/";
                    calculo = "/";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Igual(object sender, EventArgs e)
        {
            txt_visor.Text = txt_Resultado.Text;
            txt_Resultado.Text = "";
        }
        private void Button_Clicked_Inversor(object sender, EventArgs e)
        {
            try
            {
                //txt_visor.Text += "(-";
                if (txt_Resultado.Text != null)
                {
                    double inv = double.Parse(txt_Resultado.Text);
                    inv *= -1;
                    txt_Resultado.Text = inv.ToString();
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }

        }
        private void Button_Clicked_Porcento(object sender, EventArgs e)
        {
            porcento = true;
            Calcular();
        }
        private void Button_Clicked_Ponto(object sender, EventArgs e)
        {
            try
            {
                if (!txt_visor.Text.Contains("."))
                {
                    if (calculo != null)
                        txt_visor.Text += ".";
                }
                else
                {
                    if (calculo != null)
                        txt_visor.Text += ".";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }

        private void Button_Clicked_Parenteses(object sender, EventArgs e)
        {
            try
            {
                switch (parenteses)
                {
                    case false:
                        txt_visor.Text += "(";
                        parenteses = true;
                        break;
                    case true:
                        txt_visor.Text += ")";
                        parenteses = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                               $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }

        private void apagar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //testar se o valor ha valor na label
                if (txt_visor.Text != "")
                {
                    txt_visor.Text = txt_visor.Text.Remove(txt_visor.Text.Length - 1);
                    //testar se tem valor apos o calculo
                    if (txt_visor.Text.Contains("+") || txt_visor.Text.Contains("-") ||
                        txt_visor.Text.Contains("*") || txt_visor.Text.Contains("/"))
                    {
                        string teste = txt_visor.Text.Split('+')[1];
                        if (teste.Length < 1)
                        {
                            //pre = double.Parse(txt_Resultado.Text);
                            //double teste1 = double.Parse(txt_visor.Text.Split('+')[1]);
                            //switch (calculo)
                            //{
                            //    case "+":
                            //        pre -= teste1;
                            //        break;
                            //    case "-":
                            //        pre += teste1;
                            //        break;
                            //    case "*":
                            //        pre /= teste1;
                            //        break;
                            //    case "/":
                            //        pre *= teste1;
                            //        break;
                            //}
                        }
                        else
                            Calcular();
                    }

                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
    }
}
