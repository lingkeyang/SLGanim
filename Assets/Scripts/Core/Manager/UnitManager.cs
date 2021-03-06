﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnitManager : Singleton<UnitManager>
{
    //在Start后准备完毕
    public List<Unit> units;
    
    private void Start()
    {
        var temp = FindObjectsOfType<Unit>();
        foreach (var u in temp)
        {
            units.Add(u);
        }
    }

    public void AddUnit(Unit unit)
    {
        units.Add(unit);
        unit.UnitSelected += UIManager.GetInstance().OnUnitSelected;
        RoundManager.GetInstance().AddUnit(unit);
    }
}