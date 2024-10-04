using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using NAudio.Wave;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveSimulator
{
    public partial class Titul : Form
    {
        private Race currentRace;
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        public Titul()
        {
            InitializeComponent();
            InitializeAudio();
            InitializeRaceTypes();
        }
        private void InitializeAudio()
        {
            waveOut = new WaveOut();
            audioFileReader = new AudioFileReader("C:/Users/murkt/source/repos/DriveSimulator/Resources/Kavinsky - Nightcall.mp3");
            waveOut.Init(audioFileReader);
            waveOut.Play();

            // Зацикливание
            waveOut.PlaybackStopped += (s, e) =>
            {
                audioFileReader.Position = 0;
                waveOut.Play();
            };
        }
        private void InitializeRaceTypes()
        {
            comboBoxRaceType.Items.Add("Наземный");
            comboBoxRaceType.Items.Add("Воздушный");
            comboBoxRaceType.Items.Add("Смешанный");
            comboBoxRaceType.SelectedIndex = 0; // Установить значение по умолчанию
        }
        // Выключение фоновой музыки с закрытием формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            waveOut.Stop();
            audioFileReader.Dispose();
            waveOut.Dispose();
            base.OnFormClosing(e);
        }
        private void btnCreateRace_Click(object sender, EventArgs e)
        {
            double distance = (double)numericUpDownDistance.Value;
            string raceType = comboBoxRaceType.SelectedItem.ToString();

            // Создание гонки
            currentRace = new Race(distance, raceType);
            lblResult.Text = $"Гонка создана на дистанцию {distance} ед. Тип: {raceType}";
            listBoxParticipants.Items.Clear(); // Очистить список участников
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            if (currentRace == null)
            {
                MessageBox.Show("Сначала создайте гонку!");
                return;
            }
            string result = currentRace.StartRace();
            lblResult.Text = result;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
