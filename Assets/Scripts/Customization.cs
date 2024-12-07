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
    [SerializeField] private GameObject galochkachoiceeyes;
    [SerializeField] private GameObject galochkachoicemouths;
    [SerializeField] private GameObject[] galochkaeye;
    [SerializeField] private GameObject[] galochkamouth;

    public void Eyes()
    {
        galochkachoiceeyes.SetActive(true);
        galochkachoicemouths.SetActive(false);
        choiceeye1.SetActive(true);
        choiceeye2.SetActive(true);
        choicemouth1.SetActive(false);
        choicemouth2.SetActive(false);
    }

    public void Mounths()
    {
        galochkachoiceeyes.SetActive(false);
        galochkachoicemouths.SetActive(true);
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

    public void GalochkaEye(GameObject select)
    {
        foreach (GameObject go in galochkaeye)
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
        foreach (GameObject go in galochkamouth)
        {
            go.SetActive(false);
        }
        select.SetActive(true);
    }

    public void GalochkaMouth(GameObject select)
    {
        foreach (GameObject go in galochkamouth)
        {
            go.SetActive(false);
        }
        select.SetActive(true);
    }

    public void sohraneniye()
    {
        if (prefabplayer != null)
        {
            string path = "Assets/Prefabs/" + "NewPlayer" + ".prefab";
            PrefabUtility.SaveAsPrefabAsset(prefabplayer, path);
        }
    }       
}
