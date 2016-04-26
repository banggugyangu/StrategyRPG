using UnityEngine;
using System.Collections;

public class BaseChampionClass : BaseCharacterClass {

	public BaseChampionClass(){
        CharacterClassName = "Champion";
        CharacterClassDescription = "A champion tested in multiple battles.";
        Health = 80;
        Strength = 19;
        Vitality = 14;
        Intelligence = 6;
        Resistance = 7;
        Agility = 11;
        Speed = 0;
        Leadership = 60;
        Morality = 45;
        Luck = 50;
    }
}
