using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gazeus.DesafioMatch3
{
    public class SFXManager : MonoBehaviour
    {
        [SerializeField] private AudioSource a_source_music;
        [SerializeField] private AudioSource a_source_swap;
        [SerializeField] private AudioSource a_source_move;
        [SerializeField] private AudioSource a_source_match;
        [SerializeField] private AudioSource a_source_supermatch;
        [SerializeField] private AudioSource a_source_maxmatch;

        public void PlayAudioSwap()
        {
            a_source_swap.Play();
        }

        public void PlayAudioMove()
        {
            a_source_move.Play();
        }

        public void PlayAudioMatch()
        {
            a_source_match.Play();
        }

        public void PlayAudioSuperMatch()
        {
            a_source_supermatch.Play();
        }

        public void PlayAudioMaxMatch()
        {
            a_source_maxmatch.Play();
        }
    }
}
