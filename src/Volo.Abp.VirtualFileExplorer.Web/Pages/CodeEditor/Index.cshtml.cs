using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Pagination;
using Volo.Abp.VirtualFileExplorer.Web.Models;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.VirtualFileSystem.Embedded;

namespace Volo.Abp.VirtualFileExplorer.Web.Pages.CodeEditor;

public class IndexModel : PageModel
{
    public IndexModel()
    {
        
    }

    public virtual async Task OnGet()
    {
       
    }
}
