using UnityEngine;

public class DragWindow : MonoBehaviour
{
    public Vector2 mouseWorldPosition; //adjusting the mouse position from pixels to unity units  
    public Vector2 goalPosition; //Where we want our window to go 
    public Vector2 direction;
    public float speed;
    public float minX, maxX, minY, maxY; // Define your window limits

    void Update()
    {
        //ADJUST THE MOUSE POSITION FOR THE SCREEN POSITION 
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //DISTANCE BETWEEN WHERE YOU ARE & WHERE YOU WANT TO GO = DIRECTION 
        direction = mouseWorldPosition - (Vector2)transform.position;
    }

    void OnMouseDown()
    {
        //SortingLayer 
    }
    void OnMouseDrag()
    {
        Debug.Log("Mouse drag");
        direction.Normalize(); // makes the bug always move at the same speed instead of faster when further away and slower when closer
        transform.position += (Vector3)direction * speed * Time.deltaTime; 

        // //Clamp the mouse to your screen 
        // Vector3 currentPosition = transform.position;
        // currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
        // currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY); 

    }
}

