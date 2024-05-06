using Microsoft.Extensions.FileProviders;
using System.IO;

namespace CatalogoAutomotivo.Common
{
    public class FileManager
    {
        private readonly IFileProvider _fileProvider;

        public FileManager(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

        public void CreateFile(string path, IFormFile file)
        {
            var folderInfo = _fileProvider.GetFileInfo(Path.Combine("wwwroot", path));
            string filePath = Path.Combine(folderInfo.PhysicalPath, file.FileName);

            string realPath = "wwwroot/" + path;

            if (!Directory.Exists(realPath))
            {
                Directory.CreateDirectory(realPath);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (var stream = System.IO.File.Create(filePath))
            {
                file.CopyToAsync(stream);

                stream.Dispose();
            }
        }

        public void DeleteFile(string path)
        {
            if (File.Exists("wwwroot/" + path))
            {
                File.Delete("wwwroot/" + path);
            }
        }
    }
}
