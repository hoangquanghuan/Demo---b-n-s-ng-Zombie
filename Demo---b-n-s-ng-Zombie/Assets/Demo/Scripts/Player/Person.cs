using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Demo
{
    public class Person : MonoBehaviour
    {
        public PlayerController.StatePlayer StatePlayer;
        public PlayerController.TypeEquipment TypeEquipment;
        public Animator anim;

        public Weapon MainWeapon, SecondaryWeapon, Knife, Grenade;
    }
}

