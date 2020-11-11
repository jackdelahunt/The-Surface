using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotManager : MonoBehaviour
{
    public int getNumberOfBots() {
        return transform.childCount;
    }
}
