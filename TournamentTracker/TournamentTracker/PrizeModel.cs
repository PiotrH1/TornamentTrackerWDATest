﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// the unic identifyer for the prize
        /// </summary>
        public int Id { get; set; }
        public int PaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount  { get; set; }
        public double PrizePercentage { get; set; }
    }

}
