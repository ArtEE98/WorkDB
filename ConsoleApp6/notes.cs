//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp6
{
    using System;
    using System.Collections.Generic;
    
    public partial class notes
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public long UserId { get; set; }
    
        public virtual users users { get; set; }
    }
}
