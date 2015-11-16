using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    //obj canvas
    public Canvas quitMenu;
    public Canvas startMenu;
    public Canvas optionMenu;

    //obj button
    public Button starButton;
    public Button optionButton;
    public Button exitButton;

	void Start () 
    {
        //selecção dos canvas no unity
        startMenu = startMenu.GetComponent<Canvas>();
        quitMenu = quitMenu.GetComponent<Canvas>();
        optionMenu = optionMenu.GetComponent<Canvas>();

        //selecção dos button no unity
        starButton = starButton.GetComponent<Button>();
        optionButton = optionButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();

        //Menu option/quit iniciam desligados
        quitMenu.enabled = false;
        optionMenu.enabled = false;
	}

    public void BacktoStart()
    {
        //desliga o menu de quit/options e liga o menu de start
        startMenu.enabled = true;
        quitMenu.enabled = false;
        optionMenu.enabled = false;

        //aciona os botoes do menu start
        starButton.enabled = true;
        optionButton.enabled = true;
        exitButton.enabled = true;

    }

    public void ExitPress()
    {
        //desliga o menu de start e liga o menu de quit
        startMenu.enabled = false;
        quitMenu.enabled = true;
        optionMenu.enabled = false;

        //desliga os butoes do menu start
        starButton.enabled = false;
        optionButton.enabled = false;
        exitButton.enabled = false;
   
    }
    public void OptionPress()
    {
        //desliga o menu de start/quit e liga o menu de option
        startMenu.enabled = false;
        quitMenu.enabled = false;
        optionMenu.enabled = true;

        //desliga os butoes do menu start
        starButton.enabled = false;
        optionButton.enabled = false;
        exitButton.enabled = false;
    }

    public void StartLevel()
    { 
        //inicio do jogo
    }

    public void Quit()
    {
        //o jogo fecha
        Application.Quit();
    }
	
}
