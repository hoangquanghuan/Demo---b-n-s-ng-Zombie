using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    public class Player : Person, ChangeWeaponInPlayer, ChangeStateMoveInPlayer
    {
        public void ChangeWeaponInPlayer()
        {
            MainWeapon.gameObject.SetActive(false);
            SecondaryWeapon.gameObject.SetActive(false);
            Knife.gameObject.SetActive(false);

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
                    StartCoroutine(ChangWeaponInPlayer(MainWeapon.gameObject));
                    break;
                case PlayerController.TypeEquipment.SecondaryWeapon:
                    Debug.Log("đang dùng súng phụ");
                    anim.SetInteger("ChangeStateIdle", 1);
                    StartCoroutine(ChangWeaponInPlayer(SecondaryWeapon.gameObject));
                    break;
                case PlayerController.TypeEquipment.Knife:
                    Debug.Log("đang dùng dao");
                    anim.SetInteger("ChangeStateIdle", 3);
                    StartCoroutine(ChangWeaponInPlayer(Knife.gameObject));
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

        private IEnumerator ChangWeaponInPlayer(GameObject p)
        {
            yield return new WaitForSeconds(0.5f);
            p.SetActive(true);
        }

        public void ChangeStateMoveInPlayer()
        {
            switch (StateMove)
            {
                case PlayerController.StateMove.Idle:
                    anim.SetTrigger("NewStateidleHandgunWalk");
                    anim.SetInteger("StateIdleHandgunMove", 0);
                    break;
                case PlayerController.StateMove.Walk:
                    anim.SetInteger("StateIdleHandgunMove", 1);
                    break;
                case PlayerController.StateMove.Run:
                    anim.SetInteger("StateIdleHandgunMove", 2);
                    break;
                case PlayerController.StateMove.WalkBack:
                    anim.SetInteger("StateIdleHandgunMove", 3);
                    break;
                case PlayerController.StateMove.RunBack:
                    anim.SetInteger("StateIdleHandgunMove", 4);
                    break;
                case PlayerController.StateMove.WalkLeft:
                    anim.SetInteger("StateIdleHandgunMove", 5);
                    break;
                case PlayerController.StateMove.RunLeft:
                    anim.SetInteger("StateIdleHandgunMove", 5);
                    break;
                case PlayerController.StateMove.WalkRight:
                    anim.SetInteger("StateIdleHandgunMove", 7);
                    break;
                case PlayerController.StateMove.RunRight:
                    anim.SetInteger("StateIdleHandgunMove", 8);
                    break;
            }
        }
    }
}

