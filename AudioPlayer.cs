using System.Media;

namespace CybersecurityAwarenessChatbot
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("file_example_WAV_1MG.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio file not found.");
            }
        }
    }
}