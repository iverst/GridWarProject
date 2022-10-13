using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board 
{

    private int width, height;
    private Tile[,] tiles;
    public Board(int width, int height)
    {
        tiles = new Tile[height, width];
        this.height = height;
        this.width = width;
    }

}
