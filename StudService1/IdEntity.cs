using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudService1
{
    public class IdEntity
    {
        [Key]
        public int Id { get; set; }  // Id's полей таблиц , базовый класс для всех полей
    }
}