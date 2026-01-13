using UnityEngine;

public class App : MonoBehaviour
{
    public GameObject window;

    void OnMouseDown()
    {
        Debug.Log("App.OnMouseDown()");
        window.SetActive(true); 
    }
}
