using Library.Domain.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Library.Blazor.Components
{
    public abstract class AppComponentBase : ComponentBase
    {
        [Inject]
        protected NavigationManager navigationManager { get; set; }

        [Inject]
        protected IBookRepository bookRepository { get; set; }
    }
}
