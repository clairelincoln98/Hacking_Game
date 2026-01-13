using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject window;

    void OnMouseDown()
    {
        Debug.Log("Exit.OnMouseDown()");
        window.SetActive(false); 
    }
}
