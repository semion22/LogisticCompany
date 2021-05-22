using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class dilznost
    {
        [Display(Name = "Требования")]
        public string trebovaniya { get; set; }

        [Display(Name = "Обязанности")]
        public string obyzannosty { get; set; }

        [Display(Name = "Оклад")]
        public string oklad { get; set; }

        [Display(Name = "Наименование должности")]
        public string naimen_dolznosty { get; set; }

        [Display(Name = "Код должности")]
        public short ID { get; set; }
    }
}
