using UnityEngine;

public abstract class Shape : MonoBehaviour     //INHERITANCE
{
    private string shapeName;
    private Color shapeColor;

    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }
    }   //ENCAPSULATION

    public Color ShapeColor
    {
        get { return shapeColor; }
        set
        {
            shapeColor = value;
            GetComponent<Renderer>().material.color = shapeColor;
        }
    }   //ENCAPSULATION 

    public void Start()
    {
        ApplyColor();
    }

    protected void ApplyColor() //ABSTRACTION
    {
        GetComponent<Renderer>().material.color = shapeColor;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
    public abstract void DisplayText();
}


