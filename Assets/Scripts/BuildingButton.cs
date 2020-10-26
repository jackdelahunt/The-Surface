using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildingButton : MonoBehaviour
{
    [SerializeField]private RecipeManager recipeManager;
    [SerializeField]private TMP_Text text;

    public void click() {
        ResourceManager.runRecipe(1, recipeManager.getRecpie(text.text), validate:true);
    }
}
