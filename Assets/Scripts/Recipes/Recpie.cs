using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "The-Surface/Recipe")]
public class Recpie : ScriptableObject
{
    public string recipeName;
    public string[] ingredients;
    public int[] amounts;
    public int yeld;
}
