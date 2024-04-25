using Microsoft.AspNetCore.Components;

namespace Order.Frontend.Shared
{
    public partial class GenericList<Titem>
    {
        [EditorRequired, Parameter] public List<Titem> MyList { get; set; } = null!;
    }
}