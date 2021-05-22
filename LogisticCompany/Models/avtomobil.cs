using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class avtomobil
    {
        [Display(Name = "Регистрационный номер")]
        public string reg_number { get; set; }

        [Display(Name = "Номер кузова")]
        public string nom_kuzova { get; set; }

        [Display(Name = "Номер двигателя")]
        public string nom_dvigatelua { get; set; }

        [Display(Name = "Год выпуска")]
        public DateTime god_vipuska { get; set; }

        [Display(Name = "Дата последнего ТО")]
        public DateTime data_pos_to { get; set; }

        [Display(Name = "Код автомобиля")]
        public long ID { get; set; }
    }
}
