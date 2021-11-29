using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public GameObject subMenu;
    public GameObject smCredits;
    public GameObject smOptions;
   public Text tTitle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void SubMenu(){
        if (subMenu.activeInHierarchy == false)
        {
            tTitle.text = EventSystem.current.currentSelectedGameObject.name;
            if (tTitle.text == "Credits")
            {
smCredits.SetActive(true);
            }
            else{
                smOptions.SetActive(true);
            }
          
            subMenu.SetActive(true);
        }
        else //jika sub menu active / true
        {
                   if (tTitle.text == "Credits")
            {
smCredits.SetActive(false);
            }
            else{
                smOptions.SetActive(false);
            }
            subMenu.SetActive(false);

        }
    }
    public void ExitGame()
    {
        Application.Quit(); 
    }
}
