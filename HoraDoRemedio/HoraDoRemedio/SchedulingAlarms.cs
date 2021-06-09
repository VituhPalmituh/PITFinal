using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraDoRemedio
{
    public class SchedulingAlarms : IJob
    {
        public string Medicine { get; set; }
        public string Days { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public SchedulingAlarms(string medicine, string days)
        {
            Medicine = medicine;
            Days = days;
        }

        public SchedulingAlarms(string description, DateTime date)
        {
            Description = description;
            Date = date;
        }

        public void Execute()
        {
            if (Description == "" || Description == null)
            {
                var now = DateTime.Now.DayOfWeek.ToString();
                if (Days.Contains(now))
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"G:\Visual Projetos\PITFinal\Resources\Alarme.wav";
                    player.PlayLooping();
                    DialogResult popUp = MessageBox.Show($"Hora do Remédio: \n {Medicine}", "Hora do Remédio", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (popUp == DialogResult.OK)
                    {
                        player.Stop();
                    }
                }
            }
            else
            {
                var now = DateTime.Now.ToShortDateString();
                if (Date.ToShortDateString() == now)
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"G:\Visual Projetos\PITFinal\Resources\Alarme.wav";
                    player.PlayLooping();
                    DialogResult popUp = MessageBox.Show($"Hora da Consulta: \n {Description}", "Hora do Consulta", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (popUp == DialogResult.OK)
                    {
                        player.Stop();
                    }
                }
            }
        }
    }
}
