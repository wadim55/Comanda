
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public pult myPult;
    public tv myTv;
    private TVOnCommand _comand;
    private List<TVOnCommand> ListComands = new List<TVOnCommand>();
    private Color col1;
    private Color[] col = {Color.red, Color.blue, Color.black, Color.green, Color.yellow, Color.white, Color.grey};
    
    
    public void TvComandos()
    {
        col1 = col[Random.Range(0, 7)];
        _comand = new TVOnCommand(myTv, col1); 
        myPult.SetComand(_comand);
        myPult.PressButtonOn();
        ListComands.Add(_comand);
    }
  
    public void Otkat()
    {
        if (ListComands.Count <= 1) return;
        _comand = ListComands[ListComands.Count - 2];
        col1 = _comand._color;
        myPult.SetComand(_comand);
        myPult.PressButtonOn();
        ListComands.RemoveAt(ListComands.Count - 1);
    }
}
