using UnityEngine;

public class SphereShape : Shape
{


    private void Awake()
    {
        ShapeName = "Sphere";
        ShapeColor = Color.green;
    }
    public override void DisplayText()  //POLYMORPHISM
    {
        Debug.Log($"This is a {ShapeName}. It's smooth and round.");
    }
    
}
