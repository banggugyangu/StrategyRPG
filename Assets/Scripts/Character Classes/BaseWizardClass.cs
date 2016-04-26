using UnityEngine;
using System.Collections;

public class BaseWizardClass : BaseCharacterClass {

	public BaseWizardClass(){
        CharacterClassName = "Wizard";
        CharacterClassDescription = "A seasoned magician with powerful magicks.";
        Health = 60;
        Strength = 4;
        Vitality = 8;
        Intelligence = 14;
        Resistance = 11;
        Agility = 8;
        Speed = 9;
        Leadership = 65;
        Morality = 40;
        Luck = 25;
        FrontLine = "Basic Magic";
        FrontLineCount = 2;
        BackLine = "Magic";
        BackLineCount = 2;
    }
}
