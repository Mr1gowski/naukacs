using System;
using System.Diagnostics;


//clasa bazowa zawierajaca wspolne dla pochodnych metody
class  Postac
{
    protected string name;
    protected int life;
    protected int strenght;
    //odpowiednik losowania koscmi ile= ile losowan 
    protected int los(int x1,int ile)
    {
        System.Random x = new Random();
        for (int i = 0; i < ile; i++)
        {
            x1 += x.Next(1, 6);
        }
        return x1;
    }
    // dodaje rzycie lub odbiera 
    public int give_or_take(int x)
    {
        if ((life + x) <= 100 || (life + x) > 0)
        {
            life += x;
        }
       
            return life;
    }
    
   public  virtual int Attack()
    {
        return this.Attack();
    }

    public override string ToString()
    {
       
        return "zycie:  "+this.life+",  imie:"+this.name+", atak:"+this.Attack() ;
    }

}

class Mag : Postac
{
    public Mag()
    {
        name = "Xardas";
        strenght = los(strenght, 1);
        pkt_magic=los(pkt_magic, 2);
        life = 100;
    }
    private int pkt_magic;
    public void info()
    {
        Console.WriteLine(pkt_magic);
        Console.WriteLine(strenght);
        Console.WriteLine(name);
    }
    public override int Attack()     {return (pkt_magic + strenght) * life;}


  
}

class Wojownik : Postac
{
    public Wojownik()
    {
        name = "Geralt";
        life = 100;
        strenght = los(strenght, 3);

    }
    public override int Attack()
    {
        if (life > 5)
        {
            return (strenght * life);
        }
        else return strenght;
        
    }
    
}
// glowna clasa tworzaca postacie
public class program
{
   public static void Main()
    {
        Mag witek = new Mag();
       
        Console.WriteLine(witek.ToString());

        Console.Read();
    }

}
 