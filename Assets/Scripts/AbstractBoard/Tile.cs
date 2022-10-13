using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    private int x, y;
    private Unit unit;
    private TileType type;


    public Tile(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Tile(int x, int y, Unit unit)
    {
        this.x = x;
        this.y = y;
        this.unit = unit;
    }


    public TileType Type {
        get
        {
            return type;
        }
    }

}

//*********************************************************************************//

public enum TileType
{
    hill, plain, moutain, highland
}