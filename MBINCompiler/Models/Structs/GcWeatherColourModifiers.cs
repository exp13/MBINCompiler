﻿namespace MBINCompiler.Models.Structs
{
    public class GcWeatherColourModifiers : NMSTemplate
    {
        public GcColourModifier SkyColour;
        public GcColourModifier HorizonColour;
        public GcColourModifier SunColour;
        public GcColourModifier FogColour;
        public GcColourModifier HeightFogColour;
        public GcColourModifier LightColour;
        public GcColourModifier CloudColour1;
        public GcColourModifier CloudColour2;

        // todo: change this to array
        public GcColourModifier HeavyAirColour1;

        public GcColourModifier HeavyAirColour2;
        public GcColourModifier HeavyAirColour3;
        public GcColourModifier HeavyAirColour4;
        public GcColourModifier HeavyAirColour5;
    }
}
