using UnityEngine;

public class TVOnCommand : MonoBehaviour, ICommand
{
    public tv TVSet;
    public Color _color;
    public int Test;
    
    public TVOnCommand(tv tvset, Color col)
    {
        TVSet = tvset;
        _color = col;
    }
    
    public void Execute()
    {
        TVSet.On(_color);
    }

    public void Undo()
    {
        TVSet.Off(_color);
    }
}
