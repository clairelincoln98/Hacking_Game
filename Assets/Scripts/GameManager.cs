using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 mouseScreenPosition;
    public Vector2 mouseWorldPosition;

    void Update()
    {
        mouseScreenPosition = Input.mousePosition; 
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
}
