using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2_Lucero
{


    public partial class MainPage : ContentPage
    {
     
        public MainPage(string usuario, string contrasena)
        {
            InitializeComponent();
            //Envio a los laber
            lblUsuario.Text = usuario;
            lblContrasena.Text = contrasena;

            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;

            
        }

        private void btnNotaFinal_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Ingresan las notas del parcial 1
                double parcialUno = Convert.ToDouble(txtParcialUno.Text);
                double examenUno = Convert.ToDouble(txtExamenUno.Text);

                //Ingresan las notas del parcial 2
                double parcialDos = Convert.ToDouble(txtParcialDos.Text);
                double examenDos = Convert.ToDouble(txtExamenDos.Text);

                //Operacion 1

                double nota1 = parcialUno * 0.3;
                double examen1 = examenUno * 0.2;
                double parcial1 = nota1 + examen1;

                //Convertir a string para visualizar en un Entry
                txtResultado.Text = Convert.ToString(parcial1);

                //Operacion 2
                double nota2 = parcialDos * 0.3;
                double examen2 = examenDos * 0.2;
                double parcial2 = nota2 + examen2;

                //Convertir a string para visualizar en un Entry
                txtResultadoDos.Text = Convert.ToString(parcial2);

                //Operacion 3

                double notafinal = parcial1 + parcial2;

                //Convertir a string para visualizar en un Entry
                txtResultadofinal.Text = Convert.ToString(notafinal);
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de advertencia", ex.Message, "Ok");
            }

        }

        private void txtParcialUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double parcialUno = Convert.ToDouble(txtParcialUno.Text);

                if (parcialUno > 10)
                {                  
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");                 
                }
                if (parcialUno < 0)
                {
                   DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtExamenUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double examenUno = Convert.ToDouble(txtExamenUno.Text);

                if (examenUno > 10)
                {
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }
                if (examenUno < 0)
                {
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtParcialDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double parcialDos = Convert.ToDouble(txtParcialDos.Text);

                if (parcialDos > 10)
                {
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }
                if (parcialDos < 0)
                {
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }


            }
            catch (Exception ex)
            {

            }
        }

        private void txtExamenDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double examenDos = Convert.ToDouble(txtExamenDos.Text);

                if (examenDos > 10)
                {
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }
                if (examenDos < 0)
                {
                    DisplayAlert("Alerta", "Valido del 0 al 10", "ok");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtResultadofinal_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double resultadoFinal = Convert.ToDouble(txtResultadofinal.Text);
                if (resultadoFinal >=7)
                {
                    DisplayAlert("Resultado", "Aprobado", "ok");
                }
                if (resultadoFinal >=5 && resultadoFinal <6.9)
                {
                    DisplayAlert("Resultado", "Complementario", "ok");
                }
                if (resultadoFinal < 5)
                {
                    DisplayAlert("Resultado", "Reprobado", "ok");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
