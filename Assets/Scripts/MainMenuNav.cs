using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNav : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void playGame()
    {
        int selectedCharacter=
        int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        
        GameManager.instance.CharIndex=selectedCharacter;
        SceneManager.LoadScene("Gameplay");
    }
}
