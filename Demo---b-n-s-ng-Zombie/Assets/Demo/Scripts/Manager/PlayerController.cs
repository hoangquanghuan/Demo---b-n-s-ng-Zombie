using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Demo
{
    public class PlayerController : Singleton<PlayerController>
    {
        public Player Player;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))//đổi về dùng vũ khí chính
            {
                if (Player.TypeEquipment != TypeEquipment.MainWeapon)
                {
                    ChangWeaponInPlayer(Player.MainWeapon.gameObject, Player.SecondaryWeapon.gameObject, Player.Knife.gameObject);
                    Player.TypeEquipment = TypeEquipment.MainWeapon;
                    Player.ChangeWeaponInPlayer();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))// đổi về dùng vũ khí phụ
            {
                if (Player.TypeEquipment != TypeEquipment.SecondaryWeapon)
                {
                    ChangWeaponInPlayer(Player.SecondaryWeapon.gameObject, Player.MainWeapon.gameObject, Player.Knife.gameObject);
                    Player.TypeEquipment = TypeEquipment.SecondaryWeapon;
                    Player.ChangeWeaponInPlayer();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (Player.TypeEquipment != TypeEquipment.Knife)
                {
                    ChangWeaponInPlayer(Player.Knife.gameObject, Player.SecondaryWeapon.gameObject, Player.MainWeapon.gameObject);
                    Player.TypeEquipment = TypeEquipment.Knife;
                    Player.ChangeWeaponInPlayer();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (Player.TypeEquipment != TypeEquipment.Grenade)
                {
                    
                }
            }
        }


        private void ChangWeaponInPlayer(GameObject p1, GameObject p2, GameObject p3)
        {
            p1.SetActive(true);
            p2.SetActive(false);
            p3.SetActive(false);
        }

        public enum StatePlayer
        {
            unset = 0,
            Idle,
            Crouch,
            Prone,
        }

        public enum TypeEquipment
        {
            unset = 0,
            MainWeapon,
            SecondaryWeapon,
            Knife,
            Grenade,
        }
    }
}

