using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class vid_avtomobilya
    {
        [Display(Name = "Описание")]
        public string opisanie { get; set; }

        [Display(Name = "Наименование")]
        public string naimenovanie { get; set; }

        [Display(Name = "Код вида автомобиля")]
        public short ID { get; set; }

    }
}
