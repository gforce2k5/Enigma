using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    public partial class MainFrm: Form
    {
        Enigma enigma;

        int[] settings = new int[9];

        string plugboard = "";

        public MainFrm()
        {
            InitializeComponent();
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void cmdEncode_Click(object sender, EventArgs e)
        {
            txtCypher.Text = enigma.Translate(txtText.Text);

            cmbLeftOffset.SelectedIndex = enigma.L.Offset - 1;
            cmbMiddleOffset.SelectedIndex = enigma.M.Offset - 1;
            cmbRightOffset.SelectedIndex = enigma.R.Offset - 1;
        }

        private void Apply()
        {
            enigma = new Enigma(cmbRotor1.SelectedIndex + 1, cmbRotor2.SelectedIndex + 1, cmbRotor3.SelectedIndex + 1);
            enigma.L.RingSetting = cmbLeftSetting.SelectedIndex + 1;
            enigma.L.Offset = cmbLeftOffset.SelectedIndex + 1;
            enigma.M.RingSetting = cmbMiddleSetting.SelectedIndex + 1;
            enigma.M.Offset = cmbMiddleOffset.SelectedIndex + 1;
            enigma.R.RingSetting = cmbRightSetting.SelectedIndex + 1;
            enigma.R.Offset = cmbRightOffset.SelectedIndex + 1;

            try
            {
                enigma.Plug = new Plugboard(txtPlugboard.Text);
                txtText.Enabled = true;
                cmdEncode.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            cmbRotor1.SelectedIndex = 0;
            cmbRotor2.SelectedIndex = 1;
            cmbRotor3.SelectedIndex = 2;

            cmbLeftOffset.SelectedIndex = 0;
            cmbMiddleOffset.SelectedIndex = 0;
            cmbRightOffset.SelectedIndex = 0;

            cmbLeftSetting.SelectedIndex = 0;
            cmbMiddleSetting.SelectedIndex = 0;
            cmbRightSetting.SelectedIndex = 0;

            txtPlugboard.Text = "";
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            Reset();
            Apply();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            settings[0] = cmbRotor1.SelectedIndex;
            settings[1] = cmbRotor2.SelectedIndex;
            settings[2] = cmbRotor3.SelectedIndex;

            settings[3] = cmbLeftOffset.SelectedIndex;
            settings[4] = cmbMiddleOffset.SelectedIndex;
            settings[5] = cmbRightOffset.SelectedIndex;

            settings[6] = cmbLeftSetting.SelectedIndex;
            settings[7] = cmbMiddleSetting.SelectedIndex;
            settings[8] = cmbRightSetting.SelectedIndex;

            plugboard = txtPlugboard.Text;
            Apply();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            cmbRotor1.SelectedIndex = settings[0];
            cmbRotor2.SelectedIndex = settings[1];
            cmbRotor3.SelectedIndex = settings[2];

            cmbLeftOffset.SelectedIndex = settings[3];
            cmbMiddleOffset.SelectedIndex = settings[4];
            cmbRightOffset.SelectedIndex = settings[5];

            cmbLeftSetting.SelectedIndex = settings[6];
            cmbMiddleSetting.SelectedIndex = settings[7];
            cmbRightSetting.SelectedIndex = settings[8];

            txtPlugboard.Text = plugboard;
            Apply();
        }

        private void cmdProfiling_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            for (int i = 0; i < 100000; i++)
            {
                int[] rotors = new int[3];
                List<int> nums = new List<int>(5);
                for (int j = 1; j <= 5; j++) nums.Add(j);
                for (int j = 0; j < 3; j++)
                {
                    int r = random.Next(5-j);
                    rotors[j] = nums[r];
                    nums.RemoveAt(r);
                }

                Enigma randEnigma = new Enigma(rotors[0], rotors[1], rotors[2]);

                randEnigma.L.RingSetting = random.Next(26) + 1;
                randEnigma.M.RingSetting = random.Next(26) + 1;
                randEnigma.R.RingSetting = random.Next(26) + 1;

                randEnigma.L.Offset = random.Next(26) + 1;
                randEnigma.M.Offset = random.Next(26) + 1;
                randEnigma.R.Offset = random.Next(26) + 1;

                nums = new List<int>(26);
                string plug = "";
                int maxPairs = random.Next(10) + 1;

                for (int j = 0; j < 26; j++) nums.Add(j);
                for (int j = 0; j < maxPairs * 2; j++)
                {
                    int l = random.Next(26 - j);
                    plug += (char)('A' + nums[l]);
                    nums.RemoveAt(l);
                }

                randEnigma.Plug = new Plugboard(plug);
                randEnigma.Translate("RANDOMMESSAGE");
            }
        }
    }
}