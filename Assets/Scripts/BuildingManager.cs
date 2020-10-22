using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

    public RecipeManager recipeManager;
    public GameObject resourceScreenObj;
    private ResourceScreen resourceScreen;

    // Start is called before the first frame update
    void Start()
    {
        resourceScreen = resourceScreenObj.GetComponent<ResourceScreen>();
        InvokeRepeating("tick", 0f, 1f);
    }

    public void tick() {
        
        // execute whatver each building makes onceper building
        runRecipe((int)ResourceManager.getAmount("SolarPanel"), "Power");
        runRecipe((int)ResourceManager.getAmount("Mine"), "Iron");
        runRecipe((int)(1 + ResourceManager.getAmount("ShipUpgrade")), "Oxygen");
        runRecipe(1, "Manpower");

        resourceScreen.tick();
    }

    public void runRecipe(int amount, string name) {
        if(!(amount > 0))
            return;

        Recpie recpie = recipeManager.getRecpie(name);

        if(recpie == null)
            return;

        ResourceManager.runRecipe(amount, recpie);
    }

}
