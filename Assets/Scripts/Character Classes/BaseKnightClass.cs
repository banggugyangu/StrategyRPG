using UnityEngine;
using System.Collections;

public class BaseKnightClass : BaseCharacterClass {

	public BaseKnightClass(){
        CharacterClassName = "Knight";
        CharacterClassDescription = "A noble warrior and protector.";
        Health = 80;
        Strength = 15;
        Vitality = 17;
        Intelligence = 9;
        Resistance = 11;
        Agility = 11;
        Speed = 0;
        Leadership = 55;
        Morality = 65;
        Luck = 50;
        FrontLine = "Fortify";
        FrontLineCount = 2;
        BackLine = "Slice";
        BackLineCount = 1;
    }
}
