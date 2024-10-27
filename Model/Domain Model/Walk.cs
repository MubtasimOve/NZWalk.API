﻿namespace NZWalks.API.Model.Domain_Model
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm    { get; set; }
        public string? WalkImageUrl     { get; set; }

        public Guid DifficultyId { get; set; }

        public Guid Resign {  get; set; }

        //Navication Properties

        public Difficulty Difficulty { get; set; }

        public Region Region { get; set; }

    }
}