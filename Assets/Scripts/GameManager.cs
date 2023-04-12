using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Collections;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private int computerWeapon;

    private void Awake()
    {
        EventManager.OnClickedWeapon += Play;
    }

    private void Play(int userWeapon) {
        computerWeapon = ComputerChoose();

        Debug.Log($"User: {Enum.Parse(typeof(Weapons), userWeapon.ToString())}");
        Debug.Log($"Computer: {Enum.Parse(typeof(Weapons), computerWeapon.ToString())}");

        if (userWeapon == computerWeapon)
        {
            SendMessage((int)Winners.Draw);
        }
        else {
            switch (userWeapon) {
                case (int)Weapons.Rock:
                    if (computerWeapon == (int)Weapons.Scissors)
                    {
                        SendMessage((int)Winners.User);
                    }
                    else { 
                        SendMessage((int)Winners.Computer);
                    }
                    break;
                case (int)Weapons.Paper:
                    if (computerWeapon == (int)Weapons.Rock)
                    {
                        SendMessage((int)Winners.User);
                    }
                    else
                    {
                        SendMessage((int)Winners.Computer);
                    }
                    break;
                case (int)Weapons.Scissors:
                    if (computerWeapon == (int)Weapons.Paper)
                    {
                        SendMessage((int)Winners.User);
                    }
                    else
                    {
                        SendMessage((int)Winners.Computer);
                    }
                    break;
                default:
                    break;
            }
        }
    }

    private void SendMessage(int winner)
    {
        string winMsg = String.Empty;
        switch (winner) {
            case (int)Winners.Draw:
                winMsg = "Draw!!, Play Again!";
                break;
            case (int)Winners.User:
                winMsg = "You Win!!, Congratulations!!";
                break;
            case (int)Winners.Computer:
                winMsg = "Computer Win!, Try Again! :(";
                break;
            default:
                break;
        }
        Debug.Log(winMsg);
        EventManager.OnSendGameMessage($"Computer Weapon: {Enum.Parse(typeof(Weapons), computerWeapon.ToString())}\n {winMsg}");
    }

    private int ComputerChoose() {
        return Random.Range(0, 3);
    }
}
