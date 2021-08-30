using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    public class Player : Person, ChangeWeapon
    {
        public void ChangeWeaponInPlayer()
        {
            switch (StatePlayer)
            {
                case PlayerController.StatePlayer.Idle:
                    anim.SetTrigger("NewStateIdle");
                    break;
                case PlayerController.StatePlayer.Crouch:
                    anim.SetTrigger("NewStateCrouch");
                    break;
                case PlayerController.StatePlayer.Prone:
                    break;
            }

            switch (TypeEquipment)
            {
                case PlayerController.TypeEquipment.MainWeapon:
                    Debug.Log("đang dùng súng chính");
                    anim.SetInteger("ChangeStateIdle", 2);
                    break;
                case PlayerController.TypeEquipment.SecondaryWeapon:
                    Debug.Log("đang dùng súng phụ");
                    anim.SetInteger("ChangeStateIdle", 1);
                    break;
                case PlayerController.TypeEquipment.Knife:
                    Debug.Log("đang dùng dao");
                    anim.SetInteger("ChangeStateIdle", 3);
                    break;

            }
        }

        // Start is called before the first frame update
        void Awake()
        {
            if(StatePlayer == PlayerController.StatePlayer.unset)
            {
                anim.SetInteger("ChangeState", 1);
                StatePlayer = PlayerController.StatePlayer.Idle;
            }

            if(TypeEquipment == PlayerController.TypeEquipment.unset)
            {
                MainWeapon.gameObject.SetActive(true);
                SecondaryWeapon.gameObject.SetActive(false);
                Knife.gameObject.SetActive(false);
                //Grenade.gameObject.SetActive(false);
                TypeEquipment = PlayerController.TypeEquipment.MainWeapon;
                anim.SetInteger("ChangeStateIdle", 2);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

