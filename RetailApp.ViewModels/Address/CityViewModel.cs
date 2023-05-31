﻿namespace RetailApp.ViewModels.Adress
{
    public class CityViewModel
    {
        public int IdCity { get; set; }
        public string CityName { get; set; } = default!;
        public string  State { get; set; } = default!;
        public CountryViewModel CountryViewModel { get; set; } = default!;
    }
}