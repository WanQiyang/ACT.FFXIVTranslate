﻿using System.Collections.Generic;
using System.Linq;
using ACT.FFXIVTranslate.localization;

namespace ACT.FFXIVTranslate.translate.bing
{
    internal class BingTranslateProviderFactory : ITranslaterProviderFactory
    {
        private readonly List<LanguageDef> _allSupportedLanguages = new[]
        {
            LanguageDef.BuildLangFromCulture("zh-CHS"),
            LanguageDef.BuildLangFromCulture("zh-CHT"),
            LanguageDef.BuildLangFromCulture("en"),
            LanguageDef.BuildLangFromCulture("ja"),
            LanguageDef.BuildLangFromCulture("de"),
            LanguageDef.BuildLangFromCulture("fr"),
        }.ToList();

        public string ProviderName { get; } = "Microsoft Translator";
        public bool SupportAutoDetect { get; } = true;
        public List<LanguageDef> SupportedSrcLanguages => _allSupportedLanguages;
        public List<LanguageDef> SupportedDestLanguages => _allSupportedLanguages;

        public ITranslateProvider CreateProvider(string apiKey, LanguageDef src, LanguageDef dst)
        {
            return new BingTranslateProvider(apiKey, src, dst);
        }
    }
}
