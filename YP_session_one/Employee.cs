//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YP_session_one
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Employee_ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    
        public virtual Role Role1 { get; set; }
    }
}
