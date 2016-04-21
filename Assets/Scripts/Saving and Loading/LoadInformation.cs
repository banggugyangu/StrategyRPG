using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation(){
		GameInformation.UnitName = PlayerPrefs.GetString ("UNITNAME");
		GameInformation.UnitLevel = PlayerPrefs.GetInt ("UNITLEVEL");
		GameInformation.Health = PlayerPrefs.GetInt ("HEALTH");
		GameInformation.Strength = PlayerPrefs.GetInt ("STRENGTH");
		GameInformation.Vitality = PlayerPrefs.GetInt ("VITALITY");
		GameInformation.Intelligence = PlayerPrefs.GetInt ("INTELLIGENCE");
		GameInformation.Resistance = PlayerPrefs.GetInt ("RESISTANCE");
		GameInformation.Agility = PlayerPrefs.GetInt ("AGILITY");
		GameInformation.Speed = PlayerPrefs.GetInt ("SPEED");
		GameInformation.Leadership = PlayerPrefs.GetInt ("LEADERSHIP");
		GameInformation.Morality = PlayerPrefs.GetInt ("MORALITY");
		GameInformation.Luck = PlayerPrefs.GetInt ("LUCK");
		GameInformation.Experience = PlayerPrefs.GetInt ("EXPERIENCE");
	}
}
