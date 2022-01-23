using System;

namespace Lesson011
{
    public class Weapon
    {
        private uint _totalBulletsCount;
        private uint _maxBulletsInClip;
        private uint _currentBulletsInClip;

        public Weapon()
        {
            _totalBulletsCount = 10;
            _maxBulletsInClip = 3;
            _currentBulletsInClip = 2;
        }

        public void Fire()
        {
            if (_currentBulletsInClip > 0)
            {
                Console.WriteLine("Shoot fired!");
                _currentBulletsInClip--;
            }
            else
            {
                Console.WriteLine("The shoot was not fired. There are no ammo in the clip");
            }
        }

        public void Reload()
        {
            if (_currentBulletsInClip == _maxBulletsInClip || _totalBulletsCount <= 0)
            {
                Console.WriteLine("Reload is not possible.");
            }
            else
            {
                uint reloadedBulletsCount = _maxBulletsInClip - _currentBulletsInClip;

                if (_totalBulletsCount >= reloadedBulletsCount)
                {
                    _totalBulletsCount -= reloadedBulletsCount;
                }
                else
                {
                    reloadedBulletsCount = _totalBulletsCount;
                    _totalBulletsCount = 0;
                }

                _currentBulletsInClip += reloadedBulletsCount;

                Console.WriteLine("Reload success");
            }
        }
    }
}
