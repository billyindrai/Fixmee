﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction 
{
	X,
	Y,
	NX,
	NY
}

[System.Serializable]
public class LevelDefinition
{
	public int numRows;
	public int numColumns;
	public string name;
	public Vector2 botPos;
	public Direction dir = Direction.X;

	public Tile[,] board;

	public Vector2 getDirectionFromEnum ()
	{
		Vector2 direction = Vector2.zero;

		switch (dir)
		{
			case Direction.X:
				direction = Vector2.right;
				break;
			case Direction.Y:
				direction = Vector2.up;
				break;
			case Direction.NX:
				direction = Vector2.left;
				break;
			case Direction.NY:
				direction = Vector2.down;
				break;
		}

		return direction;
	}

	public LevelDefinition Clone()
	{
		LevelDefinition newLevel = new LevelDefinition ();
		newLevel.name = name;
		newLevel.numRows = numRows;
		newLevel.numColumns = numColumns;
		newLevel.botPos = botPos;

		newLevel.board = new Tile[numRows, numColumns];

		for (int i = 0; i < numRows; i++)
		{
			for (int j = 0; j < numColumns; j++)
			{
				newLevel.board[i,j] = board[i,j];
			}
		}

		return newLevel;
	}

	public override string ToString ()
	{
		string toString = "";

		toString += "NumRows: " + numRows + "\n";
		toString += "NumColumns: " + numColumns + "\n";
		toString += "Name: " + name + "\n";
		toString += "BotPos: " + botPos + "\n";

		toString += "Board: \n";

		for (int i = 0; i < numRows; i++)
		{
			for (int j = 0; j < numColumns; j++)
			{
				toString += board [i, j].ToString ();
			}

			toString += "\n";
		}

		return toString;
	}
}
