using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grafico.Visible = false;
        }

        protected void Mostrar_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = lista.Items[lista.SelectedIndex];
            if (elemento.Value == "Microonda")
            {
                Resultado.Style["color"] = "Purple";
                Resultado.InnerText = "Codigo: " + "456268778 " + 
                    "Nombre: " + "Microonda " + 
                    "Descripcion: " + "Aparato de ondas electromagnéticas que permite cocinar y calentar alimentos en pocos minutos. " + 
                    "Marca: " + "Samsung " + 
                    "Precio: " + "S/.769.90 ";
            }
            if (elemento.Value == "Refrigerador")
            {
                Resultado.Style["color"] = "Purple";
                Resultado.InnerText = "Codigo: " + "851647489 " + 
                    "Nombre: " + "Refrigerador " + 
                    "Descripcion: " + "Es un dispositivo de cocina para conservar la comida. " + 
                    "Marca: " + "LG " + 
                    "Precio: " + "S/.2800.99 ";

            }
            if (elemento.Value == "Tostadora")
            {
                Resultado.Style["color"] = "Purple";
                Resultado.InnerText = "Codigo: " + "458963255 " + 
                    "Nombre: " + "Tostadora " + 
                    "Descripcion: " + "Es un pequeño aparato que sirve para tostar rebanadas de pan. " +  
                    "Marca: " + "Holstein " + 
                    "Precio: " + "S/.330.90 ";

            }
            if (elemento.Value == "Campana extractora")
            {
                Resultado.Style["color"] = "Purple";
                Resultado.InnerText = "Codigo: " + "325784966 " + 
                    "Nombre: " + "Campana extractora " + 
                    "Descripcion: " + "Aparato de cocina que permite eliminar los malos olores, la grasa y la humedad. " + 
                    "Marca: " + "Sole " + 
                    "Precio: " + "S/.560.00 ";

            }
            if (elemento.Value == "Aspiradora")
            {
                Resultado.Style["color"] = "Purple";
                Resultado.InnerText = "Codigo: " + "558931497 " + 
                    "Nombre: " + "Aspiradora " + 
                    "Descripcion: " + "Es un dispositivo que utiliza una bomba de aire para aspirar el polvo y otras partículas pequeñas de suciedad y que permite dejar así los pisos y alfombras impecables. " + 
                    "Marca: " + "Electrolux " + 
                    "Precio: " + "S/.249.00 ";

            }
        }

        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = "figura" + lista.SelectedIndex.ToString() + ".jpg";
            Grafico.Alt = "Grafico Electrodomestico";
            Grafico.Visible = true;
        }


    }
}