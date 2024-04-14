using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Evaluacion_I_Comp_Escritorio_CJL
{
    /// <summary>
    /// Lógica de interacción para AgregarEquipo.xaml
    /// </summary>
    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            // obtención de valores de los campos que se indican en pantalla
            string nombreEquipo = txtNombreEquipo.Text;
            int cantJugadores = Convert.ToInt32(txtCantJugadores.Text);
            string nombreDT = txtDT.Text;
            string tipoEquipo = txtTipoEquipo.Text;
            string capEquipo = txtCapEquipo.Text;
            bool sub21 = (checkSub21.IsChecked.Value) ? true : false;

            // Se instancia clase equipo y se construye objeto con constructor con parametros tomando las 
            // variables que se indican
            Clases.Equipo team = new Clases.Equipo( nombreEquipo, cantJugadores, nombreDT, tipoEquipo, capEquipo, sub21);

            // Se llama a lista de equipo collection y se agrega l nuevo equipo
            Clases.EquipoCollection.EquipoList.Add(team);

            this.Close();

        }

        // función regex y aplicación de esta para implementar en campo cantidad jugadores, 
        // con el objetivo de que se ingresen solamente numeros 

        private static Regex e_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = e_regex.IsMatch(e.Text);

        }

    }
}
