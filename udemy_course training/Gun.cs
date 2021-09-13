using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace udemy_course_training
{
    public class Gun
    {
        private string _gunName;

        private int _speed;
        private int _effectiveness;
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set
            {
                if (value == _damage)
                    return;

                if (value > 0)
                    _damage = value;
                else throw new ArgumentException("Damage must be alwas positive.");
            }
        }
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value == _speed)
                    return;

                if (value > 0)
                    _speed = value;
                else throw new ArgumentException("Speed must be alwas positive.");
            }



        }
        public Gun(string gunName, int damage, int speed)
        {
            _gunName = gunName;
            Damage = damage;
            Speed = speed;
            _effectiveness = damage * speed;
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Gun Name is {_gunName} and gun damage is {_damage} and your gun effectiveness is {_effectiveness}");
        }


    }
}
