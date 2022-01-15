using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;

public class speechInput : MonoBehaviour, IMixedRealitySpeechHandler
{

    public togglePanel TogglePannel;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealitySpeechHandler>(this);
    }

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)

    {

        switch (eventData.Command.Keyword.ToLower())

        {
            case "bild":
                TogglePannel.showPanel();
                break;
            case "video":
                TogglePannel.showPanel();
                break;
            case "sicherheit":
                TogglePannel.showPanel();
                break;
            case "text":
                TogglePannel.showPanel();
                break;
            case "ar":
                TogglePannel.showPanel();
                break;
            default:
                Debug.Log($"Unknown option { eventData.Command.Keyword}");
                break;
        }

    }


}
