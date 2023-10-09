using DesafioProgTV.Models;
using System.IO;
using System.Text;
using System.Windows;//.Storage.StorageFile;
namespace DesafioProgTV.Services
{
    public class VideoService
    {

        public InformacoesVideo ObtemInfoVideos(string caminho)
        {


            var diretorios = Directory.EnumerateFiles(caminho);

            InformacoesVideo video = new InformacoesVideo();

            foreach (var item in diretorios)
            {
                var arquivo = new FileInfo(caminho);
                video.DiretorioSalvo = arquivo.DirectoryName;
                video.Nome = arquivo.Name;
                video.DataDeCriacao = arquivo.CreationTime.ToString("dd/MM/yyyy");
                video.Extensao = arquivo.Extension;
                video.Tamanho = arquivo.Length.ToString();
            }

            return video;
        }

        public void SalvaVideo(string caminho)
        {

        }

    }
}
