using UnityEngine;
using UnityEngine.UI;

public class MonsterInteraction : MonoBehaviour
{
    public GameObject pressE_UI;       // pressE_UI"
    public MonsterDialogue dialogue;   // dialouge script


    private bool isPlayerNear = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            pressE_UI.SetActive(false);
            dialogue.StartDialogue();  
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            pressE_UI.SetActive(true); // "E" UI
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            pressE_UI.SetActive(false); // hide "E"
        }
    }
}