using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    [SerializeField]private Recpie[] recpies;

    public Recpie getRecpie(string name) {
        foreach(Recpie recpie in recpies) {
            if(recpie.name.Equals(name))
                return recpie;
        }

        return null;
    }
}
