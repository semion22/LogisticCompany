using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class reys
    {
        [Display(Name = "Дата отправления")]
        public DateTime data_otpravleniya { get; set; }

        [Display(Name = "Код рейса")]
        public short ID { get; set; }

        [Display(Name = "Куда")]
        public string kuda { get; set; }

        [Display(Name = "Откуда")]
        public string otkuda { get; set; }

        [Display(Name = "Заказчик")]
        public string zakazchik { get; set; }

        [Display(Name = "Отметка о возвращении")]
        public string otm_o_vozvrashen { get; set; }

        [Display(Name = "Отметка об оплате")]
        public string otmetka_ob_oplate { get; set; }

        [Display(Name = "Цена")]
        public short tsena { get; set; }

        [Display(Name = "Дата прибытия")]
        public DateTime data_pribytiya { get; set; }
    }
}
