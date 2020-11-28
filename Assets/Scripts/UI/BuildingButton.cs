using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildingButton : MonoBehaviour
{
    [SerializeField]private RecipeManager recipeManager;
    [SerializeField]private TMP_Text buttonText;

    public void click() {
        string text = buttonText.text;
        Recpie recpie = recipeManager.getRecpie(text);
        ResourceManager.runRecipe(1, recipeManager.getRecpie(buttonText.text), validate:true);
    }
}
