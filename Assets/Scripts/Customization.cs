using UnityEngine;
using UnityEditor;

public class Customization : MonoBehaviour
{
    [SerializeField] private GameObject choiceeye1;
    [SerializeField] private GameObject choiceeye2;
    [SerializeField] private GameObject choicemouth1;
    [SerializeField] private GameObject choicemouth2;
    [SerializeField] private GameObject prefabplayer;
    [SerializeField] private GameObject[] eye;
    [SerializeField] private GameObject[] mounth;
    [SerializeField] private GameObject[] sIndicatorEye;
    [SerializeField] private GameObject[] sIndicatorMouth;

    public void Eyes()
    {
        choiceeye1.SetActive(true);
        choiceeye2.SetActive(true);
        choicemouth1.SetActive(false);
        choicemouth2.SetActive(false);
    }

    public void Mounths()
    {
        choicemouth1.SetActive(true);
        choicemouth2.SetActive(true);
        choiceeye1.SetActive(false);
        choiceeye2.SetActive(false);
    }
    
    public void ChangeEye(GameObject select)
    {
        foreach (GameObject go in eye)
        {
            go.SetActive(false);
        }
        select.SetActive(true);
    }

    public void SelectEye(GameObject select)
    {
        foreach (GameObject go in sIndicatorEye)
        {
            go.SetActive(false);
        }
        select.SetActive(true);
    }

    public void ChangeMounth(GameObject select)
    {
        foreach (GameObject go in mounth)
        {
            go.SetActive(false);
        }
        select.SetActive(true);
    }

    public void SelectMouth(GameObject select)
    {
        foreach (GameObject go in sIndicatorMouth)
        {
            go.SetActive(false);
        }
        select.SetActive(true);
    }

    public void SavePrefab()
    {
        if (prefabplayer != null)
        {
            string path = "Assets/Prefabs/" + "NewPlayer" + ".prefab";
            PrefabUtility.SaveAsPrefabAsset(prefabplayer, path);
        }
    }       
}
