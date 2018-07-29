
using UnityEngine;

public class PolygonColliderHover : MonoBehaviour
{

    // Use this for initialization
    private SpriteRenderer spriteRenderer;

    void OnMouseOver()
    {
        //spriteRenderer.color = Color.black;
        Debug.Log("Hovered");
    }

    void OnMouseExit()
    {
        //spriteRenderer.color = Color.white;
        Debug.Log("UnHovered");
    }
    private void OnMouseDown()
    {
        Debug.Log("Clicked");
    }
}