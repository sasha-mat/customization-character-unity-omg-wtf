using UnityEngine;
using UnityEditor;

public class Customization : MonoBehaviour
{
    [SerializeField] private GameObject viboreye1;
    [SerializeField] private GameObject viboreye2;
    [SerializeField] private GameObject vibormounth1;
    [SerializeField] private GameObject vibormounth2;
    [SerializeField] private GameObject eye1;
    [SerializeField] private GameObject eye2;
    [SerializeField] private GameObject mounth1;
    [SerializeField] private GameObject mounth2;
    [SerializeField] private GameObject prefabigrok;

    public void viboreye()
    {
        viboreye1.SetActive(true);
        viboreye2.SetActive(true);
        vibormounth1.SetActive(false);
        vibormounth2.SetActive(false);
    }

    public void vibormounth()
    {
        vibormounth1.SetActive(true);
        vibormounth2.SetActive(true);
        viboreye1.SetActive(false);
        viboreye2.SetActive(false);
    }


    
    //public void Change(GameObject select)
    //{
        //foreach (GameObject go in massiv)
        //{
           // go.SetActive(false);
        //}

        //select.SetActive(true);
    //}
    
    public void oneye1()
    {
        eye1.SetActive(true);
        eye2.SetActive(false);
    }

    public void oneye2()
    {
        eye1.SetActive(false);
        eye2.SetActive(true);
    }
    
    public void onmounth1()
    {
        mounth1.SetActive(true);
        mounth2.SetActive(false);
    }

    public void onmounth2()
    {
        mounth1.SetActive(false);
        mounth2.SetActive(true);
    }

    public void sohraneniye()
    {
        if (prefabigrok != null)
        {
            string path = "Assets/Prefabs/" + "NewIgrok" + ".prefab";
            PrefabUtility.SaveAsPrefabAsset(prefabigrok, path);
        }
    }       
}
