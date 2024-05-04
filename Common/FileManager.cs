using Microsoft.Extensions.FileProviders;

namespace CatalogoAutomotivo.Common
{
    public class FileManager
    {
        private readonly IFileProvider _fileProvider;

        public FileManager(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

        public void CreateFile(string fabricanteLogoPath, IFormFile file)
        {
            var folderInfo = _fileProvider.GetFileInfo(Path.Combine("wwwroot", fabricanteLogoPath));
            string filePath = Path.Combine(folderInfo.PhysicalPath, file.FileName);

            using (var stream = System.IO.File.Create(filePath))
            {
                file.CopyToAsync(stream);
            }
        }
    }
}
