using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Test_HoU;

public class CharacterObject : MonoBehaviour
{

    private Character charac;
    public GameObject obj { get; set; }
    private Sprite sprite;
    public string CharacterName { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacInit(GameObject parent, int characId)
    {
        obj = new GameObject();

        switch (characId)
        {
            case (3):
                charac = new Vesperz();
                sprite = Resources.Load<Sprite>("Images/Character_3_sprite");
                break;
            default:
                charac = new Character();
                sprite = Resources.Load<Sprite>("Images/Character_0_sprite");
                break;
        }

        obj.transform.SetParent(parent.transform, false);
        obj.transform.localPosition = Vector3.zero;
        obj.SetActive(true);

        CharacterName = charac.Name;
        obj.AddComponent<Image>();
        obj.GetComponent<Image>().sprite = sprite;
    }

    public override string ToString()
    {
        return charac.ToString();
    }
}
