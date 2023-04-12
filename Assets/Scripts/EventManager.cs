using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class EventManager
{
    #region "Events"
    public delegate void ClickWeapon(int userWeapon);
    public static event ClickWeapon OnClickedWeapon;

    public delegate void SendMessage(string message);
    public static event SendMessage OnSendedMessage;
    #endregion

    #region "Triggers"
    public static void OnClickWeapon(int userWeapon) {
        if (OnClickedWeapon != null) { 
            OnClickedWeapon(userWeapon);
        }
    }

    public static void OnSendGameMessage(string message)
    {
        if (OnSendedMessage != null)
        {
            OnSendedMessage(message);
        }
    }
    #endregion
}

