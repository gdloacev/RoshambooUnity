using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

internal class MessageManager: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;

    private void Awake()
    {
        EventManager.OnSendedMessage += ShowMessage;
    }

    private void ShowMessage(string message) { 
        messageText.SetText(message);
    }

}
