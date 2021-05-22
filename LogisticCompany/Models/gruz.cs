using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class gruz
    {
        [Display(Name = "Код груза")]
        public string ID { get; set; }

        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }

        [Display(Name = "Срок годности")]
        public short Srok_godnosty { get; set; }

        [Display(Name = "Особенности")]
        public string osobennosty { get; set; }
    }
}
