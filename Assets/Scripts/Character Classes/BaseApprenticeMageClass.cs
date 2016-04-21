using UnityEngine;
using System.Collections;

public class BaseApprenticeMageClass : BaseCharacterClass {

	public BaseApprenticeMageClass(){
        CharacterClassName = "Apprentice Mage";
        CharacterClassDescription = "An aspiring magician, unsure in his own magicks.";
        Health = 60;
        Strength = 5;
        Vitality = 7;
        Intelligence = 12;
        Resistance = 10;
        Agility = 7;
        Speed = 6;
        Leadership = 65;
        Morality = 45;
        Luck = 25;
    }
}
