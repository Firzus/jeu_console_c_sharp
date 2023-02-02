namespace console_app
{
    internal class Altere
    {
        protected string _name = "";
        protected float _level;
        protected float _life;
        protected float _damage;
        protected float _speed;
        protected float _defense;

        private float _coefLevelUp = 0.12f;

        public bool IsAlive => _life > 0;
        public float Level { get => _level; }
        public float Life { get => (float)Math.Round((_level * _coefLevelUp + 1) * _life); }
        public float Damage { get => (float)Math.Round((_level * _coefLevelUp + 1) * _damage); }
        public float Speed { get => (float)Math.Round((_level * _coefLevelUp + 1) * _speed);}
        public float Defence { get => (float)Math.Round((_level * _coefLevelUp + 1) * _defense); }

        public string Name { get => _name; }

        public void TakeDamage(float nbDegats)
        {
            _life -= nbDegats;

            if (_life < 0)
            {
                _life = 0;
            }
        }

        public void Attack(Altere cible)
        {
            cible.TakeDamage((1 - _defense / 100) * _damage);
        }
    }
}
