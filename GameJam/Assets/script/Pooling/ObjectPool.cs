using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool 
{
    List<Poolable> pool = new List<Poolable>();
    Poolable prefab;

    public ObjectPool(Poolable prefab) {
        this.prefab = prefab;
    }
    /*
     * Acquire fait que on utilise un object poolable
     * si on ne l a pas on ajoute +1 element a la liste 
     */
    public Poolable Aquire() {
        Poolable obj;
        //si j ai un objet non utiliser dans la pool
        //je le retire pour l'utiliser
        if (pool.Count > 0)
        {
            obj = pool[pool.Count - 1];
            pool.RemoveAt(pool.Count - 1);
            obj.IsPooled = false;
            return obj;
        }
        //si pool vide J instancie un prefab de poolable
        obj = Object.Instantiate(prefab);
        obj.IsPooled = false;
        return obj;
    }
    /*
     *remet l'element dans la poole si celui si n'est pas Pool 
     */
    public bool Release(Poolable obj) {
        if (!obj.IsPooled) {
            obj.IsPooled = true;
            pool.Add(obj);
            return true;
        }
        return false;    
    }
    /*
     * retire de la pool l'objet Poolable
     */
    public void Remove(Poolable obj) {
        if (obj.IsPooled) {
            obj.IsPooled = false;
            pool.Remove(obj);
        }
    }
}
