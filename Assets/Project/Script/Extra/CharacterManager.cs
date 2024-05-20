using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gazeus.DesafioMatch3
{
    public class CharacterManager : MonoBehaviour
    {
        [SerializeField] private Animator a_char;
        [SerializeField] private ParticleSystem ps_confetti;

        public void CharShout()
        {
            a_char.SetTrigger("shout");
        }

        public void PlayConfetti()
        {
            ps_confetti.Play();
        }
    }
}
