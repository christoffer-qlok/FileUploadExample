using BlazorApp10.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp10.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile file)
        {
            try
            {

                if (file.Length > 0)
                {
                    // Process the file (save it, etc.)
                    var filePath = Path.Combine("wwwroot/uploads", file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    return Ok("File uploaded successfully!");
                }
                else
                {
                    return BadRequest("File is empty.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
