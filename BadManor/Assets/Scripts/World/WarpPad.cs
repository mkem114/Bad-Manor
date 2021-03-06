﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.World
{
    /// <summary>
    /// WarpPad moves the player from one room to another, its respoonsibility is teleport the player if the WorldManager
    /// lets it. It had no dependencies other than WorldManager and RoomLocations.</summary>
    [Serializable()]
    public class WarpPad : MonoBehaviour
    {
        /// <summary>
        /// Room the player wishes to access.</summary>   
        public RoomLocations.RoomsSpawns roomToGoTo;

        public Text guide;

        /// <summary>
        /// When the user attempts to change rooms, the WorldManager is check to see if this is allowed. If so then the
        /// co-ordinates of the room are gotten and the player's location is changed to that.</summary>
        void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (GameManager.inst.WorldManager.canGoTo(roomToGoTo))
                {
                    other.transform.position = RoomLocations.getRoomCoords(roomToGoTo);
                }
            }
        }

        /// <summary>
        /// Checks that player is still inside zone
        /// </summary>
        /// <param name="other"></param>
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("wew");
                guide.text = "Press [X] to enter.";
            }
        }

        /// <summary>
        /// Checks that player has left zone
        /// </summary>
        /// <param name="other"></param>
        void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("wew");

                guide.text = "";
            }
        }
    }
}