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
    
    public partial class clients
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long site_id { get; set; }
        public long StatusId { get; set; }
        public int ClientId { get; set; }
    
        public virtual client_status client_status { get; set; }
        public virtual sites sites { get; set; }
    }
}
