using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Elevator_System
{
    public partial class StartupConfiguration : Form
    {
        ElevatorForm f;
        public StartupConfiguration()
        {
            InitializeComponent();
        }
        private void StartClick(object sender, EventArgs e)
        {
            int _floorsAmount = (int)floorsAmount.Value, _speed = (int)speed.Value, _stopTime = (int)stopTime.Value;
            f = new ElevatorForm(_floorsAmount, _speed, _stopTime);
            this.Owner = f;
            f.Show();
            this.Hide();
        }
    }
}
