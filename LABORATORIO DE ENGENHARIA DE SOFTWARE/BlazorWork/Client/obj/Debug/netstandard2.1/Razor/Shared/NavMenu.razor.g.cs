#pragma checksum "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aec9ab744a1c9e1c0e18b03d4fd023bdabf2e56"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\_Imports.razor"
using blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Bar>(0);
            __builder.AddAttribute(1, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.BarMode>(
#nullable restore
#line 2 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
        BarMode.VerticalInline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "CollapseMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.BarCollapseMode>(
#nullable restore
#line 3 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
                BarCollapseMode.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 4 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
              Breakpoint.Desktop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "NavigationBreakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 5 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
                        Breakpoint.Tablet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 6 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
                 ThemeContrast.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n  ");
                __builder2.OpenComponent<Blazorise.BarBrand>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n    ");
                    __builder3.OpenComponent<Blazorise.BarItem>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\r\n      ");
                        __builder4.OpenComponent<Blazorise.BarLink>(14);
                        __builder4.AddAttribute(15, "To", "");
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "\r\n        ");
                            __builder5.OpenComponent<Blazorise.BarIcon>(18);
                            __builder5.AddAttribute(19, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
                           IconName.Laptop

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(20, "\r\n        BlazorWork\r\n      ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n  ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n  ");
                __builder2.OpenComponent<Blazorise.BarMenu>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\r\n    ");
                    __builder3.OpenComponent<Blazorise.BarStart>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "\r\n      ");
                        __builder4.OpenComponent<Blazorise.BarItem>(30);
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(32, "\r\n        ");
                            __builder5.OpenComponent<Blazorise.BarLink>(33);
                            __builder5.AddAttribute(34, "To", "Afazer");
                            __builder5.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(36, "\r\n          ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(37);
                                __builder6.AddAttribute(38, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
                             IconName.List

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(39, "\r\n          A fazer\r\n        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(40, "\r\n      ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n      ");
                        __builder4.OpenComponent<Blazorise.BarItem>(42);
                        __builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(44, "\r\n        ");
                            __builder5.OpenComponent<Blazorise.BarLink>(45);
                            __builder5.AddAttribute(46, "To", "#docs");
                            __builder5.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(48, "Documentation");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n      ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n      ");
                        __builder4.OpenComponent<Blazorise.BarItem>(51);
                        __builder4.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(53, "\r\n        ");
                            __builder5.OpenComponent<Blazorise.BarDropdown>(54);
                            __builder5.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(56, "\r\n          ");
                                __builder6.OpenComponent<Blazorise.BarDropdownToggle>(57);
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(59, "\r\n            ");
                                    __builder7.OpenComponent<Blazorise.BarIcon>(60);
                                    __builder7.AddAttribute(61, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\milyk\PROJETOS\Curso_BCC\LABORATORIO DE ENGENHARIA DE SOFTWARE\BlazorWork\Client\Shared\NavMenu.razor"
                               IconName.Edit

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(62, "\r\n            Dropdown\r\n          ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(63, "\r\n          ");
                                __builder6.OpenComponent<Blazorise.BarDropdownMenu>(64);
                                __builder6.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(66, "\r\n            ");
                                    __builder7.OpenComponent<Blazorise.BarDropdownItem>(67);
                                    __builder7.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(69, "Action");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(70, "\r\n            ");
                                    __builder7.OpenComponent<Blazorise.BarDropdownItem>(71);
                                    __builder7.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(73, "Another action");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(74, "\r\n          ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(75, "\r\n        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(76, "\r\n      ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n  ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
