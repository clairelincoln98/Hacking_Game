using UnityEngine;

public class EmailSelect : MonoBehaviour
{
    public GameObject[] emails;
    public int Number = 0;

    public void ChangeCharacter(int Num)
    {
        // Disable all emails
        for (int i = 0; i < emails.Length; i++)
        {
            emails[i].SetActive(false);
        }

        // Change index
        Number += Num;

        // Wrap forward
        if (Number >= emails.Length)
        {
            Number = 0;
        }
        // Wrap backward
        else if (Number < 0)
        {
            Number = emails.Length - 1;
        }

        // Enable selected email
        emails[Number].SetActive(true);
    }
}
