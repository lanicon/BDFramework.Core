﻿using BDFramework.Logic.GameLife;
using BDFramework.Sql;
using UnityEngine;

namespace Code.Game
{
    [GameStartAtrribute(0)]
    public class GameStart : IGameStart
    {


        public void Awake()
        {        
            Application.targetFrameRate = 24;

        }

        public void Start()
        {
           Debug.Log("第一个游戏启动咯! index 0");
        }
        
        public void Update()
        {
            
        }

        public void LateUpdate()
        {
            
        }
    }
}