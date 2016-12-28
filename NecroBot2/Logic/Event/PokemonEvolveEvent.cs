﻿#region using directives

using POGOProtos.Enums;
using POGOProtos.Networking.Responses;

#endregion

namespace NecroBot2.Logic.Event
{
    public class PokemonEvolveEvent : IEvent
    {
        public int Exp;
        public PokemonId Id;
        public EvolvePokemonResponse.Types.Result Result;
    }
}