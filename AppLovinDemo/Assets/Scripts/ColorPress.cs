using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPress : MonoBehaviour
{
    [SerializeField] private Image _dynamicBackground;

    public void UpdateBackgroundColor()
    {
        float r = Random.Range(0.3f, 0.6f);
        float g = Random.Range(0.3f, 0.6f);
        float b = Random.Range(0.3f, 0.6f);
        Debug.Log($"=== NEWCOLOR: {r}, {g} {b}");
        Color newColor = new Color(r, g, b, 0.8f);
        _dynamicBackground.color = newColor;
    }
}