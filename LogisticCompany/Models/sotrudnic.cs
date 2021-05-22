using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticCompany.Models
{
    public class sotrudnic
    {
        [Display(Name = "Возраст")]
        public short vozrast { get; set; }

        [Display(Name = "Пол")]
        public string pol { get; set; }

        [Display(Name = "Адрес")]
        public string adres { get; set; }

        [Display(Name = "Телефон")]
        public short telephon { get; set; }

        [Display(Name = "Паспортные данные")]
        public short Pasport_dan { get; set; }

        [Display(Name = "Код сотрудника")]
        public string ID { get; set; }

        [Display(Name = "ФИО")]
        public string Fio { get; set; }
    }
}
