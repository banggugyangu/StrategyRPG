using UnityEngine;
using System.Collections;

public class BaseUnit {

	private string unitName;
    private int unitLevel;
    private BaseCharacterClass unitClass;
    //stats
	private int health;
	private int strength;
	private int vitality;
	private int intelligence;
    private int resistance;
	private int agility;
	private int speed;
	private int leadership;
	private int morality;
	private int luck;
	private int experience;

	public string UnitName {
		get{ return unitName;}
		set{ unitName = value;}
	}
	public int UnitLevel {
		get{ return unitLevel;}
		set{ unitLevel = value;}
    }
    public BaseCharacterClass UnitClass{
        get{return unitClass;}
        set{unitClass = value;}
    }

	public int Health {
		get{ return health;}
		set{ health = value;}
	}
	public int Strength {
        get{return strength;}
        set{strength = value;}
	}
    public int Vitality{
        get{return vitality;}
        set{vitality = value;}
    }
    public int Intelligence{
        get{return intelligence;}
        set{intelligence = value;}
    }
    public int Resistance{
        get{return resistance;}
        set{resistance = value;}
    }
    public int Agility{
        get{return agility;}
        set{agility = value;}
    }
    public int Speed{
        get{return speed;}
        set{speed = value;}
    }
    public int Leadership{
        get{return leadership;}
        set{leadership = value;}
    }
    public int Morality{
        get{return morality;}
        set{morality = value;}
    }
    public int Luck{
        get{return luck;}
        set{luck = value;}
    }
    public int Experience{
        get{return experience;}
        set{experience = value;}
    }
}
