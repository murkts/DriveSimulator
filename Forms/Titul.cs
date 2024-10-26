using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DriveSimulator.Transports;
using DriveSimulator.Transports.Air;
using DriveSimulator.Transports.Ground;

namespace DriveSimulator
{
    public partial class Titul : Form
    {
        private List<Transport> availableTransports = new List<Transport>();
        private List<Transport> raceParticipants = new List<Transport>();

        public Titul()
        {
            InitializeComponent();
            InitializeAudio();
            InitializeTransportList();
            UpdateAvailableTransports();
            InitializeWeatherList();
            InitializeRaceTypeOptions();
        }

        private void InitializeAudio()
        {
            axWindowsMediaPlayer1.URL = "C:/Users/murkt/source/repos/DriveSimulator/Resources/Kavinsky - Nightcall.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true); // Зацикливание трека
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            base.OnFormClosing(e);
        }

        private void InitializeRaceTypeOptions()
        {
            comboRaceType.Items.Add("Наземная");
            comboRaceType.Items.Add("Воздушная");
            comboRaceType.Items.Add("Смешанная");
        }

        private void InitializeTransportList()
        {
            availableTransports.Add(new Izbushka());
            availableTransports.Add(new FlyingCarpet());
            availableTransports.Add(new Centaur());
            availableTransports.Add(new WalkingBoots());
            availableTransports.Add(new Broomstick());
            availableTransports.Add(new Carriage());
            availableTransports.Add(new Stupa());
            availableTransports.Add(new FlyingShip());
        }

        private void UpdateAvailableTransports()
        {
            listBoxAvailableTransport.Items.Clear();
            foreach (var transport in availableTransports)
            {
                listBoxAvailableTransport.Items.Add(transport.Name);
            }
        }

        private bool IsTransportAllowed(Transport transport)
        {
            string raceType = comboRaceType.SelectedItem.ToString();
            if (raceType == "Наземная" && transport is GroundTransport)
                return true;
            if (raceType == "Воздушная" && transport is AirTransport)
                return true;
            if (raceType == "Смешанная")
                return true;

            return false;
        }

        private void InitializeWeatherList()
        {
            comboWeather.Items.AddRange(Enum.GetNames(typeof(WeatherCondition)));
        }

        private void btnAddTransport_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxAvailableTransport.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Transport selectedTransport = availableTransports[selectedIndex];
                if (IsTransportAllowed(selectedTransport))
                {
                    if (!raceParticipants.Contains(selectedTransport))
                    {
                        raceParticipants.Add(selectedTransport);
                        listBoxRaceParticipants.Items.Add(selectedTransport.Name);
                    }
                    else
                    {
                        MessageBox.Show($"{selectedTransport.Name} уже добавлен в гонку.");
                    }
                }
                else
                {
                    MessageBox.Show($"{selectedTransport.Name} не может участвовать в этой гонке.");
                }
            }
        }

        private void btnRemoveTransport_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRaceParticipants.SelectedIndex;
            if (selectedIndex >= 0)
            {
                raceParticipants.RemoveAt(selectedIndex);
                listBoxRaceParticipants.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            try
            {
                double distance = Convert.ToDouble(txtDistance.Text);
                if (raceParticipants.Count == 0)
                {
                    MessageBox.Show("Добавьте хотя бы одного участника для начала гонки.");
                    return;
                }

                Transport winner = null;
                double bestTime = double.MaxValue;
                WeatherCondition selectedWeatherCondition = (WeatherCondition)Enum.Parse(typeof(WeatherCondition), comboWeather.SelectedItem.ToString());
                Weather currentWeather = new Weather(selectedWeatherCondition);

                foreach (var participant in raceParticipants)
                {
                    double time = participant.CalculateTime(distance, currentWeather);
                    if (time < bestTime)
                    {
                        bestTime = time;
                        winner = participant;
                    }
                }

                lblRaceResult.Text = $"Победитель: {winner.Name}, Время: {bestTime:F2} у.е.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
