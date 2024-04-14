using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Lógica de interacción para ListarEquipo.xaml
    /// </summary>
    public partial class ListarEquipo : Window
    {
        public ListarEquipo()
        {
            InitializeComponent();
            dgListadoEquipos.ItemsSource = Clases.EquipoCollection.EquipoList;
            dgListadoEquipos.CanUserAddRows = false;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var equipoSeleccionado = (Clases.Equipo)dgListadoEquipos.SelectedItem;
            ActualizarEquipo actualizarTeam = new(equipoSeleccionado);
            actualizarTeam.ShowDialog();



        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int index = dgListadoEquipos.SelectedIndex;
            Clases.EquipoCollection.EquipoList.RemoveAt(index);
            dgListadoEquipos.Items.Refresh();
        }

        
        private void Window_Activated(object sender, EventArgs e)
        {
            dgListadoEquipos.Items.Refresh();
        }
    }
}
