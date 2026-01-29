using UnityEngine;

public class CapsuleShape : Shape
{
    private void Awake()
    {
        ShapeName = "Capsule";
        ShapeColor = Color.blue;
    }

    public override void DisplayText() // POLYMORPHISM
    {
        Debug.Log($"This is a {ShapeName}. It's tall and flexible.");
    }
}
