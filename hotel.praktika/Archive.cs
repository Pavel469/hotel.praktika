//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hotel.praktika
{
    using System;
    using System.Collections.Generic;
    
    public partial class Archive
    {
        public int Id { get; set; }
        public int Photo { get; set; }
    
        public virtual CalculatedCard CalculatedCard { get; set; }
    }
}
