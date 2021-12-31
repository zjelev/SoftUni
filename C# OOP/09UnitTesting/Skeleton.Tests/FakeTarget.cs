using System;
class FakeTarget : ITarget
{
    //private int health;
    //private int experience;
    public int Health => 0;

    //public FakeTarget(int health, int experience)
    //{
    //    this.health = 0;
    //    this.experience = 20;
    //}

    public int GiveExperience()
    {
        return 10;
    }

    public bool IsDead()
    {
        return true;
    }

    public void TakeAttack(int attackPoints)
    {
        //if (this.IsDead())
        //{
        //    throw new InvalidOperationException("Dummy is dead.");
        //}

        //this.health -= attackPoints;
    }
}