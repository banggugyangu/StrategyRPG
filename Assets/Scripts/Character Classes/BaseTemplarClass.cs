using UnityEngine;
using System.Collections;

public class BaseTemplarClass : BaseCharacterClass {

	public BaseTemplarClass(){
        CharacterClassName = "Templar";
        CharacterClassDescription = "A selfless protector and leader.";
        Health = 65;
        Strength = 15;
        Vitality = 19;
        Intelligence = 11;
        Resistance = 15;
        Agility = 19;
        Speed = 0;
        Leadership = 70;
        Morality = 70;
        Luck = 50;
        FrontLine = "Fortify";
        FrontLineCount = 3;
        BackLine = "Heal";
        BackLineCount = 2;
    }
}
