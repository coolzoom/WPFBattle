﻿using puskaric.RoleplayingGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class ImageFireAttack : FireAttack
    {

        private CharacterImage image;

        public ImageFireAttack(CharacterImage image)
        {
            this.image = image;
        }

        public override void Attack(ICharacter attacker, ICharacter defender)
        {
            image.State = CharacterImage.CharacterState.Attacking;
            Thread.Sleep(200);   
            base.Attack(attacker, defender);
            image.State = CharacterImage.CharacterState.Idle;
        }

    }
}
