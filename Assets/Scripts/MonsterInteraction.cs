using UnityEngine;
using UnityEngine.UI;

public class MonsterInteraction : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
public GameObject pressE_UI;
public MonsterDialogue dialogue;


private bool isPlayerNear = false;

void Update()
{
    if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
    {
        pressE_UI.SetActive(false);
        _gameManager.ChangeGameMode();
    }
}

private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        isPlayerNear = true;
        pressE_UI.SetActive(true);
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