﻿namespace RPG.Characters
{
    using RPG.Weapons;

    public abstract class Character
    {
        protected Character(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        public Weapon Weapon { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("{0} wields weapon {1}", this.Name, this.Weapon);
        }
    }
}
