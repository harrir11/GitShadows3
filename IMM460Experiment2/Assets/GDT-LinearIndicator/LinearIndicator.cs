using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearIndicator : MonoBehaviour
{
    public enum Orientation
    {
        Horizontal,
        Vertical
    }
    [SerializeField]
    public Orientation orientation;
    [SerializeField]
    public bool reverse;

    public Color fillColor=Color.green;
    public bool useTwoColors;
    public Color emptyColor = Color.red;

    private UnityEngine.UI.Image indicatorImage;
    public float minValue, maxValue;
    private float currentValue,currentScale;
    [SerializeField]
    private RectTransform valueIndicator;

    void Awake()
    {
        indicatorImage = valueIndicator.GetComponent<UnityEngine.UI.Image>();
        indicatorImage.color = fillColor;
        if (reverse)
        {
            valueIndicator.pivot = Vector2.one;
        }
        else
        {
            valueIndicator.pivot = Vector2.zero;
        }

    
    }

    void Update()
    {


    }

    public void SetupIndicator(float minValue, float maxValue)
    {
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public void SetOrientation(Orientation o)
    {
        orientation = o;
    }


    public void SetValue(float v)
    {
        currentValue = Mathf.Clamp(v,minValue,maxValue);
        currentScale = (currentValue - minValue) / (maxValue - minValue);

        if (useTwoColors)
        {
            indicatorImage.color = Color.Lerp(emptyColor,fillColor,currentScale);
        }

        if (reverse)
        {
            valueIndicator.pivot = Vector2.one;
        }
        else
        {
            valueIndicator.pivot = Vector2.zero;
        }

        switch (orientation)
        {
            case Orientation.Horizontal:
                valueIndicator.localScale = Vector3.right * currentScale + Vector3.up+Vector3.forward;
                break;
            case Orientation.Vertical:
                valueIndicator.localScale = Vector3.up * currentScale + Vector3.forward+Vector3.right;
                break;

        }

    }

}
