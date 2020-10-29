﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zork
{
    public class Player
    {

        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        public Player(World world, string startingLocation)
        {
            Assert.NotNull(world);
            Assert.NotNull(world.RoomsByName.ContainsKey(startingLocation));

            World = world;
            Location = world.RoomsByName[startingLocation];
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room desintation);
            if (isValidMove) Location = desintation;

            return isValidMove;
        }
    }
}