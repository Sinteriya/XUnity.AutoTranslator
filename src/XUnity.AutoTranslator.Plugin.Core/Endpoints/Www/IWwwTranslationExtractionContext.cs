﻿namespace XUnity.AutoTranslator.Plugin.Core.Endpoints.Www
{
   /// <summary>
   /// Interface used in the context of extracting a translated text from a web response.
   /// </summary>
   public interface IWwwTranslationExtractionContext : IWwwTranslationContext
   {
      /// <summary>
      /// Gets the response data provided by the web response.
      /// </summary>
      string ResponseData { get; }

      /// <summary>
      /// Completes the translation by providing the translated text.
      /// </summary>
      /// <param name="translatedText"></param>
      void Complete( string translatedText );

      /// <summary>
      /// Completes the translation by providing the translated texts.
      ///
      /// The indices of the translations must match the indices of the
      /// untranslated texts.
      /// </summary>
      /// <param name="translatedTexts"></param>
      void Complete( string[] translatedTexts );
   }
}
