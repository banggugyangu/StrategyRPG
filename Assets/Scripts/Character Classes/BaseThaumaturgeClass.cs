using UnityEngine;
using System.Collections;

public class BaseApprenticeMageClass : BaseCharacterClass {

	public BaseApprenticeMageClass(){
        CharacterClassName = "Apprentice Mage";
        CharacterClassDescription = "An aspiring magician, unsure in his own magicks.";
        Health = 60;
        Strength = 5;
        Vitality = 7;
        Intelligence = 16;
        Resistance = 14;
        Agility = 10;
        Speed = 11;
        Leadership = 65;
        Morality = 40;
        Luck = 25;
        FrontLine = "Battle Magic";
        FrontLineCount = 2;
        BackLine = "Superior Magic";
        BackLineCount = 3;
    }
}
