using UnityEngine;
using System.Collections;

public class BaseCharacterClass {

	private string characterClassName;
	private string characterClassDescription;

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
	private string frontLine;
	private int frontLineCount;
	private string backLine;
	pricate int backLineCount;

	public string CharacterClassName {
		get{ return characterClassName;}
		set{ characterClassName = value;}
	}
	public string CharacterClassDescription {
		get{ return characterClassDescription;}
		set{ characterClassDescription = value;}
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
    public int FrontLine{
        get{return frontLine;}
        set{frontLine = value;}
    }
    public int FrontLineCount{
        get{return frontLineCount;}
        set{frontLineCount = value;}
    }
    public string BackLine{
        get{return backLine;}
        set{backLine = value;}
    }
    public int BackLineCount{
        get{return backLineCount;}
        set{backLineCount = value;}
    }

}
