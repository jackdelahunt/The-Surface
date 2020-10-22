using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ResourceManager
{
    private static Dictionary<string, float> inventory = new Dictionary<string, float>(){
        {"Iron", 10},
        {"Oxygen", 10},
        {"Power", 10},
        {"Water", 10},
        {"Manpower", 10},
        {"ShipUpgrade", 0},
        {"Mine", 2},
        {"SolarPanel", 1},
    };

    public static bool addToInventory(string type, float amount) {

        if(inventory.ContainsKey(type) && amount >= 0) {
            inventory[type] += amount;
            return true;
        }
        else
            return false;
    }

    public static bool takeFromInventory(string type, float amount) {
        
        float value = canTake(type, amount);
        if(value >= 0) {
            inventory[type] = value - amount;
            return true;
        }

        return false;
    }
    public static float canTake(string type, float amount) {

        float storage = getAmount(type);
        if(storage - amount >= 0) {
            return storage;
        }
        return -1;

    }

    public static float getAmount(string type) {
        float value;
        if(inventory.TryGetValue(type, out value)) {
            return value;
        } else {
            return -1;
        }
    }

    public static void runRecipe(int amount, Recpie recpie) {
        for(int i = 0; i < amount; i++) {
            
            // check for all ingredients first
            for(int index = 0; index < recpie.ingredients.Length; index++) {
                if(canTake(recpie.ingredients[index], recpie.amounts[index]) == -1) {
                    return;
                }
            }

            // then take what we need
            for(int index = 0; index < recpie.ingredients.Length; index++) {
                takeFromInventory(recpie.ingredients[index], recpie.amounts[index]);
            }

            addToInventory(recpie.name, recpie.yeld);

        }
    }
}
