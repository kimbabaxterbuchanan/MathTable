using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTable
{
    public partial class FormShowDivisionWork : Form
    {
        Size defaultStepTextSize = new Size(1, 1);
        public FormShowDivisionWork()
        {
            InitializeComponent();
            defaultStepTextSize = txtBoxSteps.Size;
        }

        private void btnDivideNext_Click(object sender, EventArgs e)
        {
            txtBxQuotient.Text = string.Empty;
            txtBxRemainder.Text = string.Empty;
            txtBoxSteps.Text = String.Empty;
            txtBoxSteps.Size = defaultStepTextSize;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDivideAnswer_Click(object sender, EventArgs e)
        {
            txtBoxSteps.Text = string.Empty;

            var dividend = txtBxDividend.Text.Trim();
            var dividendInt = Convert.ToInt32(txtBxDividend.Text.Trim());

            var divisor = txtBxDivisor.Text.Trim();
            var divisorInt = Convert.ToInt32(divisor);

            var divisorLength = divisor.Length;

            var dividendLength = dividend.Length;
            var newdividendLength = dividend.Length;

            string dividendStep = string.Empty;
            string dividendLeftOver = dividend;
            int leftOver = 0;
            int idx = 0;
            int lpCnt = 0;
            string space = "                                           ";
            for (int j = 0; j < dividendLength; j++)
            {
                dividendStep += dividend[j].ToString();
                int dividendinc = int.Parse(dividendStep);
                dividendinc = dividendinc + leftOver;
                var dividendValue = dividendinc / divisorInt;
                idx++;
                if (dividendValue <= 0) continue;

                if (lpCnt > 0)
                {
                    txtBoxSteps.Text += " " + space.Substring(0, divisor.Length) + dividendinc + Environment.NewLine;
                    txtBoxSteps.Text += space.Substring(0, divisor.Length);
                }
                lpCnt++;
                txtBoxSteps.Text += "-" + (dividendValue * divisorInt).ToString() + Environment.NewLine;
                if (j < (dividendLength - 1))
                {
                    var leftOverTmp = (dividendinc - (dividendValue * divisorInt)) * Math.Pow(10, 1);
                    leftOver = Convert.ToInt32(leftOverTmp.ToString());
                }
                else
                {
                    leftOver = 0;
                }
                var stepSize = txtBoxSteps.Size;
                stepSize.Height = stepSize.Height + defaultStepTextSize.Height;
                txtBoxSteps.Size = stepSize;
                txtBoxSteps.Text += "---------------" + Environment.NewLine;
                stepSize = txtBoxSteps.Size;
                stepSize.Height = stepSize.Height + defaultStepTextSize.Height;
                txtBoxSteps.Size = stepSize;
                dividendStep = string.Empty;
                idx = 0;
            }

            txtBxQuotient.Text = (dividendInt / divisorInt).ToString();
            txtBxRemainder.Text = (dividendInt - (Convert.ToInt32(txtBxQuotient.Text) * divisorInt)).ToString();
            txtBoxSteps.Text += txtBxRemainder.Text + Environment.NewLine;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var speakTimer = "      Dividing           ";
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice(getVoice(synth));
            synth.Rate = 1;
            synth.Speak(new Prompt(speakTimer));
            synth.Speak(new Prompt(speakTimer + txtBxDividend.Text + "              Divided By                " + txtBxDivisor.Text + "               Equals                " + txtBxQuotient.Text + "            with Remainder of                " + txtBxRemainder.Text));  
        }
        private string getVoice(SpeechSynthesizer synth)
        {
            var voice = synth.GetInstalledVoices();
            string vName = voice[0].VoiceInfo.Name;
            for (int i = 0; i < voice.Count; i++)
            {
                if (rdBrnMale.Checked && i == 0)
                    return voice[i].VoiceInfo.Name;
                if (rdbtnFemale.Checked && i == 1)
                    return voice[i].VoiceInfo.Name;
            }
            return vName;
        }
    }
}
