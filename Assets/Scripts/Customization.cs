using UnityEngine;
using UnityEditor;

public class Customization : MonoBehaviour
{
    [SerializeField] private GameObject choiceeye1;
    [SerializeField] private GameObject choiceeye2;
    [SerializeField] private GameObject choicemounth1;
    [SerializeField] private GameObject choicemounth2;
    [SerializeField] private GameObject prefabplayer;
    [SerializeField] private GameObject[] eye;
    [SerializeField] private GameObject[] mounth;

    public void Eyes()
    {
        choiceeye1.SetActive(true);
        choiceeye2.SetActive(true);
        choicemounth1.SetActive(false);
        choicemounth2.SetActive(false);
    }

    public void Mounths()
    {
        choicemounth1.SetActive(true);
        choicemounth2.SetActive(true);
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

    public void ChangeMounth(GameObject select)
    {
        foreach (GameObject go in mounth)
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
