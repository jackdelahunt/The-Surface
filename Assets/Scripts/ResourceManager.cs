﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ResourceManager
{
    private static Dictionary<string, int> inventory = new Dictionary<string, int>(){
        {"Iron", 0},
        {"Oxygen", 0},
        {"Power", 0},
        {"Water", 0},
        {"Manpower", 0},
    };

    public static bool addToInventory(string type, int amount) {

        if(inventory.ContainsKey(type)) {
            inventory[type] += amount;
            return true;
        }
        else
            return false;
    }

    public static bool takeFromInventory(string type, int amount) {
        
        int value = canTake(type, amount);
        if(value >= 0) {
            inventory[type] = value - amount;
            return true;
        }

        return false;
    }
    public static int canTake(string type, int amount) {

        int value = getAmount(type);
        if(value > 0) {
            if(amount - value >= 0)
                return value;
            else
                return -1;
        }
        return -1;

    }

    public static int getAmount(string type) {
        int value;
        if(inventory.TryGetValue(type, out value)) {
            return value;
        } else {
            return -1;
        }
    }
}
