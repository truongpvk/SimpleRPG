using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicProject;

namespace MyRPG
{
    public partial class CrazyRPG : Form
    {
        public Player _player;
        public Location _currentLocation;
        public Monster _monsterInBattleNow;

        public CrazyRPG()
        {
            InitializeComponent();
            _player = Player.CreateDefaultPlayer();

            ResetStatus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveWest_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveEast_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnUseFirstSkill_Click(object sender, EventArgs e)
        {

        }

        private void btnUseSecondSkill_Click(object sender, EventArgs e)
        {

        }

        private void btnUseThirdSkill_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }

        public void ResetStatus()
        {
            lbCurrentHitPoints.Text = _player.CurrentHitPoint.ToString();
            lbCurrentManaPoints.Text = _player.CurrentManaPoints.ToString();
            lbExp.Text = _player.ExpPoints.ToString();
            lbLevel.Text = _player.Level.ToString();
        }

        public void ResetMap()
        {
            lbCurrentLocation.Text = _currentLocation.Name;
            lbWestLocation.Text = _currentLocation.LocationToWest.Name;
            lbEastLocation.Text = _currentLocation.LocationToEast.Name;
            lbNorthLocation.Text = _currentLocation.LocationToNorth.Name;
            lbSouthLocation.Text = _currentLocation.LocationToSouth.Name;
        }

        public void ResetCBOWeapon()
        {

        }

        public void ResetCBOPotion()
        {

        }
        
        public void ResetInventoryUI()
        {

        }
        public void ResetQuestUI()
        {

        }
    }
}
