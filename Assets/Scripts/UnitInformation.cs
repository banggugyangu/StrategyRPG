using UnityEngine;
using System.Collections;

public class UnitInformation : BaseUnit {

	private int unitID = 1;
	private string unitName = "Test Character";
	private int unitLevel = 1;
	private string unitClass = "Knight";
	private string unitClassDescription = "A noble knight";
	private int health = 115;
	private int strength = 14;
	private int vitality = 16;
	private int intelligence = 10;
	private int resistance = 14;
	private int agility = 8;
	private int speed = 0;
	private int leadership = 65;
	private int morality = 55;
	private int luck = 45;
	private int experience = 56;

	public int UnitID{
		get{ return unitID;}
		set{ unitID = value;}
	}
	public string UnitName {
		get{ return unitName;}
		set{ unitName = value;}
	}
	public int UnitLevel {
		get{ return unitLevel;}
		set{ unitLevel = value;}
	}
	public string UnitClass{
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
