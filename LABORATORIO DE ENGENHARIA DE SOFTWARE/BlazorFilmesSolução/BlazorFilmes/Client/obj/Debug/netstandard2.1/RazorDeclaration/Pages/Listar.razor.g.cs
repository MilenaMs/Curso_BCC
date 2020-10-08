#pragma checksum "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\Pages\Listar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02da622899f6238b6d5f4ca492d7b0d5ef21a448"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorFilmes.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using BlazorFilmes.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using BlazorFilmes.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using BlazorFilmes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\Pages\Listar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Listar")]
    public partial class Listar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorFilmesSolução\BlazorFilmes\Client\Pages\Listar.razor"
       

    private List<Product> productList = new List<Product>();

    protected override async Task OnInitializedAsync()
    {

        var products = await Http.GetFromJsonAsync<List<Product>>("/Product/List");
        foreach (var item in products)
        {
            productList.Add(item);
        }
    }

    private async Task DeleteProduct(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Product/Delete/" + itemId);
        NavigationManager.NavigateTo("User/ListProduct", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
