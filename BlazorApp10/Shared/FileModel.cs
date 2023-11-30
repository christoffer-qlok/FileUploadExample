using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp10.Shared
{
    public class FileModel
    {
        public IBrowserFile File { get; set; }
    }
}
