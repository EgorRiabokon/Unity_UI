using UnityEngine;
using System.Collections;

public class TurnColorScript : MonoBehaviour
{
    public void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}

