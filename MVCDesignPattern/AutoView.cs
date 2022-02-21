using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDesignPattern.Controller;
using MVCDesignPattern.Enums;
using MVCDesignPattern.Models;

namespace MVCDesignPattern
{
    public partial class AutoView : Form
    {
        public AutoView()
        {
            InitializeComponent();
            WireUp(new AutoMobileControl(),new SportsCar("Ferrari"));
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            Control.RequestAccelerate(int.Parse(txtAmount.Text));
        }

        private void btnDecelerate_Click(object sender, EventArgs e)
        {
            Control.RequestDecelerate(int.Parse(txtAmount.Text));
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Control.RequestTurn(DirectionEnums.RelativeDirection.Left);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Control.RequestTurn(DirectionEnums.RelativeDirection.Right);
        }
    }
}
