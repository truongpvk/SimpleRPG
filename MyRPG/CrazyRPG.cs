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

        public CrazyRPG()
        {
            InitializeComponent();
            _player = Player.CreateDefaultPlayer();
            ResetStatus();
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
            lbCurrentHitPoints.DataBindings.Add("Text", _player, $"{nameof(_player.CurrentHitPoint)}");
            lbCurrentManaPoints.DataBindings.Add("Text", _player, $"{nameof(_player.CurrentManaPoints)}");
            lbExp.DataBindings.Add("Text", _player, $"{nameof(_player.ExpPoints)}");
            lbLevel.DataBindings.Add("Text", _player, $"{nameof(_player.Level)}");
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
