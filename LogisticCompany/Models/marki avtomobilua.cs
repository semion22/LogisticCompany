using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class marki_avtomobilua
    {
        [Display(Name = "Код марки")]
        public short kod_marki { get; set; }

        [Display(Name = "Описание")]
        public string opisanie { get; set; }

        [Display(Name = "Наименование")]
        public string naimenovanie { get; set; }

        [Display(Name = "Технические характеристики")]
        public DateTime ID { get; set; }

    }
}
