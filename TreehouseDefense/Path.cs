﻿using System.Linq;

namespace TreehouseDefense
{
    public class Path
    {
        private MapLocation[] _path;

        public Path(MapLocation[] pathLocations)
        {
            _path = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation) => _path.Contains(mapLocation);

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}