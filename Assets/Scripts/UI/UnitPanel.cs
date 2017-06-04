using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPanel : MonoBehaviour
{
    public Unit unit;

    public PropertyPanel attack;
    public PropertyPanel health;
    public PropertyPanel defense;
    public PropertyPanel mana;

    [ContextMenu("Update")]
    public void Update() {
        mana.panel.SetActive(unit.mana.maxValue > 0);

        attack.value.text = unit.attack.damage.ToString();
        defense.value.text = unit.defense.power.ToString();
		health.value.text = unit.health.ToString();
		mana.value.text = unit.mana.ToString();
    }

}
