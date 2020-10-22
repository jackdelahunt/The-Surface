using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{

    public RecipeManager recipeManager;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("tick", 0f, 1f);
    }

    public void tick() {
        
        // execute whatver each building makes onceper building
        runRecipe(ResourceManager.getAmount("SolarPanel"), "Power");
        print(ResourceManager.getAmount("Power") + " : " + ResourceManager.getAmount("Water"));
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
