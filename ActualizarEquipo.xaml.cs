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
    /// Lógica de interacción para ActualizarEquipo.xaml
    /// </summary>
    public partial class ActualizarEquipo : Window
    {
        Clases.Equipo EquipoAct = new();

        public ActualizarEquipo(Clases.Equipo equipoAct)
        {
            InitializeComponent();
            EquipoAct = equipoAct;
            cargaDataPrevia();
        }

       

        private void btnActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            Clases.Equipo TempTeam = new();
            TempTeam.NombreEquipo = txtNombreEquipoAct.Text;
            TempTeam.CantidadJugadores = Convert.ToInt32(txtCantidadJugadoresAct.Text);
            TempTeam.NombreDT = txtNombreDTAct.Text;
            TempTeam.TipoEquipo = txtTipoEquipoAct.Text;
            TempTeam.CapitanEquipo = txtCapitanEquipoAct.Text;
            TempTeam.TieneSub21 = (chcSub21Act.IsChecked.Value) ? true : false;

            int index = Clases.EquipoCollection.EquipoList.IndexOf(this.EquipoAct); // arrojaba error antes porque estaba utilizando el index de TempTeam
            Clases.EquipoCollection.EquipoList.RemoveAt(index);
            Clases.EquipoCollection.EquipoList.Insert(index, TempTeam);
            this.Close();
        }


        private void cargaDataPrevia()
        {
            txtNombreEquipoAct.Text = this.EquipoAct.NombreEquipo;
            txtCantidadJugadoresAct.Text = this.EquipoAct.CantidadJugadores.ToString();
            txtNombreDTAct.Text = this.EquipoAct.NombreDT;
            txtTipoEquipoAct.Text = this.EquipoAct.TipoEquipo;
            txtCapitanEquipoAct.Text = this.EquipoAct.CapitanEquipo;
            chcSub21Act.IsChecked = (this.EquipoAct.TieneSub21) ? true : false;

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
