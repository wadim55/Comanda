using UnityEngine;

public class tv : MonoBehaviour
{
    public void On(Color col)
    {
        GetComponent<SpriteRenderer>().color = col;
    }

    public void Off(Color col)
    {
        GetComponent<SpriteRenderer>().color = col;
    }
}
