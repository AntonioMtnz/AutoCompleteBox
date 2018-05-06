using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace AutoCompletar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CargarAutoComplete();
        }

        //Método para cargar la lista de autocompletado. 
        private void CargarAutoComplete()
        {
            AutoCompleteBox aList = new AutoCompleteBox();
            aList.FontSize = 16;
            aList.FontFamily = new FontFamily("Segoe UI");
            //u.IsTextCompletionEnabled = true;
            aList.FilterMode = AutoCompleteFilterMode.Contains;
           
            List<string> cityList = new List<string>(){ "Guadalajara",
                                                "Guanajuato",
                                                "Guaymas",
                                                "Puebla",
                                                "Morelia",
                                                "Monterrey",
                                                "Querétaro",
                                                "Mérida",
                                                "CDMX",
                                                "Xalapa",
                                                "Zacatecas" };

            aList.MinimumPopulateDelay = 100;
            aList.MinimumPrefixLength = 1;
            aList.ItemsSource = cityList;

            eHTxtCiudad.Child = aList;
        }
    }
}
