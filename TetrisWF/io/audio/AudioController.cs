using AS_Coursework.io.audio.ext;
using AS_Coursework.Properties;
using NAudio.Wave;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AS_Coursework.io.audio
{
    internal static class AudioController
    {
        private static WaveOut? SoundtrackWaveOut;

        /// <summary>
        ///     The function plays a sound effect from a given resource stream using the WaveOut class.
        /// </summary>
        /// <param name="soundName">A string representing the name of the sound effect to be played. This is
        /// used to retrieve the sound resource from the application's resources.</param>
        public static void PlaySoundEffect(string soundName)
        {
            Stream soundResource = Resources.ResourceManager.GetStream(soundName);
            Task.Run(() =>
            {
                // Get the WaveFormat from the audio file
                var soundEffectReader = new WaveFileReader(soundResource);
                var waveFormat = soundEffectReader.WaveFormat;

                // Create a new RawSourceWaveStream with the WaveFormat of the audio file
                var importer = new RawSourceWaveStream(soundResource, waveFormat);
                var soundFx = new WaveOut();
                soundFx.DesiredLatency = 100;
                soundFx.Init(importer);
                soundFx.Play();
            });
        }


        /// <summary>
        ///     This function plays background music using a looped audio stream.
        /// </summary>
        public static async Task PlayBackgroundMusic()
        {
            using (var soundEffectStream = Resources.soundtrack)
            using (var soundEffectReader = new WaveFileReader(soundEffectStream))
            using (var loopStream = new LoopStream(soundEffectReader))
            {
                SoundtrackWaveOut = new WaveOut();
                SoundtrackWaveOut.Init(loopStream);
                SoundtrackWaveOut.Play();
                await Task.Delay(-1).ConfigureAwait(false);
            }
        }

        /// <summary>
        ///     This function stops and disposes of any currently playing background music.
        /// </summary>
        public static void StopBackgroundMusic()
        {
            if (SoundtrackWaveOut != null)
            {
                SoundtrackWaveOut.Stop();
                SoundtrackWaveOut.Dispose();
                SoundtrackWaveOut = null;
            }
        }
    }
}
