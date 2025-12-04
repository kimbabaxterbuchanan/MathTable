using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MathTable
{
    public partial class FormShowMultiplicationWork : Form
    {

        Size defaultStepTextSize = new Size(1, 1);

        string speakValue = "";

        public FormShowMultiplicationWork()
        {
            InitializeComponent();

            defaultStepTextSize = txtBoxSteps.Size;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnMultiplyEquals_Click(object sender, EventArgs e)
        {

            txtBoxSteps.Text = string.Empty;
            var multiplicand = Convert.ToInt32(txtBxMultiplyMultiplicand.Text.Trim());
            var multiplier = txtBxMultiplyMultiplier.Text.Trim();
            var multiplierInt = Convert.ToInt32(multiplier);

            var multLength = multiplier.Length;
            var idx = 0;

            double answerInt = 0;
            for (int i = multLength; i -- > 0;)
            {
                var multiplierStep = multiplier[i].ToString();
                int multiplierinc = int.Parse(multiplierStep);
                var multipleStep = multiplicand * multiplierinc;

                var multiSize = multLength - i;
                var stepsp = string.Empty;
                if (idx > 0)
                {
                    var newMultiStep = multipleStep * Math.Pow(10, idx);
                    answerInt = answerInt + newMultiStep;
                    txtBoxSteps.Text += newMultiStep.ToString() + stepsp + Environment.NewLine;
                }
                else
                {
                    txtBoxSteps.Text = multipleStep.ToString() + Environment.NewLine;
                    answerInt = answerInt + Convert.ToDouble(multipleStep);
                }
                idx++;

                Size size = txtBoxSteps.Size;
                size.Height = size.Height + defaultStepTextSize.Height;
                txtBoxSteps.Size = size;
            }

            Size tsize = txtBoxSteps.Size;
            tsize.Height = tsize.Height + defaultStepTextSize.Height;
            txtBoxSteps.Size = tsize;
            txtBoxSteps.Text += lblMultiplyEquals.Text + Environment.NewLine;
            Size ssize = txtBoxSteps.Size;
            ssize.Height = ssize.Height + defaultStepTextSize.Height;
            txtBoxSteps.Size = ssize;
            txtBoxSteps.Text += answerInt.ToString();
            speakValue = answerInt.ToString();
            Application.DoEvents();
        }

        private void btnMultiplyNext_Click(object sender, EventArgs e)
        {
            txtBoxSteps.Size = defaultStepTextSize;
            txtBoxSteps.Text = string.Empty;
            Application.DoEvents();
        }

        private void FormShowMultiplicationWork_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var speakTimer = "      Multiply           ";
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice(getVoice(synth));
            synth.Rate = 1;
            synth.Speak(new Prompt(speakTimer));
            synth.Speak(new Prompt(speakTimer + txtBxMultiplyMultiplicand.Text + "              Times                "+ txtBxMultiplyMultiplier.Text + "               Equals                " + speakValue));
        }
        private string getVoice(SpeechSynthesizer synth)
        {
            var voice = synth.GetInstalledVoices();
            string  vName = voice[0].VoiceInfo.Name;
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
