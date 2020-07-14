using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pippinmole.Particles {
    public class ParticleGroup : MonoBehaviour {

        [SerializeField] private List<ParticleSystem> particleSystems = new List<ParticleSystem>();

        public void EnableEmission(int index) {
            if (particleSystems.Count <= 0 || index < 0) return;
            if (index >= particleSystems.Count) throw new ArgumentOutOfRangeException($"index ({index}) cannot be larger than ParticleSystem list size ({particleSystems.Count}).");

            var emission = this.particleSystems[index].emission;
            emission.enabled = true;
        }
        public void EnableEmissions() {
            for (int i = 0; i < this.particleSystems.Capacity; i++) {
                this.EnableEmission(i);
            }
        }

        public void DisableEmission(int index) {
            if (particleSystems.Count <= 0 || index < 0) return;
            if (index >= particleSystems.Count) throw new ArgumentOutOfRangeException($"index ({index}) cannot be larger than ParticleSystem list size ({particleSystems.Count}).");

            var emission = this.particleSystems[index].emission;
            emission.enabled = false;
        }
        public void DisableEmissions() {
            for (int i = 0; i < this.particleSystems.Capacity; i++) {
                this.DisableEmission(i);
            }
        }
    }
}