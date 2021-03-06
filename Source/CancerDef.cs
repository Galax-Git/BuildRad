﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Radiology
{
    public class CancerDef : HediffMutationDef
    {
        public CancerDef()
        {
            hediffClass = typeof(Cancer);
        }

        public List<CancerCompDef> symptomsPossible;
        public IntRange symptomsCount;

        public float diagnoseDifficulty;
        public FloatRange initialSeverityRange;
    }
}
