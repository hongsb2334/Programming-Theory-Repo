using UnityEngine;

public class CubeShape : Shape
{
    

    private void Awake()
    {
        ShapeName = "Cube";
        ShapeColor = Color.red;
    }
    public override void DisplayText()      //POLYMORPHISM
    {
        Debug.Log($"this is a {ShapeName}. It's strong and solid.");
    }
    
}
