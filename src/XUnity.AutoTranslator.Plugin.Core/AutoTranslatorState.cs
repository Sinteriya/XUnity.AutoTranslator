﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnity.AutoTranslator.Plugin.Core.Configuration;

namespace XUnity.AutoTranslator.Plugin.Core
{
   public static class AutoTranslatorState
   {
      public static int TranslationCount => Settings.TranslationCount;
   }
}