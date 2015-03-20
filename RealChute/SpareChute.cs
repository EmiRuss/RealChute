﻿using System;
using UnityEngine;
using RealChute.Libraries;

/* RealChute was made by Christophe Savard (stupid_chris). You are free to copy, fork, and modify RealChute as you see
 * fit. However, redistribution is only permitted for unmodified versions of RealChute, and under attribution clause.
 * If you want to distribute a modified version of RealChute, be it code, textures, configs, or any other asset and
 * piece of work, you must get my explicit permission on the matter through a private channel, and must also distribute
 * it through the attribution clause, and must make it clear to anyone using your modification of my work that they
 * must report any problem related to this usage to you, and not to me. This clause expires if I happen to be
 * inactive (no connection) for a period of 90 days on the official KSP forums. In that case, the license reverts
 * back to CC-BY-NC-SA 4.0 INTL.*/

namespace RealChute
{
    public class SpareChute : IParachute
    {
        //Spoiler: incredibely incomplete.

        public float deployedArea
        {
            get { return RCUtils.GetArea(this.deployedDiameter); }
        }

        public float chuteMass
        {
            get { return this.deployedArea * this.material.areaDensity; }
        }

        public bool isEVA
        {
            get { return false; }
        }

        private MaterialDefinition material = new MaterialDefinition();
        private float deployedDiameter = 50;

        public SpareChute(ConfigNode node)
        {

        }

        public ConfigNode Save()
        {
            ConfigNode node = new ConfigNode("SPARE");
            return node;
        }
    }
}
