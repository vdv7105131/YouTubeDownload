using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeDownload
{
    /// <summary>
    /// Получается аналог Sender
    /// </summary>
    public class YoutubeMaster
    {
        Commands.Command _command;

        public void SetCommand(Commands.Command command) => _command = command;

        // Выполнить
        public void Run()
        {
            _command.Run();
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
