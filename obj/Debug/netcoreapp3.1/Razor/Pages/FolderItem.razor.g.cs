#pragma checksum "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db43a24ce8f17cb2736326a0e414e10a71846e3"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskLists.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using TaskLists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using TaskLists.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
using TaskLists.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
using TaskLists.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/folder")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/folder/{Id:int}")]
    public partial class FolderItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
 if (folder == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>Такого списка не існує</h1>\r\n");
#nullable restore
#line 14 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
}
else if (folder.Id == -1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<h1>Немає доступа до даного списка</h1>\r\n");
#nullable restore
#line 18 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "h1");
            __builder.AddContent(6, 
#nullable restore
#line 21 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
         folder.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 22 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
     foreach (Item it in folder.Items)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenComponent<TaskLists.Pages.ItemComponent>(9);
            __builder.AddAttribute(10, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TaskLists.Data.Item>(
#nullable restore
#line 24 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                             it

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "EventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                                  e=> SaveItem(e, it)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "EventCallbackRight", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                                                                              e => OnRightClickItem(e, it)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 25 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenComponent<TaskLists.Pages.AddItemComponent>(15);
            __builder.AddAttribute(16, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TaskLists.Data.Item>(
#nullable restore
#line 26 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                            newItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Callback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                               NewItem

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "contextmenu" + " " + (
#nullable restore
#line 28 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                              hideOrShowItem ? "contextmenu-show" : "contextmenu-hide"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "style", 
#nullable restore
#line 28 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                                                                                 styleForContextMenuItem

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "icon-close");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                           HideContextMenuItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "button button-green");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                                        e => EditItem(e, itemClick)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "button button-red");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
                                                      e => DeleteItem(e, itemClick)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 33 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
      
    [Parameter]
    public int Id { get; set; } = -1;

    public static Item newItem = new Item() { Date = DateTime.Now, Time = DateTime.Now, IsNotificationTelegram = true };
    private Folder folder;

    private Item itemClick;
    private string styleForContextMenuItem = string.Empty;
    private bool hideOrShowItem = false;

    AuthenticationState authState;
    System.Security.Claims.ClaimsPrincipal user;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("materializeMethods");
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    [JSInvokable("setDate")]
    public static async void SetDate(string instances)
    {
        newItem.Date = DateTime.Parse(instances);
    }
    [JSInvokable("setTime")]
    public static async void SetTime(string hour, string minutes)
    {
        newItem.Time = new DateTime(2000, 1, 1, Int32.Parse(hour), Int32.Parse(minutes), 0);
    }
    private async Task<DateTime> GetDate()
    {
        string s = await JSRuntime.InvokeAsync<string>("getDate");
        DateTime a = new DateTime();
        DateTime.TryParse(s, out a);
        await JSRuntime.InvokeVoidAsync("alert(getDate);");
        return a;
    }

    protected async override Task OnInitializedAsync()
    {
        authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        user = authState.User;
        if (user.Identity.Name == null) return;
        folder = await Service.GetFolderAndItemsAsync(Id, user.Identity.Name);
    }

    private async Task RefreshFolder()
    {
        folder = await Service.GetFolderAndItemsAsync(Id, user.Identity.Name);
    }
    private void HideContextMenuItem(MouseEventArgs args)
    {
        hideOrShowItem = false;
    }
    private void OnRightClickItem(MouseEventArgs args, Item item)
    {
        if (args.Button == 2)
        {
            itemClick = item;
            styleForContextMenuItem = $"top: {args.ClientY}px; left:{args.ClientX}px;";
            hideOrShowItem = true;
        }
    }

    private void EditItem(MouseEventArgs args, Item item)
    {
        item.StatusModel = StatusModel.Edit;
        hideOrShowItem = false;

    }
    private async void DeleteItem(MouseEventArgs args, Item item)
    {
        await Service.DeleteItem(item);
        hideOrShowItem = false;
        await RefreshFolder();
    }
    private async void SaveItem(MouseEventArgs args, Item item)
    {
        await Service.EditItem(item);
        item.StatusModel = StatusModel.Static;
    }




    private async Task NewItem()
    {
        bool result = await Service.AddItem(newItem, Id);
        if (result)
        {
            newItem = new Item() { Date = DateTime.Now, Time = DateTime.Now, IsNotificationTelegram = true };
            await RefreshFolder();
        }
    }

    public async override Task SetParametersAsync(ParameterView parameters)
    {
        IReadOnlyDictionary<string, object> dic = parameters.ToDictionary();
        if (Id != dic["Id"] as int?)
        {
            await base.SetParametersAsync(parameters);
            await RefreshFolder();
        }

        await base.SetParametersAsync(parameters);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskLists.Data.ItemService Service { get; set; }
    }
}
#pragma warning restore 1591
