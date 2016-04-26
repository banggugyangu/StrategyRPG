using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass(){
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A battle-hardened warrior.";
        Health = 75;
        Strength = 17;
        Vitality = 12;
        Intelligence = 6;
        Resistance = 7;
        Agility = 8;
        Speed = 0;
        Leadership = 55;
        Morality = 50;
        Luck = 50;
    }
}
