﻿namespace RetailApp.ViewModels.Fiscal
{
    public class ICMS70 : ICMSBase
    {
        public string modBC { get; set; } = default!;
        public string pRedBC { get; set; } = default!;
        public decimal vBC { get; set; } = default!;
        public string pICMS { get; set; } = default!;
        public decimal vICMS { get; set; } = default!;
        public string modBCST { get; set; } = default!;
        public string pMVAST { get; set; } = default!;
        public decimal vBCST { get; set; } = default!;
        public string pICMSST { get; set; } = default!;
        public decimal vICMSST { get; set; } = default!;
        public decimal vICMSDeson { get; set; } = default!;
    }
}