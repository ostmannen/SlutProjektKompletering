using System;

namespace slutprojekt
{
    public class Cat
    {
        private int attack = 100;

        public void SetAttack(int newAttack){
            attack = newAttack;
        }
        public int GetAttack(){
            return attack;
        }
    }
}
