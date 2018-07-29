using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class EcologyBuildings
{

    public string name;
	public bool isBuild;
	public bool isDestroyed;
	public int cost;

    public Sprite picture;

}
[System.Serializable]
public class ProductionBuildings
{
    public string name;
    public bool isBuild;
    public bool isDestroyed;
    public int cost;

    public Sprite picture;


}
[System.Serializable]
public class ScienceBuildings
{
    public string name;
    public bool isBuild;
    public bool isDestroyed;
    public int cost;

    public Sprite picture;
}
[System.Serializable]
public class ArmyBuildings
{
    public string name;
    public bool isBuild;
    public bool isDestroyed;
    public int cost;

    public Sprite picture;
}