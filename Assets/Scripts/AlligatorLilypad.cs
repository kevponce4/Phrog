﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlligatorLilypad : Lilypad
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void flipLilypad() {
        // do a flip
        Debug.Log("flipped alligator lilypad");
        GameObject.Find("Phrog").GetComponent<Phrog>().Die();
    }
}
