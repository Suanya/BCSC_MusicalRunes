using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linquing : MonoBehaviour
{
    public float m_x = 0;

    // really powerful
    private bool m_available => m_x > 0; // variable exists if x < 0 make it true

    private void Update()
    {
        Debug.Log(m_available);
    }

    public List<float> m_floats = new List<float>();

    private void Start()
    {
        float totalFloats = m_floats.Sum();

        float sumOfFloatsGreaterThan5 = m_floats.Where(t => t > 5).Sum();

        Debug.Log("sum");
    }

    public List<Hero> m_heroes = new List<Hero>();

    private void Awake()
    {
        bool checkName = m_heroes.Any(t => t.heroName == "Jeanz");
        bool checkNameAndHealth = m_heroes.Any(t => t.heroName == "Emiliano" && t.heroHealth > 0);

        double avgDamage = m_heroes.Average(t => t.heroDamage); // or float

        var allWizard = m_heroes.Where(t => t.Class ==  HeroType.Wizard);

        List<Hero> myUniqueHeroes = m_heroes.Distinct().ToList();

        var heroGrouped = m_heroes.GroupBy(t => t.Class);
        foreach(var heroes in heroGrouped)
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
