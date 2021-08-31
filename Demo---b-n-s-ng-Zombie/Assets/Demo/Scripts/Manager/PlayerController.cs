using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Demo
{
    public class PlayerController : Singleton<PlayerController>
    {
        public Player Player;

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))//đổi về dùng vũ khí chính
            {
                if (Player.TypeEquipment != TypeEquipment.MainWeapon)
                {
                    Player.TypeEquipment = TypeEquipment.MainWeapon;
                    Player.ChangeWeaponInPlayer();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))// đổi về dùng vũ khí phụ
            {
                if (Player.TypeEquipment != TypeEquipment.SecondaryWeapon)
                {
                    Player.TypeEquipment = TypeEquipment.SecondaryWeapon;
                    Player.ChangeWeaponInPlayer();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (Player.TypeEquipment != TypeEquipment.Knife)
                {
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


            Player.StateMove = StateMove.Idle;
            if (Input.GetKey(KeyCode.W))
            {
                Player.StateMove = StateMove.Walk;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Player.StateMove = StateMove.Run;
                }
                //Player.ChangeStateMoveInPlayer();
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Player.StateMove = StateMove.WalkBack;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Player.StateMove = StateMove.RunBack;
                }
                //Player.ChangeStateMoveInPlayer();
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Player.StateMove = StateMove.WalkLeft;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Player.StateMove = StateMove.RunLeft;
                }
                //Player.ChangeStateMoveInPlayer();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Player.StateMove = StateMove.WalkRight;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Player.StateMove = StateMove.RunRight;
                }
            }
            Player.ChangeStateMoveInPlayer();
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

        public enum StateMove
        {
            Idle = 0,
            Walk,
            Run,
            WalkBack,
            RunBack,
            WalkLeft,
            RunLeft,
            WalkRight,
            RunRight,
        }
    }
}

