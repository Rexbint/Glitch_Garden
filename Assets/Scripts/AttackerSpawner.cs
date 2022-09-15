using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker[] attackerPrefabArray;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(1, 6));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Spawn(Random.Range(0, attackerPrefabArray.Length));
    }

    private void Spawn(int attackerIndex)
    {
        Attacker newAttacker = Instantiate(attackerPrefabArray[attackerIndex], transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    public void StopSpawn()
    {
        spawn = false;
    }
}
