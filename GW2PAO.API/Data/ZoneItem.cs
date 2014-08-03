﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GW2PAO.API.Data.Enums;

namespace GW2PAO.API.Data
{
    public class ZoneItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ZoneItemType Type { get; set; }
        public int MapId { get; set; }
        public string MapName { get; set; }
        public int Level { get; set; }
        public Point Location { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null
                && obj is ZoneItem)
            {
                ZoneItem other = obj as ZoneItem;

                return (other.ID == this.ID)
                    && (other.Name == this.Name)
                    && (other.Type == this.Type)
                    && (other.MapId == this.MapId)
                    && (other.MapName == this.MapName)
                    && (other.Level == this.Level)
                    && (other.Location.X == this.Location.X)
                    && (other.Location.Y == this.Location.Y)
                    && (other.Location.Z == this.Location.Z);
            }
            else
            {
                return false;
            }
        }
    }
}
