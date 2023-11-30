using BlazorApp10.Shared;
using System.Net.Http.Json;

namespace BlazorApp10.Client
{
    public class FileUploadService
    {
        private readonly HttpClient _httpClient;

        public FileUploadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task UploadFile(FileModel fileModel)
        {
            await _httpClient.PostAsJsonAsync("/api/upload", fileModel);
        }
    }
}
