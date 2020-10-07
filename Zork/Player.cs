using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zork
{
    public class Player
    {

        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        [JsonIgnore]
        public string LocationName
        {
            get { return Location?.Name; } //same as writing return (Location != null ? Location.Name : null);
            set { Location = World?.RoomsByName.GetValueOrDefault(value); }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room desintation);
            if (isValidMove) Location = desintation;

            return isValidMove;
        }
    }
}