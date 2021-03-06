using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace NugetVendor.Resolver
{
    public interface ILocalBaseFolder
    {
        bool ContainsFolder(string folderName);
        Task<string> FileContentOrEmptyAsync(string filePath, CancellationToken cancelationToken);
        Stream OpenStreamForWriting(string path);
        Stream OpenStreamForReading(string path);
        void Clean(string folderName);
    }
}