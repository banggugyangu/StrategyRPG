using UnityEngine;
using System.Collections;

public class BaseSquireClass : BaseCharacterClass {

	public BaseSquireClass(){
        CharacterClassName = "Squire";
        CharacterClassDescription =  "A knight's apprentice.";
        Health = 70;
        Strength = 13;
        Vitality = 13;
        Intelligence = 9;
        Resistance = 9;
        Agility = 8;
        Speed = 0;
        Leadership = 35;
        Morality = 65;
        Luck = 50;
    }
}
