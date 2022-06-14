using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public partial class MainWindow : Component
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
