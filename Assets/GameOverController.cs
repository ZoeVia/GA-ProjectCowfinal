﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Replay()
    {
        SceneManager.LoadScene("Scene principale");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu principal");
    }

}
