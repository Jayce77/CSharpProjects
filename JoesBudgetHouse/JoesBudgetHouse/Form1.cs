using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesBudgetHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

            var labels = Controls.OfType<Label>();
            foreach (var label in labels)
            {
                label.Text = menu.GetMenuItem();
            }
        }
    }
}
