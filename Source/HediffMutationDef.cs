﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Radiology
{
    public class HediffMutationDef :HediffDef
    {
        public HediffMutationDef()
        {
            hediffClass = typeof(Mutation);
        }

        public string exclusive;
        public List<string> exclusives;

        public List<BodyPartDef> relatedParts;
        public List<BodyPartDef> affectedParts;
        public bool affectsAllParts = true;

        public float likelihood = 1.0f;

        public AutomaticEffectSpawnerDef spawnEffect;
        public AutomaticEffectSpawnerDef spawnEffectFemale;
        public AutomaticEffectSpawnerDef SpawnEffect(Pawn pawn) => (pawn.gender == Gender.Female && spawnEffectFemale != null) ? spawnEffectFemale : spawnEffect;

        public HediffStage stage;

        public override void PostLoad()
        {
            base.PostLoad();

            if (exclusives == null)
                exclusives = new List<string>();

            if (exclusive != null)
                exclusives.Add(exclusive);

            if (affectedParts == null)
                affectedParts = relatedParts;

            if (stage != null)
            {
                if (stages == null)
                    stages = new List<HediffStage>();

                stages.Add(stage);
            }
        }
    }
}
