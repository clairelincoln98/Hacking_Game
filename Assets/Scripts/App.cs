using UnityEngine;

public class App : MonoBehaviour
{
    public GameObject window;
    public bool isSelected;
    void OnMouseDown()
    {
        Debug.Log("App.OnMouseDown()");
        window.SetActive(true);
        isSelected = true;
    }
}
