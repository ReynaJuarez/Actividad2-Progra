using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_peliculasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_peliculasDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.db_peliculasDataSet.Peliculas);

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveFirst();
        }
        

        
     
            private void btnAnterior_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MovePrevious();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveNext();
        }
         private void btnUltimo_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveLast();
        }       

        }
    }

