
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public pult myPult;
    public tv myTv;
    private TVOnCommand _comand;
    public List<TVOnCommand> ListComands = new List<TVOnCommand>();
    private Color col1;
    private Color[] col = {Color.red, Color.blue, Color.black, Color.green, Color.yellow, Color.white, Color.grey};
    private Vector2 move;
    private Vector2 undoMove;
    public GameObject PrefabCube;

    void Update()
    {

        if (Input.GetKeyDown("a"))
        {
            move = new Vector2(-1, 0);
            TvComandos();
        }

        if (Input.GetKeyDown("d"))
        {
            move = new Vector2(1, 0);
            TvComandos();
        }

        if (Input.GetKeyDown("s"))
        {
            move = new Vector2(0, -1);
            TvComandos();
        }

        if (Input.GetKeyDown("w"))
        {
            move = new Vector2(0, 1);
            TvComandos();
        }
    }
    
    public void TvComandos()
    {
        col1 = col[Random.Range(0, 7)];
        _comand = new TVOnCommand(myTv, col1, move, PrefabCube); 
        myPult.SetComand(_comand);
        myPult.PressButtonOn();
        ListComands.Add(_comand);
    }
  
    public void Otkat()
    {
        if (ListComands.Count < 1) return;
        _comand = ListComands[ListComands.Count - 1];
        col1 = _comand._color;
        undoMove = _comand.Pos * (-1);
        myPult.SetComand(_comand);
        myPult.PressButtonUndo();
        ListComands.RemoveAt(ListComands.Count - 1);
    }
}
