using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ResourceManager
{
    private static Dictionary<string, float> inventory = new Dictionary<string, float>(){
        {"Iron", 50},
        {"Oxygen", 5},
        {"Power", 0},
        {"Water", 5},
        {"Manpower", 30},
        {"Ship Upgrade", 0},
        {"Mine", 0},
        {"Solar Panel", 1},
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

    public static void runRecipe(int amount, Recpie recpie, bool validate = false) {
        if(validate){
            Debug.Log(recpie.recipeName + " : validated");
        }
        if(recpie == null) {
            Debug.Log("Null Recipe");
            return;
        }
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

            addToInventory(recpie.recipeName, recpie.yeld);

            if(validate)
                Debug.Log("Successful craft of " + recpie.recipeName);

        }
    }
}
