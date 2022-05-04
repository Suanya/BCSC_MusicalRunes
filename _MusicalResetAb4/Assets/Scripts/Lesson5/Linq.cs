using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linq : MonoBehaviour
{
    public HeroType m_class;

    public float m_x = 0;
    private bool m_available => m_x > 0;

    private void Update()
    {
        Debug.Log(m_available);

    }

    public List<float> m_floats = new List<float>();

    private void Start()
    {
        //float totalFloats = TotalSum(m_floats);
        // totalFloats = m_floats.Sum();

        float totalFloats = m_floats.Sum();

        float sumOffFLoatsGreaterThan5 = m_floats.Where(t => t > 5).Sum();

        //var myList = m_floats.Where(t => t > 5);
    }

    public List<Hero> m_heroes = new List<Hero>();

    public void Awake()
    {
        bool checkName = m_heroes.Any(t => t.heroName == "Jean");
        bool checkNameAndHealth = m_heroes.Any(t => t.heroName == "Elli" && t.heroHealth > 0);

        double avgDamage = m_heroes.Average(t => t.heroDamage);

        var allWizards = m_heroes.Where(t => t.Class == HeroType.Wizard);

        List<Hero> myUniqueHeroes = m_heroes.Distinct().ToList(); // noDoubles

        var heroesGrouped = m_heroes.GroupBy(t => t.Class);

        foreach(var heroes in heroesGrouped)
        {
            Debug.Log(heroes.Key);

            foreach(var hero in heroes)
            {
                Debug.Log(hero);
            }
        }

      
        

    }
}

public class Hero
{
    public string heroName;
    public float heroHealth;
    public float heroDamage;
    public HeroType Class;
}

public enum HeroType
{
    Wizard, Knight, Witch
}



/*
 float TotalSum(List<float> myList)
 {
     float total = 0;
     foreach(float x in myList)
     {
         total += x;
     }
     return total;
 }
 */

/*
        List<float> new1List = m_floats.Where(t => t > 5);
        // is equivalent to:
        List<float> newList;
        foreach(float t in m_floats)
        {
            if(t > 5)
            {
                newList.Add(t);
            }
        }
        */