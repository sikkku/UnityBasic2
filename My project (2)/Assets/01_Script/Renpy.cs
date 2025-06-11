using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG;
    [SerializeField] Image[] img_Character;

    [SerializeField] TextMeshProUGUI txt_Name;
    [SerializeField] TextMeshProUGUI txt_NameTitle;
    [SerializeField] TextMeshProUGUI txt_Dialogue;

    int id = 1;

  

    public void DialogueNext()
    {

        img_BG.sprite = Resources.Load<Sprite>("Img/BG_CraftChamber");


        int characterID = SData.GetDialogueData(id).Character;
        txt_Name.text = SData.GetCharacterData(characterID).Name;
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title;
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;


        if (id < img_Character.Length)
        {
            img_Character[4].sprite = Resources.Load<Sprite>("Img/Kazusa_00");
            img_Character[4].SetNativeSize();
            img_Character[4].gameObject.SetActive(true);
        }

        id++; 
    }
    public void OnClickButton()
    {
        id++;

    }
}