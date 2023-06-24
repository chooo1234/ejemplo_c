using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace ClassVehicle
{
    public class Train : Sounds
    {
        public override void vehicleSounds()
        {
            AudioFileReader audioFile = new AudioFileReader("Resources/TRAIN.mp3");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();

            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}
