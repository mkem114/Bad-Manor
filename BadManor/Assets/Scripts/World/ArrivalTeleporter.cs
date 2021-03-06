﻿using System;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Subclass of Teleporter that serves as a spawn point rather than
    /// a teleporter.
    /// </summary>
    [Serializable()]
    public class ArrivalTeleporter : Teleporter
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            //do nothing
        }

        void OnTriggerStay2D(Collider2D other)
        {
            //do nothing
        }

        void OnTriggerExit2D(Collider2D other)
        {
            //do nothing
        }

        // Update is called once per frame
        void Update()
        {
            //do nothing
        }
    }
}