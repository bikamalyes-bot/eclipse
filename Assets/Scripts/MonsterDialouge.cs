using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MonsterDialogue : MonoBehaviour
{
    
private MonsterDialogueType _monsterDialogueType;
public MonsterDialogueType MonsterDialogueT { get { return _monsterDialogueType; } private set { } }
[SerializeField] GameObject dialogueUI;
[SerializeField] TextMeshProUGUI dialogueText;
[SerializeField] Button skipButton;

[SerializeField] Button button1;
[SerializeField] TextMeshProUGUI buttomText1;
[SerializeField] Button button2;
[SerializeField] TextMeshProUGUI buttomText2;
[SerializeField] Button button3;
[SerializeField] TextMeshProUGUI buttomText3;


   [SerializeField] string helloDialogueMTP =  "Привет, кто ты? я монстр";
 

private int index = 0;

public void Skip()
{
    dialogueUI.SetActive(false);
}

public void StartDialogue()
{
    switch (_monsterDialogueType)
    {
        case MonsterDialogueType.hello:
            dialogueText.text = helloDialogueMTP;
            buttonText1.text = "answer1";
            buttonText2.text = "answer2";
            buttonText3.text = "answer3";
            break;
        case MonsterDialogueType.problem:
            break;
        case MonsterDialogueType.problemBranching1:
            break;
        case MonsterDialogueType.problemBranching2:
            break;
        case MonsterDialogueType.problemBranching3:
            break;
        case MonsterDialogueType.ending1:
            break;
        case MonsterDialogueType.ending2:
            break;
        case MonsterDialogueType.ending3:
            break;
        default:
            break;
    }
    dialogueUI.SetActive(true);
    index = 0;
    dialogueText.text = helloDialogueMTP[index];
}   

    public void ChangeMonsterDialogueType(MonsterDialogueType type)
    {
        _monsterDialogueType = type;
    }

    public void SetDialouge () 
    {

    }

}