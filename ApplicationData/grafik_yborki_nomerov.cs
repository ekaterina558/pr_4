//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr_4.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class grafik_yborki_nomerov
    {
        public string housemaid_ID { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string otchestvo { get; set; }
        public string floor { get; set; }
        public System.DateTime data { get; set; }
    
        public virtual guests_currently_living_in_the_hotel guests_currently_living_in_the_hotel { get; set; }
        public virtual report_on_the_state_of_the_room_stock_as_of_date report_on_the_state_of_the_room_stock_as_of_date { get; set; }
    }
}
