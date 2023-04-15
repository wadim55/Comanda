using UnityEngine;

public class TVOnCommand : MonoBehaviour, ICommand
{
    public GameObject kubik;
    public tv TVSet;
    public Color _color;
    public Vector2 Pos;
    public GameObject ActiveKubik;
    
    public TVOnCommand(tv tvset, Color col, Vector2 pos, GameObject Kubik)
    {
        TVSet = tvset;
        _color = col;
         Pos = pos;
       
    }
    
    public void Execute()
    {
        TVSet.On(_color, Pos);
       ActiveKubik = Instantiate(kubik, new Vector2(Random.Range(-8, 8), Random.Range(-5, 5)), Quaternion.identity);
    }

    public void Undo()
    {
        TVSet.Off(_color, Pos);
        Destroy(ActiveKubik);
    }
}
