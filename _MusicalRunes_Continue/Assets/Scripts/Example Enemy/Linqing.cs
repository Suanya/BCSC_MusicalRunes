using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linqing : MonoBehaviour
{
    public float m_x = 0;
    private bool m_available => m_x > 0;

    private void Update()
    {
        Debug.Log(m_available);
    }





    public List<float> m_floats = new List<float>();
    private void Start()
    {
        float totalFloats =  m_floats.Sum();

        float sumOfFloatsGreaterThan5 = m_floats.Where(t => t > 5).Sum();
    }


    public List<Hero> m_heroes = new List<Hero>();

    private void Awake()
    {
        bool checkName = m_heroes.Any(t => t.Name == "Jean");
        bool checkNameAndHealth = m_heroes.Any(t => t.Name == "Emiliano" && t.Health > 0);

        float avgDamage = m_heroes.Average(t => t.Damage);

        var allWizards = m_heroes.Where(t => t.Class == HeroType.Wizard);

        List<Hero> myUniqueHeroes = m_heroes.Distinct().ToList();

        var herosGrouped = m_heroes.GroupBy(t => t.Class);
        foreach(var heroes in herosGrouped)
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
    public string Name;
    public float Health;
    public float Damage;
    public HeroType Class;
}

public enum HeroType
{
    Wizard, Knight, Archer
}









