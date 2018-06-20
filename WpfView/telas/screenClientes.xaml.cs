﻿using Controllers;
using Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView.telas
{
    /// <summary>
    /// Interação lógica para screenClientes.xam
    /// </summary>
    public partial class screenClientes : UserControl
    {
        public screenClientes()
        {
            InitializeComponent();
            ClienteController controller = new ClienteController();
            IList<Cliente> lista = controller.List();
            dbGridClientes.ItemsSource = lista;
        }
    }
}
