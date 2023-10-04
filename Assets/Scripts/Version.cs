using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Version", menuName = "Version")]
public class Version : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] private string description;
    [SerializeField] private int ID;
    private int points;
    
    public int GetID()
    {
        return ID;
    }
    public string GetName()
    {
        return name;
    }
    public void AddPoint()
    {
        points++;
    }
    public int GetPoints()
    {
        return points;
    }
}
