using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PrefabManager prefabManager;
    public ItemManager itemManager;
    public GameObject CoverImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickStartButton()
    {
        CoverImage.SetActive(false);
        //prefabManager.EnemyRandom();
        //itemManager.ItemRandom();
    }
    // Update is called once per frame
    void Update()
    {
        //ScoreScript.rightSide()
        //{
        //    if (rightSide >= 5) ;
        //    {
        //        "rightSide WIN";
        //    }
            

        //}
            
    }


    //public void GameOver()
    //{
    //    Debug.Log("GAME OVER");
    //}
}
