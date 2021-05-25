using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    private GameObject housesGroup;
    [SerializeField] private bool isGameOver = false;
    [SerializeField] private GameObject canvasGameOver;

    void Start()
    {
        canvasGameOver.SetActive(false);
        housesGroup = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver && housesGroup.transform.childCount == 0)
        {
            canvasGameOver.SetActive(true);
            isGameOver = true;
        }    
    }
}
