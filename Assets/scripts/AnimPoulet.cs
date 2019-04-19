using UnityEngine;
using System.Collections;

public class AnimPoulet : MonoBehaviour
{
    public RuntimeAnimatorController normalAnim;
    public RuntimeAnimatorController glaceAnim;
    public RuntimeAnimatorController feuAnim;
    public RuntimeAnimatorController zombieAnim;
    public RuntimeAnimatorController mortAnim;
    States state;
    Animator anim;
    int normalHash = Animator.StringToHash("normal");
    int glaceHash = Animator.StringToHash("glace");
    int feuHash = Animator.StringToHash("feu");
    int zombieHash = Animator.StringToHash("zombie");
    int mortHash = Animator.StringToHash("mort");

    int runStateHash = Animator.StringToHash("Base Layer.Run");


    void Start ()
    {
      state = gameObject.GetComponent<States>();
      anim = GetComponent<Animator>();
    }


    void Update ()
    {
        //A appeler seulement 1 fois quand l'objet change d'etat
    		if (States.Etat.normal == state.m_etat)
    		{
          anim.runtimeAnimatorController = normalAnim;
    		}
    		else if (States.Etat.glace == state.m_etat)
    		{
    				anim.runtimeAnimatorController = glaceAnim;
    		}
    		else if (States.Etat.feu == state.m_etat)
    		{
    				anim.runtimeAnimatorController = feuAnim;
    		}
    		else if (States.Etat.zombie == state.m_etat)
    		{
    				anim.runtimeAnimatorController = zombieAnim;
    		}
    		else
    		{
    				anim.runtimeAnimatorController = mortAnim;
    		}
    }
}
