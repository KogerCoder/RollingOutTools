﻿using System;
using System.Globalization;
using System.Threading.Tasks;

namespace RollingOutTools.Localization
{
    public class GoogleTranslateLocalizationService : ILocalizationService
    {
        public GoogleTranslateLocalizationService()
        {
           
        }

        public async Task<string> GetTranslated(string sourceString, CultureInfo sourceCultureInfo, CultureInfo translateCultureInfo)
        {

            throw new NotImplementedException();
        }
    }
}
