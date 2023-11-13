﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SocialNet.ViewModels
{
    public enum Months
    {
        [Display(Name = "Январь")]
        Jan = 1,
        [Display(Name = "Февраль")]
        Feb = 2,
        [Display(Name = "Март")]
        Mar = 3,
        [Display(Name = "Апрель")]
        Arp = 4,
        [Display(Name = "Май")]
        May = 5,
        [Display(Name = "Июнь")]
        Jal = 6,
        [Display(Name = "Июль")]
        Jul = 7,
        [Display(Name = "Август")]
        Aug = 8,
        [Display(Name = "Сентябрь")]
        Sep = 9,
        [Display(Name = "Октябрь")]
        Oct = 10,
        [Display(Name = "Ноябрь")]
        Nov = 11,
        [Display(Name = "Декабрь")]
        Dec = 12,
    }
}