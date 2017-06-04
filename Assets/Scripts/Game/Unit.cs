using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Unit : MonoBehaviour
{
    public LimitedInt health;
    public LimitedInt mana;

	public List<Ability> abilities;
    public List<Buff> buffs;

    public Attack attack
    {
        get { return abilities.FirstOrDefault(a => a is Attack) as Attack; }
    }

    public Defense defense
	{
        get { return buffs.FirstOrDefault(a => a is Defense) as Defense; }
	}
}
