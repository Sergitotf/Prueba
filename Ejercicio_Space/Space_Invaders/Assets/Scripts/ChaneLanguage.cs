using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChaneLanguage : MonoBehaviour
{
    int idioma = 0;
   
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            idioma++;
            if(idioma > 1)
            {
                idioma = 0;
            }
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idioma];
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            idioma--;
            if (idioma > 0)
            {
                idioma = 1;
            }
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idioma];
        }
    }
}
