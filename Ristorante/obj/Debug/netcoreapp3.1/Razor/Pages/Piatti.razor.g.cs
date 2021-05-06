#pragma checksum "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b742ca02822fcc064a91cfd9bba9b43a4ad559"
// <auto-generated/>
#pragma warning disable 1591
namespace Ristorante.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Christian\source\repos\Ristorante\Ristorante\_Imports.razor"
using Ristorante.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/piatti")]
    public partial class Piatti : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\"> Ristorante </h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Ecco quello che forniamo nel ristorante:</h3>\r\n\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
 if (nuovo == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", " table table-hover");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, @"<tr>
            <th>ID</th>
            <th>Tipo_portata</th>
            <th>Allergeni_contenuti</th>
            <th>Stagione_presentazione</th>
            <th>Prezzo</th>
            <th>Modifica</th>
            <th>Cancellazione</th>

        </tr>
");
#nullable restore
#line 26 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
         foreach (Piatto nuovo in db.piatti)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             nuovo.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             GetPortata(nuovo)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             GetAllergeni(nuovo)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             nuovo.Stagione_presentazione

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             nuovo.Prezzo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n        ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                              (e => Modifica(nuovo))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "style", "background-color:blue");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "\r\n                <span class=\"oi oi-pencil\" style=\"color: white;\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                              (e => Cancella(nuovo))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "style", "background-color:red");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddMarkupContent(40, "\r\n                <span class=\"oi oi-trash\" style=\"color: white;\"></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 48 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.AddContent(46, "    ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                      (e => Aggiungi())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Crea Piatto");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 52 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(51);
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddAttribute(53, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 55 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                     nuovo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 55 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                                             e => Salva()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(56, "\r\n\r\n    ");
                __builder2.AddMarkupContent(57, "<p>Inserici i dati del piatto e premi SALVA!</p>\r\n    ");
                __builder2.OpenElement(58, "p");
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.AddMarkupContent(60, "<label for=\"ID_portata\">Tipi di Portate</label>\r\n        ");
                __builder2.OpenElement(61, "select");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "id", "Piatto-Portata");
                __builder2.AddAttribute(64, "aria-label", "Seleziona la portata");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                                                nuovo.ID_portate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovo.ID_portate = __value, nuovo.ID_portate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(67, "\r\n\r\n");
#nullable restore
#line 62 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             foreach (Portata portata in db.portate)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(68, "                ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", 
#nullable restore
#line 64 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                portata.ID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(71, "default", true);
                __builder2.AddContent(72, 
#nullable restore
#line 64 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                                     portata.Tipo_portata

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n");
#nullable restore
#line 65 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(77, "p");
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.AddMarkupContent(79, "<label for=\"ID_Allergeni\">Allergeni contenuti</label>\r\n        ");
                __builder2.OpenElement(80, "select");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "id", "Piatto-Allergeni");
                __builder2.AddAttribute(83, "aria-label", "Seleziona lì allergenico");
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                                                  nuovo.ID_Allergeni_contenuti

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovo.ID_Allergeni_contenuti = __value, nuovo.ID_Allergeni_contenuti));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(86, "\r\n\r\n");
#nullable restore
#line 74 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
             foreach (Allergeni allergeni in db.allergeni)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(87, "                ");
                __builder2.OpenElement(88, "option");
                __builder2.AddAttribute(89, "value", 
#nullable restore
#line 76 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                allergeni.ID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(90, "default", true);
                __builder2.AddContent(91, 
#nullable restore
#line 76 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                                       allergeni.Allergeni_contenuti

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n");
#nullable restore
#line 77 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n    \r\n    ");
                __builder2.OpenElement(96, "p");
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.AddMarkupContent(98, "<label for=\"stagione_presentazione\">Stagione di presentazione</label>\r\n        ");
                __builder2.OpenElement(99, "input");
                __builder2.AddAttribute(100, "id", "stagione_presentazione");
                __builder2.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                                        nuovo.Stagione_presentazione

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovo.Stagione_presentazione = __value, nuovo.Stagione_presentazione));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n    ");
                __builder2.OpenElement(105, "p");
                __builder2.AddMarkupContent(106, "\r\n        ");
                __builder2.AddMarkupContent(107, "<label for=\"titolo\">Prezzo del piatto</label>\r\n        ");
                __builder2.OpenElement(108, "input");
                __builder2.AddAttribute(109, "id", "titolo");
                __builder2.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
                                        nuovo.Prezzo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovo.Prezzo = __value, nuovo.Prezzo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n    ");
                __builder2.AddMarkupContent(114, "<button>SALVA</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 97 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Christian\source\repos\Ristorante\Ristorante\Pages\Piatti.razor"
       

    private Piatto nuovo;

    private void Cancella(Piatto daCancellare)
    {
        db.piatti.Remove(daCancellare);
        db.SaveChanges();
    }

    private void Aggiungi()
    {
        nuovo = new Piatto();
    }

    public void Modifica(Piatto daModificare)
    {
        nuovo = daModificare;
    }

    private void Salva()
    {
        if (nuovo.ID == 0)
        {
            db.piatti.Add(nuovo);
        }
        else
        {
            db.piatti.Update(nuovo);
        }

        db.SaveChanges();
        nuovo = null;
    }

    public string GetPortata(Piatto piatto)
    {
        Portata portate = db.portate.Single(port => port.ID == piatto.ID_portate);
        return portate.Tipo_portata;
    }

    public string GetAllergeni(Piatto piatto)
    {
        Allergeni allergeni = db.allergeni.Single(al => al.ID == piatto.ID_Allergeni_contenuti);
        return allergeni.Allergeni_contenuti;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancaDati db { get; set; }
    }
}
#pragma warning restore 1591
