using System;
using System.Linq;
using DilmerGames.Core.Singletons;
using TMPro;
using UnityEngine;

/*
  Estos realmente no sirven en esta aplicación, pero se imprimen en la pantalla
  para mostrar qué datos se pueden utilizar simplemente para capturar el evento
  de dibujos en pantalla táctil en este caso.
*/

public class ARDebugManager : Singleton<ARDebugManager>
{   
    [SerializeField]
    private TextMeshProUGUI debugAreaText = null;

    [SerializeField]
    private bool enableDebug = false;

    [SerializeField]
    private int maxLines = 8;

    void OnEnable() 
    {
        debugAreaText.enabled = enableDebug;
        enabled = enableDebug;
    }

    public void LogInfo(string message)
    {
        ClearLines();
        debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M HH:mm:ss")}: <color=\"white\">{message}</color>\n";
    }

    public void LogError(string message)
    {
        ClearLines();
        debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M HH:mm:ss")}: <color=\"red\">{message}</color>\n";
    }

    public void LogWarning(string message)
    {
        ClearLines();
        debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M HH:mm:ss")}: <color=\"yellow\">{message}</color>\n";
    }

    private void ClearLines()
    {
        if(debugAreaText.text.Split('\n').Count() >= maxLines)
        {
            debugAreaText.text = string.Empty;
        }
    }
}