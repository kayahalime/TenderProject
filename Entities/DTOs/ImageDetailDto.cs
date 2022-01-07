using System;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Entities.DTOs
{
    public class ImageDetailDto
    {
        
            public IFormFile File { get; set; }
            public Image Image { get; set; }
        
    }
}
