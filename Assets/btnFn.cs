using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFn : MonoBehaviour
{

    public void buttonFunction(string buttonLink)
    {
        Application.OpenURL(buttonLink);
    }
}
