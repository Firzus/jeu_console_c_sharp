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

        protected string _type = "";
        protected bool _typeFire;
        protected bool _typeWatter;
        protected bool _typeGround;
        protected bool _typeAir;

        private float _coefLevelUp = 0.12f;
        private float _hightWikness = 1.30f;
        private float _lowWeakness = 1.05f;
        private float _hightResistance = 0.60f;
        private float _lowResistance = 0.85f;

        public bool IsAlive => _life > 0;
        public float Level { get => _level; }
        public float Life { get => (float)Math.Round((_level * _coefLevelUp + 1) * _life); }
        public float Damage { get => (float)Math.Round((_level * _coefLevelUp + 1) * _damage); }
        public float Speed { get => (float)Math.Round((_level * _coefLevelUp + 1) * _speed);}
        public float Defence { get => (float)Math.Round((_level * _coefLevelUp + 1) * _defense); }

        public string Name { get => _name; }

        public string Type { get => _type; }

        public void TakeDamage(float nbDegats)
        {
            _life -= nbDegats;

            if (_life < 0)
            {
                _life = 0;
            }
        }

        public void BasicAttack(Altere cible)
        {
            cible.TakeDamage((1 - _defense / 100) * _damage);
        }

        public void ElementarySpell(Altere cible)
        {
            // Air
            if(_typeAir && cible._typeAir)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightWikness);
            }
            if (_typeAir && cible._typeGround)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowWeakness);
            }
            if (_typeAir && cible._typeWatter)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowResistance);
            }
            if (_typeAir && cible._typeFire)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightResistance);
            }

            // Ground
            if (_typeGround && cible._typeGround)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightWikness);
            }
            if (_typeGround && cible._typeAir)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowWeakness);
            }
            if (_typeGround && cible._typeFire)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowResistance);
            }
            if (_typeGround && cible._typeWatter)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightResistance);
            }

            // Fire
            if (_typeFire && cible._typeFire)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightWikness);
            }
            if (_typeFire && cible._typeWatter)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowWeakness);
            }
            if (_typeFire && cible._typeAir)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowResistance);
            }
            if (_typeFire && cible._typeGround)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightResistance);
            }

            // Watter
            if (_typeWatter && cible._typeWatter)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightWikness);
            }
            if (_typeWatter && cible._typeFire)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowWeakness);
            }
            if (_typeWatter && cible._typeGround)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _lowResistance);
            }
            if (_typeWatter && cible._typeAir)
            {
                cible.TakeDamage(((1 - _defense / 100) * _damage) * _hightResistance);
            }
        }

    }
}
